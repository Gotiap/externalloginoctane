using CS.ExternalLogin.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oqtane.Enums;
using Oqtane.Infrastructure;
using Oqtane.Shared;
using System.Collections.Generic;

namespace CS.ExternalLogin.Controllers
{
    [Route(ControllerRoutes.Default)]
    public class ExternalLoginController : Controller
    {
        private readonly IExternalLoginRepository _ExternalLoginRepository;
        private readonly ILogManager _logger;
        protected int _entityId = -1;

        public ExternalLoginController(IExternalLoginRepository ExternalLoginRepository, ILogManager logger, IHttpContextAccessor accessor)
        {
            _ExternalLoginRepository = ExternalLoginRepository;
            _logger = logger;

            if (accessor.HttpContext.Request.Query.ContainsKey("entityid"))
            {
                _entityId = int.Parse(accessor.HttpContext.Request.Query["entityid"]);
            }
        }

        // GET: api/<controller>?moduleid=x
        [HttpGet]
        [Authorize(Policy = PolicyNames.ViewModule)]
        public IEnumerable<Models.ExternalLogin> Get(string moduleid)
        {
            return _ExternalLoginRepository.GetExternalLogins(int.Parse(moduleid));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        [Authorize(Policy = PolicyNames.ViewModule)]
        public Models.ExternalLogin Get(int id)
        {
            Models.ExternalLogin ExternalLogin = _ExternalLoginRepository.GetExternalLogin(id);
            if (ExternalLogin != null && ExternalLogin.ModuleId != _entityId)
            {
                ExternalLogin = null;
            }
            return ExternalLogin;
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize(Policy = PolicyNames.EditModule)]
        public Models.ExternalLogin Post([FromBody] Models.ExternalLogin ExternalLogin)
        {
            if (ModelState.IsValid && ExternalLogin.ModuleId == _entityId)
            {
                ExternalLogin = _ExternalLoginRepository.AddExternalLogin(ExternalLogin);
                _logger.Log(LogLevel.Information, this, LogFunction.Create, "ExternalLogin Added {ExternalLogin}", ExternalLogin);
            }
            return ExternalLogin;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize(Policy = PolicyNames.EditModule)]
        public Models.ExternalLogin Put(int id, [FromBody] Models.ExternalLogin ExternalLogin)
        {
            if (ModelState.IsValid && ExternalLogin.ModuleId == _entityId)
            {
                ExternalLogin = _ExternalLoginRepository.UpdateExternalLogin(ExternalLogin);
                _logger.Log(LogLevel.Information, this, LogFunction.Update, "ExternalLogin Updated {ExternalLogin}", ExternalLogin);
            }
            return ExternalLogin;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize(Policy = PolicyNames.EditModule)]
        public void Delete(int id)
        {
            Models.ExternalLogin ExternalLogin = _ExternalLoginRepository.GetExternalLogin(id);
            if (ExternalLogin != null && ExternalLogin.ModuleId == _entityId)
            {
                _ExternalLoginRepository.DeleteExternalLogin(id);
                _logger.Log(LogLevel.Information, this, LogFunction.Delete, "ExternalLogin Deleted {ExternalLoginId}", id);
            }
        }
    }
}
