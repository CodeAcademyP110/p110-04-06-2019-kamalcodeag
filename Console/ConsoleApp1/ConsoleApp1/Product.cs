using System;

namespace ConsoleApp1
{
    public class Product
    {
        public static int id { get; private set; } = 1;
        public string ID { get; private set; }
        public string Name { get; set; }
        public decimal Price
        {
            //get
            //{
            //    return Price;
            //}
            //set
            //{
            //    if (Discount == true)
            //    {
            //        value = Price - ((Price * Percent) / 100);
            //        Price = value;
            //    }
            //}
            get; set;

        }
        public bool Discount { get;  set; }
        public int Percent { get; set; }
        public decimal Count { get; private set; }

        
        public Product(decimal price, bool discount , int percent)
        {
            IdCreator();
            id++;
            if (discount == true)
            {
                Price = price - (price * percent / 100);
                //Price = 0.5;
            }
            else
            {
                Price = price;
            }
        }
        

        public void IdCreator()
        {
            ID = new string('0', 4 - id.ToString().Length) + id;
        }

        public override string ToString()
        {
            return $"{Name} + {Discount} + Endirim + {Percent} + {Price}";
        }
    }
}
