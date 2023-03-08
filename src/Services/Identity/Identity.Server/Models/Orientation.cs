namespace Identity.Server.Models
{
    public class Orientation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserOrientation> UserOrientations { get; set; }
    }
}
