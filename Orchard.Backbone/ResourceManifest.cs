using Orchard.FileSystems.VirtualPath;
using Orchard.UI.Resources;

namespace Orchard.Backbone
{
    public class ResourceManifest : IResourceManifestProvider
    {       
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            
            //** Also requires Orchard.jQuery ** //

            // Orchard-Backbone.js
            manifest.DefineScript("OrchardBackbone").SetUrl("orchard-backbone.min.js", "orchard-backbone.js").SetVersion("0.0.1").SetDependencies("Backbone");

            // for individual use
           
            // Underscore.js
            manifest.DefineScript("Underscore").SetUrl("libs/underscore/underscore.min.js", "libs/underscore/underscore.js").SetVersion("1.4.4")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/underscore.js/1.4.4/underscore-min.js", "//cdnjs.cloudflare.com/ajax/libs/underscore.js/1.4.4/underscore.js", true);
            
            // Backbone.js
            manifest.DefineScript("Backbone").SetUrl("libs/backbone/backbone.min.js", "libs/backbone/backbone.js").SetVersion("1.0.0")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/backbone.js/1.0.0/backbone-min.js", "//cdnjs.cloudflare.com/ajax/libs/backbone.js/1.0.0/backbone.js", true).SetDependencies("jQuery", "Underscore");
        }
    }
}