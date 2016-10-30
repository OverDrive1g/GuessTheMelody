using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace GuessTheMelody.Core
{
    class Songs
    {
        private static Songs instanse;
        private List<Song> songs;
        private Songs()
        {
            songs = new List<Song>();
        }
        public static Songs Instanse
        {
            get
            {
                if (instanse == null)
                {
                    instanse = new Songs();
                }
                return instanse;
            }
        }

        public void Add(Song song)
        {
            songs.Add(song);
        }

        public List<Song> getSongs()
        {
            return songs;
        }
        public Song getSong(int id)
        {
            try
            {
                return songs[id];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int getLenght()
        {
            return songs.Count;
        }
    }
}
