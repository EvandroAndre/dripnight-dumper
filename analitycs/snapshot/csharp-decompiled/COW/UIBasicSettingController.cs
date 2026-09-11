using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;

namespace COW;

public class UIBasicSettingController : UISettingContentBase, IUIModelDataChangeObserver
{
	private enum Block
	{
		AccountRestoreAndBackUp
	}

	private enum BasicSettingKey
	{
		AntiAddict,
		AccountRestore,
		AccountBackUp
	}

	private enum PrivacySettingKey
	{
		WeaponPowerHidePlayerInfo,
		FriendObservationOpen,
		OccpationShow,
		SocialPrivacy,
		NearbyPeopleDiscoverable,
		NearbyPeopleLocationPrecision,
		FollowEmoteBeFollowedSetting
	}

	private enum NetworkSettingBasicItemType
	{
		MultiSession,
		SelfDamageShowType
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<int> _003C_003E9__69_0;

		public static Action _003C_003E9__69_1;

		public static Action _003C_003E9__69_2;

		public static Action _003C_003E9__72_0;

		public static Action _003C_003E9__78_0;

		public static Func<int> _003C_003E9__117_0;

		public static Func<int> _003C_003E9__119_0;

		public static Action _003C_003E9__147_0;

		public static Action _003C_003E9__159_0;

		public static Action _003C_003E9__168_0;

		public static Action _003C_003E9__171_0;

		public static Func<int> _003C_003E9__171_1;

		public static Func<int> _003C_003E9__172_0;

		public static Func<int> _003C_003E9__173_0;

		internal int _003CCreateAutoDownloadSettingData_003Eb__69_0()
		{
			return 0;
		}

		internal void _003CCreateAutoDownloadSettingData_003Eb__69_1()
		{
		}

		internal void _003CCreateAutoDownloadSettingData_003Eb__69_2()
		{
		}

		internal void _003COnBtnDeleteAccountClick_003Eb__72_0()
		{
		}

		internal void _003COnWebViewClearCacheClick_003Eb__78_0()
		{
		}

		internal int _003CCreateAccountRestoreData_003Eb__117_0()
		{
			return 0;
		}

		internal int _003CCreateAccountBackUpData_003Eb__119_0()
		{
			return 0;
		}

		internal void _003C_ShowQuitPopup_003Eb__147_0()
		{
		}

		internal void _003CCreateWeaponPowerData_003Eb__159_0()
		{
		}

		internal void _003CCreateFriendObservationData_003Eb__168_0()
		{
		}

		internal void _003CCreateNearbyPeopleDiscoverableData_003Eb__171_0()
		{
		}

		internal int _003CCreateNearbyPeopleDiscoverableData_003Eb__171_1()
		{
			return 0;
		}

		internal int _003CCreateNearbyPeopleLocationPrecisionData_003Eb__172_0()
		{
			return 0;
		}

