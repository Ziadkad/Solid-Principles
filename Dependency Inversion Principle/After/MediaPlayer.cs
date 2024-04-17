using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    //In this example, we created an IAudio interface. The MediaPlayer class now depends on this interface instead of the concrete Audio class. This decouples MediaPlayer from specific audio player implementations, enabling easy swapping of implementations without modifying MediaPlayer.
    internal class MediaPlayer
    {
        private IAudio Audio;
        public MediaPlayer(IAudio audio)
        {
            Audio = audio;
        }
        public void Play(string audioFileName)
        {
            Audio.PlayAudio(audioFileName);
        }

    }
}
