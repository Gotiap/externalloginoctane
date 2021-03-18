using Oqtane.Models;
using Oqtane.Modules;

namespace CS.ExternalLogin
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "ExternalLogin",
            Description = "ExternalLogin",
            Version = "1.0.0",
            ServerManagerType = "CS.ExternalLogin.Manager.ExternalLoginManager, CS.ExternalLogin.Server.Oqtane",
            ReleaseVersions = "1.0.0",
            Dependencies = "CS.ExternalLogin.Shared.Oqtane"
        };
    }
}
