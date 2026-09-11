using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelBigEvent_CustomCard : UIBaseModel
{
	public class CardWishData
	{
		private uint _003Cid_003Ek__BackingField;

		private int _003Cindex_003Ek__BackingField;

		public uint id
		{
			get
			{
				return _003Cid_003Ek__BackingField;
			}
			private set
			{
				_003Cid_003Ek__BackingField = value;
			}
		}

		public int index
		{
			get
			{
				return _003Cindex_003Ek__BackingField;
			}
			private set
			{
				_003Cindex_003Ek__BackingField = value;
			}
		}

		public bool Null => false;

		public void Clear()
		{
		}

		public void SetWish(uint id, int index)
		{
		}

		public static int CompareTo(CardWishData left, CardWishData right)
		{
			return 0;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__142_1;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__169_0;

		internal CommonRewardItemInfo _003CRequestReceiveCard_003Eb__142_1(BaseItemInfo item)
		{
			return null;
		}

		internal BaseItemInfo _003CGetFloorReward_003Eb__169_0(AwardDesc item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public UIModelBigEvent_CustomCard _003C_003E4__this;

		public uint useType;

		internal void _003CRequestSetCardWish_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public UIModelBigEvent_CustomCard _003C_003E4__this;

		public uint useType;

		internal void _003CRequestCancelCardWish_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass140_0
	{
		public UIModelBigEvent_CustomCard _003C_003E4__this;

		public uint useType;

		internal void _003CRequestGiveCard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass142_0
	{
		public UIModelBigEvent_CustomCard _003C_003E4__this;

		public uint useType;

		internal void _003CRequestReceiveCard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private uint _003CCustomEventId_003Ek__BackingField;

	private uint _003CCustomEventTokenId_003Ek__BackingField;

	private bool _003CHaveInitData_003Ek__BackingField;

	private uint _003CTokenConsume_003Ek__BackingField;

	private uint _003CCardReleaseLimit_003Ek__BackingField;

	private uint _003CCardReleaseLimitSameTime_003Ek__BackingField;

	private uint _003CCardGiveLimit_003Ek__BackingField;

	private uint _003CCurrentFloor_003Ek__BackingField;

	private uint _003CCurrentReleaseCount_003Ek__BackingField;

	private int _003CCurrentReleaseCountSameTime_003Ek__BackingField;

	private uint _003CCurrentGiveCount_003Ek__BackingField;

	private uint WishSettingCountSameTime;

	private uint WishSettingCDSameTime;

	private uint CurrentWishSettingCountSameTime;

	private ulong CurrentWishSettingTime;

	public uint m_FreeNum;

	private bool _003CReceiveState_003Ek__BackingField;

	private bool _003CProgressRewardState_003Ek__BackingField;

	private bool _003CFloorRewardState_003Ek__BackingField;

	private bool _003CSwitchWishShopFunc_003Ek__BackingField;

	private bool _003CSkipDrawAnim_003Ek__BackingField;

	private Dictionary<uint, List<BigEventTemplateTokenTips>> m_DictUseTypeToListTokenTips;

	private List<CustomCardRewardDesc> mlistNormalFloorDesc;

	private CustomCardRewardDesc loopFloorDesc;

	private Dictionary<uint, CustomCard_CardData> mdicCardInfos;

	private List<CustomCardProgressRewardData> mlistProgressRewards;

	private List<AwardDesc> mlistJackpotRewards;

	private List<CSCustomCardReleaseListRes.releaseCardInfo> mlistReleaseCards;

	private List<CSCustomCardReceiveListRes.receiveCardInfo> mlistReceiveCards;

	private bool _003CIsDrawing_003Ek__BackingField;

	private List<CardWishData> m_CardWishDatas;

	public const int PropID_SettingInfoRefresh = 2;

	public const int PropID_MainInfoRefresh = 4;

	public const int PropID_CardListRefresh = 8;

	public const int PropID_FloorRefresh = 16;

	public const int PropID_ProgressRefresh = 32;

	public const int PropID_ReleaseListRefresh = 64;

	public const int PropID_ReceiveListRefresh = 128;

	public const int PropID_ShopListRefresh = 256;

	public const int PropID_JackpotRefresh = 512;

	public const int PropID_WishRefersh = 1024;

	public const int PropID_QueryReceiveListRefresh = 2048;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private const string TOKEN_NOT_ENOUGH = "T_38_ZP_CC_NOTOKEN";

	public const string CARD_FLOOR_NEED_TEXT = "T_38_ZP_CC_NEED";

	public const string CARD_FLOOR_NEED_TEXT2 = "T_38_ZP_CC_NEED2";

	public const string GIVE_TAB_LABEL = "T_38_ZP_CC_GIVETAB";

	public const string RECEIVE_TAB_LABEL = "T_38_ZP_CC_RECEIVETAB";

	public const string SHOP_TAB_LABEL = "T_38_ZP_CC_SHOPTAB";

	public const string GIVE_BUTTON_LABEL = "T_38_ZP_CC_GIVEBTN";

	public const string RECEIVE_BUTTON_LABEL = "T_38_ZP_CC_RECEIVEBTN";

	public const string GIVE_WND_LIMIT = "T_38_ZP_CC_EXCHANGELIMITDES";

	public const string SHOP_LIMIT_LABEL = "T_38_ZP_CC_EXCHANGEBUYTIPS";

	public const string SHOP_TOKEN_NOT_ENOUGH = "T_38_ZP_CC_EXCHANGENOWISH";

	public const string PURCHASE_CARD_SCUESS = "T_38_ZP_CC_PURCHASESCUESS";

	public const string RECEIVE_CARD_SCUESS = "T_38_ZP_CC_RECEIVESCUESS";

	public const string GIVE_WND_CARD_EMPTY = "T_40_YY_CC_GIVETAB_TIPS";

	public const string GIVE_WND_FRIEND_EMPTY = "TXT_OB9_ZC_NOFRIENDS";

	public const string DRAW_CARD_COOLDOWN_KEY = "T_ZP_C_BUTTONPROTECTION";

	public const uint DRAW_CARD_ONE = 1u;

	public const uint DRAW_CARD_FIVE = 5u;

	public const uint EXCHANGE_INDEX = 999u;

	public const string GUIDE_STEP_KEY = "UIBigEvent_CustomCard{0}_Step_{1}";

	private const uint DRAW_CARD_COOLDOWN = 3u;

	private long m_DrawCardPoint;

	public uint CustomEventId
	{
		get
		{
			return _003CCustomEventId_003Ek__BackingField;
		}
		private set
		{
			_003CCustomEventId_003Ek__BackingField = value;
		}
	}

	public uint CustomEventTokenId
	{
		get
		{
			return _003CCustomEventTokenId_003Ek__BackingField;
		}
		private set
		{
			_003CCustomEventTokenId_003Ek__BackingField = value;
		}
	}

	public bool HaveInitData
	{
		get
		{
			return _003CHaveInitData_003Ek__BackingField;
		}
		private set
		{
			_003CHaveInitData_003Ek__BackingField = value;
		}
	}

	public uint TokenConsume
	{
		get
		{
			return _003CTokenConsume_003Ek__BackingField;
		}
		private set
		{
			_003CTokenConsume_003Ek__BackingField = value;
		}
	}

	public uint CardReleaseLimit
	{
		get
		{
			return _003CCardReleaseLimit_003Ek__BackingField;
		}
		private set
		{
			_003CCardReleaseLimit_003Ek__BackingField = value;
		}
	}

	public uint CardReleaseLimitSameTime
	{
		get
		{
			return _003CCardReleaseLimitSameTime_003Ek__BackingField;
		}
		private set
		{
			_003CCardReleaseLimitSameTime_003Ek__BackingField = value;
		}
	}

	public uint CardGiveLimit
	{
		get
		{
			return _003CCardGiveLimit_003Ek__BackingField;
		}
		private set
		{
			_003CCardGiveLimit_003Ek__BackingField = value;
		}
	}

	public uint CurrentFloor
	{
		get
		{
			return _003CCurrentFloor_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentFloor_003Ek__BackingField = value;
		}
	}

	public uint CurrentReleaseCount
	{
		get
		{
			return _003CCurrentReleaseCount_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentReleaseCount_003Ek__BackingField = value;
		}
	}

	public int CurrentReleaseCountSameTime
	{
		get
		{
			return _003CCurrentReleaseCountSameTime_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentReleaseCountSameTime_003Ek__BackingField = value;
		}
	}

	public uint CurrentGiveCount
	{
		get
		{
			return _003CCurrentGiveCount_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentGiveCount_003Ek__BackingField = value;
		}
	}

	public bool FreeDraw => false;

	public bool ReceiveState
	{
		get
		{
			return _003CReceiveState_003Ek__BackingField;
		}
		private set
		{
			_003CReceiveState_003Ek__BackingField = value;
		}
	}

	public bool ProgressRewardState
	{
		get
		{
			return _003CProgressRewardState_003Ek__BackingField;
		}
		private set
		{
			_003CProgressRewardState_003Ek__BackingField = value;
		}
	}

	public bool FloorRewardState
	{
		get
		{
			return _003CFloorRewardState_003Ek__BackingField;
		}
		private set
		{
			_003CFloorRewardState_003Ek__BackingField = value;
		}
	}

	public int CardCount => 0;

	public bool SwitchWishShopFunc
	{
		get
		{
			return _003CSwitchWishShopFunc_003Ek__BackingField;
		}
		private set
		{
			_003CSwitchWishShopFunc_003Ek__BackingField = value;
		}
	}

	public bool SkipDrawAnim
	{
		get
		{
			return _003CSkipDrawAnim_003Ek__BackingField;
		}
		private set
		{
			_003CSkipDrawAnim_003Ek__BackingField = value;
		}
	}

	public bool IsDrawing
	{
		get
		{
			return _003CIsDrawing_003Ek__BackingField;
		}
		private set
		{
			_003CIsDrawing_003Ek__BackingField = value;
		}
	}

	public bool IsLoopReward => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override void Init()
	{
	}

	private void ClearCachedData()
	{
	}

	public void OpenCommonRewardWnd(List<CommonRewardItemInfo> list, bool draw = false, bool enableAnim = true, Action closeAction = null, AutoOpenBoxBundleData autoOpenBoxBundleData = null, string transferHint = "", bool enableMerge = true)
	{
	}

	public void SyncCustomCardRedState(uint index, uint freeNum = 0u, bool receiveState = false, bool progressRewardState = false, bool floorState = false)
	{
	}

	public void SyncCustomCardReceiveState(uint card_id)
	{
	}

	private void InitCardWishData(uint count)
	{
	}

	public void RequestCustomCardSetting(uint useType)
	{
	}

	public void RequestCustomCardMainInfo()
	{
	}

	public void RequestCustomCardDraw(uint useType, uint num)
	{
	}

	public void RequestFloorReward()
	{
	}

	public void RequestSetCardWish(uint useType, uint id)
	{
	}

	public void RequestCancelCardWish(uint useType, uint id)
	{
	}

	public void RequestProgressReward(uint id)
	{
	}

	public void RequestReleaseList()
	{
	}

	public void RequestGiveCard(uint useType, uint serial, uint card_id, ulong account_id)
	{
	}

	public void RequestReceiveList()
	{
	}

	public void RequestReceiveCard(uint useType, uint serial)
	{
	}

	public void RequestShopList()
	{
	}

	public void RequestPurchageCard(uint id)
	{
	}

	public void RequestJackpotData()
	{
	}

	private void ProcessFloorAndProgressRewardState()
	{
	}

	private void ProcessCardDesc(List<CustomCardInfoDesc> list)
	{
	}

	private void ProcessCardInfo(List<CustomCardInfo> list)
	{
	}

	private bool ResetCardWishData(uint id)
	{
		return false;
	}

	private bool AddCardWishData(uint id)
	{
		return false;
	}

	public List<CardWishData> GetCardWishDatas()
	{
		return null;
	}

	private CustomCard_CardData ProcessShopCardInfo(uint id, uint amount)
	{
		return null;
	}

	private void ProcessShopCardsInfo(List<CSCustomCardShopListRes.cardInfo> list)
	{
	}

	private void ProcessProgressDesc(List<CustomCardProgressDesc> list)
	{
	}

	private void SetCurrentFloor(uint floor)
	{
	}

	private void ProcessProgressInfo(uint[] list)
	{
	}

	private CustomCardProgressRewardData ProcessProgressInfo(uint id)
	{
		return null;
	}

	private void ProcessFloorDesc(List<CustomCardRewardDesc> list)
	{
	}

	private int FloorDescCompareTo(CustomCardRewardDesc left, CustomCardRewardDesc right)
	{
		return 0;
	}

	public void ProcessTokenTips(uint useType)
	{
	}

	public List<BigEventTemplateTokenTips> GetTokenTips(uint useType, uint id)
	{
		return null;
	}

	public bool IsLobbyEntranceTipsNeedShow()
	{
		return false;
	}

	public CustomCard_CardData GetCardInfo(uint id)
	{
		return null;
	}

	public uint GetCardCount(uint id)
	{
		return 0u;
	}

	public bool GetJackpotData(out List<BaseItemInfo> normalRewards, out List<CustomCard_CardData> cardRewards)
	{
		normalRewards = null;
		cardRewards = null;
		return false;
	}

	public List<CustomCard_CardData> GetCurrentDisplayCards()
	{
		return null;
	}

	public CustomCardRewardDesc GetFloorDesc(uint floor)
	{
		return null;
	}

	public List<BaseItemInfo> GetFloorReward()
	{
		return null;
	}

	public List<BaseItemInfo> GetFloorReward(uint floor)
	{
		return null;
	}

	public uint GetCurrentFloorCardConsume(uint card_id)
	{
		return 0u;
	}

	public List<CustomCardProgressRewardData> GetProgressRewardDatas()
	{
		return null;
	}

	public CSCustomCardReceiveListRes.receiveCardInfo GetReceiveCardInfo(uint id)
	{
		return null;
	}

	public List<CSCustomCardReleaseListRes.releaseCardInfo> GetReleaseList()
	{
		return null;
	}

	public string GetMainCloseBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetWishSetupBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGiveBtnBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetGiveBtnBubbleCdnUrl(uint useType)
	{
		return null;
	}

	public string GetFloorRewardBoxCdnUrl(uint useType)
	{
		return null;
	}

	public string GetFloorRewardSmallBoxCdnUrl(uint useType)
	{
		return null;
	}

	public string GetFloorLoopRewardBoxCdnUrl(uint useType)
	{
		return null;
	}

	public string GetFloorLoopRewardSmallBoxCdnUrl(uint useType)
	{
		return null;
	}

	public string GetProgressBackgroundCDNUrl(uint useType)
	{
		return null;
	}

	public string GetProgressForegroundCDNUrl(uint useType)
	{
		return null;
	}

	public string GetProgressNodeBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetProgressNodeFloorBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetProgressCurrentFloorBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetDrawOneBtnBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetDrawFiveBtnBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetJackpotBtnBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCommonPreviewBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetJackpotPreviewMainBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetJackpotPreviewTitleBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetJackpotPreviewCardTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetJackpotPreviewItemTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardExchangeWndMainBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardExchangeWndTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardExchangeTabSelectedCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardExchangeTabUnSelectedCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardListWndTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardListWndRowBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardListWndBtnLockCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardListWndBtnUnlockCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardShopWndColBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardShopWndBtnUnlockCDNUrl(uint useType)
	{
		return null;
	}

	public string GetNoTokenWndBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetMainCardDescBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardProfileInfoBGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardAddWishBGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardReceiveWndTopBGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetCardReceiveWndBottomBGCDNUrl(uint useType)
	{
		return null;
	}

	public string GetWishSmallCardSelectedCDNUrl(uint useType)
	{
		return null;
	}

	public string GetWishSmallCardLabelBgCDNUrl(uint useType)
	{
		return null;
	}

	public Color GetCardFloorNeedColor(uint useType)
	{
		return default(Color);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetGiveBtnLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetGiveBtnBubbleLoc(uint useType)
	{
		return null;
	}

	public Color GetProgressNodeFloorLabelColor(uint useType)
	{
		return default(Color);
	}

	public Color GetProgressCurFloorLabelColor(uint useType)
	{
		return default(Color);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetDrawOneBtnLabelLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetDrawOneBtnFreeLabelLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetDrawFiveBtnLabelLoc(uint useType)
	{
		return null;
	}

	public Color GetJackpotBtnLabelColor(uint useType)
	{
		return default(Color);
	}

	public Color GetCommonPreviewCloseColor(uint useType)
	{
		return default(Color);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetFloorPreviewTitelLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCardFloorPreviewContentLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetProgressPreviewTitelLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetProgressPreviewContentLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetJackpotPreviewWndMainTitleColor(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetJackpotPreviewWndCardTitleColor(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetJackpotPreviewWndItemTitleColor(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCardExchangeWndTitleLoc(uint useType)
	{
		return null;
	}

	public Color GetCardExchangeTabSelectedColor(uint useType)
	{
		return default(Color);
	}

	public Color GetCardExchangeTabUnSelectedColor(uint useType)
	{
		return default(Color);
	}

	public string GetCardReceiveChatLoc(uint useType)
	{
		return null;
	}

	public string GetNoTokenWndTitleDescLoc(uint useType)
	{
		return null;
	}

	public string GetCardWishSettingLimitLoc(uint useType)
	{
		return null;
	}

	public string GetCardWishSettingCancelLoc(uint useType)
	{
		return null;
	}

	public string GetCardCardNotEnouchLoc(uint useType)
	{
		return null;
	}

	public string GetCardGiveLimitLoc(uint useType)
	{
		return null;
	}

	public string GetCardGiveSuccessLoc(uint useType)
	{
		return null;
	}

	public string GetCardGiveSuccessNotShopLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCardExchangeWndWishCardGiveLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCardAddWishLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetSelectWishCardTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetWishCardCountLoc(uint useType, uint count)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCardProfileInfoTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCardGiveRecordLocLoc(uint useType, uint count)
	{
		return null;
	}

	private bool GetResult(string str)
	{
		return false;
	}

	public ResourceID GetFloorRewardBoxVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFloorRewardSmallBoxVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFloorRewardStageVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFloorRewardBoxAppearVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFloorLoopRewardBoxAppearVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFloorProgressVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCardAppearEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCardCombineEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCardCombineSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCardGiveBtnEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetDrawOneBtnEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetDrawFiveBtnEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCardMainStageLightEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFloorFlyEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFloorFlySound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCardAddWishVFX(uint useType)
	{
		return default(ResourceID);
	}

	public void ShowGoposPopupWindow(Type type)
	{
	}

	private void _003CRequestCustomCardSetting_003Eb__132_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCustomCardMainInfo_003Eb__133_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCustomCardDraw_003Eb__134_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestFloorReward_003Eb__135_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestProgressReward_003Eb__138_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestReleaseList_003Eb__139_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestReceiveList_003Eb__141_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestShopList_003Eb__143_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPurchageCard_003Eb__144_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestJackpotData_003Eb__145_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
