using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
    public class address
    {
        public int address_id { get; set; }
        public string address1 { get; set; }
        public string adress2 { get; set; }
        public string district { get; set; }
        public int city_id { get; set; }
        public string postal_code { get; set; }
        public string phone { get; set; }
        public DateTime last_update { get; set; }

    }
}
