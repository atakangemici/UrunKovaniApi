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

        [Route("side_menu/{id:int}"), HttpGet]
        public async Task<List<Categories>> SideMenu(int id)
        {
            var sideMenu = await _appOperation.SideMenu(id);

            return sideMenu;
        }

        [Route("main_menu/{id:int}"), HttpGet]
        public async Task<List<Categories>> MainMenu(int id)
        {
            var mainMenu = await _appOperation.MainMenu(id);

            return mainMenu;
        }

        [Route("app_settings/{id:int}"), HttpGet]
        public async Task<List<AppSettings>> AppSettings(int id)
        {
            var appSettings = await _appOperation.AppSettings(id);

            return appSettings;
        }

        [Route("top_stores_shops"), HttpGet]
        public async Task<List<Shops>> TopStoresShops()
        {
            var topStoresShops = await _appOperation.TopStoresShops();

            return topStoresShops;
        }

        [Route("all_shops"), HttpGet]
        public async Task<List<Shops>> AllShops()
        {
            var allShops = await _appOperation.AllShops();

            return allShops;
        }

        [Route("shop_categories"), HttpGet]
        public async Task<List<ShopCategories>> ShopCategories()
        {
            var shopCategories = await _appOperation.ShopCategories();

            return shopCategories;
        }

    }
}
