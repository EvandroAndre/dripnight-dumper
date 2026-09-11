using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchis55RewardWndController : UIPopupWindowController
{
	public enum RewardItemTemplateType
	{
		Normal,
		TenReward
	}

	public enum GoVaultType
	{
		None,
		Emote,
		Collection,
		Weapon
	}

	public enum RepurchaseCurrencyType
	{
		NONE,
		FREE,
		COUPON,
		GOLD,
		DIAMOND,
		MIXED
	}

	public delegate void PurchaseDelegate(bool isRepurchase);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<CommonRewardItemInfo> _003C_003E9__212_0;

		public static Converter<CommonRewardItemInfo, uint> _003C_003E9__293_0;

		internal bool _003CPlayAnim_003Eb__212_0(CommonRewardItemInfo x)
		{
			return false;
		}

		internal uint _003CShowRewardsViewAtLast_003Eb__293_0(CommonRewardItemInfo item)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass239_0
	{
		public UILabel label;

		public int symbolIdx;

		public StringBuilder sb;

		public UIGachaIchis55RewardWndController _003C_003E4__this;

		public int totalNeedChangeNum;

		public uint returnItemNum;
	}

	private sealed class _003C_003Ec__DisplayClass239_1
	{
		public KeyValuePair<uint, uint> kv;

		public _003C_003Ec__DisplayClass239_0 CS_0024_003C_003E8__locals1;

		internal void _003CGetReturnTokenAsStringAndPreSetLabelSymbol_003Eb__0(bool downloadSuccess, string iconName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass291_0
	{
		public UIGachaIchis55RewardWndController _003C_003E4__this;

		public CommonRewardItemInfo info;

		internal void _003CShowRewardFeatureViewNew_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass298_0
	{
		public UIGachaIchis55RewardWndController _003C_003E4__this;

		public GachaLegendaryInfoData infoData;

		internal void _003CShowGuaranteedDrop_003Eb__0(bool downloadSuccess, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass299_0
	{
		public UIGachaIchis55RewardWndController _003C_003E4__this;

		public GachaLegendaryInfoData infoData;

		internal void _003CShowGachaTipsView_003Eb__0(bool downloadSuccess, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass327_0
	{
		public UIGachaIchis55RewardWndController _003C_003E4__this;

		public List<CommonRewardItemInfo> showCongratulationsList;

		internal void _003CStartPermanentStep4_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass328_0
	{
		public UIGachaIchis55RewardWndController _003C_003E4__this;

		public List<CommonRewardItemInfo> showCongratulationsList;

		internal void _003CStartPermanentStep5_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass349_0
	{
		public bool isPremiumPlus;

		public UIGachaIchis55RewardWndController _003C_003E4__this;

		internal IEnumerator _003COnOKBtnClick_003Eb__1()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass358_0
	{
		public CSSharedItemData itemData;

		internal bool _003CFastEquipWithNoLimit_003Eb__0(PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass358_1
	{
		public PetSkinData skinData;

		internal bool _003CFastEquipWithNoLimit_003Eb__1(PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass387_0
	{
		public PetSkinData skinData;

		internal bool _003CSetPetSkinToggleInfo_003Eb__0(PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003CBPCardUnlockWithControllerContextCoroutine_003Ed__405 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaIchis55RewardWndController _003C_003E4__this;

		public bool isPremiumPlus;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBPCardUnlockWithControllerContextCoroutine_003Ed__405(int _003C_003E1__state)
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

	private sealed class _003CBeforeOnOKBtnClickActionExecuteCoroutine_003Ed__407 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<Func<IEnumerator>> actionList;

		public UIGachaIchis55RewardWndController _003C_003E4__this;

		private List<Func<IEnumerator>>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBeforeOnOKBtnClickActionExecuteCoroutine_003Ed__407(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoShowOpenBundle_003Ed__295 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaIchis55RewardWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowOpenBundle_003Ed__295(int _003C_003E1__state)
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

	private sealed class _003CCoShowRewardUITable2_003Ed__296 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaIchis55RewardWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowRewardUITable2_003Ed__296(int _003C_003E1__state)
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

	private sealed class _003CDelayShowEvoAccessWndCoroutine_003Ed__406 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private UIEvoGunMembershipRewardPopupWndController _003Ccontroller_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowEvoAccessWndCoroutine_003Ed__406(int _003C_003E1__state)
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

	private sealed class _003CPlayGotTokenVFXCoroutine_003Ed__315 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaIchis55RewardWndController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayGotTokenVFXCoroutine_003Ed__315(int _003C_003E1__state)
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

	public Action m_CloseAction;

	public Action m_OpenAction;

	public Action m_OKAction;

	public bool m_BlockAllBtnExceptOKBtn;

	public bool m_EnableFastEquip;

	public bool m_IsBigPrice;

	public bool m_IsAvatarLink;

	public bool m_ShowPermanent;

	public bool m_CheckPermanentFull;

	public bool m_EnableOptionalSelect;

	public bool m_IsHyperBookUnLockHiddenPageFail;

	public bool m_EnableOptionalKeyShow;

	public string m_OptionalTextKey;

	public bool m_EnableOKBtn;

	public bool m_HasVoucherGroup;

	public bool m_HasBundleOpened;

	public int targetPlanIndex;

	public uint targetSlot;

	public uint m_CurrencyRefund;

	public uint m_DoubleWheelGrandPrizeSequence;

	public int m_GachaBundleOpenedNum;

	public int m_GachaBoxOpenedNum;

	public bool m_HasGachaTips;

	private bool m_BundleOpenFinished;

	private UIGachaELS_TT53RewardBundleNotificationController m_BundleNotiCtrl;

	public bool m_InvokeCloseActionAfterAllWndClose;

	public Dictionary<ulong, uint> itemActivityIds;

	public uint row_id;

	private uint m_OptionalTaskRewardID;

	private uint m_OptionalBundleItemRepeatChooseOrder;

	private EOptionalBundleViewsType m_OptionalBundleViewsType;

	private const string OptionalBundleSelectKey1 = "T_41_X_REWARDWIN_SELECT_1";

	private const string OptionalBundleSelectKey2 = "T_41_X_REWARDWIN_SELECT_2";

	private const string OptionalBundleSelectKey3 = "T_41_X_REWARDWIN_SELECT_3";

	private const string OptionalBundleSelectKey4 = "T_41_X_REWARDWIN_SELECT_4";

	private const string OptionalBundleSelectKey5 = "T_41_X_REWARDWIN_SELECT_5";

	private UIGachaIchis55RewardWndView m_View;

	private UIGachaIchis55RewardWnd_BGStyleController m_StyleBaseController;

	private UIGachaIchis55RewardWnd_BGStyleView m_StyleView;

	private UIGachaIchis55RewardItemController m_ExtraReward;

	private UIGachaIchis55TenRewardContainerController m_OriginTenRewardCtrl;

	private UIGachaIchis55TenRewardContainerController m_TenRewardCtrl;

	private CommonRewardItemInfo m_FreeRewardInfo;

	private CommonRewardItemInfo m_ExtraRewardInfo;

	private List<CommonRewardItemInfo> m_RewardInfoList;

	private List<CommonRewardItemInfo> m_BeforeOpenBundleRewardInfoList;

	private HashSet<ulong> m_WeaponSkinNeedToMergeSet;

	private readonly List<CommonRewardItemInfo> m_RewardFeatureInfoList;

	private readonly Dictionary<uint, OptionalBundleShowData> m_DicOrderToOptionalBundleShowData;

	private UIVirtualBrandCollectionValueIncreaseWndController m_VirtualBrandCtrl;

	private UIEmoteGoVault m_EmoteGoVaultCtrl;

	private UICommonRewardGoPosController m_GoVaultCtrl;

	private GoVaultType m_CurrentGoVaultType;

	private UIModelLoadout m_ModelLoadout;

	private UIModelRandomCollection m_ModelRandomColletion;

	private UIModelInventory m_ModelInventory;

	private UIModelIPCollab m_ModelIPCollab;

	private uint m_AllRewardScrollviewDelay;

	private int m_CurRewardIdx;

	private int m_FeatureIndex;

	private uint m_TokenID;

	private uint m_ShowRewardDC;

	private uint m_ScrollviewDC;

	private bool m_IsLastWnd;

	public uint m_SelectAvatarID;

	public uint m_SelectPetId;

	private bool m_HasBundle;

	public AutoOpenBoxBundleData m_AutoOpenBoxBundleData;

	private UIFrontEndPreviewQuickMessageLinkController m_QuickMessageLinkCtrl;

	private UIQuickMessagePreviewController m_QuickMessagePreviewCtrl;

	private bool m_HasTreesureBoxOnlyOne;

	private bool m_ForceShowRewardFeaure;

	public uint m_GachaId;

	public GachaLuckyData m_GachaLuckyData;

	public Dictionary<uint, uint> m_SelectPetSkinDict;

	private const int m_TenRewardMaxCnt = 10;

	private const int ICHIS55_REVEAL_CARD_COUNT = 10;

	private const float ICHIS55_REVEAL_CARD_INTERVAL = 0.2f;

	private const float ICHIS55_NO_LIMIT_REWARD_ITEM_WIDTH = 126f;

	private const float ICHIS55_NO_LIMIT_REWARD_ITEM_HEIGHT = 163f;

	private const float ICHIS55_NO_LIMIT_REWARD_ITEM_SCALE = 0.8f;

	private const float ICHIS55_NO_LIMIT_REWARD_HORIZONTAL_GAP = 40f;

	private const float ICHIS55_NO_LIMIT_REWARD_VERTICAL_GAP = 48f;

	private const int ICHIS55_NO_LIMIT_REWARD_ITEM_COUNT_PER_ROW = 7;

	private const float ICHIS55_NO_LIMIT_REWARD_TABLE_WIDTH = 1300f;

	private const float ICHIS55_NO_LIMIT_REWARD_TABLE_HEIGHT = 455f;

	private const uint m_FFTokenID = 800000301u;

	private float m_ShowRewardSecondInterval;

	private bool m_Instant;

	private uint m_Ichis55RevealDrawCount;

	private bool m_Ichis55RevealPlaying;

	private int m_Ichis55RevealIndex;

	private uint m_Ichis55RevealDelayCall;

	private List<CommonRewardItemInfo> m_Ichis55RevealRewardList;

	private Dictionary<GameObject, bool> m_Ichis55RevealBGStyleActiveStates;

	private bool m_First;

	private bool m_IsShowAll;

	private bool m_IsDestory;

	private UIBooyahPassUnlockedSharePopupWndController m_BPUnlockShareCtrl;

	private UIBooyahPassPrivilegeWndController m_BPPrivilegeCtrl;

	private bool m_IsCrate;

	private bool m_HasShownFinished;

	private bool m_UseNewItem;

	private bool m_OnlyHasOneRandomCollectionItem;

	private uint m_GoVaultItemID;

	private bool m_ShowTween;

	private GameObject m_FastEquipNormalBg;

	private GameObject m_FastEquipDisableBg;

	private UILabel m_FastEquipLabel;

	private Color m_FastEquipNormalColor;

	private Color m_FastEquipDisableColor;

	private bool m_HasAvatar;

	private bool m_IsOptionalTaskReward;

	private bool m_NeedPlayPermanentMergeAnim;

	public bool m_CanPlayWeaponSkinPermanentMergeAnim;

	public bool m_CanPlayWeaponSkinPermanentGrowAnim;

	private bool m_RefreshEasyListInHide;

	private bool m_IgnoreEsc;

	private bool m_HasOpenBtnClicked;

	private bool m_HasChooseBtnClicked;

	private bool m_EnableShowFeature;

	private bool m_SkipBundleOpenAnim;

	private bool m_EnableShowBooyahPassExp;

	private RepurchaseCurrencyType m_RepurchaseCurrencyType;

	private PurchaseDelegate m_PurchaseDelegate;

	private int m_EquippedSuccessNum;

	private bool m_HaveShowFailTip;

	private uint m_AutoCloseDC;

	private bool m_EnableOKBtnClick;

	private bool m_HasABNotReadyItem;

	private uint m_EquipAvatar;

	private bool m_EquipCloth;

	private List<uint> m_EquipClothList;

	private uint m_PermanentAnimDC;

	private uint m_PermanentMergeDc;

	private bool m_RepurchaseBtnClick;

	public Dictionary<int, CommonRewardNoLimitData> m_NoLimitDataDict;

	public Dictionary<uint, CommonRewardItemInfo> m_SelectedItemIDToInfoDict;

	public Dictionary<int, uint> m_EquipedIndexIDToItemIDDict;

	private Dictionary<uint, uint> m_TokenNums;

	private List<uint> m_VoucherList;

	private int m_VoucherIndex;

	private bool m_VoucherInitFlag;

	private int OPTIONAL_REWARD_ITEM_MAX_NUM;

	private HashSet<int> m_DeltaOwnedPetIDSet;

	private int ForceCancelCount;

	private bool m_HasNoForcedOpenBundle;

	private List<uint> m_BundleIDList;

	private List<CommonRewardItemInfo> m_OptionalBundleInfoList;

	public Queue<uint> OpenOptionalBundleSelectedOrder;

	public List<uint> OpenOptionalBundleRequestList;

	public uint OpenOptionalBundleCount;

	private UIModelCollection m_ModelCollection;

	private UIModelGacha m_ModelGacha;

	public bool HippoCrisisForceFastEquip;

	private bool m_HasSendLuckyLog;

	private GameObject m_LuckyVFX;

	private const float NOLIMIT_EASYLIST_OFFSET_X = -63f;

	private const float LEVELUP_NOLIMIT_EASYLIST_OFFSET_X = 245.2f;

	private const float LEVELUP_NOLIMIT_EASYLIST_WIDTH = 500f;

	private const float LEVELUP_NOLIMIT_EASYLIST_HEIGHT = 500f;

	private const float SEASONLADDER_NOLIMIT_EASYLIST_WIDTH = 661f;

	private const float SEASONLADDER_NOLIMIT_EASYLIST_HEIGHT = 500f;

	private const float SEASONLADDER_NOLIMIT_EASYLIST_OFFEST_X = 96f;

	private const float OPTIONALBUNDLE_NOLIMIT_EASYLIST_OFFEST_Y = 12f;

	private const float AUTOOPEN_BUNDLEBOX_DELAYCALL_TIME = 1f;

	private const float SEASONLADDER_WITHFIRSTRANK_NOLIMIT_EASYLIST_WIDTH = 700f;

	private const int SIX_COLUMN = 6;

	private const int SIX_COLUMN_EXTRA_POS_X = 502;

	private const float SIX_COLUMN_SCROLLVIEW_HEIGHT = 430f;

	private const float SKIP_ANIM_TIME = 2.3f;

	private bool m_EquipFromFastBuild;

	private int m_DrawSoundEffectTicket;

	private const float TOKEN_SHOW_SOUND_PLAY_DELAY_TIME = 0.2f;

	private const float NEXT_TOKEN_SHOW_DELAY_TIME = 0.25f;

	private const float HIDE_TOKEN_MASK_AFTER_LAST_TOKEN_SHOW_DELAY_TIME = 1f;

	private int m_TokenCountInReward;

	private bool m_IsPlayingTokenAnim;

	private List<GameObject> m_TokenVFXExceptFirstList;

	private Coroutine m_TokenVFXCoroutine;

	private bool m_EnterCarousel;

	private uint m_QuickMessageMsgId;

	public uint OptionalBundleItemRepeatChooseOrder
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint OptionalTaskRewardID => 0u;

	public bool NeedPlayPermanentMergeAnim => false;

	public bool CanPlayWeaponSkinPermanentMergeAnim => false;

	public bool CanPlayWeaponSkinPermanentGrowAnim => false;

	public bool HasRepurchaseBtnClick => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnEnable()
	{
	}

	public override void OnNavigationBack()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void SetRewardsData(List<CommonRewardItemInfo> infoList, CommonRewardItemInfo extraRewardInfo = null, CommonRewardItemInfo freeRewardInfo = null, bool isLastWnd = true, List<CommonRewardItemInfo> beforeOpenBundleList = null)
	{
	}

	public void SetIchis55RevealData(uint drawCount)
	{
	}

	public void SetInstantShowRewards(bool instant)
	{
	}

	public void SetOptionalRewardData(List<CommonRewardItemInfo> infoList, List<OptionalBundleShowData> optionalBundleShowDataList)
	{
	}

	public void ShowView()
	{
	}

	public void ShowViewNoLimit()
	{
	}

	private void PlayAnim()
	{
	}

	public void SetRewardContainerPosAndActive(float? x, float? y, bool active)
	{
	}

	public void SetRewardContainerActive(bool active)
	{
	}

	public void SetWndTitle(string key)
	{
	}

	public void SetTransferHint(string content)
	{
	}

	public void SelectWndStyle(object userData = null)
	{
	}

	public void SetRewardFeatureCfgParamByERewardFeatureType(RewardWndCfg cfg)
	{
	}

	public void EnableShowFeature(bool enableShowFeature)
	{
	}

	public void EnableShowIntervalAnim(bool enableShowOneByOneAnim = false)
	{
	}

	public void SetFeatureRewardsParams(RewardWndCfg cfg)
	{
	}

	public void SetFeatureRewardsParams(bool enableShowFeature, bool forceShowRewardFeaure = false, bool isShowAll = false, bool enableShowAnim = false, bool isBigPrice = false, bool skipBundleOpenAnim = false)
	{
	}

	public void EnableBuyAgain(RepurchaseCurrencyType type, ResourceID couponResId, uint price, string strBtnName, PurchaseDelegate purchase)
	{
	}

	public void EnableBuyAgain(RepurchaseCurrencyType type, ResourceID couponResId, string currencyIcon, uint couponCnt, uint price, string strBtnName, PurchaseDelegate purchase)
	{
	}

	public bool IsThisWeaponSkinCanbeMerged(uint itemId, int souceType)
	{
		return false;
	}

	private void InitRewardsNoLimit(List<CommonRewardItemInfo> infoList, CommonRewardItemInfo extraRewardInfo, CommonRewardItemInfo freeRewardInfo, List<CommonRewardItemInfo> beforeOpenBundleList = null)
	{
	}

	private void RefreshTokenCountInReward()
	{
	}

	private bool CheckNeedToPlayMergeAnim()
	{
		return false;
	}

	public void InitOptionalTaskRewards(List<CommonRewardItemInfo> infoList)
	{
	}

	private void InitOptionalRewards(List<CommonRewardItemInfo> infoList, List<OptionalBundleShowData> optionalBundleShowDataList)
	{
	}

	public OptionalBundleShowData GetOptionalShowData(uint order)
	{
		return null;
	}

	public bool HasOptionalTaskActivityReward(uint itemID, out uint activityId)
	{
		activityId = default(uint);
		return false;
	}

	public void OnOptionalTaskRewardSelected(uint itemID, uint activityId)
	{
	}

	public ICollection<uint> RefreshOptionalViewsNew()
	{
		return null;
	}

	private void SetExchangeTokenReturnLabel(int totalNeedOpenBundleItemNum, uint returnItemNum, string result)
	{
	}

	private void SetOptionalBundleOwnedItemReturnData(OptionalBundleShowData data, ref uint ownedItemNum, ref uint returnCoin, ref uint returnDiamond, Dictionary<uint, uint> tokenDic)
	{
	}

	private void SetOptionalBundleUniqueItemReturnData(OptionalBundleShowData data, ref uint noReturnDataItemNum, ref uint uniqueItemNum, ref uint returnCoin, ref uint returnDiamond, Dictionary<uint, uint> tokenDic, uint addCnt = 1u)
	{
	}

	private void CalOneItemReturnToken(OptionalBundleShowData data, out uint coin, out uint diamond, Dictionary<uint, uint> tokenDic, uint addCnt = 1u)
	{
		coin = default(uint);
		diamond = default(uint);
	}

	private void GetReturnTokenAsStringAndPreSetLabelSymbol(UILabel label, uint coin, uint diamond, Dictionary<uint, uint> tokenDic, uint multiple, int totalNeedChangeNum, uint returnItemNum)
	{
	}

	private void AdjustWindowVFX()
	{
	}

	private void AdjustBGViewWithNoLimit()
	{
	}

	private void AdjustBeforeOpenBundleBGViewWithNoLimit()
	{
	}

	public void SetForceShowRewardFeaure(bool flag)
	{
	}

	public void SetShowAll(bool flag)
	{
	}

	public void SetBigPrice(bool flag)
	{
	}

	private void CheckOnlyHasOneRandomCollectionItemAndCantEquip()
	{
	}

	private void ProcessGachaItemsForGoVault()
	{
	}

	private void CheckForUniqueGoVaultCandidate()
	{
	}

	private bool CanEquipMoreItemsOfType(CommonRewardItemInfo itemInfo)
	{
		return false;
	}

	private bool IsEmote(CommonRewardItemInfo info)
	{
		return false;
	}

	private bool IsWeapon(CommonRewardItemInfo info)
	{
		return false;
	}

	private GoVaultType GetGoVaultType(CommonRewardItemInfo info)
	{
		return GoVaultType.None;
	}

	private UICommonRewardGoPosController CreateGoVaultController(GoVaultType goVaultType)
	{
		return null;
	}

	private bool IsPhotoGroupTemplate(CommonRewardItemInfo info)
	{
		return false;
	}

	private void CheckPhotoGroupTemplateShowGoTakePhoto()
	{
	}

	private void ShowRewardsViewNoLimit()
	{
	}

	private void RefreshOriginRewardView(List<CommonRewardItemInfo> rewardInfoList)
	{
	}

	private bool TryBeginIchis55CardReveal()
	{
		return false;
	}

	private void BuildIchis55RevealRewardList()
	{
	}

	private void PrepareIchis55RevealWindow()
	{
	}

	private void StopIchis55RewardWindowAnimationsForReveal()
	{
	}

	private bool TrySkipRewardWindowAnimation(Animation animation)
	{
		return false;
	}

	private void RestoreIchis55RevealWindowRoots()
	{
	}

	private void ScheduleNextIchis55RevealCard()
	{
	}

	private void ScheduleFinishIchis55CardReveal()
	{
	}

	private void OnIchis55CardRevealFinishDelay()
	{
	}

	private void RevealNextIchis55Card()
	{
	}

	private void FinishIchis55CardRevealImmediately()
	{
	}

	private void FinishIchis55CardReveal(bool playBGStyleAnim)
	{
	}

	private void RefreshIchis55BGStyleAnimAfterReveal(bool playAnim)
	{
	}

	private void CancelIchis55CardReveal(bool restoreBGStyle)
	{
	}

	private void CancelIchis55RevealDelayCall()
	{
	}

	private void HideIchis55BGStyleExceptBG()
	{
	}

	private void HideIchis55BGStyleChildrenExceptBG(Transform root, Transform bg)
	{
	}

	private bool IsIchis55BGStyleParentOf(Transform parent, Transform child)
	{
		return false;
	}

	private void CacheAndHideIchis55BGStyleObject(GameObject target)
	{
	}

	private void RestoreIchis55BGStyleAfterReveal()
	{
	}

	private void RefreshFinalRewardView(List<CommonRewardItemInfo> rewardInfoList)
	{
	}

	private void RefreshNoLimitRewardArrow()
	{
	}

	private void RefreshOKBtnFastEquip()
	{
	}

	private void ShowGachaLucky()
	{
	}

	private void ShowGachaLuckyEnterVFX()
	{
	}

	public void MergeWeaponSkinItemInfo()
	{
	}

	public void OnPetToggle(uint petId = 0u, bool isSkin = false, uint petSkinId = 0u)
	{
	}

	private void OnPetToggleWithNoLimit(uint petId = 0u, bool isSkin = false, uint petSkinId = 0u)
	{
	}

	public void OnCollectionTypeToggle(uint selectItemId)
	{
	}

	public void OnClothTypeToggle(uint selectItemId)
	{
	}

	public void OnAvatarToggle(uint selectid = 0u)
	{
	}

	public void OnAvatarToggleWithNoLimit(uint selectid = 0u)
	{
	}

	private bool CheckFeatureCanShowNoLimit(CommonRewardItemInfo info)
	{
		return false;
	}

	private void ShowRewardFeatureViewNew()
	{
	}

	private void ShowRewardsAtLast(bool needProcessExtraAward = false)
	{
	}

	private void ShowRewardsViewAtLast(bool needProcessExtraAward = false)
	{
	}

	private void TryShowOpenBundleView()
	{
	}

	private IEnumerator CoShowOpenBundle()
	{
		return null;
	}

	private IEnumerator CoShowRewardUITable2()
	{
		return null;
	}

	private void ShowTitleView()
	{
	}

	private void ShowGuaranteedDrop()
	{
	}

	private void ShowGachaTipsView()
	{
	}

	private void ShowIPCollabTipsView()
	{
	}

	private void ShowBtnsView()
	{
	}

	private bool ShowGachaTokenGroupView()
	{
		return false;
	}

	private bool ShowExchangeTokenGroupView()
	{
		return false;
	}

	private void ConfigExchangeBtn()
	{
	}

	private void SortVoucherList()
	{
	}

	private void InitVoucherView()
	{
	}

	private void StartVoucherCarousel()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void ShowTokenGuide()
	{
	}

	private void OnTokenGuideFinish()
	{
	}

	private void OnAnimEvt(object[] data)
	{
	}

	private void ShowRightBottomView()
	{
	}

	private void PlayGotTokenVFX()
	{
	}

	private IEnumerator PlayGotTokenVFXCoroutine()
	{
		return null;
	}

	private bool ShowAutoOpenBoxBundleVFX()
	{
		return false;
	}

	private void TryResumeGachaTips()
	{
	}

	private void ShowShareButtonView()
	{
	}

	private void SetCommonWndVisble(bool flag)
	{
	}

	private void SetHideRefreshEasylistFlag(bool isPlayInterval = false)
	{
	}

	private void CheckAndShowPermanentAnim()
	{
	}

	private void ShowPermanentMerge()
	{
	}

	private void AfterPermanentMerged()
	{
	}

	private void ShowPermanentGrow()
	{
	}

	private void StartPermanentStep2()
	{
	}

	private void StartPermanentStep3()
	{
	}

	private void StartPermanentStep4()
	{
	}

	private void StartPermanentStep5(List<CommonRewardItemInfo> showCongratulationsList, bool skipAnim = true)
	{
	}

	private void CheckPermanentFull()
	{
	}

	public void RefreshCurrencyCountDown(DateTime time)
	{
	}

	private void RefreshBuyAgainBtnView(ResourceID couponResId)
	{
	}

	private void OnBannerEquipResult(object[] data)
	{
	}

	private void BannerEquipWithNoLimit(uint itemID, bool data0, bool data2)
	{
	}

	private void RefreshItemSelectStateAfterEquip(int index, bool isSuccess)
	{
	}

	private void OnHeadPicEquipResult(object[] data)
	{
	}

	private void OnCommonEquipResult(object[] data)
	{
	}

	private void CommonEquipWithNoLimit(List<uint> idList, bool data0, bool data2)
	{
	}

	public void RemoveWeaponSkinsInNewItemCache(IEnumerable<uint> Ids)
	{
	}

	private void OnEmoteEquipResult(object[] data)
	{
	}

	private void EmoteEquipWithNoLimit(uint emoteId, bool data0, bool data2)
	{
	}

	private void OnClothEquipResult(object[] data)
	{
	}

	private void OnAvatarEquipResult(object[] data)
	{
	}

	public void OnEquipSuccess(bool isTipShow = true, int selectCount = 0)
	{
	}

	public void OnEquipFail()
	{
	}

	private void ShowResult(bool isTipShow = true)
	{
	}

	private void AutoClose()
	{
	}

	private void OnClose(object[] data)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnOKBtnClick()
	{
	}

	private void OnOKBtnFastEquipChanged()
	{
	}

	private void OnOpenBtnClick()
	{
	}

	private void OnChooseBtnClick()
	{
	}

	public override void EnterByReturn()
	{
	}

	private void UpdateAvatarClothData(uint itemID)
	{
	}

	public void OnToggleSelected()
	{
	}

	public void RefreshCurrentItemToggleState()
	{
	}

	private void OnFastEquipClick()
	{
	}

	private void FastEquipWithNoLimit()
	{
	}

	private List<CommonRewardItemInfo> SortClothesInfoByLinkSetID(ICollection<CommonRewardItemInfo> infoList)
	{
		return null;
	}

	private bool CheckItemABReady(CSSharedItemData itemData)
	{
		return false;
	}

	private void OnRepurchaseBtnClick()
	{
	}

	private void OnSkipMaskClick()
	{
	}

	private void OnSkipPermanentMergeMaskClick()
	{
	}

	public void OnShareBtnClick()
	{
	}

	private void OnGemRefundTipsBtnClick()
	{
	}

	private void OnGoToExchangeClick()
	{
	}

	private void DefOpenAction()
	{
	}

	public void AutoOpenOptionalBundle()
	{
	}

	public void SetUseNewItem()
	{
	}

	private void CreateWndStyle(object userData = null)
	{
	}

	public void OnLastWndOpen()
	{
	}

	public bool HideToggle()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	private void CheckItemExceedMaxNum()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public bool HasAvatar()
	{
		return false;
	}

	private void SetFeatureData(CommonRewardItemInfo info, int index)
	{
	}

	private void SetBundleData(CommonRewardItemInfo info)
	{
	}

	private void SetBoxData()
	{
	}

	private void SetRewardToggleInfo(CommonRewardItemInfo info, CommonRewardNoLimitData noLimitData, Dictionary<uint, uint> toggledWeaponIDs, bool mustGrandPrize = false)
	{
	}

	private void SetRewardToggleInfo(CommonRewardItemInfo info, CommonRewardNoLimitData noLimitData, Dictionary<uint, uint> toggledWeaponIDs, Dictionary<uint, uint> toggledCollectionIDs, bool mustGrandPrize = false)
	{
	}

	private void SetRewardToggleInfo(CommonRewardItemInfo info, CommonRewardNoLimitData noLimitData, Dictionary<uint, uint> toggledWeaponIDs, Dictionary<uint, uint> toggledCollectionIDs, Dictionary<byte, uint> toggledClothTypes, bool mustGrandPrize = false)
	{
	}

	private void SetIsReward(CommonRewardItemInfo info)
	{
	}

	private void SetBooyahPassExp(CommonRewardItemInfo info, ref uint bpExpIncre)
	{
	}

	private void SetClothToggleInfo(CommonRewardItemInfo info, bool mustGrandPrize = false)
	{
	}

	private void SetClothToggleInfo(CommonRewardItemInfo info, Dictionary<byte, uint> toggledClothTypes, bool mustGrandPrize = false)
	{
	}

	private void SetPetSkinToggleInfo(CommonRewardItemInfo info, bool mustGrandPrize = false)
	{
	}

	private bool IsItemCanEquip(CommonRewardItemInfo info)
	{
		return false;
	}

	private List<uint> GetSelectedItemIDList()
	{
		return null;
	}

	public bool ShowTween()
	{
		return false;
	}

	public bool UseNewItem()
	{
		return false;
	}

	public bool IsOptionalTaskReward()
	{
		return false;
	}

	public bool PlayInterval()
	{
		return false;
	}

	public bool IsCurIndexInNoLimitDataDict(int index, out CommonRewardNoLimitData noLimitData)
	{
		noLimitData = null;
		return false;
	}

	public bool IsSelectAllOptionalBundleItem()
	{
		return false;
	}

	private bool CanOnlyObtainOnce(OptionalBundleShowData data)
	{
		return false;
	}

	public EOptionalBundleViewsType GetOptionalBundleViewsType()
	{
		return EOptionalBundleViewsType.None;
	}

	private bool CheckRewardListIsAllQuickMessage()
	{
		return false;
	}

	private bool CheckRewardListContainQuickMessage()
	{
		return false;
	}

	private bool ShowTokenTowerProgress()
	{
		return false;
	}

	public List<CommonRewardItemInfo> GetRewardList()
	{
		return null;
	}

	private bool ShowVirtualBrandCollectionValue()
	{
		return false;
	}

	private void ExecuteOriginalOKBtnClickActions()
	{
	}

	private IEnumerator BPCardUnlockWithControllerContextCoroutine(bool isPremiumPlus)
	{
		return null;
	}

	private IEnumerator DelayShowEvoAccessWndCoroutine()
	{
		return null;
	}

	private IEnumerator BeforeOnOKBtnClickActionExecuteCoroutine(List<Func<IEnumerator>> actionList)
	{
		return null;
	}

	private bool CheckRewardContainsBPCard()
	{
		return false;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitRewardItemTemplate()
	{
	}

	private Vector2 GetNoLimitNormalRewardItemSize()
	{
		return default(Vector2);
	}

	private UITable2.Margin GetNoLimitNormalRewardItemMargin(int normalIndex, int normalItemCount)
	{
		return null;
	}

	private IEnumerator _003COnOKBtnClick_003Eb__349_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitRewardItemTemplate_003Eb__410_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitRewardItemTemplate_003Eb__410_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
