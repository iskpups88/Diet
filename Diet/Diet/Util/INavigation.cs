﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Util
{
    public interface INavigation
    {
        void ShowViewModel<T>() where T : class;
    }
}
