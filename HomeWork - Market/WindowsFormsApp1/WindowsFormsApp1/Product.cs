using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Product
    {
        public static int id { get; private set; } = 1;
        public string ID { get; private set; }
        public string Ad { get; private set; }
        public string Kateqoriya { get; private set; }
        public decimal Say { get; private set; }

        public decimal Qiymət { get; private set; }
        public bool Endirim { get; private set; }
        public decimal Faiz { get; private set; }

        public Product()
        {
            IdCreator();
            id++;
        }
        public Product(string name, string category, decimal count,decimal price,bool discount,decimal percent) :this()
        {
            Ad = name;
            if (discount == true)
            {
                Qiymət = price - (price * percent / 100);
            }
            else
            {
                Qiymət = price;
            }
            Endirim = discount;
            Say = count;
            Kateqoriya = category;
            Faiz = percent;
        }

        public void IdCreator()
        {
            ID = new string('0', 4 - id.ToString().Length) + id;
        }
    }
}
