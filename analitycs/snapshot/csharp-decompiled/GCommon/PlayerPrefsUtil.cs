using System.Text;

namespace GCommon;

public static class PlayerPrefsUtil
{
	public static string UserKey;

	public const int SHOWED = 1;

	public const int UNSHOWED = 0;

	private static StringBuilder m_KeyStringBuilder;

	public static void DeleteKey(string key, bool global = false)
	{
	}

	public static bool DeleteAll()
	{
		return false;
	}

	public static float GetFloat(string key, float defaultValue = 0f, bool global = false)
	{
		return 0f;
	}

	public static int GetInt(string key, int defaultValue = 0, bool global = false)
	{
		return 0;
	}

	public static string GetString(string key, string defaultValue = null, bool global = false)
	{
		return null;
	}

	public static bool HasKey(string key, bool global = false)
	{
		return false;
	}

	public static void Save()
	{
	}

	public static void SetFloat(string key, float value, bool global = false)
	{
	}

	public static void SetInt(string key, int value, bool global = false)
	{
	}

	public static void SetGlobalAddedIntKey(string key, int startnum)
	{
	}

	public static void SetString(string key, string value, bool global = false)
	{
	}

	private static string GenKeyWithUserPrefix(string key, bool global)
	{
		return null;
	}
}
