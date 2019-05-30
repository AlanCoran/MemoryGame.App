using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryGame.App.Services
{
    public interface ILocalDataSource
    {
        void SaveSettings(string fileName, string text);
        string LoadSettings(string fileName);
    }
}
