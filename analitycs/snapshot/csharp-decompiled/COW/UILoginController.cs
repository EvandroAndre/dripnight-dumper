using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using UnityEngine;

namespace COW;

public class UILoginController : UIBaseController, IUIModelDataChangeObserver
{
	private class RegFormObserverVN : RegFormCallback.IRegFormObserver
	{
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public RegFormObserverVN _003C_003E4__this;

			public RegFormCallback.Result ret;

			internal void _003CGarenaMSDK_002ERegFormCallback_002EIRegFormObserver_002EOnCompleted_003Eb__0()
			{
			}
		}

		private UILoginController _Ctrl;

		private bool _Shown;

		private bool _Closed;

		private bool _Completed;

		public RegFormObserverVN(UILoginController ctrl)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__63_0;

		public static Action _003C_003E9__66_0;

		public static Action _003C_003E9__98_0;

		internal void _003C_CheckMsdkRegFormVN_003Eb__63_0()
		{
		}

		internal void _003C_OnCheckedMsdkRegFormVN_003Eb__66_0()
		{
		}

		internal void _003CTestInvalideClientVersion_003Eb__98_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public UILoginController _003C_003E4__this;

		public PlatformType platformType;

		internal void _003CManualLogin_003Eb__0()
		{
		}

		internal void _003CManualLogin_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public UILoginController _003C_003E4__this;

		public string customerServiceUrl;

		internal void _003CShowAppleLoginHintPopup_003Eb__0()
		{
		}

		internal void _003CShowAppleLoginHintPopup_003Eb__1()
		{
		}

		internal void _003CShowAppleLoginHintPopup_003Eb__2()
		{
		}

		internal void _003CShowAppleLoginHintPopup_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public Action callback;

