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

        public string Test()
        {
            return "test";
        }

        public async Task<List<Categories>> BaseMenu(int id)
        {
            var getMenu = await _dbContext.Categories.Where(x => x.ShopId == id).ToListAsync();

            return getMenu;
        }
    }
}
