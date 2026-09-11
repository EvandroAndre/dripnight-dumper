using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public static class OpenUrl
{
	private delegate string ReplaceDelegate(string url);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal string _003C_002Ecctor_003Eb__10_0(string url)
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__10_1(string url)
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__10_2(string url)
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__10_3(string url)
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__10_4(string url)
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__10_5(string url)
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__10_6(string url)
		{
			return null;
		}
	}

	private const string PLACEHOLDER_FORMAT = "<{0}>";

	private static readonly Dictionary<string, ReplaceDelegate> Replacements;

	private static readonly AES.AESOption aesOption;

	public static string GetEncryptedToken()
	{
		return null;
	}

	public static string Get(string key)
	{
		return null;
	}

	public static void Open(string url)
	{
	}

	private static string FilterUrlQuery(string url)
	{
		return null;
	}

	private static IEnumerable<string> GetWhitelistDomainsForReplacement(string replacement)
	{
		return null;
	}

	public static string Modify(string url)
	{
		return null;
	}
}
