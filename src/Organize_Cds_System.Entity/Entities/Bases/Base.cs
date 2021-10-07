using Organize_Cds_System.Entity.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Organize_Cds_System.Entity.Entities.Bases
{
    /// <summary>
    /// Classe reponsável por 
    /// propiedades genéircas
    /// para serem herdads por outras classes do 
    /// Dominio
    /// </summary>

    public class Base : Notifiers
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

    }
}
