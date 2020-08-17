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
        public async Task<List<ShopCategories>> SideMenu(int id)
        {
            var sideMenu = await _appOperation.SideMenu(id);

            return sideMenu;
        }

        [Route("main_menu/{id:int}"), HttpGet]
        public async Task<List<ShopCategories>> MainMenu(int id)
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

        [Route("get_shop/{id:int}"), HttpGet]
        public async Task<Shops> GetShop(int id)
        {
            var shopInfo = await _appOperation.GetShop(id);

            return shopInfo;
        }

        [Route("top_stores_shops"), HttpGet]
        public async Task<List<Shops>> TopStoresShops()
        {
            var topStoresShops = await _appOperation.TopStoresShops();

            return topStoresShops;
        }


        [Route("get_shops_products/{id:int}"), HttpGet]
        public async Task<List<Products>> GetShopsProducts(int id)
        {
            var products = await _appOperation.GetShopsProducts(id);

            return products;
        }


        [Route("sort_shops_products"), HttpGet]
        public async Task<List<Products>> SortShopProducts(int id, int sortId)
        {
            var products = await _appOperation.SortShopsProducts(id,sortId);

            return products;
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


        [Route("register"), HttpPost]
        public async Task<ActionResult<Users>> ShopCategories([FromBody] JObject data)
        {
            var registerResponse = await _appOperation.Register(data);

            return registerResponse;
        }


    }
}
