namespace Identity.Server.Models
{
    public class UserInterest
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
