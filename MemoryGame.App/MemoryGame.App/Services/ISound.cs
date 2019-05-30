using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryGame.App.Services
{
    public interface ISound
    {
        bool PlayMp3File(string fileName);
        bool PlayWavFile(string fileName);
    }
}
