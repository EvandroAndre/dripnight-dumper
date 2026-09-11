using System;
using UnityEngine;

namespace GooglePlayInstant;

public static class CookieApi
{
	public class CookieApiException : Exception
	{
		public CookieApiException(string message, Exception innerException)
		{
		}

		public CookieApiException(string message)
		{
		}
	}

	private const string Authority = "com.google.android.gms.instantapps.provider.api";

	private const string ContentAuthority = "content://com.google.android.gms.instantapps.provider.api/";

	private const string KeyCookie = "cookie";

	private const string KeyResult = "result";

	private const string KeyUid = "uid";

	private const string MethodGetInstantAppCookie = "getInstantAppCookie";

	private const string MethodGetInstantAppCookieMaxSize = "getInstantAppCookieMaxSize";

	private const string MethodSetInstantAppCookie = "setInstantAppCookie";

	private static bool _verifiedContentProvider;

	public static int GetInstantAppCookieMaxSizeBytes()
	{
		return 0;
	}

	public static string GetInstantAppCookie()
	{
		return null;
	}

	public static byte[] GetInstantAppCookieBytes()
	{
		return null;
	}

	public static bool SetInstantAppCookie(string cookie)
	{
		return false;
	}

	public static bool SetInstantAppCookieBytes(byte[] cookie)
	{
		return false;
	}

	private static void VerifyContentProvider()
	{
	}

	private static AndroidJavaObject CallMethod(string methodName, AndroidJavaObject extrasBundle)
	{
		return null;
	}

	private static int ProcessGetMyUid()
	{
		return 0;
	}
}
