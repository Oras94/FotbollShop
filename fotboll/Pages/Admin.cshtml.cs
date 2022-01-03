using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fotboll.Pages
{
    public class AdminModel : PageModel
    {
        public IEnumerable<Models.Product> ProductsList { get; set; }
        [BindProperty]
        public string name { get; set; }
        [BindProperty]
        public decimal cost { get; set; }
        [BindProperty]
        public int supply { get; set; }

        [BindProperty]
        public string imgFileName { get; set; }
        [BindProperty]
        public int id { get; set; }
        [BindProperty]
        public string category { get; set; }
        public void OnGet()
        {
            List<Models.Product> ProductsList = Data.ProductManager.GetProducts();
        }

        public void OnPost()
        {
            Data.ProductManager.AddItem(name,supply,imgFileName,cost,id,category);
        }
    }
        

    
}
