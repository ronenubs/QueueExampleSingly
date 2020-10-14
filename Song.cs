using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleSingly
{
    public class Song
    {
        private string title;
        private string artist;
        private string album;
        private int length;

        public Song(string title, string artist, string album, int length)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.length = length;
        }

        public override string ToString()
        {
            return title + " (" + album + ") by "
                + artist + " " + length + ":00mins";
        }
    }
}
