using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Oqtane.Modules;
using CS.ExternalLogin.Models;

namespace CS.ExternalLogin.Repository
{
    public class ExternalLoginRepository : IExternalLoginRepository, IService
    {
        private readonly ExternalLoginContext _db;

        public ExternalLoginRepository(ExternalLoginContext context)
        {
            _db = context;
        }

        public IEnumerable<Models.ExternalLogin> GetExternalLogins(int ModuleId)
        {
            return _db.ExternalLogin.Where(item => item.ModuleId == ModuleId);
        }

        public Models.ExternalLogin GetExternalLogin(int ExternalLoginId)
        {
            return _db.ExternalLogin.Find(ExternalLoginId);
        }

        public Models.ExternalLogin AddExternalLogin(Models.ExternalLogin ExternalLogin)
        {
            _db.ExternalLogin.Add(ExternalLogin);
            _db.SaveChanges();
            return ExternalLogin;
        }

        public Models.ExternalLogin UpdateExternalLogin(Models.ExternalLogin ExternalLogin)
        {
            _db.Entry(ExternalLogin).State = EntityState.Modified;
            _db.SaveChanges();
            return ExternalLogin;
        }

        public void DeleteExternalLogin(int ExternalLoginId)
        {
            Models.ExternalLogin ExternalLogin = _db.ExternalLogin.Find(ExternalLoginId);
            _db.ExternalLogin.Remove(ExternalLogin);
            _db.SaveChanges();
        }
    }
}
