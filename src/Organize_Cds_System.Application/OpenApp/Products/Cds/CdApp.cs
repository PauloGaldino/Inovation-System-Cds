using Organize_Cds_System.Application.Interfaces.Products.Cds;
using Organize_Cds_System.Domain.Interfaces.InterfaceServices.Products.Cds;
using Organize_Cds_System.Domain.Interfaces.Products.Cds;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Organize_Cds_System.Application.OpenApp.Products.Cds
{
    public class CdApp : ICdApp
    {
        //Injeção de dependencia
        ICd _ICd;
        IServiceCd _IServiceCd;


        //=======Construtores=============
        public CdApp(ICd ICd, IServiceCd IServiceCd)
        {
            _ICd = ICd;
            _IServiceCd = IServiceCd;
        }

        //======================Métodos=========================

        //=======Métodos CRUD===========================
        public async Task Add(Cd cd)
        {
            await _ICd.Add(cd);
        }

        public async Task Update(Cd cd)
        {
            await _ICd.UpDate(cd);
        }

        public async Task Delete(Cd cd)
        {
            await _ICd.Delete(cd);
        }

        //Método para pesquisa==========================
        public async Task<Cd> GetEntityById(int Id)
        {
            return await _ICd.getEntityById(Id);
        }

        public async Task<List<Cd>> List()
        {
            return await _ICd.List();
        }


        //========Métodos custumizados==================
        public async Task AddCd(Cd cd)
        {
            await _IServiceCd.AddCd(cd);
        }

        public async Task UpdateCd(Cd cd)
        {
            await _IServiceCd.UpdateCd(cd);
        }

        public async Task<List<Cd>> ListCdByUser(string userId)
        {
            return await _ICd.ListCdByUser(userId);
        }
    }
}
