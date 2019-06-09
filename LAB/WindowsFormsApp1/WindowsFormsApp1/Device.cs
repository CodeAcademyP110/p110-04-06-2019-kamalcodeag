using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Device
    {
        private static int id { get; set; } = 1;
        public string ID { get; set; }
        public string Name { get; set; }
        public Category category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Device()
        {
            id++;
        }

        public void IdCreator()
        {
            ID = new string('0', 4 - id.ToString().Length) + id;
        }
    }
}
