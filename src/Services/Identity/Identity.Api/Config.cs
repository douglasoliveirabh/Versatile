using System.Collections.Generic;
using IdentityServer4.Models;


namespace Identity.Api
{
    public class IdentityServerConfig
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>(){
                new ApiResource("PersonApi", "Person Api")
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>(){
                new IdentityResources.OpenId(),
                new IdentityResources.Address(),
                new IdentityResources.Email(),
                new IdentityResources.Phone(),
                new IdentityResources.Profile()
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client() {
                        ClientId = "PersonApiClient",
                        ClientName = "Person Api Client",
                        AllowedGrantTypes = GrantTypes.ClientCredentials,
                        ClientSecrets = new List<Secret>(){
                            new Secret("p@ssw0rd".Sha256())
                        },
                        AllowedScopes = new List<string>{ "PersonApi.Read"}
                }
            };
        }
    }
}


