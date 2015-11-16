using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace MusicTagger
{
    public partial class LoaderForm : MetroForm
    {
        public Project Project { get; private set; }

        public LoaderForm()
        {
            InitializeComponent();
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
                    Project = new Project { Name = Path.GetFileNameWithoutExtension(fi.Name), Path = path };

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
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
