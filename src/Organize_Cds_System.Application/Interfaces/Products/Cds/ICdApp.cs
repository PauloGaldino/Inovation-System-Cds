using Organize_Cds_System.Application.Interfaces.Generics;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using System.Threading.Tasks;

namespace Organize_Cds_System.Application.Interfaces.Products.Cds
{
    public interface ICdApp : IGenericApp<Cd>
    {
        //========Métodos custumizados========

        Task AddCd(Cd cd);

        Task UpdateCd(Cd cd);
    }
}
