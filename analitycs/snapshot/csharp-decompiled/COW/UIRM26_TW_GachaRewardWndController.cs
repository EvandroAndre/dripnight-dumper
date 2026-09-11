using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRM26_TW_GachaRewardWndController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_0;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_1;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_2;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_3;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_4;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_5;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_6;

		public static Converter<UIGachaIIVTWRewardItemHelper, Transform> _003C_003E9__217_7;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__284_0;

		internal Transform _003CSetRewardItemView_003Eb__217_0(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal Transform _003CSetRewardItemView_003Eb__217_1(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal Transform _003CSetRewardItemView_003Eb__217_2(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal Transform _003CSetRewardItemView_003Eb__217_3(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal Transform _003CSetRewardItemView_003Eb__217_4(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal Transform _003CSetRewardItemView_003Eb__217_5(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal Transform _003CSetRewardItemView_003Eb__217_6(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal Transform _003CSetRewardItemView_003Eb__217_7(UIGachaIIVTWRewardItemHelper helper)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CDefOpenAction_003Eb__284_0(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass194_0
	{
		public UILabel label;

		public int symbolIdx;

		public StringBuilder sb;

		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		public int totalNeedChangeNum;

		public uint returnItemNum;
	}

	private sealed class _003C_003Ec__DisplayClass194_1
	{
		public KeyValuePair<uint, uint> kv;

		public _003C_003Ec__DisplayClass194_0 CS_0024_003C_003E8__locals1;

		internal void _003CGetReturnTokenAsStringAndPreSetLabelSymbol_003Eb__0(bool downloadSuccess, string iconName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass210_0
	{
		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		public CommonRewardItemInfo info;

		internal void _003CShowRewardFeatureViewNew_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass211_0
	{
		public Action afterFeatureClose;

		public CommonRewardItemInfo info;

		internal void _003CShowRewardFeatureWithInterval_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass213_0
	{
		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		public bool needProcessExtraAward;

		internal void _003CShowRewardsAtFirst_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass222_0
	{
		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		public GachaLegendaryInfoData infoData;

		internal void _003CShowGuaranteedDrop_003Eb__0(bool downloadSuccess, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass223_0
	{
		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		public GachaLegendaryInfoData infoData;

		internal void _003CShowGachaTipsView_003Eb__0(bool downloadSuccess, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass249_0
	{
		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		public List<CommonRewardItemInfo> showCongratulationsList;

		internal void _003CStartPermanentStep4_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass250_0
	{
		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		public List<CommonRewardItemInfo> showCongratulationsList;

		internal void _003CStartPermanentStep5_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass278_0
	{
		public CSSharedItemData itemData;

		internal bool _003CFastEquipWithNoLimit_003Eb__0(PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass278_1
	{
		public PetSkinData skinData;

		internal bool _003CFastEquipWithNoLimit_003Eb__1(PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass302_0
	{
		public PetSkinData skinData;

		internal bool _003CSetPetSkinToggleInfo_003Eb__0(PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003CCoHideContent_003Ed__162 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoHideContent_003Ed__162(int _003C_003E1__state)
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

	private sealed class _003CDelayShowRewardFeatureViewNew_003Ed__216 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRM26_TW_GachaRewardWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowRewardFeatureViewNew_003Ed__216(int _003C_003E1__state)
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

	public int targetPlanIndex;

	public uint targetSlot;

	public const int FiveCenterIndex = 3;

	public const int TenCenterIndex = 4;

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

	private UIRM26_TW_GachaRewardWndView m_View;

	private UIRM26_TW_GachaRewardWnd_BGStyleController m_StyleBaseController;

	private UIRM26_TW_GachaRewardWnd_BGStyleView m_StyleView;

	private UIRM26_TW_GachaRewardItemController m_ExtraReward;

	private CommonRewardItemInfo m_FreeRewardInfo;

	private CommonRewardItemInfo m_ExtraRewardInfo;

	private List<CommonRewardItemInfo> m_RewardInfoList;

	private List<UIRM26_TW_GachaRewardItemController> m_RewardItemList;

	private UIGachaIIVTWRewardItemHelper m_OneRewardItemHelper;

	private List<UIGachaIIVTWRewardItemHelper> m_FiveRewardItemHelperList;

	private UIGachaIIVTWRewardItemHelper m_FiveExtraRewardItemHelper;

	private List<UIGachaIIVTWRewardItemHelper> m_WithExtraFiveRewardItemHelperList;

	private List<UIGachaIIVTWRewardItemHelper> m_TenRewardItemHelperList;

	private UIGachaIIVTWRewardItemHelper m_TenExtraRewardItemHelper;

	private List<UIGachaIIVTWRewardItemHelper> m_WithExtraTenRewardItemHelperList;

	private HashSet<ulong> m_WeaponSkinNeedToMergeSet;

	private readonly List<CommonRewardItemInfo> m_RewardFeatureInfoList;

	private readonly Dictionary<int, CommonRewardItemInfo> m_RewardFeatureIndexDic;

	private readonly Dictionary<uint, OptionalBundleShowData> m_DicOrderToOptionalBundleShowData;

	private UIVirtualBrandCollectionValueIncreaseWndController m_VirtualBrandCtrl;

	private UIEmoteGoVault m_EmoteGoVaultCtrl;

	private UIModelLoadout m_ModelLoadout;

	private UIModelRandomCollection m_ModelRandomColletion;

	private UIModelInventory m_ModelInventory;

	private uint m_AllRewardScrollviewDelay;

	private int m_CurRewardIdx;

	private int m_FeatureIndex;

	private uint m_TokenID;

	private uint m_ShowRewardDC;

	private uint m_ScrollviewDC;

	private bool m_IsLastWnd;

	public uint m_SelectAvatarID;

	public uint m_SelectPetId;

	public bool m_ChildWndKeepStyle;

	private List<ExchangedAward> m_BundleOpenedAwardList;

	public AutoOpenBoxBundleData m_AutoOpenBoxBundleData;

	private UIFrontEndPreviewQuickMessageLinkController m_QuickMessageLinkCtrl;

	private UIQuickMessagePreviewController m_QuickMessagePreviewCtrl;

	private bool m_ForceShowRewardFeaure;

	public uint m_GachaId;

	public GachaLuckyData m_GachaLuckyData;

	public Dictionary<uint, uint> m_SelectPetSkinDict;

	private const int m_MaxRewardCnt1Row = 5;

	private const uint m_FFTokenID = 800000301u;

	private float m_ShowRewardSecondInterval;

	private bool m_Instant;

	private bool m_First;

	private bool m_IsShowAll;

	private bool m_IsDestory;

	private bool m_IsCrate;

	private bool m_UseNewItem;

	private bool m_OnlyHasOneEmoteInSelectedItem;

	private uint m_GoVaultEmoteItemID;

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

	private UICommonRewardWndController.WndStyleEnum m_wndStyle;

	private bool m_EnableShowFeature;

	private bool m_EnableShowBooyahPassExp;

	private UICommonRewardWndController.RepurchaseCurrencyType m_RepurchaseCurrencyType;

	private UICommonRewardWndController.PurchaseDelegate m_PurchaseDelegate;

	private int m_EquippedSuccessNum;

	private bool m_HaveShowFailTip;

	private uint m_AutoCloseDC;

	private bool m_EnableOKBtnClick;

	private bool m_HasABNotReadyItem;

	private uint m_ShowViewDelayCall;

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

	private const string m_Winterland25CanSkipDrawAnimKey = "Winterland25CanSkipDrawAnim_{0}_{1}";

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

	private bool m_HasBigPrize;

	private bool m_EquipFromFastBuild;

	private bool m_IsIPCollabTipsTaken;

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

	private IEnumerator CoHideContent()
	{
		return null;
	}

	public override void OnNavigationBack()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void InitRewardItemList()
	{
	}

	public void SetRewardsData(List<CommonRewardItemInfo> infoList, CommonRewardItemInfo extraRewardInfo = null, CommonRewardItemInfo freeRewardInfo = null, bool isLastWnd = true)
	{
	}

	public void SetHasBigPrize(bool hasBigPrize)
	{
	}

	public void ShowView()
	{
	}

	public void ShowViewNoLimit()
	{
	}

	private void OnHippoCrisisPreStartPurchaseFastEquipFinished(object[] param)
	{
	}

	public void SelectWndStyle(UICommonRewardWndController.WndStyleEnum style, object userData = null)
	{
	}

	private void PlayRewardWndAnim()
	{
	}

	private void PlayRewardWndAnimSound()
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

	public void SetFeatureRewardsParams(bool enableShowFeature, bool forceShowRewardFeaure = false, bool isShowAll = false, bool enableShowAnim = false, bool isBigPrice = false)
	{
	}

	public void EnableBuyAgain(UICommonRewardWndController.RepurchaseCurrencyType type, ResourceID couponResId, uint price, string strBtnName, UICommonRewardWndController.PurchaseDelegate purchase)
	{
	}

	public void EnableBuyAgain(UICommonRewardWndController.RepurchaseCurrencyType type, ResourceID couponResId, string currencyIcon, uint couponCnt, uint price, string strBtnName, UICommonRewardWndController.PurchaseDelegate purchase)
	{
	}

	public bool IsThisWeaponSkinCanbeMerged(uint itemId, int souceType)
	{
		return false;
	}

	private void InitRewardsNoLimit(List<CommonRewardItemInfo> infoList, CommonRewardItemInfo extraRewardInfo, CommonRewardItemInfo freeRewardInfo)
	{
	}

	private bool CheckNeedToPlayMergeAnim()
	{
		return false;
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

	public void RefreshAllOptionalToggle()
	{
	}

	public void RefreshAllOptionalTaskToggle()
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

	public void SetForceShowRewardFeaure(bool flag)
	{
	}

	public void SetShowAll(bool flag)
	{
	}

	public void SetBigPrice(bool flag)
	{
	}

	private void CheckOnlyHasOneEmoteAndCantEquipInSelectedItem()
	{
	}

	private bool IsEmote(CommonRewardItemInfo info)
	{
		return false;
	}

	private void ShowRewardsViewNoLimit()
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

	private bool ShowRewardFeatureWithInterval(int i, Action afterFeatureClose)
	{
		return false;
	}

	public void PlayEasyListIntervalDone()
	{
	}

	private void ShowRewardsAtFirst(bool needProcessExtraAward = false)
	{
	}

	private void ShowRewardsViewAtFirst(bool needProcessExtraAward = false)
	{
	}

	private IEnumerator DelayShowRewardFeatureViewNew()
	{
		return null;
	}

	private void SetRewardItemView()
	{
	}

	private void SetRewardView(GameObject rewardContainer, List<Transform> transList, List<Transform> bgTransList)
	{
	}

	private void SetRewardView(GameObject rewardContainer, CommonRewardItemInfo rewardInfo, Transform trans, Transform bgTrans)
	{
	}

	private bool IsBigReward(CommonRewardItemInfo info)
	{
		return false;
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

	private void VoucherCarousel(object[] data)
	{
	}

	private void ShowRightBottomView()
	{
	}

	private bool ShowAutoOpenBoxBundleVFX()
	{
		return false;
	}

	private void ShowOptionalBundleView()
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

	private bool CheckItemABReady(CSSharedItemData itemData)
	{
		return false;
	}

	private void OnRepurchaseBtnClick()
	{
	}

	private void OnSkipPermanentMergeMaskClick()
	{
	}

	public void OnShareBtnClick()
	{
	}

	private void OnGoToExchangeClick()
	{
	}

	private void DefOpenAction()
	{
	}

	public void SetBundleOpenedAwardList(List<ExchangedAward> bundleOpenedAwardList)
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

	private void SetIsReward(CommonRewardItemInfo info)
	{
	}

	private void SetBooyahPassExp(CommonRewardItemInfo info, ref uint bpExpIncre)
	{
	}

	private void SetClothToggleInfo(CommonRewardItemInfo info, bool mustGrandPrize = false)
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

	public UICommonRewardWndController.WndStyleEnum GetWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
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

	private void SetCityHeroIntervalExtraInfo()
	{
	}

	private void SetIntervalExtraInfo()
	{
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

	public void SetOpenOptionalBundleRequestList(ICollection<uint> filterList)
	{
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

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void _003CShowViewNoLimit_003Eb__171_0()
	{
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
