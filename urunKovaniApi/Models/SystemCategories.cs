using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class SystemCategories : BaseEntity
    {
        [Column("category_name")]
        public string CategoryName { get; set; }

        public virtual ICollection<Shops> Shops { get; set; }


    }
}