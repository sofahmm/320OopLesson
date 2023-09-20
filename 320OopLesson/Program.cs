using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _320OopLesson
{

    class Cat
    {
        public string Name;
        public virtual void Move()
        {
            Console.WriteLine("МЯУ");
        }
    }

    class Lion : Cat
    {
        public void Bite()
        {
            Console.WriteLine("Кусь");
        }
        public override void Move()
        {
            Console.WriteLine("РРРРР!");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Мурка";
            cat.Move();
            Console.WriteLine("Меня зовут " + cat.Name);

            Cat cat2 = new Cat();
            cat2.Name = "Барсик";
            Console.WriteLine("Меня зовут " + cat2.Name);

            Lion lion = new Lion();
            lion.Move();
            lion.Bite();
            Console.ReadKey();
        }
    }
}
