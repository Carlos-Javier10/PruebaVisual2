using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
    public class payment
    {
        public int payment_id { get; set; }
        public int customers_id { get; set; }
        public int staff_id { get; set; }
        public int rental_id { get; set; }
        public double amount { get; set; }
        public DateTime payment_date { get; set; }



    }
}
