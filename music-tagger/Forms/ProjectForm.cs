using MetroFramework.Forms;
using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace MusicTagger
{
    public partial class ProjectForm : MetroForm
    {
        private CompositeDisposable _selectedFileChangedDisposables = new CompositeDisposable();
        private IObservable<MusicFile> _selectedFileChangedObservable;

        public Project Project { get; set; }

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
                    WindowState = FormWindowState.Normal;
                    StartPosition = FormStartPosition.CenterScreen;

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
            _selectedFileChangedObservable = Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                ev => grdFiles.CellEnter += ev,
                ev => grdFiles.CellEnter -= ev)
                .Select(GetMusicFileFromGridCell);

            var tagsLoader = _selectedFileChangedObservable.Subscribe(GetTagsForFile);
            _selectedFileChangedDisposables.Add(tagsLoader);

            var linkingFiles = _selectedFileChangedObservable.Subscribe(GetLinkingFiles);
            _selectedFileChangedDisposables.Add(linkingFiles);
        }

        private void GetLinkingFiles(MusicFile file)
        {

        }

        private void GetTagsForFile(MusicFile file)
        {
            
        }

        private MusicFile GetMusicFileFromGridCell(DataGridViewCellEventArgs e)
        {
            return grdFiles.Rows[e.RowIndex].DataBoundItem as MusicFile;
        }

        private void ProjectFormClosing(object sender, FormClosingEventArgs e)
        {
            _selectedFileChangedDisposables.Dispose();
        }
    }
}
