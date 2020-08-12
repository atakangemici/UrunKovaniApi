using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class Shops : BaseEntity
    {
        [Column("shop_name")]
        public string ShopName { get; set; }

        [Column("shop_address")]
        public string ShopAddress { get; set; }

        [Column("delivery_time")]
        public string DeliveryTime { get; set; }

        [Column("work_hours")]
        public string WorkHours { get; set; }

        [Column("shop_phone")]
        public string ShopPhone { get; set; }

        [Column("min_order_price")]
        public double MinOrderPrice { get; set; }

        [Column("top_stores")]
        public bool TopStores { get; set; }

        [Column("image")]
        public string Image { get; set; }


        public virtual ShopCategories ShopCategory { get; set; }
        public virtual List<Categories> Categorie { get; set; }

    }
}