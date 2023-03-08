namespace Identity.Server.Models
{
    public class UserOrientation
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid OrientationId { get; set; }
        public Orientation Orientation { get; set;}
    }
}
