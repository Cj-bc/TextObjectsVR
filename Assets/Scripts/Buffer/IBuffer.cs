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

    /// <summary>Find Character forward by <paramref name="pred" /> and
    /// return its point when found, null otherwise.
    /// </summary>
    /// <param name="pred">A predicate function to determine which
    /// char to find</param>
    /// <param name="startIdx">buffer position to start search</param>
    /// <param name="limit">a buffer position that bounds the
    /// search. This is term from emacs's re-search-forward.</param>
    public int? FindCharForward(Func<char, bool> pred, int startIdx, int limit);
    /// return its point when found, null otherwise.
    /// both end are inclusive.
    /// </summary>
}
