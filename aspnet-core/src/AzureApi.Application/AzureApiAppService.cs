using System;
using System.Collections.Generic;
using System.Text;
using AzureApi.Localization;
using Volo.Abp.Application.Services;

namespace AzureApi;

/* Inherit your application services from this class.
 */
public abstract class AzureApiAppService : ApplicationService
{
    protected AzureApiAppService()
    {
        LocalizationResource = typeof(AzureApiResource);
    }
}
