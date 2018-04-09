using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalProcessor.IO
{
    /// <summary>
    /// Contains a portion of data not yet analized, but presented
    /// in the most simplistic way.
    /// </summary>
    class RawDataContainer
    {
        double[] array;

        RawDataContainer(uint capacity)
        {
            array = new double[capacity];
        }
    }
}
