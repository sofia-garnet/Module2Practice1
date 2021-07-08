using System;
using System.Collections.Generic;
using Module2Practice1.Models;
using Module2Practice1.Services;

namespace Module2Practice1
{
    public class Starter
    {
        public static void Run()
        {
            var productsProvider = new ProductProvider();

            for (var i = 0; i < Configs.ConfigService.Instance.Config.CartConfig.Capasity; i++)
            {
                try
                {
                    var product = productsProvider.Get(i);
                    CartService.Instance.Add(product);
                }
                catch (KeyNotFoundException knfe)
                {
                    Console.WriteLine(knfe.ToString());
                }
                catch (IndexOutOfRangeException ioore)
                {
                    Console.WriteLine(ioore.ToString());
                }
            }

            var user = new User() { Name = "User_1", Mail = "User_1@mail.us", Phone = "+2345 34124 14 14" };
            OrderService.Instance.Submit(CartService.Instance, user);
        }
    }
}