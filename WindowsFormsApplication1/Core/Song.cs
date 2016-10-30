using System;
using NAudio.Wave;

namespace GuessTheMelody.Core
{
    public class Song
    {
        public String name = "";
        public String filePath = "";
        public String[] answer;

        private IWavePlayer waweOutDevice;
        private AudioFileReader audioFileREader;

        public Song()
        {

        }
        public Song(String name, String filePath, String[] answer)
        {
            this.name = name;
            this.filePath = filePath;
            this.answer = answer;
            waweOutDevice = new WaveOut();
            audioFileREader = new AudioFileReader(filePath);
            waweOutDevice.Init(audioFileREader);
        }

        public void Init()
        {
            waweOutDevice = new WaveOut();
            audioFileREader = new AudioFileReader(filePath);
            waweOutDevice.Init(audioFileREader);
        }
        public void playSong()
        {
            waweOutDevice.Play();
        }
        public void pauseSong()
        {
            waweOutDevice.Pause();
        }

        public void stopSong()
        {
            waweOutDevice.Stop();
        }
    }
}
