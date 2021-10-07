using Microsoft.AspNetCore.Identity;
using Organize_Cds_System.Entity.Entities.Enuns;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Organize_Cds_System.Entity.Entities.Persons.Users.Indentity
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Column("NOME")]
        [MaxLength(255)]
        [Display(Name = "NOME")]
        public string Name { get; set; }

        [Column("TIPO")]
        [DisplayName("TIPO_USUÁRIO")]
        public UserType? Type { get; set; }
    }
}
