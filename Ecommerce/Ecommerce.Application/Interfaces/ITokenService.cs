using Ecommerce.Data.Entities;

namespace Ecommerce.Application.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
