using System;
using Module2Practice1.Configs;
using Module2Practice1.Models;

namespace Module2Practice1.Services
{
    public class CartService
    {
        private readonly Product[] _products;
        private int _capasity;
        private static readonly CartService Self;

        static CartService()
        {
            Self = new CartService();
        }

        private CartService()
        {
            _products = new Product[ConfigService.Instance.Config.CartConfig.Capasity];
            _capasity = 0;
        }

        public int Capasity => _capasity;

        public static CartService Instance => Self;

        public void Add(Product product)
        {
            if (_capasity == _products.Length)
            {
                throw new IndexOutOfRangeException();
            }

            _products[_capasity++] = product;
        }

        public Product Get(int index)
        {
            if (index == _products.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return _products[index];
        }

        internal void Clear()
        {
            _capasity = 0;
        }
    }
}