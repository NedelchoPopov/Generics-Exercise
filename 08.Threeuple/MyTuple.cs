﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Threeuple
{
    public class MyTuple<T1, T2, T3>
    {
        public MyTuple(T1 item1, T2 item2, T3 item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T1 Item1 { get; }

        public T2 Item2 { get; }

        public T3 Item3 { get; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
