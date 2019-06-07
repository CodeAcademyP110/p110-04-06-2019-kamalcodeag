using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public static class A
    {
        private static readonly List<B> letters;
        static A()
        {
            letters = new List<B>
            {
                new B
                {
                    Name = "a",
                    Surname = "b"
                }
            };
        }

        public static List<B> GetLetters()
        {
            return letters;
        }
    }

    public class B
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        //public string Name;
        //public string Surname;
    }
}