		internal int _003CCreatesFollowEmoteBeFollowedBtnData_003Eb__173_0()
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass145_0
	{
		public UIBasicSettingController _003C_003E4__this;

		public UISecondConfirmContoller confirmWnd;

		internal void _003COnAntiAddictionBRVerifyBtnClick_003Eb__0()
		{
		}

		internal void _003COnAntiAddictionBRVerifyBtnClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass146_0
	{
		public UIBasicSettingController _003C_003E4__this;

		public UISecondConfirmContoller confirmWnd;

		internal void _003COnAntiAddictionBRChangeBindBtnClick_003Eb__0()
		{
		}

		internal void _003COnAntiAddictionBRChangeBindBtnClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public UIBasicSettingController _003C_003E4__this;

		public UISecondConfirmContoller confirmWnd;

		internal void _003COnAntiAddictionBRMinorUnBindBtnClick_003Eb__0()
		{
		}

		internal void _003COnAntiAddictionBRMinorUnBindBtnClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public UIBasicSettingController _003C_003E4__this;

		public UISecondConfirmContoller confirmWnd;

		internal void _003COnAntiAddictionBRMinorCancelUnBindBtnClick_003Eb__0()
		{
		}

		internal void _003COnAntiAddictionBRMinorCancelUnBindBtnClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public UICommonCountDownBoxController ctrl;

		internal void _003CShowGoToSystemSettingsDialogForNearbyPeople_003Eb__0()
		{
		}

		internal void _003CShowGoToSystemSettingsDialogForNearbyPeople_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public UISecondConfirmContoller confirmWnd;

		internal void _003COnBtnDeleteAccountClick_003Eb__1()
		{
		}
	}

	private sealed class _003CRefreshAdultInfoCourtine_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBasicSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshAdultInfoCourtine_003Ed__144(int _003C_003E1__state)
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

	private sealed class _003CRefreshScroll_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBasicSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__74(int _003C_003E1__state)
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

	private sealed class _003CRestoreCoroutine_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBasicSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRestoreCoroutine_003Ed__130(int _003C_003E1__state)
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

	private sealed class _003CScrollToPrivacySettingDelayed_003Ed__196 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBasicSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollToPrivacySettingDelayed_003Ed__196(int _003C_003E1__state)
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

	private const int TOGGLE_GROUP_ID = 117;

	private UIBasicSettingView m_View;

	private UIModelSetting m_Model;

	private UITipsNormalController m_BindAccountTipsController;

	private UITipsNormalController m_AntiAddictionBRMinorBindRequestTipsController;

	private UITipsNormalController m_AntiAddictionBRAgeVerifyTipsController;

	private string FIRSTSYNCEDUIFX;

	private UICommonSettingItemController m_AutoUploadItemCtrl;

	private UIModelConnectionReport m_ConnectionModel;

	private UIButton[] m_HideIngameGO;

	private List<PopMenuData> m_LanDataList;

	private List<UISettingAccountBtnController> m_AccountBtnList;

	private UIModelLogin m_LoginModel;

	private UIModelPlayGamesService m_ModelPGS;

	private BasicSettingInfo m_SettingInfo;

	private UISelectLanguageController m_UISelectLanguageController;

	private Dictionary<int, bool> m_PlatformSupportSignin;

	private bool m_NeedRefreshBtnState;

	private UIModelUser m_UserModel;

	private UIModelAntiAddiction m_AntiAddictionModel;

	private UIModelOTP m_OTPModel;

	private UIModelProfile m_ModelProfile;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelLocalization m_ModelLocalization;

	private bool m_OccupationShow;

	private uint m_LeftTimeDelayCallId;

	private uint m_UnbindCoolDownDelayCallId;

	private bool m_SocialPrivacyShow;

	private bool m_SocialPrivacyShowClick;

	private const uint RED_TIP_ID_SYNC_SETTING = 10100001u;

	private const uint RED_TIP_ID_AUTO_UPLOAD_SETTING = 10100002u;

	private const uint RED_TIP_ID_BROWSER_CACHE = 10100003u;

	private List<UICommonSettingContentController> m_CtrlList;

	private List<CommonSettingContentData> m_DataList;

	private UISyncSettingConfirmController m_Ctrl;

	private const string m_PageShownPlayerPrefsKey = "NetworkSettingPageShown";

	private UIModelConnectionReport ConnectionModel => null;

	private bool ShowOccupationSwitch => false;

	public override void SetInGameShow(bool isInGame)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitSettingInfo()
	{
	}

	public override void RefreshContent(object[] param)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected void InitChooseAgeView()
	{
	}

	private void RefreshChooseAgeVerifyView(bool forceCDOK = false)
	{
	}

	private void OnBtnAgeGroupChildWithVerifyClick()
	{
	}

	private void OnBtnAgeGroupAdultWithVerifyClick()
	{
	}

	private void OnBtnAgeGroupCannotChangeClick()
	{
	}

	private void OnBtnRebindPhoneClick()
	{
	}

	private void OnBtnCannotRebindPhoneClick()
	{
	}

	private void OnLoginHistoryBtnClick()
	{
	}

	private void OnBindAccountBtnClick()
	{
	}

	private void OnAccountManagementBtnClick()
	{
	}

	private void OnSecurityCenterBtnClick()
	{
	}

	private void InitRedTip()
	{
	}

	private void OnSecurityLevelTipClick()
	{
	}

	private void OnAccountBindBtnClick()
	{
	}

	private void OnAccountUnBindBtnClick()
	{
	}

	private void OnBtnDMAPolicyClick()
	{
	}

	private void OnAccountReBindBtnClick()
	{
	}

	private void OnAccountCancelBindBtnClick()
	{
	}

	private void OnCoolDownTipClick()
	{
	}

	private void InitPGSConnection()
	{
	}

	private void InitDMABtn()
	{
	}

	private bool ShouldShowPGSConnectionBtn()
	{
		return false;
	}

	private bool CanWriteToPGSRecall()
	{
		return false;
	}

	private void RefreshAutoDownloadSetting()
	{
	}

	private CommonSettingItemDataToggleBtns CreateAutoDownloadSettingData()
	{
		return null;
	}

	private void InitDebugUpload()
	{
	}

	private void OnBtnBugReportClick()
	{
	}

	public void OnBtnDeleteAccountClick()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
	}

