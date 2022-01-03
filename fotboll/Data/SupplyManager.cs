using fotboll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fotboll.Data
{
    public class SupplyManager
    {
        public static List<Models.Product> Supply { get; set; } = new List<Models.Product>();
        public static List<Product> Supplies { get; private set; }

        public static List<Models.Product> GetSupply()
        {
            return Supply;
        }
        
        public static List<Models.Product> RemoveSupply(Models.Product supply)
        {
            if (supply.Supply> 0)
            {
                supply.Supply--;
                Supply.Remove(supply);

            }
            return Supply;
            // Den rensar Supply listan

        }
    }
}
