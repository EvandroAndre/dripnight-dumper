namespace GCommon;

public static class NetworkCryptologyUtil
{
	public static byte[] TestKey;

	public static readonly int SALT_LEN;

	public static readonly int ZERO_LEN;

	private static readonly uint DELTA;

	private static readonly int ROUNDS;

	private static readonly int LOG_ROUNDS;

	public static bool TeaDecrypt(TeaDecTempBuffer decTempBuffer, byte[] pInBuf, int nInBufLen, byte[] pKey, byte[] pOutBuf, ref int pOutBufLen)
	{
		return false;
	}

	private static int rand()
	{
		return 0;
	}

	public static int TeaEncrypt_Len(int nInBufLen)
	{
		return 0;
	}

	public static void TeaEncrypt(TeaEncTempBuffer encTempBuffer, byte[] pInBuf, int nInBufLen, byte[] pKey, byte[] pOutBuf, ref int pOutBufLen)
	{
	}

	private static string bytesToString(byte[] p)
	{
		return null;
	}

	private static void TeaEncryptECB(TeaEncTempBuffer encTempBuffer, byte[] pInBuf, int inBufPos, byte[] pKey, byte[] pOutBuf, int outBufIndex)
	{
	}

	private static void TeaDecryptECB(TeaDecTempBuffer decTempBuffer, byte[] pInBuf, int inBufIndex, byte[] pKey, byte[] pOutBuf, int outBufIndex)
	{
	}

	private static void IntToBytes(int value, byte[] array, int offset)
	{
	}
}
