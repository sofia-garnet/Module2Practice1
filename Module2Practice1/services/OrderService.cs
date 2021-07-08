using System;
using Module2Practice1.Models;
using Module2Practice1.Services.Notifications;

namespace Module2Practice1.Services
{
    public class OrderService
    {
        private static readonly OrderService Self;
        private readonly SmsService _smsService;
        private readonly MailService _mailService;
        static OrderService()
        {
            Self = new OrderService();
        }

        private OrderService()
        {
            _smsService = new();
            _mailService = new();
        }

        public static OrderService Instance => Self;

        public void Submit(CartService basket, User user)
        {
            if (!string.IsNullOrEmpty(user.Phone))
            {
                _smsService.Notify(basket, user);
            }

            if (!string.IsNullOrEmpty(user.Mail))
            {
                _mailService.Notify(basket, user);
            }

            Log(basket, user);

            basket.Clear();
        }

        private void Log(CartService basket, User user)
        {
            var total = 0;
            for (var i = 0; i < basket.Capasity; i++)
            {
                total += basket.Get(i).Price;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Info: {user.Name} ordered {basket.Capasity} products. Total price: {total}");
            Console.ResetColor();
        }
    }
}