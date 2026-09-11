using System;
using GarenaMSDK;

namespace COW;

public class RegFormObserverBR : RegFormCallback.IRegFormObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__9_1;

		internal void _003CGarenaMSDK_002ERegFormCallback_002EIRegFormObserver_002EOnCompleted_003Eb__9_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public RegFormCallback.Result ret;

		public RegFormObserverBR _003C_003E4__this;

		internal void _003CGarenaMSDK_002ERegFormCallback_002EIRegFormObserver_002EOnCompleted_003Eb__0()
		{
		}
	}

	private bool m_IsBeforeLogin;

	private bool _Shown;

	private bool m_PlayerRefresh;

	private bool m_IsOnlyGetVerificationInfo;

	private bool m_IsSkipped;

	private bool m_ReAuth;

	public RegFormObserverBR(bool isBeforeLogin, bool playerRefresh, bool isOnlyGetVerificationInfo = false, bool reauth = false)
	{
	}

	public void UpdateParams(bool isBeforeLogin, bool playerRefresh, bool isOnlyGetVerificationInfo = false, bool reauth = false)
	{
	}

	void RegFormCallback.IRegFormObserver.OnClosed(int closeType)
	{
	}

	void RegFormCallback.IRegFormObserver.OnCompleted(RegFormCallback.Result ret)
	{
	}

	void RegFormCallback.IRegFormObserver.OnShown()
	{
	}

	public void OnGetUserVerificationInfo(RegFormCallback.VerificationInfo info)
	{
	}
}
