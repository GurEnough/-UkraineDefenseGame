using System.Collections.Generic;
using System.Drawing;
using System.Media;
using UkraineDefense.Engine;

namespace UkraineDefense
{
    class Resources
    {
        static Dictionary<string, Image> frames = new Dictionary<string, Image>();
        static Dictionary<string, SoundPlayer> sounds = new Dictionary<string, SoundPlayer>();
        static public void InitializationResources()
        {
            frames = FileSystem.LoadFrames("Res.int");
            sounds = FileSystem.LoadSound("Sound.int");
        }
        static public Image GetFrame(string key) => frames[key];
        static public SoundPlayer GetSound(string key) => sounds[key];
    }
}
