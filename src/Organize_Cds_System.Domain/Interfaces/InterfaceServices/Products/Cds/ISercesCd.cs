using Organize_Cds_System.Entity.Entities.Products.Cds;
using System.Threading.Tasks;

namespace Organize_Cds_System.Domain.Interfaces.InterfaceServices.Products.Cds
{
    public interface IServiceCd
    {
        //============Métodos custumizados=======

        Task AddCd(Cd cd);

        Task UpdateCd(Cd cd);
    }
}
