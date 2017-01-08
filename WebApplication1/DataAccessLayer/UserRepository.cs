using WebApplication1.Models;
using WebApplication1.Interface;

namespace WebApplication1.DataAccessLayer
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
    }
}