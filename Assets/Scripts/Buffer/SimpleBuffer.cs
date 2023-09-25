using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Stores text as is. Not sufficient.
public class SimpleBuffer : IBuffer
{
    private string raw;

    public int endPoint => raw.Length - 1;

    public SimpleBuffer(string initial) {
	raw = initial;
    }

    public string Contents() {
	return raw;
    }

    public string Substring(int beg, int end) {
	return raw.Substring(beg, end - beg);
    }

    public int? FindCharForward(char c) {
	return FindCharForward((nc) => nc == c, 0, raw.Length - 1);
    }

    public int? FindCharForward(Func<char, bool> pred) {
	return FindCharForward(pred, 0, raw.Length - 1);
    }

    public int? FindCharForward(Func<char, bool> pred, int startIdx) {
	return FindCharForward(pred, startIdx, raw.Length - 1);
    }

    public int? FindCharForward(Func<char, bool> pred, int startIdx, int limit) {
	for (int i = startIdx; i <= limit; i++) {
	    if (pred(raw[i])) {
		return i;
	    }
	}

	return null;
    }

    public int? FindCharBackward(Func<char, bool> pred, int startIdx, int limit) {
	for (int i = startIdx; limit <= i; i--) {
	    if (pred(raw[i])) {
		return i;
	    }
	}
	return null;
    }

    public bool Insert(int pos, string str) {
	if (pos < 0 || raw.Length <= pos) {
	    return false;
	}

	raw = raw.Insert(pos, str);
	return true;
    }
}
