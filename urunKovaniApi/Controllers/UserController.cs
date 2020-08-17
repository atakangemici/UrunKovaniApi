using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using urunKovaniApi.Helpers;
using urunKovaniApi.Models;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace urunKovaniApi.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IAuthOperation _authOperation;

        public UserController(UrunKovaniContext context, IAuthOperation authOperation)
        {
            _authOperation = authOperation;
        }

        //[Route("register"), HttpPost]
        //public async Task<Users> Register(string name, string lastname, string email, string password)
        //{
            
        //    var response = await _authOperation.Register(name,lastname,email,password);

        //    return response;

        //}

    }
}
