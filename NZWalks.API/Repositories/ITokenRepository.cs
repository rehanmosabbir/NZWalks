using Microsoft.AspNetCore.Identity;

namespace NZWalks.API.Repositories
{
    public interface ITokenRepository
    {
        string GetJWTToken(IdentityUser user, List<string> roles);
    }
}
