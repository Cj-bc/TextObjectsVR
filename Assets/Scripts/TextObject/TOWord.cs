using System;

public struct TOWord : ITextObject {
    public int? findBeginning(IBuffer buf, int point) {
	var str = buf.Contents();

	for (int i = point; i >= 0; i--) {
	    if (Char.IsWhiteSpace(str[i])) {
		return i;
	    }
	}
	return 0;
    }

    public int? findEnd(IBuffer buf, int point) {
	var str = buf.Contents();

	for (int i = point; i < str.Length; i++) {
	    if (Char.IsWhiteSpace(str[i])) {
		return i;
	    }
	}
	return str.Length - 1;
    }
}
