using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class Extensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString(index, length));
        }
    }
}
