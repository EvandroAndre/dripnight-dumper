using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class InflaterHuffmanTree
{
	private const int MAX_BITLEN = 15;

	private short[] tree;

	public static InflaterHuffmanTree defLitLenTree;

	public static InflaterHuffmanTree defDistTree;

	private static Dictionary<int, short[]> m_HuffmanTreeCache;

	private int[] m_blCount;

	private int[] m_nextCode;

	static InflaterHuffmanTree()
	{
	}

	public InflaterHuffmanTree(byte[] codeLengths, int index = -1)
	{
	}

	public InflaterHuffmanTree(byte[] codeLengths, int codeStartIndex, int codeEndIndex, int index)
	{
	}

	public void BuildTree(byte[] codeLengths, int codeStartIndex, int codeEndIndex, int index, bool use_same_meme = false)
	{
	}

	public void BuildTree(byte[] codeLengths, int index, bool use_same_mem = false)
	{
	}

	public int GetSymbol(StreamManipulator input)
	{
		return 0;
	}
}
