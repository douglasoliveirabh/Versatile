using System.Collections.Generic;
using IdentityServer4.Models;


namespace Identity.Api
{
    public class IdentityServerConfig
    {
        public static IEnumerable<ApiResource> GetApiResources() {
            return null;
        }

        public static IEnumerable<IdentityResource> GetIdentityResources() {
            return new List<IdentityResource>(){
                new IdentityResources.OpenId(),
                new IdentityResources.Address(),
                new IdentityResources.Email(),
                new IdentityResources.Phone(),
                new IdentityResources.Profile()
            };
        }
    }
}


