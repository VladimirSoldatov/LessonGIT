using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }
        string date = DateTime.Now.ToString();
        public string getDate()
        {
            return DateTime.Now.ToString();
        }
        public override string ToString()
        {
            return $"Студенческий билет: { Series}         { Number} {date}";
        }
    }
}
