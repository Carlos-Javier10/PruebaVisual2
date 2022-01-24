using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
    public class city
    { 
        public int city_id { get; set; }
        public string city_name { get; set; }
        public int country_id { get; set; }
        public DateTime last_update { get; set; }

    }
}
