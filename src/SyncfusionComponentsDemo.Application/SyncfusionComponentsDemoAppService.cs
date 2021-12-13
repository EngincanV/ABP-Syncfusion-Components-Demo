using System;
using System.Collections.Generic;
using System.Text;
using SyncfusionComponentsDemo.Localization;
using Volo.Abp.Application.Services;

namespace SyncfusionComponentsDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class SyncfusionComponentsDemoAppService : ApplicationService
    {
        protected SyncfusionComponentsDemoAppService()
        {
            LocalizationResource = typeof(SyncfusionComponentsDemoResource);
        }
    }
}
