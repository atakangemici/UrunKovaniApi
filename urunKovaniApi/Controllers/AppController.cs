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
using urunKovaniApi.Models;

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

        [Route("test"), HttpGet]
        public string GetValue()
        {
            var getValue = _appOperation.Test();

            return getValue;
        }

        [Route("base_menu/{id:int}"), HttpGet]
        public async Task<List<Categories>> BaseMenu(int id)
        {
            var getMenus = await _appOperation.BaseMenu(id);

            return getMenus;
        }

    }
}
