using SyncfusionComponentsDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SyncfusionComponentsDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SyncfusionComponentsDemoController : AbpControllerBase
    {
        protected SyncfusionComponentsDemoController()
        {
            LocalizationResource = typeof(SyncfusionComponentsDemoResource);
        }
    }
}