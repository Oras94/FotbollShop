using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fotboll.Pages
{
    public class Fotboll1Model : PageModel
    {
        public string Meddelande { get; set; }

        public int Siffra { get; set; }


        public void OnGet()
        {
            Meddelande = " Fotboll";
        }
    }
}
