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
                // badrequest dönmemiz lazm return de yemiyo hiç bişey
                return new Users();
                // User kayıtlı olduğundan user login olmalı diye dönüş olmalı
            }

        }

        public async Task<Users> Login(JObject data)
        {
            string email = (string)data["email"];
            string password = (string)data["password"];

            var returnModel = new JObject();

            var isUserAlreadyHave = await _dbContext.Users.Where(x => x.Email == email).FirstOrDefaultAsync();

            if (isUserAlreadyHave == null)
            {
                returnModel["error"] = true;
                returnModel["message"] = "Kullanıcı Tanımlı Değil";
                // return olmuyo badrequest dönememiz lazım
            }
      
            return isUserAlreadyHave;

        }
    }
}
