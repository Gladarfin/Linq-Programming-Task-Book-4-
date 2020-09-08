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
            //LinqBegin37°. Дана строковая последовательность A. Строки последовательности содержат только заглавные буквы латинского алфавита. 
            //Получить новую последовательность строк, элементы которой определяются по соответствующим элементам A следующим образом: 
            //пустые строки в новую последовательность не включаются, а к непустым приписывается порядковый номер данной строки в исходной последовательности
            //(например, если пятый элемент A имеет вид «ABC», то в полученной последовательности он будет иметь вид «ABC5»).При нумерации должны учитываться и пустые строки последовательности A. 
            //Отсортировать полученную последовательность в лексикографическом порядке по возрастанию. 

            Task("LinqBegin37");
            GetEnumerableString().Select((s, i) => s.Length != 0 ? s + (i + 1).ToString():"").Where(s=> s.Length!=0).OrderBy(s=>s).Put();            
        }
    }

}
