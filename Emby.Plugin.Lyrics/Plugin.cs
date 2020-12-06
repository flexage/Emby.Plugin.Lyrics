using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Serialization;

namespace Emby_Lyrics_Provider
{
    public class Plugin:MediaBrowser.Common.Plugins.BasePlugin<PluginConfiguration>
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {

        }

        private Guid _id = new Guid("7319bdb3-a90e-4e47-af15-c9282c7bcdad");

        public override Guid Id
        {
            get { return _id; }
        }


        public override string Name
        {
            get { return "Lyrics"; }
        }

        public static Plugin Instance { get; private set; }

        // Plugin configuration page
        //public IEnumerable<PluginPageInfo> GetPages()
        //{
        //    return new[]
        //    {
        //        new PluginPageInfo
        //        {
        //            Name = "anime",
        //            EmbeddedResourcePath = "MediaBrowser.Plugins.Anime.Configuration.configPage.html"
        //        }
        //    };
        //}

        // Plugin thumbnail image
        //public Stream GetThumbImage()
        //{
        //    var type = GetType();
        //    return type.Assembly.GetManifestResourceStream(type.Namespace + ".thumb.png");
        //}

        //public ImageFormat ThumbImageFormat
        //{
        //    get
        //    {
        //        return ImageFormat.Png;
        //    }
        //}

    }
}
