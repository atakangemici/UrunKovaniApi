using Esnafim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Esnafim.Models
{
    public class Products : BaseEntity
    {
        [Column("shop_name")]
        public string ShopName { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("birim")]
        public string Unit { get; set; }

        [Column("kg")]
        public string Kg { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Categories Category { get; set; }

    }
}