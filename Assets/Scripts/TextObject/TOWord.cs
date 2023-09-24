public struct Word : ITextObject {

    public int? findBeginning(IBuffer buf, int point) {
	var str = buf.Contents();
	str.IndexOf(" ", point);

	return 0;
    }

    public int? findEnd(IBuffer buf, int point) {
	var str = buf.Contents();

	/// TODO: Use Char.IsSeparator or something to identify all other separators
	/// <ref>https://learn.microsoft.com/en-us/dotnet/api/system.char.isseparator?view=net-7.0</ref>
	var idx = str.IndexOf(" ", point);

	return idx == -1 ? null : idx;
    }
}
