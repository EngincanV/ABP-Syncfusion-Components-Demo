using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SyncfusionComponentsDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class SyncfusionComponentsDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SyncfusionComponentsDemo";
    }
}
