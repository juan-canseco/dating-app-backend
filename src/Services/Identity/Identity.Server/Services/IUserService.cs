namespace Identity.Server.Services
{
    public interface IUserService
    {
        Task CreateUserAsync(string userId);
        Task GetUserProfileId(string userId);
    }
}
