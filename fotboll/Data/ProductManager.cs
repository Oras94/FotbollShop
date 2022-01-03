using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fotboll.Models;

namespace fotboll.Data
{
    public class ProductManager
    {
        public static List<Models.Product> Products { get; set; } = new List<Models.Product>();

        public static List<Models.Product> GetProducts()
        {
            if (!Products.Any())
            {
                Products = new List<Models.Product>

                {

                new Models.Tshirts()

                {
                 ID = 1,
                 Cost = 100,
                 Name = "Barca Shirt",
                 ImgFileName = "Shirt1.jpg",
                 Color = "Blue/red",
                 Supply = 5
                },

                new Models.Tshirts()
                {
                 ID = 2,
                 Cost = 100,
                 Name = "City Shirt",
                 ImgFileName = "Shirt2.jpg",
                 Color = "Blue",
                 Supply = 5

                },

                new Models.Tshirts()
                {
                 ID = 3,
                 Cost = 100,
                 Name = "Psg Shirt",
                 ImgFileName = "Shirt3.jpg",
                 Color = "Blue",
                 Supply = 5

                },
                new Models.Tshirts()
                {
                 ID = 4,
                 Cost= 100,
                 Name="Chelsea Shirt",
                 ImgFileName = "Shirt4.jpg",
                 Color = "Blue",
                 Supply = 5
                },

                new Models.Tshirts()
                {
                 ID = 5,
                 Cost = 100,
                 Name = "Real Madrid Shirt",
                 ImgFileName = "Shirt5.jpg",
                 Color = "White" ,
                 Supply = 5
                },
            new Models.Fotball()
            {
                 ID=6,
                 Cost=15,
                 Name="Fc Barcelona ball",
                 ImgFileName="Ball1.jpg",
                 Brand="Nike",
                 Supply = 5
            },
            new Models.Fotball()
            {
                 ID= 7,
                 Cost = 15,
                 Name = "Manchester City Ball",
                 ImgFileName= "Ball2.jpg",
                 Brand = "Puma",
                 Supply = 5
            },

            new Models.Fotball()
            {
                ID=8,
                Cost=15,
                Name="Paris Ball",
                ImgFileName= "Ball3.jpg",
                Brand = "Nike",
                Supply = 5

            },

            new Models.Fotball()
            {
                 ID=9,
                 Cost=15,
                 Name= "Chelsea Ball",
                 ImgFileName="Ball4.jpg",
                 Brand="Nike",
                 Supply = 5


            },

            new Models.Fotball()

            {
                ID=10,
                Cost=15,
                Name="Real Madrid Ball",
                ImgFileName="Ball5.jpg",
                Brand= "Adidas"


            },
            new Models.Shoes()
            {
                 ID=11,
                 Cost=210,
                 Name ="Nike Mercurial",
                 ImgFileName="Shoes1.jpg",
                 Size=41,
                 Supply = 5


            },

            new Models.Shoes()
            {
                ID=12,
                Cost=220,
                Name ="Puma Boots",
                ImgFileName="Shoes2.jpg",
                Size=40,
                Supply = 5

            },

            new Models.Shoes()
            {
                ID=13,
                Cost=290,
                Name ="Real Madrid boots",
                ImgFileName="Shoes3.jpg",
                Size=41,
                Supply = 5

            },

            new Models.Shoes()
            {
                ID=14,
                Cost=250,
                Name ="Adidas Boots",
                ImgFileName="Shoes4.jpeg",
                Size=44,
                Supply = 5

            },

            new Models.Shoes()
            {
                ID=15,
                Cost=230,
                Name ="Puma Boots",
                ImgFileName="Shoes5.jpeg",
                Size=40,
                Supply = 5

            },

        };
            }

            return Products;
        }
        public static string AddItem(string name, int supply, string imgFileName, decimal cost, int id, string category)
        {
            var AddItem = new Models.Product();
            if (category == "Tshirts")
            { AddItem = new Models.Tshirts(); }
            
            if (category == "Fotball")
            { AddItem = new Models.Fotball(); }

            if (category == "Shoes")
            { AddItem = new Models.Shoes(); }



            AddItem.Name = name;
            AddItem.Supply = supply;
            AddItem.ImgFileName = imgFileName;
            AddItem.Cost = cost;
            


            return "";
        }
    }
       
} 
