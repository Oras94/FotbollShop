using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fotboll.Pages
{
    public class IndexModel : PageModel
    {

        public IEnumerable<Models.Product> ProductsList { get; set; }


        public void OnGet()
        {
            ProductsList = Data.ProductManager.GetProducts();
            ProductsList = from p in ProductsList
                           where (p is Models.Product)
                           select (p);

            ProductsList = ProductsList.Where(p => p.Name.Contains("Madrid"));
        }
    }
}
