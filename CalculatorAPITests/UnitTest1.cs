using MyApp.Namespace;
using Xunit;
using CalculatorLibrary;

namespace CalculatorAPITests;
// using CalculatorAPI.Controllers;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class CalculatorControllerTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Add(3, 5);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Add_WithNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Add(-3, -5);

            // Assert
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void Add_WithZero_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Add(0, 7);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Add_WithDecimalNumbers_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Add(2.5m, 4.5m);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Add_WithLargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Add(1000000000, 2000000000);

            // Assert
            Assert.AreEqual(3000000000, result);
        }
    }
     [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Subtract(8, 3);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_WithNegativeResult_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Subtract(5, 8);

            // Assert
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void Subtract_FromZero_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Subtract(0, 7);

            // Assert
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void Subtract_WithDecimalNumbers_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Subtract(7.5m, 4.5m);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Subtract_WithLargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            decimal result = controller.Subtract(3000000000, 2000000000);

            // Assert
            Assert.AreEqual(1000000000, result);
        }
    

