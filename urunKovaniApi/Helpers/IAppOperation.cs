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
        Task<List<Categories>> SideMenu(int id);
        Task<List<Categories>> MainMenu(int id);
        Task<List<AppSettings>> AppSettings(int id);
        Task<List<Shops>> TopStoresShops();
        Task<Shops> GetShop(int id); //shopId
        Task<List<Products>> GetShopsProducts(int id);// shopsId 
        Task<List<Products>> SortShopsProducts(int id, int sortId);// shopsId 


    }
}
