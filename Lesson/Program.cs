using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IC s2 = new Lesson(1,5,10);//Не явное приведение типов
 
            Auditory auditory = new Auditory();

            Console.WriteLine(auditory[3]);
            Child a = new Child();
            a.Age = 18;
            Child b = (a.Clone() as Child);
            Console.WriteLine(b.Age);
            Console.WriteLine(b.student.StudentCard);
        }
    }
}
