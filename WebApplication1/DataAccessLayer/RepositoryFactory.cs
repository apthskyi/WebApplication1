using WebApplication1.Interface;

namespace WebApplication1.DataAccessLayer
{
    public class RepositoryFactory
    {
        /// <summary>
        /// 用户仓储
        /// </summary>
        public static IUserRepository UserRepository { get { return new UserRepository(); } }
    }
}