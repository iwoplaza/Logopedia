using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalProcessor.Analysis
{
    public class ThresholdValuesCalculator
    {
        public double Min(double[] samples)
        {
            if (samples == null || samples.Length == 0)
                throw new ArgumentException();

            return samples.Min();
        }

        public double Max(double[] samples)
        {
            if (samples == null || samples.Length == 0)
                throw new ArgumentException();

            return samples.Max();
        }
    }
}
