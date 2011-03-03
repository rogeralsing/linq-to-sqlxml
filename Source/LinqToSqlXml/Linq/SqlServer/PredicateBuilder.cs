﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToSqlXml.SqlServer
{
    public class PredicateBuilder
    {
        private readonly Stack<string> paths = new Stack<string>();
        private string CurrentPath
        {
            get { return paths.Peek(); }
        }
        private string GetFreeVariable()
        {
            int index = paths.Count;
            return "$" + ((char)(64 + index));
        }

    }
}
