using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class Likes : BaseEntity
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("shop_id")]
        public int ShopId { get; set; }

        [Column("product_id")]
        public int PrdocutId { get; set; }
 

    }
}