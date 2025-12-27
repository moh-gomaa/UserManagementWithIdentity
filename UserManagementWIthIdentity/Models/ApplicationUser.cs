using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserManagementWIthIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(150)]
        public string FirstName { get; set; }

        [Required, MaxLength (150)]
        public string LastName { get; set; }

        public byte[] ProfilePicture { get; set; }
    }
}
