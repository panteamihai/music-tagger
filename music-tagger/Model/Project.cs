using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MusicTagger.Model
{
    public class Project : IEquatable<Project>
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public List<Tag> Tags { get; set; }
        public List<MusicFile> Files { get; set; }

        public Project()
        {
            Files = new List<MusicFile>();
        }

        public void LoadFilesFromFolder(string folderPath)
        {
            Files.AddRange(Directory.GetFiles(folderPath, "*.mp3").Select(path => new MusicFile(path)).ToList());
        }

        public void LoadFiles(string[] folderPaths)
        {
            Files.AddRange(folderPaths.Select(path => new MusicFile(path)).ToList());
        }

        public bool Equals(Project other)
        {
            if (other == null) return false;

            return 
                Tags != null && Files != null 
                && !Tags.Except(other.Tags).Any() 
                && !Files.Except(other.Files).Any();
        }
    }
}
