using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestSquareExample.Main
{
    interface ISquareEquation
    {
        List<SquareEquation> CreateConnectionFile(string path);
        double SolveDiscriminant(SquareEquation squareEquation);
        double[] SearchRoot(SquareEquation squareEquation, double discriminant);
        double SearchRoot(SquareEquation squareEquation);
    }
}
