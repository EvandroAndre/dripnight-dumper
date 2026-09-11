using System;
using UnityEngine;

namespace GarenaMSDK;

public class SDKSocialMediaProfile
{
	public static class Platform
	{
		public const int None = 0;

		public const int Facebook = 3;

		public const int VKontakte = 5;

		public const int TikTok = 15;

		public const int Youtube = 16;
	}

	public class SocialMediaProfileData
	{
		public string Name;

		public string PlatformUID;

		public int Platform;

		public string Icon;

		public string WebUrl;

		public string Deeplink;

		public long UpdateTime;

		public bool IsTokenValid;
	}

	public class ProfileInfoResult
	{
		public int ErrorCode;

		public string ErrorMsg;

		public int[] AvailablePlatformsToLink;

		public SocialMediaProfileData[] Profiles;
	}

	public class UnlinkResult
	{
		public int ErrorCode;

		public string ErrorMsg;

		public int Platform;
	}

	public class OpenProfileResult
	{
		public int ErrorCode;

		public string ErrorMsg;

		public bool Success;
	}

	public class LinkResult
	{
		public int ErrorCode;

		public string ErrorMsg;

		public SocialMediaProfileData Profile;
	}

	private class Impl_Android : SDKSocialMediaProfile
	{
		[Serializable]
		private class AndroidSocialMediaProfileData
		{
			public string name;

			public string platformUID;

			public int platform;

			public string icon;

			public string webUrl;

			public string deeplink;

			public long updateTime;

			public bool isTokenValid;
		}

		[Serializable]
		private class AndroidProfileInfoResult
		{
			public int errorCode;

			public string errorMsg;

			public int[] availablePlatformsToLink;

			public AndroidSocialMediaProfileData[] profiles;
		}

		[Serializable]
		private class AndroidUnlinkResult
		{
			public int errorCode;

			public string errorMsg;

			public int platform;
		}

		[Serializable]
		private class AndroidOpenProfileResult
		{
			public int errorCode;

			public string errorMsg;

			public bool success;
		}

		[Serializable]
		private class AndroidLinkResult
		{
			public int errorCode;

			public string errorMsg;

			public AndroidSocialMediaProfileData profile;
		}

		private class Callback : AndroidJavaProxy
		{
			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public string profileInfoJson;

				public Callback _003C_003E4__this;

				internal void _003ConGetProfileInfo_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass6_0
			{
				public string unlinkResultJson;

				public Callback _003C_003E4__this;

				internal void _003ConUnlink_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass7_0
			{
				public string openResultJson;

				public Callback _003C_003E4__this;

				internal void _003ConOpenProfile_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass8_0
			{
				public string linkResultJson;

				public Callback _003C_003E4__this;

				internal void _003ConLink_003Eb__0()
				{
				}
			}

			private static Callback _I;

			public Impl_Android Impl;

			public static Callback I => null;

			private Callback()
				: base((string)null)
			{
			}

			public void onGetProfileInfo(string profileInfoJson)
			{
			}

			public void onUnlink(string unlinkResultJson)
			{
			}

			public void onOpenProfile(string openResultJson)
			{
			}

			public void onLink(string linkResultJson)
			{
			}
		}

		private Action<ProfileInfoResult> _getProfileInfoCallback;

		private Action<UnlinkResult> _unlinkCallback;

		private Action<OpenProfileResult> _openProfileCallback;

		private Action<LinkResult> _linkCallback;

		private AndroidJavaObject _JavaObj;

		private AndroidJavaObject JavaObj => null;

		private static SocialMediaProfileData ConvertProfile(AndroidSocialMediaProfileData androidProfile)
		{
			return null;
		}

		public override void GetProfileInfo(bool refresh, Action<ProfileInfoResult> callback)
		{
		}

		public override void Unlink(int platform, Action<UnlinkResult> callback)
		{
		}

		public override void OpenProfile(int platform, Action<OpenProfileResult> callback)
		{
		}

		public override void Link(int platform, Action<LinkResult> callback)
		{
		}

		public void _003C_003EiFixBaseProxy_GetProfileInfo(bool P0, Action<ProfileInfoResult> P1)
		{
		}

		public void _003C_003EiFixBaseProxy_Unlink(int P0, Action<UnlinkResult> P1)
		{
		}

		public void _003C_003EiFixBaseProxy_OpenProfile(int P0, Action<OpenProfileResult> P1)
		{
		}

		public void _003C_003EiFixBaseProxy_Link(int P0, Action<LinkResult> P1)
		{
		}
	}

	private static SDKSocialMediaProfile _I;

	public static SDKSocialMediaProfile I => null;

	protected SDKSocialMediaProfile()
	{
	}

	public virtual void GetProfileInfo(bool refresh, Action<ProfileInfoResult> callback)
	{
	}

	public virtual void Unlink(int platform, Action<UnlinkResult> callback)
	{
	}

	public virtual void OpenProfile(int platform, Action<OpenProfileResult> callback)
	{
	}

	public virtual void Link(int platform, Action<LinkResult> callback)
	{
	}
}
