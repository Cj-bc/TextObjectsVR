using System;

/// <summary>
/// Interface for Text Buffers. Text Buffers are used to hold actual texts with different algorythms.
/// </summary>
public interface IBuffer
{
    /// <summary>End of buffer point</summary>
    public int endPoint {get; }

    /// <summary> Returns full text in buffer with rich text markup</summary>
    public string Contents(); 

    /// <summary>Returns text between two points <param>beg</param>
    /// and <param>end</param>.
    /// both end are inclusive.
    /// </summary>
    public string Substring(int beg, int end);

    /// <summary>Find Character forward by <param>pred</param> and
    /// return its point when found, null otherwise.
    /// both end are inclusive.
    /// </summary>
    public int? FindCharNext(Func<char, bool> pred, int startIdx, int endIdx);
}
