using System;

namespace fotboll.Models
{
    public class Product
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public int Supply { get; set; }
        public string ImgFileName { get; set; }

        
       
        
    }

    public class Tshirts : Product
    {
        public string Color { get; set; }
    }
    public class Shoes : Product
    {
        public int Size { get; set; }
    }
    public class Fotball : Product
    {
        public string Brand { get; set; }

    }
}