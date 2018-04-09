using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalProcessor.Analysis
{
    public class ArithmeticMeanCalculator
    {
        public double Calculate(double[] samples)
        {
            if (samples == null || samples.Length == 0)
                throw new ArgumentException();

            return samples.Average();
        }

    }
}
