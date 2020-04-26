using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netsatis.Entities.Tables
{
    public class Stok
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }

    }
}
