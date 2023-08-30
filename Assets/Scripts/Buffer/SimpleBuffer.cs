using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Stores text as is. Not sufficient.
public class SimpleBuffer : IBuffer
{
    private string raw;

    public SimpleBuffer(string initial) {
	raw = initial;
    }

    public string Contents() {
	return raw;
    }
}
