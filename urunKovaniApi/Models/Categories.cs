using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class Categories : BaseEntity
    {
        [Column("category_name")]
        public string CategoryName { get; set; }

        public int ShopId { get; set; }

        [Column("url")]
        public string Url { get; set; }

        [ForeignKey("ShopId")]
        public Shops Shop { get; set; }

        public List<Products> Product { get; set; }


    }
}