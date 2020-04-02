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
            /*int x = 7;
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

            int num = 4;
            TheSwitch s = new TheSwitch();
            Console.WriteLine(s.TheSwitch2(num));
            */

            /*
            Console.WriteLine("");
            Console.WriteLine("The while Loop");

            int increment = 0;
            int state1 = 1;
            int state2 = 2;
            While loop = new While();
            loop.TheWhileLoop(increment, state1);
            Console.WriteLine("Different state");
            loop.TheWhileLoop(increment, state2);
           */


            /*
            Console.WriteLine("");
            Console.WriteLine("The for Loop");
            TheFor loop2 = new TheFor();
            int increment2 = 2;
            loop2.TheForLoop(increment2);
            */

            /*
            int increment3 = 0;
            The_do_while_Loop DoWhileLoop = new The_do_while_Loop();
            DoWhileLoop.TheDoWhile(increment3);
            */

            /*
            TheBreakContinue BreakContinue = new TheBreakContinue();
            BreakContinue.TheBreak();
            BreakContinue.TheContinue();
            */

            /*
            int age1 = 11;
            int age2 = 21;
            int age3 = 18;
            int age4 = 65;
            int age5 = -5;
            string sex1 = "f";
            string sex2 = "m";
            int money1 = 0;
            int money2 = 6000;
            Logical_Operators.LogicalOperators logic = new Logical_Operators.LogicalOperators();
            logic.TheAnd(age1, sex1, money1);
            logic.TheAnd(age2, sex2, money1);
            logic.TheAnd(age2, sex1, money1);
            logic.TheAnd(age2, sex1, money2);

            logic.TheOr(age1);
            logic.TheOr(age2);
            logic.TheOr(age3);
            logic.TheOr(age4);
            logic.TheOr(age5);
            */


            Basic_Calculator.Calculator sum = new Basic_Calculator.Calculator();
            sum.CalculateSum();

            Console.ReadKey();
        }
    }
}