	private void ResetScrollViewWidth()
	{
	}

	public void SetPopupWnd(UIModelSetting.SyncStatus status)
	{
	}

	public void UploadSetting()
	{
	}

	private void OnWebViewClearCacheClick()
	{
	}

	private void OnBtnSendNetworkReportClick()
	{
	}

	private void RefreshPGSConnectionView()
	{
	}

	private void RefreshPGSConnectionLabel(bool isAuthorized)
	{
	}

	private void ShowPGSConnectedTips()
	{
	}

	private void AfterPGSManualSignIn()
	{
	}

	private void SignInPGS()
	{
	}

	private void OnBtnPGSConnectionClick()
	{
	}

	private void RefreshNetworkReportBtnState(bool reset_to_default = false)
	{
	}

	private void OnDownloadClick()
	{
	}

	private void OnUploadClick()
	{
	}

	private void OnSyncSettingBtnClick()
	{
	}

	private void OnBrowserCacheSettingTipClick()
	{
	}

	private void OnSyncSettingTipClick()
	{
	}

	private void OnNetworkReportTipClick()
	{
	}

	private void InitBindPlatformDict()
	{
	}

	private void CheckPlatformBtnState(PlatformType platformType)
	{
	}

	private bool CheckPlatformBindBtnCanShow(PlatformType platformType)
	{
		return false;
	}

	private void SetSecondaryShow()
	{
	}

	private void SetThirdShow()
	{
	}

	private void RefreshBindshow()
	{
	}

	private void CloseAllBindUI()
	{
	}

	private void ResetThirdStateLabel()
	{
	}

	private void RefreshRecommendIcon()
	{
	}

	private void RefreshSecurityLevelShow()
	{
	}

	private void RefreshEmailOrPhone()
	{
	}

	private void RefreshCoolDownState()
	{
	}

	private void CheckCountDownFinishedProcess()
	{
	}

	private void InitBindAccountSetting(SDKBind.PlatformBindingInfo info)
	{
	}

	private void UpdateBindAccountTips()
	{
	}

	private bool ShouldShowCustomService()
	{
		return false;
	}

	private bool ShouldShowBugReportBtn()
	{
		return false;
	}

	private bool ShouldShowDeleteAccountBtn()
	{
		return false;
	}

	private void InitBtnClickDelegete()
	{
	}

	private void InitLanguageSetting()
	{
	}

	public void RefreshSyncSetting()
	{
	}

	private void InitLanguageList()
	{
	}

	public void ConfirmSetLan(object[] data)
	{
	}

	private CommonSettingItemDataToggleBtns CreateAccountRestoreData()
	{
		return null;
	}

	private void OnAccountRestoreTipClick()
	{
	}

	private CommonSettingItemDataToggleBtns CreateAccountBackUpData()
	{
		return null;
	}

	private void OnAccountBackUpTipClick()
	{
	}

	private void OnBtnAccountRestoreClick()
	{
	}

	private void RefreshAccountRestoreAndBackUpContainer()
	{
	}

	private void OnBtnAccountBackUpClick()
	{
	}

	private CommonSettingContentData CreateAccountRestoreAndBackUpBlockData()
	{
		return null;
	}

