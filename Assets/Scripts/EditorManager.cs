using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Contains Text editor states.</summary>
public class EditorManager : MonoBehaviour
{
    private ITextObject textObj;
    private string? selectionString;
    private GameObject? selectionInstance;

    void Start() {
	textObj = new TOWord();
    }

    /// <summary>Apply currently active text object to given buffer
    /// and return retrived string</summary>
    public string? ApplyTextObject(IBuffer buf, int point) {
	if (textObj.findBeginning(buf, point) is int beg
	    && textObj.findEnd(buf, point) is int end) {
	    selectionString = buf.Substring(beg, end);
	    return selectionString;
	}
	selectionString = null;
	return selectionString;
    }
}
