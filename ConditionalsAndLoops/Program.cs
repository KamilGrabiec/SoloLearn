using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int xx = 7;
            int y = 8;
            int age1 = 9;
            int age2 = 13;
            int age3 = 18;
            int age4 = 11;
            int age5 = 65;
            int age6 = -3;


            TheIfElseStatement p = new TheIfElseStatement();
            p.TheIf();

            RelationalOperators o = new RelationalOperators();
            o.GreaterOrEqual(x,y);
            o.LessOrEqual(x, y);
            o.Equal(x, xx);
            o.NotEqual(x, y);

            TheElseClause i = new TheElseClause();
            i.CompareN1toN2(x, y);
            i.CompareN1toN2(x, xx);

            NastedIfStatements u = new NastedIfStatements();
            u.FindGeneration(age1);
            u.FindGeneration(age2);
            u.FindGeneration(age3);
            u.FindGeneration(age4);
            u.FindGeneration(age5);
            // This will return wrong result for negative value
            u.FindGeneration(age6);

            Console.WriteLine(" ");

            TheIfElseIfStatement t = new TheIfElseIfStatement();
            t.FindGeneration2(age1);
            t.FindGeneration2(age2);
            t.FindGeneration2(age3);
            t.FindGeneration2(age4);
            t.FindGeneration2(age5);
            t.FindGeneration2(age6);

    

            Console.ReadKey();
        }
    }
}
