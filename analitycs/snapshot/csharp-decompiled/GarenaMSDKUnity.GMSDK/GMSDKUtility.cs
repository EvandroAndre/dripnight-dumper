using System;
using System.Collections.Generic;

namespace GarenaMSDKUnity.GMSDK;

internal static class GMSDKUtility
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<byte, string> _003C_003E9__2_0;

		internal string _003CDigest_SHA256_003Eb__2_0(byte item)
		{
			return null;
		}
	}

	private const string PASSWORD_CHARACTERS = "0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&*()";

	public static string GeneratePassword(int length = 64)
	{
		return null;
	}

	public static string Digest_SHA256(string template)
	{
		return null;
	}

	public static string MakeUrlParameters(Dictionary<string, string> data)
	{
		return null;
	}
}
