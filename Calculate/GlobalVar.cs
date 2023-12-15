using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  Iterative
{
    public static class GlobalVar
    {
        public enum CalcMethods
        {
            Jacobi = 1,
            Gauss_Seidel = 2,
            SOR = 3
        };
        public enum LogType
        {
            Info = 1,
            Warn = 2,
            Error = 3
        };

    }
}
