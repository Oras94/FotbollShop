using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fotboll.Pages
{
    public class PaymentsModel : PageModel
    {
        public IEnumerable<Models.Product> CartList { get; set; }
        public void OnGet()
        {
            CartList = Data.ShoppingCartManager.GetCartProducts();
           
        }
       
    }
}
