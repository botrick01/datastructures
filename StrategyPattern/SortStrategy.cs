﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class SortStrategy
    {
        public abstract void Sort(IMyList list);
        public abstract void SortDescending(IMyList list);
    }
}
