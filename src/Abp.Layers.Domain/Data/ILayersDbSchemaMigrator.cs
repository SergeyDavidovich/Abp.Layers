using System.Threading.Tasks;

namespace Abp.Layers.Data;

public interface ILayersDbSchemaMigrator
{
    Task MigrateAsync();
}
