using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelBigEventTemplate : UIBaseModel
{
	public class LocStrWithColor
	{
		public string LocStr;

		public Color LocColor;
	}

	public struct LabelEffect
	{
		public bool isNull;

		public UILabel.Effect effect;

		public Color color;

		public Vector2 distance;

		public static LabelEffect zero;
	}

	public struct LabelGradient
	{
		public bool isNull;

		public NGUIText.GradientType gradientType;

		public Color gradientTop;

		public Color gradientBottom;

		public static LabelGradient zero;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ClientActivityDesc> _003C_003E9__128_0;

		public static Predicate<CustomEventEntryDesc> _003C_003E9__187_0;

		public static Comparison<CustomEventEntryDesc> _003C_003E9__285_0;

		public static Action<HttpErrorCode, object> _003C_003E9__298_0;

		public static Func<string> _003C_003E9__309_1;

		public static Func<int> _003C_003E9__309_3;

		public static Func<string> _003C_003E9__309_4;

		internal bool _003CGetUGCCustomMissionList_003Eb__128_0(ClientActivityDesc e)
		{
			return false;
		}

		internal bool _003CProcessPreDownloadCDNUrls_003Eb__187_0(CustomEventEntryDesc x)
		{
			return false;
		}

		internal int _003CProcessEntryDesc_003Eb__285_0(CustomEventEntryDesc a, CustomEventEntryDesc b)
		{
			return 0;
		}

		internal void _003CRequestActivityAward_003Eb__298_0(HttpErrorCode errorCode, object obj)
		{
		}

		internal string _003CGetNotifyInfo_003Eb__309_1()
		{
			return null;
		}

		internal int _003CGetNotifyInfo_003Eb__309_3()
		{
			return 0;
		}

		internal string _003CGetNotifyInfo_003Eb__309_4()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass292_0
	{
		public UIModelBigEventTemplate _003C_003E4__this;

		public uint useType;

		internal void _003CRequestExchangeStoreInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass293_0
	{
		public UIModelBigEventTemplate _003C_003E4__this;

		public uint useType;

		public bool success;

		internal void _003CRequestExchangeStoreDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass294_0
	{
		public UIModelBigEventTemplate _003C_003E4__this;

		public uint useType;

		public CustomEventStoreCommodityDesc desc;

		internal void _003CRequestExchangeStorePurchase_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass295_0
	{
		public UIModelBigEventTemplate _003C_003E4__this;

		public uint useType;

		public CustomEventStoreCommodityDesc desc;

		public UICommonRewardWndController.WndStyleEnum wndStyleEnum;

		internal void _003CRequestGPExchangeStorePurchase_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass299_0
	{
		public UIModelBigEventTemplate _003C_003E4__this;

		public uint useType;

		public uint token_id;

		internal void _003CRequestTokenLimitedInGame_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass309_0
	{
		public uint GoPos;

		public string content;

		internal string _003CGetNotifyInfo_003Eb__0(object[] parameters)
		{
			return null;
		}

		internal string _003CGetNotifyInfo_003Eb__2()
		{
			return null;
		}
	}

	public const string CDN_LANGUAGE_DEFAULT = "default";

	public const string LOBBY_ENTRANCE_CLICKED_KEY = "CustomEvent{0}_LobbyEntranceClicked";

	public Dictionary<uint, CustomEventOpenInfoDesc> DictUseTypeToOpenInfo;

	public Dictionary<uint, CustomEventOpenInfoDesc> DictUseTypeToAutoPopOpenInfo;

	public Dictionary<uint, CustomEventOpenInfoDesc> DictUseTypeToWarmupOpenInfo;

	public CustomEventOpenInfoDesc m_LobbyIconOpenInfo;

	public readonly Dictionary<uint, Dictionary<uint, CustomEventEntranceDesc>> DictUseTypeToDictInPageEntrance;

	private readonly List<BigEventTemplateIntroDesc> m_ListEntranceIntro;

	private readonly Dictionary<BigEventTemplateCdnKey, CustomEventCDNDesc> m_DictCdn;

	private readonly Dictionary<BigEventTemplateLocKey, CustomEventLocDesc> m_DictLoc;

	private readonly Dictionary<uint, Dictionary<string, CustomEventTemplateDesc>> m_DictUseTypeToDictTempates;

	public Dictionary<uint, List<BigEventTemplateTokenTips>> m_DictUseTypeToListTokenTips;

	private readonly Dictionary<int, List<int>> m_DictRule;

	private bool m_InitRuleConfigDict;

	private readonly Dictionary<uint, Dictionary<int, BigEventTemplateRuleConfig>> m_DictUseTypeToDictRuleConfig;

	private readonly Dictionary<uint, uint> m_DictEventIDToUseType;

	private readonly Dictionary<uint, uint> m_UseTypeToTemplateTypeInfoDic;

	public const int PropID_ProcessedOpenInfo = 2;

	public const int PropID_ExchangeStoreInfoUpdate = 4;

	public const int PropID_ExchangeStoreDescUpdate = 8;

	public const int PropID_ExchangeStorePurchaseFinished = 16;

	public const int PropID_TemplateTokenInfoInGame = 32;

	private const EActivity.SubType ACTIVITY_SUBTYPE = EActivity.SubType.Subtype_CUSTOM_EVENT;

	private const EActivity.SubType UGC_ACTIVITY_SUBTYPE = EActivity.SubType.SubType_CUSTOM_EVENT_UGC;

	private const string PEAKDAY_OPENED_TIMESTAMP_KEY = "CustomEvent{0}_PeakDayOpenTimestamp";

	private Dictionary<uint, bool> m_ExchangeStoreDescFetched;

	private Dictionary<uint, bool> m_ExchangeStoreInfoFetched;

	private Dictionary<uint, CustomEventMatchResultTaskDesc> m_MatchResultTaskInfoDic;

	private Dictionary<uint, Dictionary<uint, CustomLimitedStoreAccountInfo>> m_DictUseTypeToDictExchangeStoreInfo;

	private Dictionary<uint, Dictionary<uint, CustomEventStoreDesc>> m_DictUseTypeToDictExchangeStoreDesc;

	private Dictionary<uint, Dictionary<uint, uint>> m_DictUseTypeToDictExchangeStoreTab;

	private Dictionary<uint, List<CustomEventStoreCommodityDesc>> m_DictUseTypeToExchangeStoreCommodityDesc;

	private Dictionary<uint, BigEventTemplateTokenInfos> m_DcitUseTypeToTokenId;

	public string PlayerPrefsKey_ExchangeStoreClassicTipsOnOff;

	public string PlayerPrefsKey_ExchangeStoreSpecialTipsOnOff;

	private List<CustomEventEntryDesc> m_CustomAutoEntryDesc;

	private Dictionary<uint, CustomEventLobbyIconDesc> m_CustomEventLobbyIconDesc;

	public const string NOTIFY_BIGEVENT_TEMPLATE_START = "NOTIFY_BIGEVENT_TEMPLATE_START_";

	public Queue<LocalNotificationManager.NotifyType> m_CanUseNotifyTypes;

	public Dictionary<uint, LocalNotificationManager.NotifyType> m_UsingNotifyTypes;

	private Dictionary<uint, BigEventLocalMailDesc> m_BigEventTemplateLocalMailDic;

	public const string PREF_BIGEVENTTEMPLATE_LOCAL_MAIL = "BigEventTemplate_LocalMail_{0}";

	private const uint MAIN_ENTRY_DESC_INDEX = 1u;

	private EBigEventTemplateUseType _003CCurrentTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType CurrentTemplateUseType
	{
		get
		{
			return _003CCurrentTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentTemplateUseType_003Ek__BackingField = value;
		}
	}

	public void SetTemplateUseType(EBigEventTemplateUseType useType)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool GetOpenInfoByUseType(EBigEventTemplateUseType useType, out CustomEventOpenInfoDesc openInfo)
	{
		openInfo = null;
		return false;
	}

	public bool GetOpenInfoByUseType(uint useType, out CustomEventOpenInfoDesc openInfo)
	{
		openInfo = null;
		return false;
	}

	public EBigEventTemplateType GetTemplateType(uint useType)
	{
		return EBigEventTemplateType.None;
	}

	public uint GetEventId(uint useType)
	{
		return 0u;
	}

	public ECustomEvent.EventState GetEventState(EBigEventTemplateUseType useType)
	{
		return ECustomEvent.EventState.EventState_NONE;
	}

	public EBigEventTemplateLobbyIntroTimingType GetSatisfiedLobbyIntroTiming(uint useType)
	{
		return EBigEventTemplateLobbyIntroTimingType.Unsatisfied;
	}

	public string GetEventStateTimeStr(ECustomEvent.EventState eventState, EBigEventTemplateUseType useType)
	{
		return null;
	}

	public bool IsDuringEventStateTime(ECustomEvent.EventState eventState, EBigEventTemplateUseType useType)
	{
		return false;
	}

	public CustomEventMatchResultTaskDesc GetCustomBigEventDailyActivitySubType(uint custom_event_id)
	{
		return null;
	}

	public bool IsDuringAutoOpenTime(uint useType)
	{
		return false;
	}

	public bool IsDuringAutoWarmUpTime(uint useType)
	{
		return false;
	}

	public bool IsDuringAutoOpenLobbyIconTime(uint custom_event_id)
	{
		return false;
	}

	public uint GetWarmUpOverTimeSanp(uint useType)
	{
		return 0u;
	}

	public string GetStoreStartTimeStr(uint useType, uint storeType)
	{
		return null;
	}

	public uint GetEventStateStartTime(ECustomEvent.EventState eventState, uint useType)
	{
		return 0u;
	}

	public uint GetEventStateEndTime(ECustomEvent.EventState eventState, uint useType)
	{
		return 0u;
	}

	public uint GetEventStateEstEndTime(ECustomEvent.EventState eventState, uint useType)
	{
		return 0u;
	}

	public uint GetOpenInfoEndTime(uint useType)
	{
		return 0u;
	}

	public UIModelBigEvent.EBigEventEntranceState GetInPageEntranceState(uint useType, uint entranceType)
	{
		return (UIModelBigEvent.EBigEventEntranceState)0;
	}

	public CustomEventEntranceDesc GetInPageEntranceDescByEntranceID(uint useType, uint entranceId)
	{
		return null;
	}

	public List<CustomEventEntranceDesc> GetInPageEntranceDescListByUseType(uint useType)
	{
		return null;
	}

	private string GetCdnUrl(string strCdnId)
	{
		return null;
	}

	public string GetCdnUrl(uint cdnId)
	{
		return null;
	}

	private CustomEventCDNDesc GetCdnDesc(uint cdnId)
	{
		return null;
	}

	public void DownloadCdnSuccessCallBack()
	{
	}

	private string GetCdnUrlByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return null;
	}

	public string GetCdnIdAndParseToUrlByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return null;
	}

	private CustomEventLocDesc GetLocDesc(string strLocId)
	{
		return null;
	}

	public CustomEventLocDesc GetLocDesc(uint locId)
	{
		return null;
	}

	public CustomEventTemplateDesc GetTemplateValue(uint useType, EBigEventTemplateConfigKey configKeyEnum)
	{
		return null;
	}

	private bool GetBool(string Switch)
	{
		return false;
	}

	public bool GetSwitchByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return false;
	}

	public bool GetSwitchShareByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return false;
	}

	public CustomEventTemplateDesc GetTemplateValue(uint useType, string strKey)
	{
		return null;
	}

	public uint GetPlayerActionLeftOrRight(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return 0u;
	}

	public static void SetTextByLocConfig(UILabel uILabel, LocStrWithColor stringConfig)
	{
	}

	public LocStrWithColor GetLocIdAndParseToStrByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return null;
	}

	public LocStrWithColor GetLocIdAndParseToStrByConfigKey(uint useType, string configKey)
	{
		return null;
	}

	public string GetLocStrByConfigKey(uint useType, string configKey)
	{
		return null;
	}

	public LocStrWithColor GetLocIdAndParseToStrByLocId(uint locId)
	{
		return null;
	}

	private Color GetColorByString(string colorStr)
	{
		return default(Color);
	}

	public Color GetColorByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return default(Color);
	}

	public Color GetColorByConfigKey(uint useType, string configKey)
	{
		return default(Color);
	}

	public LabelEffect GetLabelEffectConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return default(LabelEffect);
	}

	public LabelEffect GetLabelEffectConfigKey(uint useType, string configKey)
	{
		return default(LabelEffect);
	}

	public static void SetTextByLabelEffect(UILabel uILabel, LabelEffect label_effect, bool isEffect1)
	{
	}

	public LabelGradient GetLabelGradientConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return default(LabelGradient);
	}

	public LabelGradient GetLabelGradientConfigKey(uint useType, string configKey)
	{
		return default(LabelGradient);
	}

	public static void SetTextByLabelGradient(UILabel uILabel, LabelGradient label_effect)
	{
	}

	public string GetRedDotCdnUrl(uint useType)
	{
		return null;
	}

	public string GetEntranceBtnLabeBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetPeakDayTimeStr(EBigEventTemplateUseType useType)
	{
		return null;
	}

	public string GetPeakDayBubbleDateStr(EBigEventTemplateUseType useType)
	{
		return null;
	}

	public Color GetPeakDayBubbleDateColor(EBigEventTemplateUseType useType)
	{
		return default(Color);
	}

	public string GetPeakDayBubbleBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetPeakDayWndBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetPeakDayClaimedBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetPeakDayUnClaimedBtnCdnUrl(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetPeakDayWndTitleStr(uint useType)
	{
		return null;
	}

	public Color GetPeakDayWndCloseColor(uint useType)
	{
		return default(Color);
	}

	public LocStrWithColor GetPeakDayDescStr(uint useType, string peakDayStr)
	{
		return null;
	}

	public LocStrWithColor GetPeakDayExpireDescStr(uint useType)
	{
		return null;
	}

	public bool IsPeakDayStateClaimable(EBigEventTemplateUseType useType)
	{
		return false;
	}

	public bool IsPeakDayOpenedToday(uint useType)
	{
		return false;
	}

	public void SavePeakDayOpenedToday(uint useType)
	{
	}

	public UIModelBigEvent.EPeakDayState GetPeakDayState(EBigEventTemplateUseType useType)
	{
		return UIModelBigEvent.EPeakDayState.Invalid;
	}

	public ClientActivityDesc GetPeakDayDesc(EBigEventTemplateUseType useType)
	{
		return null;
	}

	public Color GetCommonPreviewCloseColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonPreviewBgCDNUrl(uint useType)
	{
		return null;
	}

	public ShareSettingDesc GetShareSetting(uint useType)
	{
		return null;
	}

	public int GetMissionFinishedCount(EBigEventTemplateUseType useType)
	{
		return 0;
	}

	public bool IsMissionComplete(EBigEventTemplateUseType useType)
	{
		return false;
	}

	public List<ClientActivityDesc> GetMissionList(EBigEventTemplateUseType useType)
	{
		return null;
	}

	public List<ClientActivityDesc> GetUGCCustomMissionList()
	{
		return null;
	}

	public List<ClientActivityDesc> GetMissionList(EEventType type, EBigEventTemplateUseType useType)
	{
		return null;
	}

	public EActivity.SubType GetActivitySubType(EBigEventTemplateUseType useType)
	{
		return EActivity.SubType.SubType_NONE;
	}

	public LocStrWithColor GetMissionWndTitleStr(uint useType)
	{
		return null;
	}

	public LabelEffect GetMissionWndTitleLabelEffect1(uint useType)
	{
		return default(LabelEffect);
	}

	public LabelEffect GetMissionWndTitleLabelEffect2(uint useType)
	{
		return default(LabelEffect);
	}

	public LabelGradient GetMissionWndTitleLabelGradient(uint useType)
	{
		return default(LabelGradient);
	}

	public string GetMissionWndBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionWndTitleBGCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionClaimedBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionUnClaimBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionAllClaimedBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionGotoBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionClaimBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionReceiveBtnCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetMissionMissionAwardedColor(uint useType)
	{
		return default(Color);
	}

	public Color GetMissionWndCloseColor(uint useType)
	{
		return default(Color);
	}

	public string GetMissionItemBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionItemBg2CdnUrl(uint useType)
	{
		return null;
	}

	public Color GetMissionDescColor(uint useType)
	{
		return default(Color);
	}

	public Color GetMissionProcessColor(uint useType)
	{
		return default(Color);
	}

	public string GetMissionSpecRedDotCdn(uint useType)
	{
		return null;
	}

	public string GetMissionTokenLimitCharacterCdn(uint useType)
	{
		return null;
	}

	public string GetMissionTokenDialogKeyTokenCdn(uint useType)
	{
		return null;
	}

	public string GetMissionTokenLimitKeyTokenCdn(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetMissionTokenLimitKeyDes(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetMissionTokenLimitKeyBR(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetMissionTokenLimitKeyCS(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetMissionTokenLimitKeyLW(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetGuideStepDesc(uint useType, EBigEventTemplateType templateType, uint step)
	{
		return null;
	}

	public string GetRuleWndBgCdnUrl(uint useType)
	{
		return null;
	}

	public bool GetRuleConfig(uint useType, EBigEventTemplateRulePopupWndType rulePopupWndType, out BigEventTemplateRuleConfig ruleConfig)
	{
		ruleConfig = null;
		return false;
	}

	public string GetCommonRewardWndBgCdnUrl(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetCommonRewardWndTitleLoc(uint useType)
	{
		return null;
	}

	public string GetCommonRewardWndRepurchaseBtnCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndRepurchaseLabelColor(uint useType)
	{
		return default(Color);
	}

	public Color GetCommonRewardWndRepurchaseFreeColor(uint useType)
	{
		return default(Color);
	}

	public Color GetCommonRewardWndRepurchaseCountDownLabelColor(uint useType)
	{
		return default(Color);
	}

	public Color GetCommonRewardWndCurrencyLabelColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonRewardWndOkBtnCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndOkBtnLabelColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonRewardWndCancelBtnCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndCancelBtnLabelColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonRewardWndOpenBtnCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndOpenBtnLabelColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonRewardWndFastEquipBtnNormalCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndFastEquipBtnLabelNormalColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonRewardWndFastEquipBtnDisableCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndFastEquipBtnLabelDisableColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonRewardWndChooseBtnCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndChooseBtnLabelColor(uint useType)
	{
		return default(Color);
	}

	public string GetCommonRewardWndExchangeBtnCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetCommonRewardWndExchangeBtnLabelColor(uint useType)
	{
		return default(Color);
	}

	public string GetLobbyEntranceIconCdnUrl(uint useType)
	{
		return null;
	}

	public uint GetLobbyEntranceIconCdnSize(uint useType)
	{
		return 0u;
	}

	public ResourceID GetLobbyEntranceEffectRes(uint useType)
	{
		return default(ResourceID);
	}

	public string GetLobbyEntranceIconMaskCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTokenBgCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetTokenColor(uint useType)
	{
		return default(Color);
	}

	private void ProcessPreDownloadCDNUrls(CSGetCustomEventOpenInfoRes openInfos)
	{
	}

	private void ProcessAllLocalMailEntrances(List<BigEventLocalMailDesc> eventLocalMails)
	{
	}

	public BigEventLocalMailDesc GetLocalMailDesc(uint emailId)
	{
		return null;
	}

	private MailInfo CreateBigEventTemplateLocalMailInfo(BigEventLocalMailDesc mailDesc, EMail.Status state)
	{
		return null;
	}

	private void ProcessTokenTips()
	{
	}

	public List<BigEventTemplateTokenTips> GetTokenTips(uint useType, uint id)
	{
		return null;
	}

	public uint GetCustomEventTokenId(uint useType)
	{
		return 0u;
	}

	public BigEventTemplateModeToken GetCustomEventTokenItem(uint useType, uint gameMode = 1u)
	{
		return null;
	}

	public List<BigEventTemplateVFXDesc> GetVFXByConfigKey(uint useType, List<int> vfx_config_list)
	{
		return null;
	}

	private void ProcessDictUseTypeToTemplateType()
	{
	}

	private void ProcessLobbyEnrtranceIntro()
	{
	}

	public bool GetLobbyEffectShow(EBigEventTemplateLobbyIntroTimingType timing, bool v2 = false)
	{
		return false;
	}

	public string GetLobbyEntranceIntroLocKey(EBigEventTemplateLobbyIntroTimingType timing, bool v2 = false)
	{
		return null;
	}

	public string GetLobbyEntranceIntroCdnUrl(EBigEventTemplateLobbyIntroTimingType timing, bool v2 = false)
	{
		return null;
	}

	public List<CustomEventEntryDesc> GetCustomEventEntryDescs()
	{
		return null;
	}

	public CustomEventLobbyIconDesc GetCustomEventLobbyIconDesc(uint custom_event_id)
	{
		return null;
	}

	public Color GetLobbyEnterWndTimeColor(uint useType)
	{
		return default(Color);
	}

	public Color GetLobbyEnterWndCloseColor(uint useType)
	{
		return default(Color);
	}

	public Color GetLobbyEnterWndArrowColor(uint useType)
	{
		return default(Color);
	}

	public Color GetLobbyEnterItemTimeColor(uint useType)
	{
		return default(Color);
	}

	public Color GetLobbyEnterItemTitleColor(uint useType)
	{
		return default(Color);
	}

	public Color GetLobbyEnterItemNotifyColor(uint useType)
	{
		return default(Color);
	}

	public LabelGradient GetLobbyEnterItemTimeGradient(uint useType)
	{
		return default(LabelGradient);
	}

	public string GetLobbyWarmUpTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetLobbyWarmUpBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetLobbyWarmUpLeftGifCDNUrl(uint useType)
	{
		return null;
	}

	public string GetLobbyWarmUpRightGifCDNUrl(uint useType)
	{
		return null;
	}

	public string GetLobbyWarmUpCloseButtonCDNUrl(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetLobbyWarmUpDescLoc(uint useType)
	{
		return null;
	}

	public string GetMainPageBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMainPageTitleCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMainCloseCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetMainPageCloseColor(uint useType)
	{
		return default(Color);
	}

	public Color GetMainPageTimeColor(uint useType)
	{
		return default(Color);
	}

	public string GetMainRuleCdnUrl(uint useType)
	{
		return null;
	}

	public List<UIModelLobbyAds.AdInfo> GetMainPageCdnAds(uint useType)
	{
		return null;
	}

	public string GetMainPageCdnAdsBgCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetGlobalProgressValueColor(uint useType)
	{
		return default(Color);
	}

	public string GetGlobalProgressValueBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressShareBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressShareAwardBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressShareBtnBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressAwardItemBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressAwardCantClaimCdnUrl(uint useType)
	{
		return null;
	}

	public Color GetGlobalProgressBarItemActiveColor(uint useType)
	{
		return default(Color);
	}

	public Color GetGlobalProgressBarItemDisactiveColor(uint useType)
	{
		return default(Color);
	}

	public Color GetPersonalProcessValueColor(uint useType)
	{
		return default(Color);
	}

	public string GetPersonalProgressInfoBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetPersonalProgressAwardItemBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetPersonalProgressBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetPersonalProgressAwardNormalMarkBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetPersonalProgressAwardLightMarkBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetPersonalProgressShareButtonCDNUrl(uint useType)
	{
		return null;
	}

	public string GetPersonalProcessShareBubbleBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetPersonalProcessShareTextBgCDNUrl(uint useType)
	{
		return null;
	}

	public Color GetPersonalProgressBarItemActiveColor(uint useType)
	{
		return default(Color);
	}

	public Color GetPersonalProgressBarItemDisableColor(uint useType)
	{
		return default(Color);
	}

	public Color GetPersonalProcessShareTextColor(uint useType)
	{
		return default(Color);
	}

	public string GetUGCGlobalRightTitleBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetUGCGlobalProgressCloseBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetUGCGlobalExchangeStoreCloseBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetUGCGlobalMissionCloseBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetRuleWndCloseCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreBGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreToggle1BGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreToggle1LogoCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeToggle1BGUnSelectCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreToggle2BGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreToggle2LogoCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeToggle2BGUnSelectCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreToggleLockBGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreItemBGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetGlobalProgressExchangeStoreBtnBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetUGCGlobalExchangeItemBtnBGCDNUrl(uint useType)
	{
		return null;
	}

	public Color GetExchangeStoreSelectColor(uint useType)
	{
		return default(Color);
	}

	public Color GetExchangeStoreUnSelectColor(uint useType)
	{
		return default(Color);
	}

	public Color GetExchangeStoreLockedColor(uint useType)
	{
		return default(Color);
	}

	public Color GetUGCGlobalExchangeItemOwnedColor(uint useType)
	{
		return default(Color);
	}

	public Color GetExchangeStoreButtonColor(uint useType)
	{
		return default(Color);
	}

	public Color GetExchangeStoreButtonDisableColor(uint useType)
	{
		return default(Color);
	}

	public Color GetExchangeStoreLimitColor(uint useType)
	{
		return default(Color);
	}

	public Color GetExchangeStoreTimeColor(uint useType)
	{
		return default(Color);
	}

	public Color GetTokenLabelColor(uint useType)
	{
		return default(Color);
	}

	public bool GetExchangeStoreRedTips(uint storeType)
	{
		return false;
	}

	private bool RefreshExchangeStoreItemRedTips(uint useType, EStoreTab storeType, ETipsType storeTipsType)
	{
		return false;
	}

	public bool GetExchangeStoreRedTipsState(uint useType)
	{
		return false;
	}

	public void RefreshExchangeStoreRedTips(uint useType)
	{
	}

	public string GetExchangeStoreDateShowCdnUrl(uint useType)
	{
		return null;
	}

	public List<CustomEventStoreCommodityDesc> GetExchangeStoreCommodityDescByUseType(uint useType)
	{
		return null;
	}

	public string GetEventLogPrefix(uint useType)
	{
		return null;
	}

	public bool IsLobbyEntranceTipsNeedShow(uint useType, out bool showRewardTips)
	{
		showRewardTips = default(bool);
		return false;
	}

	private void ClearCachedData()
	{
	}

	private void ProcessInPageEntrance(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	private void ProcessTemplateComponents(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	private void ProcessLocs(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	private void ProcessCDN(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	private void ProcessMatchResultRewardTask(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	private void ProcessEntryDesc(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	private void ProcessLobbyIconDesc(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	public string GetBigEventTemplateEntryDataTitle(CustomEventEntryDesc DescData)
	{
		return null;
	}

	public string GetBigEventTemplateLocalMailTitle(string localMailTitles)
	{
		return null;
	}

	private void ProcessRuleConfig()
	{
	}

	private void ProgressRuleByRuleType(EBigEventTemplateRulePopupWndType rulePopupWndType)
	{
	}

	public void RequestOpenInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestExchangeStoreInfo(uint useType, bool force = false)
	{
	}

	public void RequestExchangeStoreDesc(uint useType, bool force = false)
	{
	}

	public void RequestExchangeStorePurchase(uint useType, CustomEventStoreCommodityDesc desc, uint cnt = 1u)
	{
	}

	public void RequestGPExchangeStorePurchase(uint useType, CustomEventStoreCommodityDesc desc, UICommonRewardWndController.WndStyleEnum wndStyleEnum = UICommonRewardWndController.WndStyleEnum.COMMON, uint cnt = 1u)
	{
	}

	public void RequestActivityAward(uint activityid, EBigEventTemplateType tempalteType, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	public void RequestActivityAllAward(uint[] activityids, EBigEventTemplateType tempalteType, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	public void RequestActivityAward(uint[] activityid)
	{
	}

	public void RequestTokenLimitedInGame(uint useType)
	{
	}

	public LocStrWithColor GetExchangeStoreClassicNameStr(uint useType)
	{
		return null;
	}

	public LocStrWithColor GetExchangeStoreSpecialNameStr(uint useType)
	{
		return null;
	}

	public bool IsOptionalCustomEventDownloaded(uint custom_event_id, bool show_pop = false)
	{
		return false;
	}

	public CustomLimitedStoreAccountInfo GetExchangeStoreAccountInfoByUseTypeAndSkuId(uint useType, uint skuId)
	{
		return null;
	}

	public CustomEventStoreDesc GetStoreDescByStoreType(uint useType, uint storeType)
	{
		return null;
	}

	public bool IsDuringOpenTimeByStoreType(uint useType, uint storeType)
	{
		return false;
	}

	public uint GetExchangeStoreTypeByStoreId(uint useType, uint storeId)
	{
		return 0u;
	}

	public bool GetExchangeStoreItemLockStateByStoreId(uint useType, uint storeId)
	{
		return false;
	}

	public void ChangeNotify(CustomEventEntryDesc entryDesc, bool state)
	{
	}

	private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, CustomEventEntryDesc entryDesc)
	{
		return null;
	}

	private void _003CRequestOpenInfo_003Eb__291_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
