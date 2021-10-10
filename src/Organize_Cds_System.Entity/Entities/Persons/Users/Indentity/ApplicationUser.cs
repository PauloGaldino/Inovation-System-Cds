using Microsoft.AspNetCore.Identity;



namespace Organize_Cds_System.Entity.Entities.Persons.Users.Indentity
{
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }

    }
}
