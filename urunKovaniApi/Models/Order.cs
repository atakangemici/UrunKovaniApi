using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class Order : BaseEntity
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("shop_id")]
        public int ShopId { get; set; }

        [Column("shop_name")]
        public string ShopName { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("order_total")]
        public int OrderTotal { get; set; }

        [Column("payment_type")]
        public string PaymentType { get; set; }
    }
}