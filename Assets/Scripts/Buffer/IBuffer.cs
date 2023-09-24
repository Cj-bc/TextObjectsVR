/// <summary>
/// Interface for Text Buffers. Text Buffers are used to hold actual texts with different algorythms.
/// </summary>
public interface IBuffer
{
    /// <summary>End of buffer point</summary>
    public int endPoint {get; }

    /// <summary> Returns full text in buffer with rich text markup</summary>
    public string Contents(); 
}
