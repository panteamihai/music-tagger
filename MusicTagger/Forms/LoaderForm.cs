using MetroFramework.Forms;
using MusicTagger.Helpers;
using MusicTagger.Model;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTagger.Forms
{
    public partial class LoaderForm : MetroForm
    {
        public Project Project { get; private set; }

        private readonly string Title = "Projects";
        private readonly string LoadingTitle = "Loading project. Please wait...";

        public override sealed string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        public LoaderForm()
        {
            InitializeComponent();
            Text = Title;
            progress.Visible = false;
        }

        private void BtnLoadProjectClick(object sender, EventArgs e)
        {
            var projectTask = ProjectLoader.Load(ToggleFormState);

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
                    DialogResult = MessageBox.Show(
                            "An error occured while reading the project file, continue with an empty project?",
                            "Error retriving the project details",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button2);

                    if (DialogResult == DialogResult.OK)
                    {
                        var result = ProjectSaver.Save();

                        DialogResult = result.Item1;
                        Project = result.Item2;
                    }

                    if (DialogResult == DialogResult.OK && Project != null)
                        Close();
                },
                CancellationToken.None,
                TaskContinuationOptions.OnlyOnCanceled,
                TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ToggleFormState()
        {
            Text = LoadingTitle;
            Invalidate();

            btnLoadProject.Visible = false;
            btnCreateNewProject.Visible = false;
            progress.Visible = true;
            progress.Spinning = true;
            ControlBox = false;
        }

        private void BtnCreateNewProjectClick(object sender, EventArgs e)
        {
            var result = ProjectSaver.Save();

            DialogResult = result.Item1;
            Project = result.Item2;

            if(DialogResult == DialogResult.OK && Project != null)
                Close();
        }
    }
}
