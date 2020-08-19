using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class Comments : BaseEntity
    {
        [Column("shop_id")]
        public int ShopId { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("comment")]
        public string Comment { get; set; }

    }
}