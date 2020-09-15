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
            //LinqBegin54°. Даны строковые последовательности A и B; все строки в каждой последовательности различны, 
            //имеют ненулевую длину и содержат только цифры и заглавные буквы латинского алфавита.Найти последовательность всех пар строк,
            //удовлетворяющих следующим условиям: первый элемент пары принадлежит последовательности A, а второй либо является одним из 
            //элементов последовательности B, начинающихся с того же символа, что и первый элемент пары, либо является пустой строкой
            //(если B не содержит ни одной подходящей строки).Результирующая последовательность называется левым внешним объединением последовательностей A и B по ключу, 
            //определяемому первыми символами исходных строк.Представить найденное объединение в виде последовательности строк вида «EA.EB», 
            //где EA — элемент из A, а EB — либо один из соответствующих ему элементов из B, либо пустая строка. Расположить элементы полученной 
            //строковой последовательности в лексикографическом порядке по возрастанию.
            //Указание.Использовать методы GroupJoin, DefaultIfEmpty, Select и SelectMany.

            Task("LinqBegin54");
            GetEnumerableString().GroupJoin(
                GetEnumerableString(),
                right => right[0],
                right => right[0],
                (left, e2) => e2.DefaultIfEmpty().Select(right => left +'.'+ right))
                                .SelectMany(e => e)
                                .OrderBy(e => e)
                                .Put();            
        }
    }

}