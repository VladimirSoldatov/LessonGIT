using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public interface IA
    {
        void Print();

    }
    public interface IB
    {
        void Print();

    }
    public interface IC
    {
        void Print();

    }
    public class Lesson:IA, IB, IC
    {
        int a;
        int b;
        int c;
        public void Print()
        {
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
        public Lesson(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        void IA.Print()
        {
            Console.WriteLine($"Hello {a}");
        }
        void IB.Print()
        {
            Console.WriteLine($"Hello {b}");
        }
        void IC.Print()
        {
            Console.WriteLine($"Hello {c}");
        }

    }
}
