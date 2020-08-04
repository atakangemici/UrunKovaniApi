using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class AppSettings : BaseEntity
    {

        [Column("key")]
        public int Key { get; set; }

        [Column("content")]
        public string Content { get; set; }


    }
}