namespace Identity.Server.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public string IsMain { get; set; }
        public ApplicationUser User { get; set; }
    }
}
