using Organize_Cds_System.Domain.Interfaces.Generics;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Organize_Cds_System.Domain.Interfaces.Products.Cds
{

    public interface ICd : IGeneric<Cd>
    {
        Task<List<Cd>> ListCdByUser(string userId);
    }
}
