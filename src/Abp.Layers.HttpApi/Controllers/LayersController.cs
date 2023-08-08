using Abp.Layers.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Layers.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LayersController : AbpControllerBase
{
    protected LayersController()
    {
        LocalizationResource = typeof(LayersResource);
    }
}
