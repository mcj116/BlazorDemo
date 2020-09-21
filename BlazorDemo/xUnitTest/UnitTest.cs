using BlazorDemo.Pages;
using Xunit;

namespace xUnitTest
{
    public class CalculatorTest
    {

        [Theory]
        [InlineData("14", "2", "16")]
        [InlineData("1", "2", "3")]
        [InlineData("-4", "-6", "-10")]
        public void CalculatorAdd(string num1, string num2, string finalresult)
        {
            var calculator = new Calculator
            {
                num1 = num1,
                num2 = num2
            };
            calculator.AddNumbers();

            Assert.Equal(finalresult, calculator.finalresult);
        }

        [Theory]
        [InlineData("14", "2", "12")]
        [InlineData("1", "2", "-1")]
        [InlineData("-4", "-6", "2")]
        public void CalculatorSub(string num1, string num2, string finalresult)
        {
            var calculator = new Calculator
            {
                num1 = num1,
                num2 = num2
            };
            calculator.SubtractNumbers();

            Assert.Equal(finalresult, calculator.finalresult);
        }

        [Theory]
        [InlineData("14", "2", "7")]
        [InlineData("1", "2", "0,5")]
        [InlineData("-4", "-2", "2")]
        public void CalculatorDiv(string num1, string num2, string finalresult)
        {
            var calculator = new Calculator
            {
                num1 = num1,
                num2 = num2
            };
            calculator.DivideNumbers();

            Assert.Equal(finalresult, calculator.finalresult);
        }

        [Theory]
        [InlineData("14", "2", "28")]
        [InlineData("1", "2", "2")]
        [InlineData("-4", "-2", "8")]
        public void CalculatorMul(string num1, string num2, string finalresult)
        {
            var calculator = new Calculator
            {
                num1 = num1,
                num2 = num2
            };
            calculator.MultiplyNumbers();

            Assert.Equal(finalresult, calculator.finalresult);
        }
        [Theory]
        [InlineData("14", "2", "14")]
        [InlineData("1", "2", "2")]
        [InlineData("-4", "-2", "-2")]
        public void CalculatorMax(string num1, string num2, string finalresult)
        {
            var calculator = new Calculator
            {
                num1 = num1,
                num2 = num2
            };
            calculator.MaxNumbers();

            Assert.Equal(finalresult, calculator.finalresult);
        }
        [Theory]
        [InlineData("14", "2", "196")]
        [InlineData("1", "2", "1")]
        [InlineData("-4", "-2", "0,0625")]
        public void CalculatorPow(string num1, string num2, string finalresult)
        {
            var calculator = new Calculator
            {
                num1 = num1,
                num2 = num2
            };
            calculator.PowerNumbers();

            Assert.Equal(finalresult, calculator.finalresult);
        }
    }
}
