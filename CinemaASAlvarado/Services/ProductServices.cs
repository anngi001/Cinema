using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaASAlvarado.Services
{
    public static class ProductoService
    {
        public static List<login> GetProducts()
        {
            var products = ApiHelpers.Get<ResponseProducts>("/api/Cartelera");
            return products.products;
        }
    }
}
