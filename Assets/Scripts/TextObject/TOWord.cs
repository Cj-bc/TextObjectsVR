using System;

public struct TOWord : ITextObject {
    public int? findBeginning(IBuffer buf, int point) {
	return buf.FindCharBackward(Char.IsWhiteSpace, point) ?? 0;
    }

    public int? findEnd(IBuffer buf, int point) {
	if (buf.FindCharForward(Char.IsWhiteSpace, point) is int wsp) {
	    // wsp is buffer point of 'next whitespace'. Therefore, word boundary is -1.
	    return wsp - 1;
	}
	return buf.endPoint;
    }
}
