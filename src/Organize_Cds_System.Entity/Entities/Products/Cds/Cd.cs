using Organize_Cds_System.Entity.Entities.Persons.Users.Indentity;
using Organize_Cds_System.Entity.Notifications;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Organize_Cds_System.Entity.Entities.Products.Cds
{
    [Table("Cd")]
    public class Cd : Notifiers
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("ARTISTA")]
        [MaxLength(150)]
        [DisplayName("ARTISTA")]
        public string Artist { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        [Display(Name = "DURAÇÃO")]
        public decimal Duration { get; set; }

        [Column("QUANTIDADEESTOQUE")]
        [DisplayName("QUANTIDADE_ESTOQUE")]
        public int StockQuantity { get; set; }



        [Column("Estado")]
        [Display(Name = "Estado")]
        public bool State { get; set; }

        [Column("DATAREGISTRO")]
        [Display(Name = "DATA_REGISTRO")]
        public DateTime RegisterDate { get; set; }

        [Column("DATAALTERACAO")]
        [Display(Name = "DATA_ALTERAÇÃO")]
        public DateTime ChangeDate { get; set; }


        [Display(Name = "USUÁRIO")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
