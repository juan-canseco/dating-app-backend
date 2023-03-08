namespace Identity.Server.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
