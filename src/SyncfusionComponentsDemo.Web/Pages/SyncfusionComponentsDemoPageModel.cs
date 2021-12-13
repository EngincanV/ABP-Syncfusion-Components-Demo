using SyncfusionComponentsDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SyncfusionComponentsDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SyncfusionComponentsDemoPageModel : AbpPageModel
    {
        protected SyncfusionComponentsDemoPageModel()
        {
            LocalizationResourceType = typeof(SyncfusionComponentsDemoResource);
        }
    }
}