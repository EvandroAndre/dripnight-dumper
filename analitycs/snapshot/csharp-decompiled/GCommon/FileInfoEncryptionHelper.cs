namespace GCommon;

public static class FileInfoEncryptionHelper
{
	public const string ENCRYPTION_SALT = "FF_FileInfo_Salt";

	public const string PREF_KEY_LAST_ENCRYPTION_STATE = "FileInfoEncryption_LastState";

	private const int GGP_KEY_LENGTH = 32;

	public const int GGP_WRITE_SUCCESS = 1;

	private const uint GGP_MAGIC_VALUE = 2708929427u;

	public const string PREF_KEY_GGP_DECRYPT_FAILURE = "FileInfoEncryption_GGPDecryptFailed";

	private static long s_GGPDecryptFailedMask;

	private const string PREF_KEY_FILEINFO_ENCRYPTED_MASK = "FileInfoEncryption_EncryptedMask";

	private static long s_FileInfoEncryptedMask;

	private static string s_CachedGGPKey;

	private static readonly char[] s_HexChars;

	private const int FILEINFO_MIN_FIELDS = 7;

	public static bool IsFileInfoEncryptionEnabled()
	{
		return false;
	}

	public static bool IsGGPDecryptionFailed(uint downloadType)
	{
		return false;
	}

	public static void InitGGPDecryptionState(bool encryptionEnabled)
	{
	}

	public static void ClearGGPDecryptionState()
	{
	}

	public static void MarkGGPDecryptionFailed(uint downloadType)
	{
	}

	public static void InitFileInfoEncryptedState()
	{
	}

	public static void MarkFileInfoEncrypted(uint downloadType)
	{
	}

	public static void ClearFileInfoEncrypted(uint downloadType)
	{
	}

	public static bool WasFileInfoEncrypted(uint downloadType)
	{
		return false;
	}

	private static string GetGGPKey()
	{
		return null;
	}

	private static string ComputeMD5Hash(string input)
	{
		return null;
	}

	public static void ClearCachedKey()
	{
	}

	public static bool ValidateFileInfoContent(string content)
	{
		return false;
	}

	public static int WriteEncryptedFile(string targetFile, string content)
	{
		return 0;
	}

	public static string ReadDecryptedFile(string targetFile, out bool wasEncrypted, out DecryptResultCode resultCode)
	{
		wasEncrypted = default(bool);
		resultCode = default(DecryptResultCode);
		return null;
	}

	public static bool HasGGPEncryptionMagic(string targetFile)
	{
		return false;
	}
}
