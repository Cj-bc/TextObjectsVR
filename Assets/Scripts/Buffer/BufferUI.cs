using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>Visualize Buffer</summary>
[RequireComponent(typeof(TextMeshProUGUI))]
public class BufferUI : MonoBehaviour
{

    private IBuffer buf;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
	text = GetComponent<TextMeshProUGUI>();
	buf = new SimpleBuffer("Hi! This is just a test text\nwith some <i>rich texts</i>");
	Redraw();
    }

    /// Redraws Buffer UI
    void Redraw()
    {
        text.text = buf.Contents();
    }
}
