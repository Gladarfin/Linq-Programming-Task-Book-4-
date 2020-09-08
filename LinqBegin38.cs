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
            //LinqBegin38°. Дана целочисленная последовательность A. Получить новую последовательность чисел, элементы которой определяются по соответствующим элементам 
            //последовательности A следующим образом: если порядковый номер элемента A делится на 3(3, 6, …), 
            //то этот элемент в новую последовательность не включается; 
            //если остаток от деления порядкового номера на 3 равен 1(1, 4, …), то в новую последовательность добавляется удвоенное значение этого элемента; 
            //в противном случае(для элементов A с номерами 2, 5, …) элемент добавляется в новую последовательность без изменений.
            //В полученной последовательности сохранить исходный порядок следования элементов. 

            Task("LinqBegin38");
            GetEnumerableInt().Select((n, i) => (i + 1) % 3 == 1 ? 2 * n : (i+1) % 3 == 0 ? 3: n).Where(n=> n != 3).Put();           
        }
    }

}
