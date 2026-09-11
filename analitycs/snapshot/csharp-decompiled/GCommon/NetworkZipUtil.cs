using ICSharpCode.SharpZipLib.GZip;

namespace GCommon;

internal static class NetworkZipUtil
{
	public static void ZipXORHeader(byte[] data, int dataLen, byte[] secretKey)
	{
	}

	public static long Unzip(GZipInputStream gzipStream, byte[] data, int dataLen, byte[] secretKey, byte[] outputData, byte[] tmpBuffer)
	{
		return 0L;
	}
}
