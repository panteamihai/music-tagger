using System;

using MusicTagger.Model;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace MusicTagger
{
    public class ProjectSaver
    {
        public static Tuple<DialogResult, Project> Save(Project project = null)
        {
            using (var sfd = CreateSaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var path = sfd.FileName;

                    if (project == null)
                    {
                        project = Project.CreateDefaultProject(path);
                    }

                    var jsonData = JsonConvert.SerializeObject(project, Formatting.Indented);

                    if (!File.Exists(path))
                    {
                        var file = File.Create(path);
                        file.Close();
                    }

                    TextWriter tw = new StreamWriter(path, false);
                    tw.WriteLine(jsonData);
                    tw.Close();

                    return new Tuple<DialogResult, Project>(DialogResult.OK, project);
                }
            }

            return new Tuple<DialogResult, Project>(DialogResult.Cancel, null);
        }

        private static SaveFileDialog CreateSaveFileDialog()
        {
            return new SaveFileDialog
                      {
                          Filter = "MusicTagger project files (*.tagger)|*.tagger",
                          InitialDirectory = Application.StartupPath,
                          Title = "Save the tagger project.",
                          CreatePrompt = false,
                          OverwritePrompt = true,
                          AddExtension = true
                      };
        }
    }
}
