namespace fotboll.Models.Pages
{
    public class ProductModels
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }

    public class Tshirts : ProductModels
    {
        public string Color { get; set; }
    }
    public class Shoes : ProductModels
    {
        public int Sizee { get; set; }
    }
    public class Fotball : ProductModels
    {
        public string Brand { get; set; }

    }
}