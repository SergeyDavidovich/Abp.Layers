using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Layers.Data;

/* This is used if database provider does't define
 * ILayersDbSchemaMigrator implementation.
 */
public class NullLayersDbSchemaMigrator : ILayersDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
