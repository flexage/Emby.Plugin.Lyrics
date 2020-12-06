using System;
using MediaBrowser.Controller.Plugins;

namespace Emby_Lyrics_Provider
{
    public class LyricsProviderEntrypoint : IServerEntryPoint
    {
        public LyricsProviderEntrypoint()
        {

        }

        public void Run()
        {
            Console.Write("On your feet it's bobsleight time");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
