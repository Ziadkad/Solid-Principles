using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class Audio : IAudio
    {
        public void PlayAudio(string audioFileName)
        {
            // Play audio
        }
    }
}
