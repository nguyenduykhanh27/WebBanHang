using Ecommerce.Data.Entities;

namespace Ecommerce.Application.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
