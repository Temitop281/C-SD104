using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleAppLesson10_4LabMediaPlayer2
{
    class MediaPlayer
    {

        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();


        }

        public interface IAudioPlayer
        {
            void Play();
        }
    }
}
