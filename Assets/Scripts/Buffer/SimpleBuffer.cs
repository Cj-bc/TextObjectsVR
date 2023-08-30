using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Stores text as is. Not sufficient.
public class SimpleBuffer : IBuffer
{
    private string content;

    public SimpleBuffer(string initial) {
	content = initial;
    }

    public string Contents() {
	return content;
    }
}
