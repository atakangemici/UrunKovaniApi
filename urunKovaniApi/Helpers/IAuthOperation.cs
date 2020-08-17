using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using urunKovaniApi.Models;

namespace urunKovaniApi.Helpers
{
    public interface IAuthOperation
    {
        Task<Users> Register(JObject data);

        Task<Users> Login(JObject data);
        
    }
}