		internal void _003CCheckIfGDPRPopupNeeded_003Eb__0()
		{
		}
	}

	private sealed class _003CDelayCreateUI_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoginController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCreateUI_003Ed__27(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CSetButtonCoolDown_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public UILoginController _003C_003E4__this;

		public UIButton btn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetButtonCoolDown_003Ed__89(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CWaitPreloadFinishGotoLobby_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoginController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitPreloadFinishGotoLobby_003Ed__71(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public const string ACCOUNTREGION = "ACCOUNTREGION_{0}";

	private UILoginView m_View;

	private UIVersionController m_UIVersion;

	private bool m_platfromLogined;

	private UIPopupMessageBoxController m_MaintenanceMessageCtrl;

	private GameObject m_SpineBG;

	private ResourceID m_CurrentSpineBGResID;

	private bool m_GotoLobbyed;

	private UIModelLogin m_ModelLogin;

	private UIModelOTP m_ModelOTP;

	private UIModelAntiAddiction m_ModelAntiAddiction;

	private UIRegisterController m_CtrlRegister;

	private UILoginTrialInfoController m_TrialInfoCtrl;

	private UILoginDebugController m_DebugCtrl;

	private UILoginRegionInfoController m_RegionInfoController;

	private UILoginSuccessInfoController m_LoginSuccessInfoCtrl;

	private UILoginOptionalDownloadTipsController m_OptionalDownloadTipsCtrl;

	private UILoginAgeTOSController m_AgeTOSCtrl;

	private UIAntiAddictionBRLoginAgeTOSController m_BRAgeTOSCtrl;

	private UILoginAccountRetrievalController m_AccountRetrievalCtrl;

	private UILoginOfflinePlayController m_OfflinePlayCtrl;

	private List<UILoginButton> m_LoginButtons;

	private bool _RetriedGuestRestore;

	private RegFormObserverVN _RegFormObserverVN;

	private UIWaitingForRequestController m_WaitingController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void WatchScreenshot()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void CheckCSVException()
	{
	}

	private IEnumerator DelayCreateUI()
	{
		return null;
	}

	public List<UILoginButton.LoginButtionData> InitLoginButtonDatas()
	{
		return null;
	}

	public void CreateLoginButtions()
	{
	}

	public bool NeedShowVK()
	{
		return false;
	}

	public bool NeedShowFB()
	{
		return false;
	}

	public bool NeedShowTwitter()
	{
		return false;
	}

	public bool NeedShowHW()
	{
		return false;
	}

	public void CreataAge18UI()
	{
	}

	private void ShowStartGameLabel(object[] data)
	{
	}

	public void OnToggleTOSChange(bool tosToggle)
	{
	}

	private void RestorePlatformLogin()
	{
	}

	private void _RestorePlatformLogin()
	{
	}

	private bool TryAutoLoginFromPGS()
	{
		return false;
	}

	private void AutoLogin(PlatformType platformType)
	{
	}

	private void ManualLogin(PlatformType platformType)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnGuestLogin()
	{
	}

	private void ProcessGuestRestore()
	{
	}

	private void OnMigrateGuestResult(SDKLogin.SAFGuestResult safResult)
	{
	}

	private void OnGuestRestorePrompted()
	{
	}

	private void GuestRestoreTryAgain()
	{
	}

	private void GuestLogin()
	{
	}

	private void OnBtnLoginVKClick()
	{
	}

	private void OnBtnFacebookClick()
	{
	}

	private void OnBtnTwitterClick()
	{
	}

	private void OnBtnAppleClick()
	{
	}

	private void OnBtnHuaweiClick()
	{
	}

	private void OnBtnGarenaClick()
	{
	}

	private void OnBtnVKClick()
	{
	}

	private void OnBtnGoogleClick()
	{
	}

	private void OnMoreChannelClick()
	{
	}

	private void VerifyAgeForAntiAddiction()
	{
	}

	private void CheckAgeCtrlByStoreUS()
	{
	}

	private void OnCheckedAgeCtrlByStoreUS()
	{
	}

	private void CheckMsdkRegFormVN()
	{
	}

	private bool _CheckMsdkRegFormVN()
	{
		return false;
	}

	private void _OnCheckedMsdkRegFormVN(RegFormCallback.Result ret)
	{
	}

	private void GotoLobby()
	{
	}

	private void GotoLobbyInternal()
	{
	}

	private bool IsWaitingAsyncPreloadFinished()
	{
		return false;
	}

	private IEnumerator WaitPreloadFinishGotoLobby()
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void SelectDefaultServer()
	{
	}

	private void SetBtnStartGameActive(bool active, bool showLabel)
	{
	}

	public void StartGame()
	{
	}

	private void ProcessStartGame()
	{
	}

	private void OpenRegisterController()
	{
	}

	private bool IsFFIPackage()
	{
		return false;
	}

	private bool IsFFVNPackage()
	{
		return false;
	}

	private bool IsAppleLogin()
	{
		return false;
	}

	private bool ShouldShowAppleLoginHint()
	{
		return false;
	}

	private void ShowAppleLoginHintPopup()
	{
	}

	public void OnLogoutBtnClick()
	{
	}

	private void UpdateLoginButtons(bool showStartGameLabel = true)
	{
	}

	private void Refresh(bool showStartGameLabel = true)
	{
	}

	private void RefreshPlayerInfo()
	{
	}

	private void RefreshLoginRegion()
	{
	}

	private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
	{
		return null;
	}

	private bool CheckIfPolicyPopupNeeded(Action callback = null)
	{
		return false;
	}

	private bool CheckIfGDPRPopupNeeded(Action callback)
	{
		return false;
	}

	private bool CheckIfDMAPopupNeeded(Action callback)
	{
		return false;
	}

	private void OnEventCloseLogin(object[] data)
	{
	}

	private void ShowMaintenanceMessage(string content)
	{
	}

	private void InitBG()
	{
	}

	public void SetSpineBGActive(bool active)
	{
	}

	public void ShowSpineBG(ResourceID spineBGResID)
	{
	}

	public void TestInvalideClientVersion()
	{
	}

	public void SetTrialAccountID(string accounID)
	{
	}

	private void CreateAccountRetrievalUI()
	{
	}

	public void SetAccountRetrievalShow(bool show)
	{
	}

	public void CreateDebugUI()
	{
	}

	private void CreateLoginSuccessUI()
	{
	}

	public void SetLoginSuccessUIShow(bool show)
	{
	}

	public void CreateRegionInfo()
	{
	}

	public void CreateOptionalDownloadandTips()
	{
	}

	public void CreateAgeTosUI()
	{
	}

	public void SetAgeTosUIShow(bool show)
	{
	}

	private void CreateOfflinePlayUI()
	{
	}

	public void SetOfflinePlayShow(bool show)
	{
	}

	private void _003CGuestRestoreTryAgain_003Eb__48_0()
	{
	}

	private void _003CVerifyAgeForAntiAddiction_003Eb__59_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
