using Organize_Cds_System.Domain.Interfaces.Products.Cds;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using Organize_Cds_System.Infrastructure.Repositories.Generics;

namespace Organize_Cds_System.Infrastructure.Repositories.Products.Cds
{
    public class CdRepository : GenericRepository<Cd>, ICd
    {
    }
}
