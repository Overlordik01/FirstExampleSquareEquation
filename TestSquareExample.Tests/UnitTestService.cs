using System;
using System.Collections.Generic;
using TestSquareExample.Main;
using Xunit;

namespace TestSquareExample.Tests
{
    public class UnitTestService
    {

        [Fact]
        public void UnitTestSquareEquationService()
        {
            string path = @"C:\Users\overl\source\repos\TestSquareExample\TestSquareExample\SquareEquationContent.txt";
            SquareEquationService SquareEquationService = new SquareEquationService();

            List<SquareEquation> SquareEquation = SquareEquationService.CreateConnectionFile(path);

            Assert.NotEmpty(SquareEquation);
        }

        [Fact]
        public void UnitTestSolveDiscriminant()
        {
            SquareEquationService SquareEquationService = new SquareEquationService();

            double D = SquareEquationService.SolveDiscriminant(new SquareEquation { a = 1, b = 4, c = 1 });

            Assert.Equal(D, 12.0);
        }

        [Fact]
        public void UnitTestSearchRootTwo()
        {
            SquareEquationService SquareEquationService = new SquareEquationService();

            double[] Root = SquareEquationService.SearchRoot(new SquareEquation { a = 1, b = 4, c = 1 },12.0);
            double[] RootTest = { -0.2679491924311228, -3.732050807568877 };

            Assert.Equal(Root, RootTest);
        }
        [Fact]
        public void UnitTestSearchRootOne()
        {
            SquareEquationService SquareEquationService = new SquareEquationService();

            double Root = SquareEquationService.SearchRoot(new SquareEquation { a = 1, b = 2, c = 1 });
            double RootTest = -1.0;

            Assert.Equal(Root, RootTest);
        }
    }
}
