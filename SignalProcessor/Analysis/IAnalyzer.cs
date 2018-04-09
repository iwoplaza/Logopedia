using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalProcessor.Analysis
{
        /// <summary>
        /// An interface for every data analytic methods.
        /// </summary>
        interface IAnalyzer
        {
            /// <summary>
            /// Analyzes data using the specified request parameters.
            /// </summary>
            /// <param name="request_">The request.</param>
            /// <returns>Analyzed data.</returns>
            IAnalyzedData Analyze(IRequest request_);
        }
}
