using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using urunKovaniApi;

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
    }
}
