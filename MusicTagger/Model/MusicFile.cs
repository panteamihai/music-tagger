using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MusicTagger.Model
{
    public class MusicFile : IEquatable<MusicFile>
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public List<Tag> Tags { get; set; }
        public List<MusicFile> ContinueWithFiles { get; set; }
        public List<MusicFile> PrecedeByFiles { get; set; }

        public MusicFile(string path)
        {
            var fileInfo = new FileInfo(path);

            Name = System.IO.Path.GetFileNameWithoutExtension(fileInfo.Name);
            Path = fileInfo.FullName;
            Tags = new List<Tag>();
            ContinueWithFiles = new List<MusicFile>();
            PrecedeByFiles = new List<MusicFile>();
        }

        public bool Equals(MusicFile other)
        {
            if (other == null) return false;

            return !Tags.Except(other.Tags).Any() 
                    && !ContinueWithFiles.Except(other.ContinueWithFiles).Any()
                    && !PrecedeByFiles.Except(other.PrecedeByFiles).Any();
        }
    }
}
