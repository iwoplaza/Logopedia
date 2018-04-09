namespace SignalProcessor.IO
{
    /// <summary>
    /// An interface for objects used to stream raw data.
    /// by the filePath parameter.
    /// </summary>
    interface IRawDataStream<TData>
    {
        /// <summary>
        /// Returns the specified amount of samples from the file specified by the
        /// filePath, and advances the reader by that same amount.
        /// </summary>
        /// <param name="samples">The minimum amount of samples this function should retrieve.</param>
        /// <returns>The data retrieved as a RawDataContainer</returns>
        RawDataContainer<TData> GetNextSnippet(uint samples);
    }
}