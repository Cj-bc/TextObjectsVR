using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
using UnityEngine.EventSystems;

/// <summary>Visualize Buffer</summary>
[RequireComponent(typeof(TextMeshProUGUI))]
public class BufferUI : MonoBehaviour
{

    private IBuffer buf;
    private TextMeshProUGUI text;

    [SerializeField] private string stringOnEmpty;

    // Start is called before the first frame update
    void Start()
    {
	text = GetComponent<TextMeshProUGUI>();
	buf = new SimpleBuffer(stringOnEmpty);

	Redraw();
    }

    /// Redraws Buffer UI
    void Redraw()
    {
        text.text = buf.Contents();
    }

    public void pointerClick(BaseEventData d) {
	var pointerEv = d as PointerEventData;
	if (pointerEv == null) {
	    Debug.Log("Expected pointer click event, but failed to convert.");
	    return;
	}

	// intersecting point in <c>Camera.main</c> screen space
	var intersectPointInScreenSpace = Camera.main.WorldToScreenPoint(pointerEv.pointerPressRaycast.worldPosition);
	var idx = TMP_TextUtilities.FindIntersectingCharacter(text, intersectPointInScreenSpace, Camera.main, false);
	if (idx != -1) {
	    Debug.Log($"Intersected at {idx}, which is {text.text[idx]}");

	    // find word
	    var word = new Word();
	    var beg = word.findBeginning(buf, idx);
	    var end = word.findEnd(buf, idx);

	    if (beg != null && end != null) {
		Debug.Log($"Selected word: {buf.Contents().Substring(beg ?? 0,(end ?? 0)-(beg ?? 0))}");
	    }
	}
    }
}
