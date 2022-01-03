using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fotboll.Data
{
    public class ShoppingCartManager
    {

        public static List<Models.Product> CartProducts { get; set; } = new List<Models.Product>();


        public static List<Models.Product> GetCartProducts()
        {
            return CartProducts;
        }
        // Den tar fram koden till produkterna.
        public static List<Models.Product> AddCartProduct(Models.Product Product)
        {
            CartProducts.Add(Product);
            return CartProducts;
          //  Lägger till produkten
        }

        public static List<Models.Product> ClearCartList()
        {
            CartProducts.Clear();
            return CartProducts;
            // Den rensar listan 
        }
    }
}
