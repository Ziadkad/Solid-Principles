using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Before
{
    //For example, consider a scenario where you have a class that needs to use an instance of another class. In the traditional approach, the first class would directly create an instance of the second class, leading to a tight coupling between them. This makes it difficult to change the implementation of the second class or to test the first class independently.
    //In this example The MediaPlayer class directly depends on the Audio class, creating a strong coupling between them.
    //If we decide to introduce a new type of player (e.g., Video), or if we need to change the behavior of the Audio class, we would have to modify the MediaPlayer class.
    internal class MediaPlayer
    {
        private Audio audio;
        public MediaPlayer()
        {
            audio = new Audio();
        }
        public void Play(string audioFileName)
        {
            audio.PlayAudio(audioFileName);
        }

    }
}
