using Organize_Cds_System.Domain.Interfaces.InterfaceServices.Products.Cds;
using Organize_Cds_System.Domain.Interfaces.Products.Cds;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using System;
using System.Threading.Tasks;

namespace Organize_Cds_System.Domain.Services.Products.Cds
{/// <summary>
 /// Esta classe fica responsável
 /// por manter as regras de negócio
 /// e as validaçõesda entidade 
 /// de produto
 /// </summary>
    public class ServiceCd : IServiceCd
    {
        //Injeção de dependencia
        private readonly ICd _ICd;

        //Construtor
        public ServiceCd(ICd ICd)
        {
            _ICd = ICd;
        }


        //Métodos 
        public async Task AddCd(Cd cd)
        {
            var validateName = cd.ValidateStringProperties(cd.Name, "Name");
            var validateArtist = cd.ValidateStringProperties(cd.Artist, "Artist");

            if (validateName && validateArtist)
            {
                cd.RegisterDate = DateTime.Now;
                cd.ModificateDate = DateTime.Now;
                cd.State = true;
                await _ICd.Add(cd);
            }
        }

        public async Task UpdateCd(Cd cd)
        {
            var validateName = cd.ValidateStringProperties(cd.Name, "Name");
            var validateArtist = cd.ValidateStringProperties(cd.Artist, "Artist");

            if (validateName && validateArtist)
            {
                cd.ModificateDate = DateTime.Now;
                await _ICd.UpDate(cd);
            }
        }
    }
}
