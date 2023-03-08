using Microsoft.AspNetCore.Identity;

namespace Identity.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public ICollection<UserInterest> UserInterests { get; set; }
        public ICollection<UserOrientation> UserOrientations { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}