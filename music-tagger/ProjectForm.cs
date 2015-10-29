using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace MusicTagger
{
    public partial class ProjectForm : MetroForm
    {
        public Project CurrentProject { get; set; }

        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(Project project)
        {
            InitializeComponent();

            CurrentProject = project;
        }

        private void BtnAddFolderClick(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = false;
                fbd.Description = "Select a folder containing .mp3 files.";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.LoadFilesFromFolder(fbd.SelectedPath);
                    grdFiles.DataSource = null;
                    grdFiles.DataSource = CurrentProject.Files;
                }
            }
        }

        private void BtnAddFileClick(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Music files (*.mp3)|*.mp3";
                ofd.InitialDirectory = @"C:\";
                ofd.Title = "Please select music files to operate on.";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.LoadFiles(ofd.FileNames);
                    grdFiles.DataSource = null;
                    grdFiles.DataSource = CurrentProject.Files;
                }
            }
        }

        private void BtnClearListClick(object sender, EventArgs e)
        {
            CurrentProject.Files.Clear();
            grdFiles.DataSource = null;
            grdFiles.DataSource = CurrentProject.Files;
        }

        private void ProjectForm_Shown(object sender, EventArgs e)
        {
            using (var loaderForm = new LoaderForm())
            {
                if (loaderForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject = loaderForm.Project;
                    WindowState = FormWindowState.Normal;
                    StartPosition = FormStartPosition.CenterScreen;
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
