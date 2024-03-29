﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using urunKovaniApi;
using urunKovaniApi.Models;

namespace urunKovaniApi.Helpers
{
    public class AppRepository : IAppOperation
    {
        private readonly UrunKovaniContext _dbContext;

        public AppRepository(UrunKovaniContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ShopCategories>> SideMenu(int id)
        {
            var sideMenus = await _dbContext.ShopCategories.Where(x => x.ShopId == id).ToListAsync();

            return sideMenus;
        }

        public async Task<List<ShopCategories>> MainMenu(int id)
        {
            var mainMenu = await _dbContext.ShopCategories.Where(x => x.ShopId == id).ToListAsync();

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

        public async Task<Shops> GetShop(int id)
        {
            var shopInfo = await _dbContext.Shops.Where(x => x.Id == id)
                .Include(y => y.ShopCategory)
                .ThenInclude(z => z.Product)
                .FirstOrDefaultAsync();

            return shopInfo;
        }

        public Task<List<Products>> GetShopsProducts(int id)
        {
            var products = _dbContext.Products.Include(x => x.ShopCategory).ThenInclude(y => y.Product).Where(xy => xy.ShopCategory.ShopId == id).ToListAsync();

            return products;
        }

        public Task<List<Products>> SortShopsProducts(int id, int sortId)
        {

            if (sortId == 0)
            {
                var products = _dbContext.Products.OrderBy(c => c.Price).Include(x => x.ShopCategory).ThenInclude(y => y.Product).Where(xy => xy.ShopCategory.ShopId == id).ToListAsync();
                return products;
            }
            else
            {
                var products = _dbContext.Products.OrderByDescending(c => c.Price).Include(x => x.ShopCategory).ThenInclude(y => y.Product).Where(xy => xy.ShopCategory.ShopId == id).ToListAsync();

                return products;
            }
        }

        public async Task<List<Shops>> AllShops()
        {
            var allShops = await _dbContext.Shops.Where(x => x.Deleted == false).ToListAsync();

            return allShops;
        }

        public async Task<List<Shops>> ShopsAndSystemCategories()
        {
            var shopsAndSystemCategories = await _dbContext.Shops.Where(x => x.Deleted == false)
                .Include(x => x.SystemCategory)
                .Include(y => y.ShopCategory)
                .ThenInclude(z => z.Product)
                .ToListAsync();

            return shopsAndSystemCategories;
        }

        public async Task<List<SystemCategories>> SystemCategories()
        {
            var systemCategories = await _dbContext.SystemCategories.Where(x => x.Deleted == false)
                .Include(x => x.Shops)
                .ToListAsync();

            return systemCategories;
        }

    }
}
