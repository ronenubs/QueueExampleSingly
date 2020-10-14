using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleSingly
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedQueue<string> strQ = new LinkedQueue<string>();
            //try
            //{
            //    strQ.Enqueue("letter a");
            //    strQ.Enqueue("letter b");
            //    strQ.Enqueue("letter c");
            //    Console.WriteLine("Removed: " + strQ.Dequeue());
            //    Console.WriteLine("Removed: " + strQ.Dequeue());
            //    Console.WriteLine("Removed: " + strQ.Dequeue());
            //    Console.WriteLine("First: " + strQ.First());
            //    Console.WriteLine("Size: " + strQ.Size());
            //    Console.WriteLine("Emtpy: " + strQ.IsEmpty());
            //}
            //catch(EmptyListException e)
            //{
            //    Console.WriteLine("Size: " + strQ.Size());
            //    Console.WriteLine("Emtpy: " + strQ.IsEmpty());
            //    Console.WriteLine(e.Message);
            //}

            PlayList<Song> songs =
                new PlayList<Song>();
            Song song1 = new Song(
                    "Time",
                    "The Alan Parsons Project",
                    "Time",
                    5
                );
            Song song2 = new Song(
                    "Sirius Eye in the Sky",
                    "The Alan Parsons Project",
                    "Time",
                    3
                );
            songs.AddToPlaylist(song1);
            songs.AddToPlaylist(song2);
            Console.WriteLine("Playing now: " + songs.PlayingNow());
            Console.WriteLine("Next: " + songs.PlayNext());
            Console.ReadLine();
        }
    }
}
