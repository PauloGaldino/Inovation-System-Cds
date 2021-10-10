using Microsoft.AspNetCore.Identity;
using Organize_Cds_System.Entity.Entities.Enuns;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Organize_Cds_System.Entity.Entities.Persons.Users.Indentity
{
    public class ApplicationUser : IdentityUser
    {
    
        public string Name { get; set; }

    }
}
