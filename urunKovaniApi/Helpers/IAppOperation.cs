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

        string Test();
        Task<List<Categories>> BaseMenu(int id);

    }
}
