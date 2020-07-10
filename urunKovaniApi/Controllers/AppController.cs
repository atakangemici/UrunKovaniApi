using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using urunKovaniApi.Helpers;

namespace urunKovaniApi.Controllers
{
    [Route("api/app")]
    public class AppController : ControllerBase
    {
        private readonly IAppOperation _appOperation;

        public AppController(UrunKovaniContext context, IAppOperation appOperation)
        {
            _appOperation = appOperation;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "home page" };

        }

    }
}
