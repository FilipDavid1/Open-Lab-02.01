using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] listOfarraysDoubles = new[] {1.9, 2.5, 3.1, 8.2, 17.22};
            return listOfarraysDoubles;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}