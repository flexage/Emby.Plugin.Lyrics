using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Serialization;

namespace Emby_Lyrics_Provider
{
    public class Plugin :MediaBrowser.Common.Plugins.BasePlugin<PluginConfiguration>
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {

        }

        public override Guid Id => new Guid("7319bdb3-a90e-4e47-af15-c9282c7bcdad");

        public override string Name => "Emby Lyrics Provider";
    }
}
