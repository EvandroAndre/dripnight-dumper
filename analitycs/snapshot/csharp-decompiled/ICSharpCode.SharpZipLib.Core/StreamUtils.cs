using System.IO;
using ICSharpCode.SharpZipLib.GZip;

namespace ICSharpCode.SharpZipLib.Core;

public sealed class StreamUtils
{
	public static void ReadFully(Stream stream, byte[] buffer)
	{
	}

	public static void ReadFully(Stream stream, byte[] buffer, int offset, int count)
	{
	}

	public static void Copy(Stream source, Stream destination, byte[] buffer)
	{
	}

	public static void CopyFromGzipInputStream(GZipInputStream source, Stream destination, byte[] buffer, bool enable_optimize = false)
	{
	}

	private StreamUtils()
	{
	}
}
