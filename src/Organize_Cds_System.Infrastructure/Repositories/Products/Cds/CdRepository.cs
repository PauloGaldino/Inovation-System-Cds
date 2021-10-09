using Microsoft.EntityFrameworkCore;
using Organize_Cds_System.Domain.Interfaces.Products.Cds;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using Organize_Cds_System.Infrastructure.Configurations.Context;
using Organize_Cds_System.Infrastructure.Repositories.Generics;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Organize_Cds_System.Infrastructure.Repositories.Products.Cds
{
    public class CdRepository : GenericRepository<Cd>, ICd
    {
        private readonly DbContextOptions<BaseDbContext> _optionsBulder;    
        public CdRepository()
        {
            _optionsBulder = new DbContextOptions<BaseDbContext>();
        }
        public async Task<List<Cd>> ListCdByUser(string userId)
        {
            using (var  data = new BaseDbContext(_optionsBulder))
            {
                return await data.Cds.Where(c => c.UserId == userId).AsNoTracking().ToListAsync();
            }
        }
    }
}
