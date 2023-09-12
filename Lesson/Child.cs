using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class Child:ICloneable
    {
        public int Age { set; get; }
        public Student student { get; set; }

        public Child()
        {


            student = new Student()
            {
                FirstName = "Joey",
                LastName = "Finch",
                BirthDate = new DateTime(1996, 11, 30),
                StudentCard = new StudentCard
                {
                    Number = 258322,
                    Series = "AA"
                }
            };
        }
    public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
