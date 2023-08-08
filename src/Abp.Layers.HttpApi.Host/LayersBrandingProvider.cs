using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.Layers;

[Dependency(ReplaceServices = true)]
public class LayersBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Layers";
}
