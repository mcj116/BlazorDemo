using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Pages
{
    public partial class Calculator
    {
        public string num1;
        public string num2;
        public string finalresult;
        public void AddNumbers()
        {
            finalresult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
        }
        public void SubtractNumbers()
        {
            finalresult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
        }
        public void MultiplyNumbers()
        {
            finalresult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
        }
        public void DivideNumbers()
        {
            if (Convert.ToDouble(num2) != 0)
            {
                finalresult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
            }
            else
            {
                finalresult = "Cannot Divide by Zero";
            }
        }
        public void MaxNumbers()
        {
            finalresult = Math.Max(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
        }
        public void PowerNumbers()
        {
            finalresult = Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
        }
    }
}
