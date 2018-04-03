using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalProcessor
{
    class DataStream
    {
        /*
            Creates a DataStream that can be used to stream data from a file specified
            by the filePath parameter.
        */
        DataStream(String filePath) {}
        /*
            Returns the specified amount of samples from the file specified by the
            filePath, and advances the reader by that same amount.
        */
        public RawDataContainer GetNextSnippet(uint samples) { return null; }
    }
}