	private void onBtnTermsOfServiceClick()
	{
	}

	private void onBtnPrivacyPolicyClick()
	{
	}

	private void OnLanPopMenuBtnClick()
	{
	}

	private void OnRestoreBtnClick()
	{
	}

	private void GotoCustomerService()
	{
	}

	private IEnumerator RestoreCoroutine()
	{
		return null;
	}

	private bool IsNeedShowLogOutAllDevice()
	{
		return false;
	}

	private void OnDebugUploadBtnClick()
	{
	}

	private void SetFourthShow()
	{
	}

	private void RequestUserVerificationInfoForBR()
	{
	}

	private void RefreshAntiAddictionBRContainer()
	{
	}

	private void RefreshMinorGuardianInfo()
	{
	}

	private void RefreshMinorPlayedTime()
	{
	}

	private void StartLeftTimeUpdate()
	{
	}

	private void StopLeftTimeUpdate()
	{
	}

	private void StartUnbindCoolDownCountDown()
	{
	}

	private void UpdateUnbindCoolDownLabel(ulong remainingSeconds)
	{
	}

	private void StopUnbindCoolDownUpdate()
	{
	}

	private void RefreshAdultInfo()
	{
	}

	private IEnumerator RefreshAdultInfoCourtine()
	{
		return null;
	}

	private void OnAntiAddictionBRVerifyBtnClick()
	{
	}

	private void OnAntiAddictionBRChangeBindBtnClick()
	{
	}

	private void _ShowQuitPopup()
	{
	}

	private void OnAntiAddictionBRMinorBindBtnClick()
	{
	}

	private void OnAntiAddictionBRMinorCancelBindBtnClick()
	{
	}

	private void OnAntiAddictionBRMinorUnBindBtnClick()
	{
	}

	private void OnAntiAddictionBRMinorCancelUnBindBtnClick()
	{
	}

	private void OnAntiAddictionBRMinorBindRequestBtnClick()
	{
	}

	private void OnAntiAddictionBRAdultManagementBtnClick()
	{
	}

	private void OnAntiAddictionBRVerifyCDTipsBtnClick()
	{
	}

	private CommonSettingContentData CreatePrivateSettingBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateWeaponPowerData()
	{
		return null;
	}

	public void OnWeaponPowerLeaderBoardPrivacySwitchClick(bool enable)
	{
	}

	private int SetWeaponSkinLeaderBoardHidePlayerInfoSetting()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateOccupationShowData()
	{
		return null;
	}

	private void OnOccupationSwitchClick(bool show)
	{
	}

	private int GetOccupationOpenSetting()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateSocialPrivacyShowData()
	{
		return null;
	}

	private void OnSocialPrivacyClick(bool open)
	{
	}

	private int GetSocialPrivacySetting()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateFriendObservationData()
	{
		return null;
	}

	private int SetFriendObservationOpenSetting()
	{
		return 0;
	}

	public void OnFriendObservationSwitchClick(bool enable)
	{
	}

	private CommonSettingItemDataToggleBtns CreateNearbyPeopleDiscoverableData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateNearbyPeopleLocationPrecisionData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreatesFollowEmoteBeFollowedBtnData()
	{
		return null;
	}

	private void OnNearbyPeopleDiscoverableClick(bool isEnable)
	{
	}

	private void ShowGoToSystemSettingsDialogForNearbyPeople()
	{
	}

	private void UpdateNearbyPeopleLocationPrecisionChildItem(bool show)
	{
	}

	private bool ShowPrivacy()
	{
		return false;
	}

	private bool IsSocialPrivacyOpen()
	{
		return false;
	}

	private CommonSettingContentData CreateNetworkSettingBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateOptimizeMultiSessionAllowed()
	{
		return null;
	}

	private static void OnNetworkOptimizeMultiSessionToggleOn()
	{
	}

	private static void OnMultiSessionSecondConfirmProceed()
	{
	}

	private static void OnMultiSessionSecondConfirmExit()
	{
	}

	private static void OnNetworkOptimizeMultiSessionToggleOff()
	{
	}

	private static void OnNetworkOptimizeMultiSessionTipsBtnClick()
	{
	}

