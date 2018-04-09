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
    /// </summar
    public class RawDataContainer<T>
    {
        protected T[] dataArray;

        /// <summary>
        /// Returns the capacity of this container.
        /// </summary>
        public double Length
        {
            get { return dataArray.Length; }
        }

        /// <summary>
        /// Constructs a new RawDataContainer.
        /// </summary>
        /// <param name="capacity">Describes how many samples this container will hold.</param>
        public RawDataContainer(uint capacity)
        {
            dataArray = new T[capacity];
        }

        /// <summary>
        /// Sets a value at a specific index.
        /// </summary>
        /// <param name="index">Index at which you'd like to set a new value.</param>
        /// <param name="value">A value that you want to set.</param>
        public void SetSample(uint index, T value)
        {
            if (index < 0u || index >= (uint) dataArray.Length)
                return;
            dataArray[index] = value;
        }

        /// <summary>
        /// Returns
        /// </summary>
        /// <param name="index">The index of the desired sample.</param>
        /// <returns>The sampled value at the specified index.</returns>
        public T GetSample(uint index)
        {
            if (index < 0u || index >= (uint) dataArray.Length)
                return default(T);
            return dataArray[index];
        }
    }
}
