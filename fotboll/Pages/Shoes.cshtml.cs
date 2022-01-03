using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fotboll.Pages
{
    public class ShoesModel : PageModel
    {
        public IEnumerable<Models.Product> ProductsList { get; set; }
        public IEnumerable<Models.Product> CartList { get; set; }
        public IEnumerable<Models.Product> SupplyList { get; set; }

        public void OnGet(int productId)
        {
            ProductsList = Data.ProductManager.GetProducts();
            SupplyList = Data.SupplyManager.GetSupply();
            CartList = Data.ShoppingCartManager.GetCartProducts();
            if (productId != 0)
            {
                var product = ProductsList.Where(m => m.ID == productId).FirstOrDefault();
                Data.SupplyManager.RemoveSupply(product);
            }
            
            if (productId != 0)
            {
                var product = ProductsList.Where(m => m.ID == productId).FirstOrDefault();
                Data.ShoppingCartManager.AddCartProduct(product);


            }
        }
        public void OnPost(int productId)
        {
            ProductsList = Data.ProductManager.GetProducts();
            CartList = Data.ShoppingCartManager.GetCartProducts();
            SupplyList = Data.SupplyManager.GetSupply();

            if (productId != 0)
            {
                var product = ProductsList.Where(m => m.ID == productId).FirstOrDefault();
                Data.ShoppingCartManager.AddCartProduct(product);
            }
            if (productId != 0)
            {
                var product = ProductsList.Where(m => m.ID == productId).FirstOrDefault();
                Data.SupplyManager.RemoveSupply(product);
            }
        }
    }   }
