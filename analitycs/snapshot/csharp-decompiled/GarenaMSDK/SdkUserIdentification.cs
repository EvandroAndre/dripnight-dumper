using System;
using UnityEngine;

namespace GarenaMSDK;

public class SdkUserIdentification
{
	[Serializable]
	public class VerificationInfo
	{
		public ErrorCode flag;

		public VerificationStatus verificationStatus;

		public string ageGroup;

		public VerifySource verifySource;
	}

	[Serializable]
	public class GoogleAgeRangeInfo
	{
		public GoogleAgeVerificationStatus verificationStatus;

		public int ageLower;

		public int ageUpper;
	}

	[Serializable]
	public class GoogleUserIdentificationInfo
	{
		public ErrorCode flag;

		public string errorMsg;

		public VerificationInfo userVerificationInfo;

		public GoogleAgeRangeInfo thirdPartyAgeGroup;
	}

	[Serializable]
	public class AppleUserIdentificationInfo
	{
		public ErrorCode flag;

		public string errorMsg;

		public VerificationInfo userVerificationInfo;
	}

	private class AndroidCallback : AndroidJavaProxy
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public string retJson;

			public AndroidCallback _003C_003E4__this;

			internal void _003ConRequestGoogleUserIdentification_003Eb__0()
			{
			}
		}

		private static AndroidCallback _I;

		public SdkUserIdentification Impl;

		public static AndroidCallback I => null;

		private AndroidCallback()
			: base((string)null)
		{
		}

		public void onRequestGoogleUserIdentification(string retJson)
		{
		}
	}

	private static SdkUserIdentification sInstance;

	private Action<GoogleUserIdentificationInfo> _GoogleUserIdentificationCallback;

	private Action<AppleUserIdentificationInfo> _AppleUserIdentificationCallback;

	private AndroidJavaObject javaSdkUserIdentification;

	public static SdkUserIdentification Instance => null;

	private SdkUserIdentification()
	{
	}

	public void RequestGoogleUserIdentification(string region, Action<GoogleUserIdentificationInfo> callback)
	{
	}

	public void RequestAppleUserIdentification(string region, Action<AppleUserIdentificationInfo> callback)
	{
	}

	public void SetAppleCustomAgeGates(int threshold1, int threshold2 = -1, int threshold3 = -1)
	{
	}

	private void NotifyGoogleUserIdentification(GoogleUserIdentificationInfo info)
	{
	}

	private void NotifyAppleUserIdentification(AppleUserIdentificationInfo info)
	{
	}
}
