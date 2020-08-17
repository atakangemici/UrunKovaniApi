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
    public class AppOperation : IAppOperation
    {
        private readonly UrunKovaniContext _dbContext;

        public AppOperation(UrunKovaniContext dbContext)
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
            var shopInfo = await _dbContext.Shops.Where(x => x.Id == id).FirstOrDefaultAsync();

            return shopInfo;
        }

        public Task<List<Products>> GetShopsProducts(int id)
        {
            var products = _dbContext.Products.Include(x=>x.Category).ThenInclude(y=>y.Product).Where(xy=>xy.Category.ShopId==id).ToListAsync();
           
            return products;
        }

        public Task<List<Products>> SortShopsProducts(int id,int sortId)
        {

            if (sortId == 0)
            {
                var products = _dbContext.Products.OrderBy(c => c.Price).Include(x => x.Category).ThenInclude(y => y.Product).Where(xy => xy.Category.ShopId == id).ToListAsync();
                return products;
            }
            else
            {
                var products = _dbContext.Products.OrderByDescending(c => c.Price).Include(x => x.Category).ThenInclude(y => y.Product).Where(xy => xy.Category.ShopId == id).ToListAsync();

                return products;
            }
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



        public async Task<Users> Register(JObject data)
        {
            //var returnModel = new JObject();
            //returnModel["error"] = false;
            //returnModel["message"] = "";

            string name = (string)data["name"];
            string lastname = (string)data["lastname"];
            string email = (string)data["email"];
            string password = (string)data["password"];

            var isUserAlreadyHave = await _dbContext.Users.Where(x => x.Email == email).FirstOrDefaultAsync();

            if (isUserAlreadyHave == null)
            {

                Users registerUser = new Users();
                registerUser.Name = name;
                registerUser.SureName = lastname;
                registerUser.Email = email;
                registerUser.Password = password;

                _dbContext.Users.Add(registerUser);

                await _dbContext.SaveChangesAsync();

                return registerUser;
            }
            else
            {

                return new Users();
                // User kayıtlı olduğundan user login olmalı diye dönüş olmalı
            }

        }
    }
}
