using System;

namespace GarenaMSDK;

public static class SDKShare
{
	public enum ShareScene
	{
		Chat,
		Buzz
	}

	public static int WorkaroundForSendingLinkToVKontakte;

	public static int WorkaroundForSendingImageToVKontakte;

	internal static Action<int, string, long> _SendGameRequestToFacebookUserCallback;

	internal static long _CallBackFBUid;

	internal static Action<int, string> _ShareVideoToTikTokCallback;

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

	public static void SendLinkToVKontakte(string message, string url)
	{
	}

	public static void ShareToVKontakte(string message, string url, string imagePath, int compressRate)
	{
	}

	public static void ShareVideoToTikTok(string file, Action<int, string> callback)
	{
	}
}
