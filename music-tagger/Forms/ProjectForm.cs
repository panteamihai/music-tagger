using MetroFramework.Forms;
using MusicTagger.ExtensionMethods;
using MusicTagger.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace MusicTagger
{
    public partial class ProjectForm : MetroForm
    {
        private readonly CompositeDisposable _selectedFileChangedDisposables = new CompositeDisposable();
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

            _selectedFileChangedObservable = Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                genericGridHandler =>
                {
                    DataGridViewCellEventHandler specificHandler = (sender, e) => { genericGridHandler(e); };
                    return specificHandler;

                },
                handler => grdFiles.CellEnter += handler,
                handler => grdFiles.CellEnter -= handler)
                .Select(GetMusicFileFromGridCell);

            var tagsLoader = _selectedFileChangedObservable.Subscribe(GetTagsForFile);
            _selectedFileChangedDisposables.Add(tagsLoader);

            var linkingFiles = _selectedFileChangedObservable.Subscribe(GetLinkingFiles);
            _selectedFileChangedDisposables.Add(linkingFiles);
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

            grdTags.DataSource = null;

            if (Project.Files.Contains(file))
            {
                grdTags.DataSource = Project.Files.Find(f => f.Equals(file)).Tags;
            }
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
                var dialogResult = MessageBox.Show("The project has been changed. Do you want to save the changes?", "Save project", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (dialogResult == DialogResult.Yes)
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "MusicTagger project files (*.tagger)|*.tagger";
                        sfd.InitialDirectory = Application.StartupPath;
                        sfd.Title = "Save the tagger project.";
                        sfd.CreatePrompt = false;
                        sfd.OverwritePrompt = true;
                        sfd.AddExtension = true;

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            var path = sfd.FileName;

                            var jsonData = JsonConvert.SerializeObject(Project, Formatting.Indented);

                            if (!File.Exists(path))
                            {
                                var file = File.Create(path);
                                file.Close();
                            }

                            TextWriter tw = new StreamWriter(path, false);
                            tw.WriteLine(jsonData);
                            tw.Close();

                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return; //don't dispose
                }
            }

            _selectedFileChangedDisposables.Dispose();
        }

        private void AddProjectTagClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewTag.Text)) return;

            var newTag = new Tag { Name = txtNewTag.Text };

            if(!Project.Tags.Contains(newTag))
                Project.Tags.Add(newTag);
        }
    }
}
