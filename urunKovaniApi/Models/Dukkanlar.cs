using Esnafim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Esnafim.Models
{
    public class Shops : BaseEntity
    {
        [Column("shop_name")]
        public string ShopName { get; set; }

        [Column("shop_adress")]
        public string ShopAdress { get; set; }

        [Column("teslimat_suresi")]
        public string TeslimatSuresi { get; set; }

        [Column("calisma_saatleri")]
        public string CalismaSaatleri { get; set; }

        [Column("dukkan_telefon")]
        public string DukkanTelefon { get; set; }

        [Column("minimum_siparis_tutari")]
        public double MinimumSiparisTutari { get; set; }

        public virtual DukkanKategori DukkanKategori { get; set; }
        public virtual List<Kategoriler> Kategori { get; set; }

    }
}