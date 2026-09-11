using System;
using System.Collections.Generic;
using UnityEngine;

namespace GarenaMSDK;

public class RegFormCallback
{
	[Serializable]
	public class Result
	{
		public static readonly Result SKIP;

		public int errorCode;

		public string errorMsg;

		public bool required;

		public int gameMinAge;

		public int govMinAge;

		public bool skippable;

		public bool skipped;

		public bool identified;

		public bool wasFormDisplayed;

		public VerificationStatus verificationStatus;

		public string ageGroup;

		public VerifySource verifySource;

		public string[] verifyOrder;
	}

	[Serializable]
	public class VerificationInfo
	{
		public ErrorCode flag;

		public VerificationStatus verificationStatus;

		public string ageGroup;

		public VerifySource verifySource;
	}

	public interface IRegFormObserver
	{
		void OnCompleted(Result ret);

		void OnShown();

		void OnClosed(int closeType);

		void OnGetUserVerificationInfo(VerificationInfo info);
	}

	public static class CloseType
	{
		public const int Unknown = -1;

		public const int WebViewExit = 0;

		public const int SystemBack = 1;

		public static string ToString(int closeType)
		{
			return null;
		}
	}

	private class Impl_Android : RegFormCallback
	{
		private class Callback : AndroidJavaProxy, IRegFormCallback
		{
			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public string regFormRetJson;

				public Callback _003C_003E4__this;

				internal void _003ConRegFormCompleted_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass8_0
			{
				public string retJson;

				public Callback _003C_003E4__this;

				internal void _003ConGetUserVerificationInfo_003Eb__0()
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

			public void onRegFormCompleted(string regFormRetJson)
			{
			}

			public void onRegFormShown()
			{
			}

			public void onRegFormClosed(int closeType)
			{
			}

			public void onGetUserVerificationInfo(string retJson)
			{
			}
		}
	}

	private static RegFormCallback _I;

	private HashSet<IRegFormObserver> _RegFormObservers;

	public static RegFormCallback I => null;

	public void Observe(IRegFormObserver observer)
	{
	}

	public void Unobserve(IRegFormObserver observer)
	{
	}

	private void _NotifyGetUserVerificationInfo(VerificationInfo info)
	{
	}

	private void _NotifyCompleted(Result ret)
	{
	}

	private void _NotifyShown()
	{
	}

	private void _NotifyClosed(int type)
	{
	}
}
