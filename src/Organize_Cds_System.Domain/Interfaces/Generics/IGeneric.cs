using System.Collections.Generic;
using System.Threading.Tasks;

namespace Organize_Cds_System.Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        //===========Métodos Crud=============

        Task Add(T Object);
        Task UpDate(T Object);
        Task Delete(T Object);

        //==========Métodos para pesquisa=====

        Task<T> getEntityById(int Id);
        Task<List<T>> List();
    }
}
