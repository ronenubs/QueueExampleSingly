using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleSingly
{
    public class PlayList<Songs> : LinkedQueue<Songs>
    {
        private LinkedQueue<Songs> song;

        public PlayList()
        {
            song = new LinkedQueue<Songs>();
        }

        public void AddToPlaylist(Songs song)
        {
            this.song.Enqueue(song);
        }

        public string PlayingNow()
        {
            return song.First().ToString();
        }

        public string PlayNext()
        {
            song.Dequeue();
            return PlayingNow();
        }
    }
}
