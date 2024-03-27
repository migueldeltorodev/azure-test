using AzureApi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AzureApi.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AzureApiController : AbpControllerBase
{
    protected AzureApiController()
    {
        LocalizationResource = typeof(AzureApiResource);
    }
}
