using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using urunKovaniApi;
using urunKovaniApi.Models;

namespace urunKovaniApi.Helpers
{
    public class AuthOperation : IAuthOperation
    {
        private readonly UrunKovaniContext _dbContext;

        public AuthOperation(UrunKovaniContext dbContext)
        {
            _dbContext = dbContext;
        }


        public string selam()
        {
            return "hellowwwwww";
        }
    }
}
