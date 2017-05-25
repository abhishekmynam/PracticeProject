using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace PracticeProject
{
    public class FractionAdditionAndSub
    {
        public string FractionAddition()
        {
            string expression = "5/3+1/3";
            return string.Join("/",
            Regex.Matches(expression, @"(-?\d+)\/(\d+)").OfType<Match>()
            .Select(m => new[] { int.Parse(m.Groups[1].Value), int.Parse(m.Groups[2].Value) })
            .Aggregate(new[] { 0, 1 }, (p, c) => Normalize (p[0] * c[1] + p[1] * c[0], p[1] * c[1])));

        }
        private int Gcd(int a, int b) {return a == 0 ? Math.Abs(b) : Gcd(b % a, a);}

        private int[] Normalize(int n, int d) { return new[] { n / Gcd(n, d), d / Gcd(n, d) }; }
    }

}
