using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Category
    {
        private int id { get; set; } = 1;
        public string ID { get; set; }
        public string Name { get; private set; }
        public Category(string name)
        {
            Name = name;
            IdCreator();
            id++;
        }
        public void IdCreator()
        {
            ID = new string('0', 4 - id.ToString().Length) + id;
        }
    }
}
