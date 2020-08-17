using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using urunKovaniApi.Models;

namespace urunKovaniApi.Helpers
{
    public interface IAppOperation
    {
        Task<List<ShopCategories>> SideMenu(int id);
        Task<List<ShopCategories>> MainMenu(int id);
        Task<List<AppSettings>> AppSettings(int id);
        Task<List<Shops>> TopStoresShops();
        Task<List<Shops>> AllShops();
        Task<List<ShopCategories>> ShopCategories();
        Task<Shops> GetShop(int id); //shopId
        Task<List<Products>> GetShopsProducts(int id);// shopsId 
        Task<List<Products>> SortShopsProducts(int id, int sortId);// shopsId 


        //Ardanın method
        Task<Users> Register(JObject data);


    }

    public interface IAuthOperation
    {
  
    }
}
