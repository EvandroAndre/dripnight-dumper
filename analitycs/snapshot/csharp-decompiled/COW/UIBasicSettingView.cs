using GCommon;
using UnityEngine;

namespace COW;

public class UIBasicSettingView : UIBaseView
{
	public UIButton Resotre;

	public UIButton BtnDeleteAccount;

	public UIButton ServiceLinkBtn;

	public UIButton BtnPrivacyPolicy;

	public UIButton BtnTermsOfService;

	public UIScrollView SettingScrollView;

	public UITable Table;

	public GameObject Account;

	public UILabel BindLabel;

	public UISprite BindIcon;

	public GameObject NotBindLabel;

	public GameObject SecondaryContainer;

	public UIButton AccountTipBtn;

	public UIGrid AccountBtnCenter;

	public UIButton LanPopMenuBtn;

	public UISprite LanMenuWidget;

	public UISprite SelectedLan;

	public GameObject CanClickHL;

	public UIButton SyncSettingTip;

	public UIButton BtnUpload;

	public UIButton BtnDownload;

	public GameObject WebViewWidget;

	public UIButton BtnWebViewClearCache;

	public GameObject NetworkReportWidget;

	public UIButton BtnSendReport;

	public GameObject ReportingWidget;

	public UILabel ReportLabel;

	public GameObject ReportCircle;

	public UIButton NetworkReportTip;

	public GameObject AntiAddictSettingWidget;

	public UIToggleButton ToggleChild1;

	public UILabel ToggleChild1SelectLabel;

	public UILabel ToggleChild1UnselectLabel;

	public UIToggleButton ToggleAdult1;

	public UILabel ToggleAdult1SelectLabel;

	public UILabel ToggleAdult1UnselectLabel;

	public Transform AccountRestoreContainer;

	public GameObject BugReportWidget;

	public UIButton BtnBugReport;

	public UIButton BtnGooglePlaySync;

	public UILabel BtnGooglePlaySyncLabel;

	public GameObject DebugUploadWidget;

	public UIButton BtnDebugUpload;

	public GameObject AntiAddictSecond;

	public UILabel BindPhoneNumber;

	public UIButton BtnRebindPhone;

	public UIButton BtnAgeGroupCannotChange;

	public UIButton BtnCannotRebindPhone;

	public UIButton BtnAgeGroupChildWithVerify;

	public UIButton BtnAgeGroupAdultWithVerify;

	public UILabel BindPhoneCDText;

	public UICountDownLabel BindPhoneCD;

	public UIToggleButtonGroup AgeGroup;

	public Transform GiftTips;

	public UIButton BindAccountBtn;

	public UIButton LoginHistoryBtn;

	public UIButton AccountManagementBtn;

	public UIButton SecurityCenterBtn;

	public GameObject ThirdContainer;

	public GameObject NotBindState;

	public GameObject BindState;

	public GameObject BindCoolDownState;

	public UISprite PhoneOrMailSprite;

	public UILabel PhoneOrMailLabel;

	public UILabel CoolDownLabel;

	public UICountDownLabel CoolDownLabelComp;

	public UIButton CoolDownTip;

	public GameObject NotBindRightState;

	public UIButton AccountBindBtn;

	public GameObject BindwithCoolDownRightState;

	public GameObject BindWithNDayRightState;

	public GameObject BindRightState;

	public UIButton AccountCancelBindBtn;

	public UILabel NDayChangeLabel;

	public UIButton AccountReBindBtn;

	public UIButton AccountUnBindBtn;

	public GameObject SecurityLevelContainer;

	public UISprite SecurityLevelFirstSprite;

	public UISprite SecurityLevelSecondSprite;

	public UISprite SecurityLevelThirdSprite;

	public UIButton SecurityLevelTip;

	public UILabel SyncFailedLabel;

	public UIButton BtnDMAPolicy;

	public UILabel BtnDMAPolicyLabel;

	public UILabel ThirdStateLabel;

	public Transform PrivateSetting;

	public Transform NetWork;

	public Transform AutoUploadSwitch;

	public UIGrid Grid;

	public UILabel LocalSettingPendingSyncLabel;

	public GameObject AutoUploadSwitchPos;

	public GameObject SyncSuccessLabel;

	public UILabel OTPNotBindLabel;

	public Animation recommendIcon;

	public UILabel BRAgeVerifyLabel;

	public UIButton BRAgeVerifyBtn;

	public GameObject FourthContainer;

	public UILabel BRAgeVerifyStateLabel;

	public UICountDownLabel BRAgeVerifyCDLabel;

	public UIButton BRAgeVerifyCDTipsBtn;

	public GameObject BRAgeVerifyCDContainer;

	public UIButton MinorBindBtn;

	public UIButton MinorCancelBindBtn;

	public GameObject AntiAddictionBRAdultContainer;

	public UIButton MinorBindRequestBtn;

	public UIButton AdultManagementBtn;

	public GameObject AntiAddictionBRMinorContainer;

	public UILabel AccountIdLabel;

	public GameObject headbtn;

	public UILabel NameLabel;

	public UIEffectSprite HeadSprite;

	public GameObject HeadContainer;

	public GameObject EmptyContainer;

	public UILabel EmptyNoticeLabel;

	public UIButton MinorUnBindBtn;

	public UIButton MinorCancelUnBindBtn;

	public UILabel UnbindCoolDownLabel;

	public UILabel LeftTimeLabel;

	public Transform MinorBindRequestRedTipsContainer;

	public GameObject SyncSettingRedTipContainer;

	public GameObject BrowserCacheRedTipContainer;

	public UIButton SyncSettingBtn;

	public UIButton BrowserCacheSettingBtn;

	public UIEffectSprite BannerBg;

	public Transform BRAgeVerifyRedTipsContainer;

	public GameObject AdultManagementContainer;

	public UIButton BRChangeBindBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
