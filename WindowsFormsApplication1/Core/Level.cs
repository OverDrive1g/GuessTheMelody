using System;

namespace GuessTheMelody.Core
{
    class Level
    {
        private Song[] _songs;
        private int _lenght;
        public Level(int lenght)
        {
            _lenght = lenght;
            _songs = new Song[lenght];
            addSongs();
        }

        public Song[] getSongs()
        {
            return _songs;
        }

        private void addSongs()
        {
            Songs s = Songs.Instanse;
            Random rnd = new Random();
            

            for (int i = 0; i < _songs.Length; i++)
            {
                Song song = new Song();
                do
                {
                    song = s.getSong(rnd.Next(0, s.getLenght()));

                } while (Array.IndexOf(_songs, song) != -1);

                _songs[i] = song;
            }
        }
    }
}
