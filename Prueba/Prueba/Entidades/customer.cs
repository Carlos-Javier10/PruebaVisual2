using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
    public class customer
    {
        public int customer_id { get; set; }
        public int store_id { get; set; }
        public string fist_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int address_id { get; set; }
        public Boolean activebool { get; set; }
        public DateTime create_date { get; set; }
        public DateTime last_update { get; set; }
       public int active { get; set; }


    }
}
