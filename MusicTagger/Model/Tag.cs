using System;

namespace MusicTagger.Model
{
    public class Tag : IEquatable<Tag>
    {
        public string Name { get; set; }

        public bool Equals(Tag other)
        {
            if (other == null) return false;

            return Name == other.Name;
        }
    }
}