	private static int GetNetworkOptimizeMultiSessionSelectedRightToLeft()
	{
		return 0;
	}

	private static void SetNetworkSettingPageShown()
	{
	}

	public static bool IsNetworkSettingPageShown()
	{
		return false;
	}

	private static void OnNetworkTipsBtnClick(string content)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshBtnsState(object[] param)
	{
	}

	public void ScrollToPrivacySetting()
	{
	}

	private IEnumerator ScrollToPrivacySettingDelayed()
	{
		return null;
	}

	private void _003CRefreshChooseAgeVerifyView_003Eb__46_0()
	{
	}

	private void _003COnBtnAgeGroupChildWithVerifyClick_003Eb__47_1()
	{
	}

	private void _003COnBtnAgeGroupChildWithVerifyClick_003Eb__47_2()
	{
	}

	private void _003COnBtnAgeGroupChildWithVerifyClick_003Eb__47_0()
	{
	}

	private void _003COnBtnAgeGroupAdultWithVerifyClick_003Eb__48_1()
	{
	}

	private void _003COnBtnAgeGroupAdultWithVerifyClick_003Eb__48_2()
	{
	}

	private void _003COnBtnAgeGroupAdultWithVerifyClick_003Eb__48_0()
	{
	}

	private void _003COnBtnRebindPhoneClick_003Eb__50_0()
	{
	}

	private void _003COnAccountCancelBindBtnClick_003Eb__62_0()
	{
	}

	private void _003CSignInPGS_003Eb__84_0(string msg)
	{
	}

	private void _003CSignInPGS_003Eb__84_1(string str)
	{
	}

	private void _003COnBtnPGSConnectionClick_003Eb__85_0()
	{
	}

	private void _003COnBtnPGSConnectionClick_003Eb__85_1()
	{
	}

	private void _003CRefreshCoolDownState_003Eb__105_0()
	{
	}

	private void _003CInitLanguageList_003Eb__115_0(object lan)
	{
	}

	private void _003CCreateAccountRestoreData_003Eb__117_1()
	{
	}

	private void _003CCreateAccountBackUpData_003Eb__119_1()
	{
	}

	private void _003COnBtnAccountRestoreClick_003Eb__121_0()
	{
	}

	private void _003COnBtnAccountBackUpClick_003Eb__123_0()
	{
	}

	private void _003CSetFourthShow_003Eb__133_0()
	{
	}

	private void _003CSetFourthShow_003Eb__133_1()
	{
	}

	private void _003CStartLeftTimeUpdate_003Eb__138_0()
	{
	}

	private void _003CStartUnbindCoolDownCountDown_003Eb__140_0()
	{
	}

	private void _003CCreateWeaponPowerData_003Eb__159_1()
	{
	}

	private void _003CCreateWeaponPowerData_003Eb__159_2()
	{
	}

	private void _003CCreateOccupationShowData_003Eb__162_0()
	{
	}

	private void _003CCreateOccupationShowData_003Eb__162_1()
	{
	}

	private void _003CCreateSocialPrivacyShowData_003Eb__165_0()
	{
	}

	private void _003CCreateSocialPrivacyShowData_003Eb__165_1()
	{
	}

	private void _003CCreateFriendObservationData_003Eb__168_1()
	{
	}

	private void _003CCreateFriendObservationData_003Eb__168_2()
	{
	}

	private void _003CCreateNearbyPeopleDiscoverableData_003Eb__171_2()
	{
	}

	private void _003CCreateNearbyPeopleDiscoverableData_003Eb__171_3()
	{
	}

	private void _003CCreateNearbyPeopleLocationPrecisionData_003Eb__172_1()
	{
	}

	private void _003CCreateNearbyPeopleLocationPrecisionData_003Eb__172_2()
	{
	}

	private void _003CCreatesFollowEmoteBeFollowedBtnData_003Eb__173_1()
	{
	}

	private void _003CCreatesFollowEmoteBeFollowedBtnData_003Eb__173_2()
	{
	}

	private void _003CCreatesFollowEmoteBeFollowedBtnData_003Eb__173_3()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInGameShow(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitSettingInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
