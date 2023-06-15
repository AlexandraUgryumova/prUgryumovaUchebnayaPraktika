using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_zad2
{
    class Playlist
    {
        public List<Song> list;
        public int currentIndex;

        public Playlist ()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public Song CurrentSong ()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void Add(Song song)
        {
            list.Add(song);
        }
        public void Next ()
        {
            if (list.Count > 0)
            {
                currentIndex = (currentIndex + 1) % list.Count;
            }
        }
        public void Back ()
        {
            if (list.Count > 0)
            {
                currentIndex = (currentIndex - 1 + list.Count) % list.Count;
            }
        }
        public void Clear ()
        {
            if (list.Count != 0)
            {
                list.Clear();
                currentIndex = 0;
            }
        }
    }
    public struct Song
    {
        public string Author;
        public string Title;
        public string Filename;

        public Song(string author, string title, string filname)
        {
            Author = author;
            Title = title;
            Filename = filname;
        }
        public override string ToString ()
        {
            return $"{Title} от {Author}";
        }
    }
}
