using System;
using UnityEngine;

namespace GarenaMSDK;

public static class SDKShare_Android
{
	[Serializable]
	public class PluginResult
	{
		public int status;

		public string message;

		public string source;

		public int flag;
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string pluginResultString;

		internal void _003CShareVideoToTikTokCallback_003Eb__0()
		{
		}
	}

	private static AndroidJavaClass _Share;

	private static AndroidJavaClass Share => null;

	public static void SendGameToSession(int scene, string title, string description, string mediaTag, string caption, string url, string imagePath, int compressRate)
	{
	}

	public static void SendMediaToSession(int scene, string mediaTag, string messageExt, string imagePath)
	{
	}

	public static void SendLinkToSession(int scene, string mediaTag, string url, string title, string caption, string description, string mediaUrl)
	{
	}

	public static void ShareToFacebook(int scene, string name, string caption, string description, string link, string imagePath, int compressRate, string mediaUrl)
	{
	}

	public static void SendLinkToFacebook(string name, string caption, string description, string link, string mediaUrl)
	{
	}

	public static void SendRequestInvitationToFacebook(string title, string message)
	{
	}

	public static void SendGameRequestToFacebookUser(long fbUid, string title, string message, string data)
	{
	}

	public static void ShareToVKontakte(string message, string url, string imagePath, int compressRate)
	{
	}

	public static void ShareVideoToTikTok(string file)
	{
	}

	internal static void SendGameRequestToFacebookUserCallback(string pluginResultString)
	{
	}

	internal static void ShareVideoToTikTokCallback(string pluginResultString)
	{
	}
}
