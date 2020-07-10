using Esnafim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Esnafim.Models
{
    public class Complaints : BaseEntity
    {
        [Column("shop_id")]
        public int ShopId { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("message")]
        public string Message { get; set; }

    }
}