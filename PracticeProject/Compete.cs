using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class Compete
    {
        public void tempSet()
        {
            var numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
            int[] arrTemp = numbers.ToArray();

            int c1 = arrTemp[0];
            int c2 = arrTemp[1];
            int h1 = arrTemp[2];
            int h2 = arrTemp[3];
            int cold = 0;
            int hot = 0;
            if(c1>c2)
            {
                cold = c1;
            }else{cold = c2;}
            if(h1>h2){hot = h2;}
            else { hot = h1; }

            if(hot < cold){Console.WriteLine("YES");}
            else{Console.WriteLine("NO");}
        }

        public int getPoints(int month1, int month2, int month3)
        {
            int rewards = 0;
            
            if (month1 >= 10) { rewards += 100; }
            else { rewards = 10 * month1; }
            if (month2 >= 10) { rewards += 100; }
            else { rewards = 10 * month2; }
            if (month3 >= 10) { rewards += 100; }
            else { rewards = 10 * month3; }

            return rewards;
        }

        public static int minimumDeletions(int[] a)
        {
            int prev = a[0];
            int flagH = 0;
            int flagL = 0;
            int flagPivot = 0;
            
            for(int i=1; i<a.Count(); i++)
            {
               if (prev < a[i]) { flagL++; prev = a[i]; flagH = 0; }
                else if (prev > a[i]) { flagH++; prev = a[i]; flagL = 0; }
                if (Math.Abs(flagH) > 1 || Math.Abs(flagL) > 1) { flagPivot++;  }
            }
            return flagPivot;
            
        }
        static long[] solve(int n, int k, long[] a)
        {
            long maximal = a[0];
            long maximalFinal = 0;
            long count = 0;
            long[] results = new long[2];
            
            for (int i = 0; i <= a.Count() - k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    maximal = maximal & a[i + j];
                }
                if (maximalFinal < maximal)
                {
                    count = 1;
                    maximalFinal = maximal;
                }
                else if (maximalFinal == maximal)
                { count++; }
                results[0] = maximalFinal;
                results[1] = long.Parse((count % (Math.Pow(10.0,9.0)+ 7)).ToString());
            }
            return results;
        }

        public void bitWise() 
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            long[] a = new long[n];
            for (int a_i = 0; a_i < n; a_i++)
            {
                a[a_i] = Convert.ToInt64(Console.ReadLine());
            }
            long[] result = solve(n, k, a);
            Console.WriteLine(String.Join("\n", result));
        }

        public void hashsetUse()
        {
            HashSet<int> HS = new HashSet<int>();
            HS.Add(1);
            HS.Add(3);
            HS.Add(1);
            HS.Add(2);
            HS.Add(4);
            HS.Add(5);
            HS.Add(6);
            HS.Add(3);
            HS.Count();
            bool x=  HS.Contains(3);
            

            foreach (int i in HS)
            {
                Console.WriteLine(i);
            }

        }


    }
}
