/// Text object represents some portion of text in buffer.
/// Basic idea is came from vim's "Text Object"
public interface ITextObject
{
    /// <summary>Find and return point of beginning of this object in <param>buf</param></summary>
    public int? findBeginning(IBuffer buf, int point);

    /// <summary>Find and return point of end of this object in <param>buf</param></summary>
    public int? findEnd(IBuffer buf, int point);
}
