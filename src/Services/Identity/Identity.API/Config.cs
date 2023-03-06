using Duende.IdentityServer.Models;

namespace Identity.API
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
                {
                    new ApiScope("matching", "Matching Service")
                };

        public static IEnumerable<Client> Clients =>
            new Client[]
                { };
    }
}