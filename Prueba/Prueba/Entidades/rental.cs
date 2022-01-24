using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
    public class rental
    {
        public int rental_id { get; set; }
        public DateTime rental_date { get; set; }
        public int inventory_id { get; set; }
        public int customer_id { get; set; }
        public DateTime return_date { get; set; }
        public int staff_id { get; set; }
        public DateTime last_update { get; set; }


    }
}
