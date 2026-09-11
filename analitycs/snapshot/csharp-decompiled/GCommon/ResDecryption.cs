using System.Security.Cryptography;

namespace GCommon;

public class ResDecryption
{
	private static SHA1CryptoServiceProvider m_SHA1;

	public static string GetFileHash(string filePath)
	{
		return null;
	}

	public static void HashBlock(SHA1CryptoServiceProvider worker, byte[] data, int offset, int size)
	{
	}

	public static string HashFinalBlock(SHA1CryptoServiceProvider worker, byte[] data, int offset)
	{
		return null;
	}

	public static string ComputeHash(SHA1CryptoServiceProvider worker, byte[] data, int offset = 0)
	{
		return null;
	}

	public static void Decryption(byte[] fileBytes, out byte[] decryptionBytes)
	{
		decryptionBytes = null;
	}

	public static ICryptoTransform CreateDecryptor(out int blockSize)
	{
		blockSize = default(int);
		return null;
	}

	public static int Decryption(ICryptoTransform decryptor, int blockSize, byte[] fileBytes, ref byte[] decryptionBytes)
	{
		return 0;
	}
}
