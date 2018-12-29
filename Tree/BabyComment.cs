﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBabyScript.Tree
{
    public class BabyComment : BabyNode
    {
        public readonly string Text;

        public BabyComment(string text) : base(null)
        {
            Text = text;
        }
    }
}
