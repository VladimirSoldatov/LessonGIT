using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Auditory : IEnumerable
    {
        Student[] students =
        {
        new Student
        {
        FirstName ="John",
        LastName ="Miller",
        BirthDate =new DateTime(1997,3,12),
        StudentCard =new StudentCard
            {
                Number=189356,Series= "AA"
            }
        }
        ,
         new Student
            {
                FirstName ="Candice",
                LastName ="Leman",
                BirthDate = new DateTime(1998,7,22),
                StudentCard = new StudentCard { Number=345185,Series= "AA"
            }
         }
         ,
        new Student
                {
                FirstName ="Joey",
                LastName ="Finch",
                BirthDate = new DateTime(1996,11,30),
                StudentCard = new StudentCard { Number=258322,Series= "AA"
            }
        },
                       new Student
                {
                FirstName ="Nicole",
                LastName ="Taylor",
                BirthDate = new DateTime(1996,5,10),
                StudentCard = new StudentCard { Number=513484,Series= "AA"
                }
                       }
        };

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(students);
        }
        public int Length()
        {
            return students.Length;
        }
        public Student this[int index]
        {
            get
            {
                if(index>-1 && index < Length())
                return students[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }
     
    }
}
