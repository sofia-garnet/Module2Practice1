using System;
using System.Text;
using Module2Practice1.Models;

namespace Module2Practice1.Services.Notifications
{
    public class SmsService
    {
        internal void Notify(CartService cart, User user)
        {
            var message = Create(cart, user);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private string Create(CartService basket, User user)
        {
            var message = new StringBuilder();
            message.Append($"SMS: Dear {user.Name} You have already ordered some products thank You!{Environment.NewLine}");

            for (var i = 0; i < basket.Capasity; i++)
            {
                var product = basket.Get(i);

                message.Append($"Name: {product.Name} Price: {product.Price}{Environment.NewLine}");
            }

            return message.ToString();
        }
    }
}