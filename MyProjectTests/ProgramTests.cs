using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AreaRightTriangle_NormalTwo()
        {
            // Arrange
            double a = 3.0;
            double b = 4.0;
            double expectedArea = 6.0;

            // Act
            double actualArea = Program.AreaRightTriangle(a, b);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod()]
        public void AreaRightTriangle_NegativeTwo()
        {
            // Arrange
            double a = 3.0;
            double b = -4.0;
            double expectedArea = 0;

            // Act
            double actualArea = Program.AreaRightTriangle(a, b);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod()]
        public void AreaRightTriangle_NormalThree()
        {
            // Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expectedArea = 6.0;

            // Act
            double actualArea = Program.AreaRightTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod()]
        public void AreaRightTriangle_NotExist()
        {
            // Arrange
            double a = 1.0;
            double b = 2.0;
            double c = 5.0;
            double expectedArea = 0.0;

            // Act
            double actualArea = Program.AreaRightTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod()]
        public void AreaRightTriangle_NegativeThree()
        {
            // Arrange
            double a = 3.0;
            double b = 4.0;
            double c = -5.0;
            double expectedArea = 0.0;

            // Act
            double actualArea = Program.AreaRightTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod()]
        public void AreaTriangle_Normal()
        {
            // Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expectedArea = 6.0;

            // Act
            double actualArea = Program.AreaTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod()]
        public void AreaTriangle_NotExist()
        {
            // Arrange
            double a = 2.0;
            double b = 1.0;
            double c = 5.0;
            double expectedArea = 0.0;

            // Act
            double actualArea = Program.AreaTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod()]
        public void AreaTriangle_Negative()
        {
            // Arrange
            double a = 2.0;
            double b = 1.0;
            double c = -5.0;
            double expectedArea = 0.0;

            // Act
            double actualArea = Program.AreaTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}