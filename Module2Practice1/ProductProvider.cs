using System.Collections.Generic;
using Module2Practice1.Models;

namespace Module2Practice1
{
    public class ProductProvider
    {
        private Product[] _products;
        public ProductProvider()
        {
            Init();
        }

        public Product[] Products => _products;

        public Product Get(int id)
        {
            for (var i = 0; i < _products.Length; i++)
            {
                var product = _products[i];
                if (product.Id == id)
                {
                    return product;
                }
            }

            throw new KeyNotFoundException();
        }

        private void Init()
        {
            _products = new Product[]
            {
                new() { Id = 0, Name = "Proudct_00", Price = 1 },
                new() { Id = 1, Name = "Proudct_01", Price = 1 },
                new() { Id = 2, Name = "Proudct_02", Price = 2 },
                new() { Id = 3, Name = "Proudct_03", Price = 3 },
                new() { Id = 4, Name = "Proudct_04", Price = 4 },
                new() { Id = 5, Name = "Proudct_05", Price = 5 },
                new() { Id = 6, Name = "Proudct_06", Price = 6 },
                new() { Id = 7, Name = "Proudct_07", Price = 7 },
                new() { Id = 8, Name = "Proudct_08", Price = 8 },
                new() { Id = 9, Name = "Proudct_09", Price = 9 },
                new() { Id = 10, Name = "Proudct_10", Price = 10 },
            };
        }
    }
}