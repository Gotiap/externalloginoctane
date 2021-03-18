using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Oqtane.Modules;
using Oqtane.Models;
using Oqtane.Infrastructure;
using Oqtane.Repository;
using CS.ExternalLogin.Models;
using CS.ExternalLogin.Repository;

namespace CS.ExternalLogin.Manager
{
    public class ExternalLoginManager : IInstallable, IPortable
    {
        private IExternalLoginRepository _ExternalLoginRepository;
        private ISqlRepository _sql;

        public ExternalLoginManager(IExternalLoginRepository ExternalLoginRepository, ISqlRepository sql)
        {
            _ExternalLoginRepository = ExternalLoginRepository;
            _sql = sql;
        }

        public bool Install(Tenant tenant, string version)
        {
            return _sql.ExecuteScript(tenant, GetType().Assembly, "CS.ExternalLogin." + version + ".sql");
        }

        public bool Uninstall(Tenant tenant)
        {
            return _sql.ExecuteScript(tenant, GetType().Assembly, "CS.ExternalLogin.Uninstall.sql");
        }

        public string ExportModule(Module module)
        {
            string content = "";
            List<Models.ExternalLogin> ExternalLogins = _ExternalLoginRepository.GetExternalLogins(module.ModuleId).ToList();
            if (ExternalLogins != null)
            {
                content = JsonSerializer.Serialize(ExternalLogins);
            }
            return content;
        }

        public void ImportModule(Module module, string content, string version)
        {
            List<Models.ExternalLogin> ExternalLogins = null;
            if (!string.IsNullOrEmpty(content))
            {
                ExternalLogins = JsonSerializer.Deserialize<List<Models.ExternalLogin>>(content);
            }
            if (ExternalLogins != null)
            {
                foreach(var ExternalLogin in ExternalLogins)
                {
                    _ExternalLoginRepository.AddExternalLogin(new Models.ExternalLogin { ModuleId = module.ModuleId, Name = ExternalLogin.Name });
                }
            }
        }
    }
}