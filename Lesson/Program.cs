﻿using System;
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
            s2.Print();

          ;
        }
    }
}