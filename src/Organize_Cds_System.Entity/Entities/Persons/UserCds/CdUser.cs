using Organize_Cds_System.Entity.Entities.Persons.Users.Indentity;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using Organize_Cds_System.Entity.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize_Cds_System.Entity.Entities.Persons.UserCds
{
    [Table("CompraUsuario")]
    public class UserCd : Notifiers
    {
        [Column("USUARIOID")]
        [Display(Name = "CÓDIGO")]
        public int Id { get; set; }



        [Column("QUANTIDADECD")]
        [Display(Name = "QUANTIDADE DE CD")]
        public int Quantity { get; set; }

        //Relacionamento entre as tabelas

        [Display(Name = "USUÁRIO")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "CD")]
        [ForeignKey("Cd")]
        [Column(Order = 1)]
        public int CdId { get; set; }
        public virtual Cd Cds { get; set; }

    }
}
