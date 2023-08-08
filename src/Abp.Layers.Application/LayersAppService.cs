using System;
using System.Collections.Generic;
using System.Text;
using Abp.Layers.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Layers;

/* Inherit your application services from this class.
 */
public abstract class LayersAppService : ApplicationService
{
    protected LayersAppService()
    {
        LocalizationResource = typeof(LayersResource);
    }
}
