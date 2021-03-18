using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Oqtane.Modules;
using Oqtane.Repository;
using CS.ExternalLogin.Models;

namespace CS.ExternalLogin.Repository
{
    public class ExternalLoginContext : DBContextBase, IService
    {
        public virtual DbSet<Models.ExternalLogin> ExternalLogin { get; set; }

        public ExternalLoginContext(ITenantResolver tenantResolver, IHttpContextAccessor accessor) : base(tenantResolver, accessor)
        {
            // ContextBase handles multi-tenant database connections
        }
    }
}
