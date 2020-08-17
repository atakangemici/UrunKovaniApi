using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using urunKovaniApi;
using urunKovaniApi.Models;

namespace urunKovaniApi.Helpers
{
    public class AppOperation : IAppOperation
    {
        private readonly UrunKovaniContext _dbContext;

        public AppOperation(UrunKovaniContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Categories>> SideMenu(int id)
        {
            var sideMenus = await _dbContext.Categories.Where(x => x.ShopId == id).ToListAsync();

            return sideMenus;
        }

        public async Task<List<Categories>> MainMenu(int id)
        {
            var mainMenu = await _dbContext.Categories.Where(x => x.ShopId == id).ToListAsync();

            return mainMenu;
        }

        public async Task<List<AppSettings>> AppSettings(int id)
        {
            var appSettings = await _dbContext.AppSettings.Where(x => x.Key == id).ToListAsync();

            return appSettings;
        }

        public async Task<List<Shops>> TopStoresShops()
        {
            var topStoresShops = await _dbContext.Shops.Where(x => x.TopStores == true && !x.Deleted).ToListAsync();

            return topStoresShops;
        }

        public async Task<List<Shops>> AllShops()
        {
            var allShops = await _dbContext.Shops.Where(x => x.Deleted == false).ToListAsync();

            return allShops;
        }

        public async Task<List<ShopCategories>> ShopCategories()
        {
            var shopCategories = await _dbContext.ShopCategories.Where(x => x.Deleted == false).ToListAsync();

            return shopCategories;
        }
    }
}
