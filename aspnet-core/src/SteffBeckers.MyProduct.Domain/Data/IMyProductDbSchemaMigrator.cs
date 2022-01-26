using System.Threading.Tasks;

namespace SteffBeckers.MyProduct.Data;

public interface IMyProductDbSchemaMigrator
{
    Task MigrateAsync();
}
