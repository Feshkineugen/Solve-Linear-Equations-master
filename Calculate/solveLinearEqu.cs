using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  Iterative
{
    public  class solveLinearEqu
    {

        
        private static List<double[]>  matTrans(List<double[]> c)
        {
            List<double[]> cTrans = new List<double[]>();
            for (int i = 0; i < c.Count; i++)
            {
                double[] ci = new double[c[i].Length];
                c[i].CopyTo(ci, 0);
                if (ci[i] == 0)
                {
                    ci = c[i];
                    ci[i] = 1;
                    ci[ci.Length - 1] = -ci[ci.Length - 1];
                }
                else
                {
                    for (int j = 0; j < ci.Length ; j++)
                    {
                        ci[j] = -ci[j] / c[i][i];
                    }
                    ci[i] = 0;
                    ci[ci.Length - 1] = -ci[ci.Length - 1];
                }
                cTrans.Add(ci);
            }

            return cTrans;
 
        }

       
        public static int Jacobi(List<double[]> c, int IterativeTimes, double Epsilon, out int t, double[] solution)
        {
            List<double[]> cTrans = matTrans(c);
            double[] history = new double[cTrans.Count];
            double[] now = new double[cTrans.Count];
            int times = 0;
            bool isTrueSolution = false;
            while (times <= IterativeTimes && !isTrueSolution)
            {

         
                for (int i = 0; i < cTrans.Count; i++)
                {
                    now[i] = 0;
                    double[] Con = cTrans[i];
                    for (int j = 0; j < Con.Length - 1; j++)
                    {
                        now[i] += Con[j] * history[j];
                    }
                    now[i] += Con[Con.Length - 1];
                    if (Double.IsNaN(now[i]) || Double.IsInfinity(now[i]))
                        throw new Exception("Ошибка: Решение уравнения выглядит NaN или бесконечным, пожалуйста, проверьте сходимость системы уравнений!");
                }
                times++;
         
                isTrueSolution = true;
                for (int i = 0; i < now.Length; i++)
                {
                    if (Math.Abs(now[i] - history[i]) > Epsilon)
                    {
                        isTrueSolution = false;
                        break;
                    }
                }
          
                now.CopyTo(history, 0);
            }
            t = times;
            now.CopyTo(solution, 0);
        
            if (times > IterativeTimes) return 1;
            else
                return 0;

        }

        
        public static int SOR(List<double[]> c, int IterativeTimes, double Epsilon,double omega,  out int t, double[] solution)
        {
            List<double[]> cTrans = matTrans(c);
            double[] history = new double[cTrans.Count];
            double[] now = new double[cTrans.Count];
            int times = 0;
            bool isTrueSolution = false;
            while (times <= IterativeTimes && !isTrueSolution)
            {

           
                for (int i = 0; i < cTrans.Count; i++)
                {
                    now.CopyTo(history, 0);
                    now[i] = (1-omega)*history[i];
                    double[] Con = cTrans[i];
                    for (int j = 0; j < Con.Length - 1; j++)
                    {
                        now[i] += omega * Con[j] * history[j];
                    }
                    now[i] += omega * Con[Con.Length - 1];
                    if (Double.IsNaN(now[i]) || Double.IsInfinity(now[i]))
                        throw new Exception("Ошибка: Решение уравнения выглядит NaN или бесконечным, пожалуйста, проверьте сходимость системы уравнений!");
                    
                }
                times++;
             
                isTrueSolution = true;
                for (int i = 0; i < now.Length; i++)
                {
                    if (Math.Abs(now[i] - history[i]) > Epsilon)
                    {
                        isTrueSolution = false;
                        break;
                    }
                }
              
                now.CopyTo(history, 0);
            }
          
            t = times;
            now.CopyTo(solution, 0);
            if (times > IterativeTimes) return 1;
            else
                return 0;

        }
       
        
        public static int Gauss_Seidel(List<double[]> c, int IterativeTimes, double Epsilon, out int t, double[] solution)
        {
            return SOR(c, IterativeTimes, Epsilon, 1, out t, solution);
        }
    }
}
