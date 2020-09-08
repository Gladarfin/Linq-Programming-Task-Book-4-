﻿using PT4;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Schema;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        // При решении задач группы LinqBegin доступны следующие
        // дополнительные методы, определенные в задачнике:
        //
        //   GetEnumerableInt() - ввод числовой последовательности;
        //
        //   GetEnumerableString() - ввод строковой последовательности;
        //
        //   Put() (метод расширения) - вывод последовательности;
        //
        //   Show() и Show(cmt) (методы расширения) - отладочная печать
        //     последовательности, cmt - строковый комментарий;
        //
        //   Show(e => r) и Show(cmt, e => r) (методы расширения) -
        //     отладочная печать значений r, полученных из элементов e
        //     последовательности, cmt - строковый комментарий.

        public static void Solve()
        {
            //LinqBegin57°. Дана целочисленная последовательность.Среди всех элементов последовательности, оканчивающихся одной и той же цифрой, 
            //выбрать максимальный. Полученную последовательность максимальных элементов упорядочить по возрастанию их последних цифр. 

            Task("LinqBegin57");
            GetEnumerableInt().GroupBy(
                                       d => Math.Abs(d % 10), 
                                       s => s,
                                       (d,s) => s.Max()).OrderBy(e => Math.Abs(e%10))
                              .Put();            
        }
    }

}
