using System.Collections.Generic;
using Abp.Dependency;
using Abp.RealTime;

namespace project56.Authorization.Users
{
    public interface IUserLogoutInformer
    {
        void InformClients(IReadOnlyList<IOnlineClient> clients);
    }
}
