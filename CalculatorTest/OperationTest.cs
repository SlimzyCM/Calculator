using System;
using CalculatorLibrary.FuncModel.Controller;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class OperationTest
    {

        [Test]
        public void Addition()
        {
           //Arrange
            const string calculateValue = "5";
            const string operation = "+";
            const string formDisplayValue = "7";
            const string secondFormDisplayValue = "3";


            var addition = new GetResult();
            const string expected = "12";
            const string expectedSecond = "15";
            
            //Act
            var actual = addition.Calculate(calculateValue, formDisplayValue, operation);
            var actualSecond = addition.Calculate(actual, secondFormDisplayValue, operation);


            //Assert
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(expectedSecond, Is.EqualTo(actualSecond));


        }



        [Test]
        public void Subtraction()
        {
            //Arrange
            const string calculateValue = "15";
            const string operation = "-";
            const string formDisplayValue = "7";
            const string secondFormDisplayValue = "3";


            var subtract = new GetResult();
            const string expected = "8";
            const string expectedSecond = "5";

            //Act
            var actual = subtract.Calculate(calculateValue, formDisplayValue, operation);
            var actualSecond = subtract.Calculate(actual, secondFormDisplayValue, operation);


            //Assert
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(expectedSecond, Is.EqualTo(actualSecond));


        }

        [Test]
        public void Multiplication()
        {
            //Arrange
            const string calculateValue = "5";
            const string operation = "*";
            const string formDisplayValue = "7";
            const string secondFormDisplayValue = "10";


            var multiply = new GetResult();
            const string expected = "35";
            const string expectedSecond = "350";

            //Act
            var actual = multiply.Calculate(calculateValue, formDisplayValue, operation);
            var actualSecond = multiply.Calculate(actual, secondFormDisplayValue, operation);


            //Assert
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(expectedSecond, Is.EqualTo(actualSecond));


        }


        [Test]
        public void Division()
        {
            //Arrange
            const string calculateValue = "150";
            const string operation = "÷";
            const string formDisplayValue = "10";
            const string secondFormDisplayValue = "3";


            var divide = new GetResult();
            const string expected = "15";
            const string expectedSecond = "5";

            //Act
            var actual = divide.Calculate(calculateValue, formDisplayValue, operation);
            var actualSecond = divide.Calculate(actual, secondFormDisplayValue, operation);


            //Assert
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(expectedSecond, Is.EqualTo(actualSecond));


        }

        [Test]
        public void DivisionbyZero()
        {
            //Arrange
            const string calculateValue = "15";
            const string operation = "÷";
            const string formDisplayValue = "0";

            var divide = new GetResult();
            
            //Act and Assert
            Assert.Throws<DivideByZeroException>(
                () => divide.Calculate(calculateValue, formDisplayValue, operation) );
        }

        [Test]
        public void Negation()
        {
            //Arrange
            const string formDisplayValue = "10";

            var negateNum = new GetResult();
            const string expected = "-10";
            const string expectedSecond = "10";

            //Act
            var actual = negateNum.Negate(formDisplayValue);
            var actualSecond = negateNum.Negate(actual);


            //Assert
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(expectedSecond, Is.EqualTo(actualSecond));


        }

    }
}
