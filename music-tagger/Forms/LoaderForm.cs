using MetroFramework.Forms;
using MusicTagger.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTagger
{
    public partial class LoaderForm : MetroForm
    {
        public Project Project { get; private set; }

        private readonly string Title = "Projects";
        private readonly string LoadingTitle = "Loading project. Please wait...";

        public LoaderForm()
        {
            InitializeComponent();
            Text = Title;
            progress.Visible = false;
        }

        private void BtnLoadProjectClick(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "MusicTagger project files (*.tagger)|*.tagger";
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Title = "Please select a tagger project.";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var path = ofd.FileName;
                    var fi = new FileInfo(path);


                    Text = LoadingTitle;
                    Invalidate();

                    btnLoadProject.Visible = false;
                    btnCreateNewProject.Visible = false;
                    progress.Visible = true;
                    progress.Spinning = true;
                    ControlBox = false;

                    var projectTask = GetProject(fi);

                    projectTask.ContinueWith(
                        antecedent =>
                        {
                                Project = antecedent.Result;

                                DialogResult = DialogResult.OK;
                                Close();
                        },
                        CancellationToken.None,
                        TaskContinuationOptions.OnlyOnRanToCompletion,
                        TaskScheduler.FromCurrentSynchronizationContext());

                    projectTask.ContinueWith(
                        antecedent =>
                        {
                            Project = new Project { Name = Path.GetFileNameWithoutExtension(fi.Name), Path = path };

                            DialogResult = MessageBox.Show(
                                    "An error occured while reading the project file, continue with an empty project?",
                                    "Error retriving the project details",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button2);

                            Close();
                        },
                        CancellationToken.None,
                        TaskContinuationOptions.OnlyOnCanceled,
                        TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }

        private Task<Project> GetProject(FileInfo fi)
        {
            return Task.Run(() =>
                {
                    using (var reader = File.OpenText(fi.FullName))
                    {
                        var json = reader.ReadToEnd();
                        return JsonConvert.DeserializeObject<Project>(json);
                    }
                });
        }

        private void CreateNewProjectClick(object sender, EventArgs e)
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
                    var fi = new FileInfo(path);
                    Project = new Project { Name = Path.GetFileNameWithoutExtension(fi.Name), Path = path };

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
                    Close();
                }
            }
        }
    }
}
