using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer4Authentication.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Command")]
    [Authorize]
    public class CommandController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            //var json = { "firstName" : "Greg", "lastName" :  "Donovan"}

            var results = new string[] { "value1", "value2" };

            return Json(results);
        }
    }
}