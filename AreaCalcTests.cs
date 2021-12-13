using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaCalc;

namespace AreaCalc.Tests
{
    [TestClass]
    public class AreaCalcTests
    {
        [TestMethod]
        public void AreaTriangle_3_4_5_Area6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            String area = "Прямоугольный теругольник.  Площадь треугольника = 6";

            Area testAreaTria = new Area();
            Assert.AreEqual(area, testAreaTria.AreaFig(a, b, c));


        }
        [TestMethod]
        public void AreaTriangle_3_6_7_Area894()
        {
            double a = 3;
            double b = 6;
            double c = 7;
            String area = "Треугольник не прямоугольный.  Площадь треугольника = 8,94";

            Area testAreaTria = new Area();
            Assert.AreEqual(area, testAreaTria.AreaFig(a, b, c));


        }
        [TestMethod]
        public void AreaCircle_3_Area2826()
        {
            double r = 3;
            Area testAreaCir = new Area();

            String area = "Площадь круга = 28,26";

            Assert.AreEqual(area, testAreaCir.AreaFig(r));

        }
    }
}
