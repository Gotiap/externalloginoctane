using System.Collections.Generic;
using CS.ExternalLogin.Models;

namespace CS.ExternalLogin.Repository
{
    public interface IExternalLoginRepository
    {
        IEnumerable<Models.ExternalLogin> GetExternalLogins(int ModuleId);
        Models.ExternalLogin GetExternalLogin(int ExternalLoginId);
        Models.ExternalLogin AddExternalLogin(Models.ExternalLogin ExternalLogin);
        Models.ExternalLogin UpdateExternalLogin(Models.ExternalLogin ExternalLogin);
        void DeleteExternalLogin(int ExternalLoginId);
    }
}
