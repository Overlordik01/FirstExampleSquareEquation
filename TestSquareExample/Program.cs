using System;
using System.Collections.Generic;
using System.IO;
using TestSquareExample.Main;

namespace TestSquareExample
{
    class Program
    {
        static void Main(string[] args)
        {

            ISquareEquation SquareEquation = new SquareEquationService();
            List<SquareEquation> SquareEquationsList;

            string path = @"C:\Users\overl\source\repos\TestSquareExample\TestSquareExample\SquareEquationContent.txt";
            double D;

            SquareEquationsList  = SquareEquation.CreateConnectionFile(path);
            try
            {
                foreach (SquareEquation item in SquareEquationsList)
                {

                    D = SquareEquation.SolveDiscriminant(item);

                    if (D > 0)
                    {
                        double[] Root = SquareEquation.SearchRoot(item, D);
                        Console.WriteLine(Root[0] + " " + Root[1]);
                    }
                    else if (D == 0)
                    {
                        double Root = SquareEquation.SearchRoot(item);
                        Console.WriteLine(Root);
                    }
                    else
                        Console.WriteLine("Never to solve equation");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Empty");
            }
           
        }
    }
}
