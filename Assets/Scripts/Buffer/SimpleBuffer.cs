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

    public bool Insert(int pos, string str) {
	if (pos < 0 || raw.Length <= pos) {
	    return false;
	}

	raw = raw.Insert(pos, str);
	return true;
    }
}
