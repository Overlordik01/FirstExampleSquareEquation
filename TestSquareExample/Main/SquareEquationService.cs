using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestSquareExample.Main
{
    public class SquareEquationService : ISquareEquation
    {
        public List<SquareEquation> CreateConnectionFile(string path)
        {
            try
            {
                List<SquareEquation> squareEquations = new List<SquareEquation>();

                string line;
                StreamReader sr = new StreamReader(path);

                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(new char[] { ' ' });
                    squareEquations.Add(new SquareEquation() { a = Convert.ToDouble(values[0]), b = Convert.ToDouble(values[1]), c = Convert.ToDouble(values[2]) });
                }

                foreach(SquareEquation item in squareEquations)
                    Console.WriteLine(item.a + " " +item.b + " " + item.c);

                sr.Close();
                return squareEquations;
            }

            catch (IOException ex)
            {
                Console.WriteLine("File not find");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file");
            }
            return null;
        }
        public double SolveDiscriminant(SquareEquation squareEquation)
        {
            return Math.Pow(squareEquation.b, 2) - 4 * squareEquation.a * squareEquation.c;
        }

        public double[] SearchRoot(SquareEquation squareEquation,double D)
        {
            double x1 = (-squareEquation.b + Math.Sqrt(D)) / (2 * squareEquation.a);
            double x2 = (-squareEquation.b - Math.Sqrt(D)) / (2 * squareEquation.a);
            double[] Root = { x1, x2 };
            return Root;
        }

        public double SearchRoot(SquareEquation squareEquation)
        {
            double x = -squareEquation.b /(2 * squareEquation.a);
            double Root = x ;
            return Root;
        }
    }
}
