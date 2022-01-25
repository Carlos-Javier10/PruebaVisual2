using System;
using Prueba.Entidades;
using Prueba;
using System.Collections.Generic;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //cracion de rental
            rental subida1 = new rental()
            {
                rental_id = 1,
                rental_date = new DateTime(2022 - 05 - 24),
                inventory_id = 367,
                customer_id = 130,
                return_date = new DateTime(2022 - 05 - 26),
                staff_id = 1,
                last_update = new DateTime(2022 - 05 - 16)
            };
            payment subida = new payment()
            {
                payment_id = 17503,
                customers_id = 130,
                staff_id = 2,
                rental_id= 1,
                amount = 7.99,
                payment_date = new DateTime(2022-02-15)
            };

            customer subid = new customer()
            {
                customer_id = 130,
                store_id = 1,
                fist_name = "Carlos",
                last_name = "Guagrilla",
                email = "carlo@hotmail.com",
                address_id = 5,
                activebool = true,
                create_date =new DateTime(2022-05-10),
                last_update = new DateTime(2022-04-15),
                active = 1
            };
            List<rental> listarenta = new List<rental> { subida1 };
            Class1 conex = new Class1();
            conex.rental.AddRange(listarenta);
            conex.SaveChanges();
        }
    }
}
