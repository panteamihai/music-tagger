using System;

using MusicTagger.Model;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTagger.Helpers
{
    public class ProjectLoader
    {
        public static Task<Project> Load(Action preloadCallback)
        {
            using (var ofd = CreateOpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var path = ofd.FileName;
                    var fi = new FileInfo(path);

                    preloadCallback();

                    return GetProject(fi);
                }

                return Task.FromResult<Project>(null);
            }
        }

        private static Task<Project> GetProject(FileInfo fi)
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

        private static OpenFileDialog CreateOpenFileDialog()
        {
            return new OpenFileDialog
                      {
                          Filter = "MusicTagger project files (*.tagger)|*.tagger",
                          InitialDirectory = Application.StartupPath,
                          Title = "Please select a tagger project."
                      };
        }
    }
}