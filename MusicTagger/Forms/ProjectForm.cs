using MetroFramework.Forms;
using MusicTagger.ExtensionMethods;
using MusicTagger.Model;
using System;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace MusicTagger.Forms
{
    public partial class ProjectForm : MetroForm
    {
        private readonly CompositeDisposable _disposables = new CompositeDisposable();

        private IObservable<MusicFile> _selectedFileChangedObservable;
        private IObservable<Tag> _newTagAddedObservable;

        private bool IsSaveRequired => Project != null && !Project.Equals(InitialProject);

        public Project Project { get; set; }
        private Project InitialProject { get; set; }

        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(Project project)
        {
            InitializeComponent();

            Project = project;
        }

        private void BtnAddFolderClick(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Application.StartupPath;
                fbd.ShowNewFolderButton = false;
                fbd.Description = "Select a folder containing .mp3 files.";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Project.LoadFilesFromFolder(fbd.SelectedPath);
                    grdFiles.DataSource = null;
                    grdFiles.DataSource = Project.Files;
                }
            }
        }

        private void BtnAddFileClick(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Music files (*.mp3)|*.mp3";
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Title = "Please select music files to operate on.";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Project.LoadFiles(ofd.FileNames);
                    grdFiles.DataSource = null;
                    grdFiles.DataSource = Project.Files;
                }
            }
        }

        private void BtnClearListClick(object sender, EventArgs e)
        {
            Project.Files.Clear();
            grdFiles.DataSource = null;
            grdFiles.DataSource = Project.Files;
        }

        private void ProjectFormShown(object sender, EventArgs e)
        {
            using (var loaderForm = new LoaderForm())
            {
                if (loaderForm.ShowDialog() == DialogResult.OK)
                {
                    Project = loaderForm.Project;
                    InitialProject = Project.CloneUsingJson();
                    WindowState = FormWindowState.Normal;
                    StartPosition = FormStartPosition.Manual;
                    Location = Screen.AllScreens[0].WorkingArea.Location;

                    Initialize();
                }
                else
                {
                    Close();
                }
            }
        }

        private void Initialize()
        {
            grdFiles.DataSource = Project.Files;

            SetTagsComboDatasource();

            var defaultTag = new Tag();
            colTag.ValueMember = nameof(defaultTag.Name);
            colTag.DisplayMember = nameof(defaultTag.Name);

            _selectedFileChangedObservable = Observable
                .FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                    genericGridHandler =>
                    {
                        DataGridViewCellEventHandler specificHandler = (sender, e) => { genericGridHandler(e); };
                        return specificHandler;

                    },
                    handler => grdFiles.CellEnter += handler,
                    handler => grdFiles.CellEnter -= handler)
                .Select(GetMusicFileFromGridCell)
                .Where(musicFile => musicFile != null);

            _newTagAddedObservable =
                Observable.FromEventPattern(ev => btnAddTag.Click += ev, ev => btnAddTag.Click -= ev)
                    .Select(e => CreateTag())
                    .Where(tag => tag != null);

            var tagsLoader = _selectedFileChangedObservable.Subscribe(GetTagsForFile);
            _disposables.Add(tagsLoader);

            var linkingFiles = _selectedFileChangedObservable.Subscribe(GetLinkingFiles);
            _disposables.Add(linkingFiles);

            var updateTags = _newTagAddedObservable.Subscribe(UpdateProjectTags);
            _disposables.Add(updateTags);
        }

        private void SetTagsComboDatasource()
        {
            bsProjectTags.DataSource = null;
            bsProjectTags.DataSource = Project.Tags;

            colTag.DataSource = null;
            colTag.Items.Clear();
            Project.Tags.ForEach(tag => colTag.Items.Add(tag));
        }

        private void UpdateProjectTags(Tag tag)
        {
            if (!Project.Tags.Contains(tag))
            {
                Project.Tags.Add(tag);
                SetTagsComboDatasource();
            }

            txtNewTag.Text = string.Empty;
        }

        private void GetLinkingFiles(MusicFile file)
        {
            if (file == null) return;

            grdPrecedeByFiles.DataSource = null;
            grdContinueWithFiles.DataSource = null;

            if (Project.Files.Contains(file))
            {
                grdPrecedeByFiles.DataSource = Project.Files.Find(f => f.Equals(file)).PrecedeByFiles;
                grdContinueWithFiles.DataSource = Project.Files.Find(f => f.Equals(file)).ContinueWithFiles;
            }
        }

        private void GetTagsForFile(MusicFile file)
        {
            if (file == null) return;

            bsTags.DataSource = null;
            bsTags.DataSource = Project.Files.Contains(file)
                ? Project.Files.Find(f => f.Equals(file)).Tags
                : Enumerable.Empty<Tag>();

            grdTags.DataSource = null;
            grdTags.DataSource = bsTags;
        }

        private MusicFile GetMusicFileFromGridCell(DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
                return grdFiles.Rows[e.RowIndex].DataBoundItem as MusicFile;

            return null;
        }

        private void ProjectFormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSaveRequired)
            {
                var dialogResult = MessageBox.Show(
                    "The project has been changed. Do you want to save the changes?",
                    "Save project",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button3);

                if (dialogResult == DialogResult.Yes)
                {
                    var result = ProjectSaver.Save(Project);

                    DialogResult = result.Item1;
                    Project = result.Item2;
                }

                if (dialogResult == DialogResult.Cancel || DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return; //don't dispose
                }
            }

            _disposables.Dispose();
        }

        private Tag CreateTag()
        {
            return string.IsNullOrWhiteSpace(txtNewTag.Text) ? null : new Tag { Name = txtNewTag.Text };
        }

        private void grdTags_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= ComboOnSelectedIndexChanged;
                combo.SelectedIndexChanged += ComboOnSelectedIndexChanged;
            }
        }

        private void ComboOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            
        }
    }
}
