namespace GCommon;

public struct PackedStringsSettings(byte suffixBits, byte suffixAlign = 1, byte strLenBytes = 1)
{
	public byte SuffixBits = 0;

	public byte SuffixAlign = 0;

	public byte StrLenBytes = 0;

	public uint PrefixMask = 0u;

	public uint SuffixMask = 0u;

	public int MaxPrefixIndex = 0;

	public int MaxSuffixOffset = 0;

	public int MaxSuffixLength = 0;

	public int MaxPrefixLength = 0;

	public static readonly PackedStringsSettings Default;
}
