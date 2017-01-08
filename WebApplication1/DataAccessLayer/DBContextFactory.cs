using System.Runtime.Remoting.Messaging;

namespace WebApplication1.DataAccessLayer
{
    public class DBContextFactory
    {

        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static CustomerDBContext GetCurrentContext()
        {
            CustomerDBContext _nContext = CallContext.GetData("CustomerContext") as CustomerDBContext;
            if (_nContext == null)
            {
                _nContext = new CustomerDBContext();
                CallContext.SetData("CustomerContext", _nContext);
            }
            return _nContext;
        }
    }
}