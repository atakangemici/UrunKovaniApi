using Esnafim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Esnafim.Models
{
    public class Basket : BaseEntity
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("shop_id")]
        public int ShopId { get; set; }

        [Column("shop_name")]
        public string ShopName { get; set; }

        [Column("product_id")]
        public int PrdocutId { get; set; }

        [Column("product_name")]
        public string ProductName { get; set; }

        [Column("product_price")]
        public int ProductPrice { get; set; }

        [Column("unit")]
        public string Unit { get; set; }

        [Column("piece_kg")]
        public string PieceKg { get; set; }

        [Column("basket_total")]
        public int BasketTotal { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }


    }
}