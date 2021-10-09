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
        [Display(Name = "CODIGO")]
        public int Id { get; set; }

        [Column("NOME")]
        [MaxLength(255)]
        [Display(Name = "NOME_CD")]
        public string Name { get; set; }

        [Column("ARTISTA")]
        [MaxLength(150)]
        [DisplayName("ARTISTA")]
        public string Artist { get; set; }

        [Column("ANOLANCAMENTO")]
        [DisplayName("ANO_LANCAMENTO")]
        public int releaseYear { get; set; }

        
        [Column(TypeName = "decimal(18, 3)")]
        [Display(Name = "DURAÇÃO")]
        public decimal Duration { get; set; }

        [Column("QUANTIDADEESTOQUE")]
        [DisplayName("QUANTIDADE_ESTOQUE")]
        public int StockQuantity { get; set; }



        [Column("ESTADO")]
        [Display(Name = "ESTADO")]
        public bool State { get; set; }

        [Column("DATAREGISTRO")]
        [Display(Name = "DATA_REGISTRO")]
        public DateTime RegisterDate { get; set; }

        [Column("DATAALTERACAO")]
        [Display(Name = "DATA_ALTERAÇÃO")]
        public DateTime ModificateDate { get; set; }


        [Display(Name = "USUÁRIO")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
