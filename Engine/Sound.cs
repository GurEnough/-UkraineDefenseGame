namespace UkraineDefense.Engine
{
    class Sound
    {
        static public void Play(string key) => Resources.GetSound(key).Play();
    }
}
