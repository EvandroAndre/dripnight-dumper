using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachalegendaryNewContentController : UIGachaContentBase, IUIModelDataChangeObserver, IClothTriggerEffectPreviewContext
{
	public enum EGachaPrivilegeType
	{
		LegendClothPrivilege,
		WeaponPrivilege,
		TriggerEffect
	}

	public class ExtendedGachaPrivilege
	{
		private EGachaPrivilegeType _003CPrivilegeType_003Ek__BackingField;

		private LegendClothPrivilege _003CLegendClothPrivilege_003Ek__BackingField;

		private uint _003CWeaponPrivilegeFeatureId_003Ek__BackingField;

		private uint _003CTriggerEffectId_003Ek__BackingField;

		private ResourceID _003CIcon_003Ek__BackingField;

		private string _003CTitleKey_003Ek__BackingField;

		private EInventory.RareType _003CRare_003Ek__BackingField;

		public EGachaPrivilegeType PrivilegeType
		{
			get
			{
				return _003CPrivilegeType_003Ek__BackingField;
			}
			set
			{
				_003CPrivilegeType_003Ek__BackingField = value;
			}
		}

		public LegendClothPrivilege LegendClothPrivilege
		{
			get
			{
				return _003CLegendClothPrivilege_003Ek__BackingField;
			}
			set
			{
				_003CLegendClothPrivilege_003Ek__BackingField = value;
			}
		}

		public uint WeaponPrivilegeFeatureId
		{
			get
			{
				return _003CWeaponPrivilegeFeatureId_003Ek__BackingField;
			}
			set
			{
				_003CWeaponPrivilegeFeatureId_003Ek__BackingField = value;
			}
		}

		public uint TriggerEffectId
		{
			get
			{
				return _003CTriggerEffectId_003Ek__BackingField;
			}
			set
			{
				_003CTriggerEffectId_003Ek__BackingField = value;
			}
		}

		public ResourceID Icon
		{
			get
			{
				return _003CIcon_003Ek__BackingField;
			}
			set
			{
				_003CIcon_003Ek__BackingField = value;
			}
		}

		public string TitleKey
		{
			get
			{
				return _003CTitleKey_003Ek__BackingField;
			}
			set
			{
				_003CTitleKey_003Ek__BackingField = value;
			}
		}

		public EInventory.RareType Rare
		{
			get
			{
				return _003CRare_003Ek__BackingField;
			}
			set
			{
				_003CRare_003Ek__BackingField = value;
			}
		}

		public ExtendedGachaPrivilege(LegendClothPrivilege legendPrivilege)
		{
		}

		public ExtendedGachaPrivilege(uint weaponFeatureId, ResourceID icon, string titleKey, bool isWeaponPrivilege)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass144_0
	{
		public List<ItemTagInfo> launchTagItems;

		internal CommonRewardItemInfo _003CShowExchangeResultWnd_003Eb__1(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass178_0
	{
		public UIGachalegendaryNewContentController _003C_003E4__this;

		public uint transformID;
	}

	private sealed class _003C_003Ec__DisplayClass178_1
	{
		public int index;

		public _003C_003Ec__DisplayClass178_0 CS_0024_003C_003E8__locals1;

		internal void _003CRefreshShowAvatarTransform_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public UIGachalegendaryNewContentController _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CInitShowOptionalDownloadInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public UILabel label;

		public UIGachalegendaryNewContentController _003C_003E4__this;

		internal void _003CSetGuaranteedDropText_003Eb__0(bool downloadResult, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003CCoRefreshDebrisGuide_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachalegendaryNewContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRefreshDebrisGuide_003Ed__126(int _003C_003E1__state)
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

	private sealed class _003CDelayHideDiscountBubbleCoroutine_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachalegendaryNewContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHideDiscountBubbleCoroutine_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003CPlayProgressAnim_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachalegendaryNewContentController _003C_003E4__this;

		public int endPoint;

		public int startPoint;

		private float _003CperGrowUpTime_003E5__2;

		private float _003CperTimeChange_003E5__3;

		private int _003Ci_003E5__4;

		private float _003Ccur_time_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressAnim_003Ed__85(int _003C_003E1__state)
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

	private sealed class _003CTokenVFXCoroutine_003Ed__151 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachalegendaryNewContentController _003C_003E4__this;

		private float _003CmF1_003E5__2;

		private float _003CmF2_003E5__3;

		private float _003CtimeCounter_003E5__4;

		private Vector3 _003CstartPos_003E5__5;

		private Vector3 _003CendPos_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTokenVFXCoroutine_003Ed__151(int _003C_003E1__state)
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

	private UIGachalegendaryNewContentView m_View;

	private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

	private UIFrontEndPreviewWeaponPropertyPanelBaseController m_weaponPropertyCtrl;

	private UILegendAvatarTransformAnimController m_AvatarTransformCtrl;

	public const string DISCOUNT_BUBBLE_SHOWED_KEY = "DISCOUNT_BUBBLE_SHOWED_KEY_{0}_{1}_{2}";

	private const string m_PrizePreviewVFXKey = "TokenTowerVFX_{0}_{1}_AccountId_{2}";

	private const uint m_GrowUpTime = 1u;

	private uint m_SpacingDistance;

	private bool m_ShowAvatarTransformUI;

	private uint m_AvatarTransformID;

	private const uint FIRSTCALIBRATIONLENGTH = 45u;

	private const uint THREEGACHAINTERVAL = 145u;

	private const uint FOURGACHAINTERVAL = 140u;

	private const uint FIVEGACHAINTERVAL = 120u;

	private const int PROGRESSHEIGHTWITHTHREEITEM = 335;

	private const int PROGRESSHEIGHTWITHF0URITEM = 465;

	private const int PROGRESSHEIGHTWITHFIVEITEM = 525;

	private const int PRIVILEGEPANELBGWITHOUTITEM = 57;

	private const int PRIVILEGEPANELBGPADDING = 18;

	private Vector3 m_AvatarTransformWithCDN;

	private Vector3 m_AvatarTransformWithoutCDN;

	private Vector3 m_PrivilegePanelPosWithCDN;

	private Vector3 m_PrivilegePanelPosWithoutCDN;

	private Vector3 m_PropertyBtnPosWithCDN;

	private Vector3 m_PropertyBtnPosWithoutCDN;

	private uint m_CurrentTokenNum;

	private uint m_CurrentExchangingTokenNum;

	private uint m_CurrentExchangingGachaID;

	private uint m_LegendClothId;

	private bool m_UseCDNProgressBar;

	private GachaLegendaryInfoData m_GachaInfoData;

	private UILegendDrawAnimPopWindowController m_AnimPopWnd;

	private GachaDesc m_GachaDesc;

	private List<LegendClothPrivilege> m_PrivilegeList;

	private List<UIGachaLegendaryNewPrivilegeItemController> m_PrivilegeItemList;

	private List<ExtendedGachaPrivilege> m_ExtendedPrivilegeList;

	private FrontEndPreviewPrivilegeContextAdapter m_PrivilegeContextAdapter;

	private uint m_DelayCallStopShowPrivilege;

	private const float m_ShowLoopPrivilegeTime = 10f;

	private PreviewShowItemParams m_SavedPreviewParams;

	private PreviewShowAvatarParams m_SavedAvatarParams;

	private uint m_ClothOrBundleId;

	private bool m_IsFemaleAvatar;

	private List<Transform> m_SpotPosTranList;

	private List<Transform> m_ExtraItemTransList;

	private List<Transform> m_SpotSpriteTranList;

	private List<UINetworkTexture> m_CDNSegmentList;

	private List<UIProgressBar> m_CDNSegmentProgressBarList;

	private List<ExchangedAward> m_ExtraRewardList;

	private List<ItemTagInfo> m_LaunchTagItemList;

	private List<UIGachaLengendaryExtraListItemController> m_ExtraRewardItemList;

	private Coroutine m_ProgressCoroutine;

	private UILegendGachaAdsController m_LegendGachaAds;

	private GameObject m_TokenVfx;

	private UILaunchTagFrameController m_LaunchTagCtrl;

	private uint m_BundleID;

	private uint m_TransformAfterSingleAnimDelayCall;

	private bool _003CIsPreviewingPrivilege_003Ek__BackingField;

	private UIFrontEndPreviewCollectionOnTrialController m_TrialBtnCtrl;

	private uint m_RewardId;

	private Coroutine m_DelayHideDiscountBubbleCoroutine;

	private bool m_IsRepurchasing;

	private const int m_MaxShowCount = 4;

	private ClothTriggerEffectPreviewHandler m_ClothTriggerEffectPreviewHandler;

	public bool IsPreviewingPrivilege
	{
		get
		{
			return _003CIsPreviewingPrivilege_003Ek__BackingField;
		}
		private set
		{
			_003CIsPreviewingPrivilege_003Ek__BackingField = value;
		}
	}

	FrontEndPreviewComponent IClothTriggerEffectPreviewContext.FrontEndPreviewComponent => null;

	uint IClothTriggerEffectPreviewContext.ClothOrBundleId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	uint IClothTriggerEffectPreviewContext.ClothesSetID => 0u;

	bool IClothTriggerEffectPreviewContext.IsFemaleAvatar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void CheckCanShowPrimeAccess()
	{
	}

	public override Transform GetPrimeCountDownPos()
	{
		return null;
	}

	public Transform GetKillNotifyContainer()
	{
		return null;
	}

	public Transform GetAnnouncementContainer()
	{
		return null;
	}

	public override Transform GetNoPrimeTipsTrans()
	{
		return null;
	}

	private void RefreshPrimeShowState()
	{
	}

	private void SetInitialState()
	{
	}

	public override void OnSkipAnim()
	{
	}

	public override void InitShowOptionalDownloadInfo(List<ResourceID> resList)
	{
	}

	private void OnLegendAnimPopEnd(object[] data)
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	public override void OnTempHidePreview()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private bool HasSpecialToken()
	{
		return false;
	}

	public void PlayLengendaryAnim(string anim)
	{
	}

	private void RefreshProgressValue()
	{
	}

	private IEnumerator PlayProgressAnim(int startPoint, int endPoint)
	{
		return null;
	}

	private void SetProgressBarValue(uint tokenNum)
	{
	}

	private void OnLuckProgressClick()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void SetCDNSpinForTokens()
	{
	}

	private void RefreshDiscountBubble()
	{
	}

	private void ShowDiscountBubble()
	{
	}

	private void HideDiscountBubble()
	{
	}

	private IEnumerator DelayHideDiscountBubbleCoroutine()
	{
		return null;
	}

	private void OnBuyBtnSwitchBtnClick()
	{
	}

	private void RefreshGuaranteedDrop()
	{
	}

	private void SetGuaranteedDropText(UILabel label, ResourceID resID)
	{
	}

	private void SetSymbolLabelAtlasInfo(UILabel label, ResourceID resID)
	{
	}

	private void SetGuaranteedDropCDNBg()
	{
	}

	private void SetGuaranteedDropText()
	{
	}

	private void RefreshGuaranteedDropHighlight()
	{
	}

	private void RefreshProgressBarValueOnShowContent()
	{
	}

	private void RefreshLegendClothPrivilege()
	{
	}

	private void AddWeaponPrivileges(uint rewardId)
	{
	}

	private void AddTriggerEffects(uint rewardId)
	{
	}

	private void TryMergeKillAndBeKilled(List<uint> effectTriggerIDs, uint itemId)
	{
	}

	private void TryMergeKillAndKnockDown(List<uint> effectTriggerIDs, uint itemId)
	{
	}

	private void SetPrivilegePreviewPanelCDNBg(int privilegeCount)
	{
	}

	private void SetPrivilegePreviewGotoText()
	{
	}

	private void AdjustPrivilegePanelBg()
	{
	}

	public void OnPrivilegeItemClick(LegendClothPrivilege privilege)
	{
	}

	public void OnWeaponPrivilegeClick(uint featureId)
	{
	}

	public void OnTriggerEffectClick(uint triggerID)
	{
	}

	private float GetReturnDelayTimeForTriggerEffect(uint triggerID, ClothTriggerEffectPreviewData data)
	{
		return 0f;
	}

	private ResourceID GetTriggerEffectAnimResourceID(uint triggerID)
	{
		return default(ResourceID);
	}

	private float GetAnimationClipDuration(ResourceID animResID)
	{
		return 0f;
	}

	private void OnStartPreviewPrivilegeForWeaponOrTrigger(uint privilegeId, bool isWeaponPrivilege)
	{
	}

	private void ReturnToIdle()
	{
	}

	private void RestorePreviousPreviewState()
	{
	}

	private void OnStartPreviewPrivilege(LegendClothPrivilege privilege)
	{
	}

	private void OnEndPreviewPrivilege(object[] data)
	{
	}

	private void RefreshTrialBtn(uint privilegeId = 0u)
	{
	}

	private void UnSelectAllPrivilegeItem()
	{
	}

	private void SetPrivilegeQualityBG(EInventory.RareType rare)
	{
	}

	private IEnumerator CoRefreshDebrisGuide()
	{
		return null;
	}

	private void RefreshDebrisGuide()
	{
	}

	private void ShowCollectionTrailGuide()
	{
	}

	private void OnGuideClose()
	{
	}

	private void SetCDNTitle()
	{
	}

	private void OnLegendGachaAdsClick(object[] data)
	{
	}

	private void OnClickRewardPoolBtn()
	{
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return FrontendPreviewType.Lobby;
	}

	public override void OnGachaSceneShowTypeChange(UIGachaSceneShowType type)
	{
	}

	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	protected override void BeforeNavigationToGachaReward()
	{
	}

	protected override void OnNavigationToGachaReward(uint itemId)
	{
	}

	protected override void OnRefreshUIView()
	{
	}

	public override void OnHideContent()
	{
	}

	public override void OnShowContent()
	{
	}

	private void HideExtraListItemVfx()
	{
	}

	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	private void ShowExchangeResultWnd(object[] data)
	{
	}

	private void OnCloseCommonRewardWindow(object[] param)
	{
	}

	protected override void OnCloseRewardPanel()
	{
	}

	private void OnRewardWndRepurchase()
	{
	}

	private void OnCancelPurchase()
	{
	}

	private void ResetInfoState()
	{
	}

	private void ShowTokenVfx()
	{
	}

	private IEnumerator TokenVFXCoroutine()
	{
		return null;
	}

	private void BeginPlayDrawAnim()
	{
	}

	private void EndPlayDrawAnim()
	{
	}

	private void InitExtraRewardItems()
	{
	}

	private void OnExchangeAnimInterfaceMaskClick()
	{
	}

	private bool SetCDNProgressBarMain()
	{
		return false;
	}

	private void SetCDNProgressBarSegment()
	{
	}

	private void SetDefaultProgressBar()
	{
	}

	private void RefreshExtraRewardList()
	{
	}

	private void OnShowExchangeAnim(object[] data)
	{
	}

	private void RefreshGachaAds()
	{
	}

	private void SetPreviewBtnSmallCDNBg()
	{
	}

	private void SetPreviewBtnWithoutCDNText()
	{
	}

	private void SetPreviewBtnBigCDNBg()
	{
	}

	private void SetPreviewBtnWithCDNText()
	{
	}

	private void InitSpotSpriteTranList()
	{
	}

	private void InitPosTransList()
	{
	}

	private void InitTransList()
	{
	}

	private void InitCDNSegmentList()
	{
	}

	private void InitCDNSegmentProgressBarList()
	{
	}

	private void InitWeaponScoreItem()
	{
	}

	private uint GetBundleID()
	{
		return 0u;
	}

	private void OnLegendClothGotoBtnClick()
	{
	}

	private void OnPropertyBtnClick()
	{
	}

	private void ResetTransformAvatarData()
	{
	}

	private void OnShowAvatarTramsformAnimAfterSingleAnim()
	{
	}

	private void ShowAvatarTramsformAnimByIndex(uint TransformDataID, int index)
	{
	}

	private void RefreshShowAvatarTransform()
	{
	}

	private void RefreshShowWeaponOrVehicle()
	{
	}

	private void SetPropertyBtnCDNBg()
	{
	}

	private void SetLaunchTagData()
	{
	}

	private void ShowLaunchTag(bool show)
	{
	}

	private GameObject GetTokenVfx()
	{
		return null;
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	void IClothTriggerEffectPreviewContext.SwtichEffectAvatarPreview(bool isAvatarPreview)
	{
	}

	void IClothTriggerEffectPreviewContext.RefreshPreview(uint clothID, int clothEffectTriggerID, bool refreshNow, EPrivilegePreviewType privilegePreviewType)
	{
	}

	private void _003CSetCDNSpinForTokens_003Eb__89_0()
	{
	}

	private void _003CSetGuaranteedDropCDNBg_003Eb__98_0()
	{
	}

	private void _003CSetPrivilegePreviewPanelCDNBg_003Eb__108_0()
	{
	}

	private void _003CShowExchangeResultWnd_003Eb__144_0()
	{
	}

	private void _003CSetCDNProgressBarMain_003Eb__156_0()
	{
	}

	private void _003CSetPreviewBtnSmallCDNBg_003Eb__162_0()
	{
	}

	private void _003CSetPreviewBtnBigCDNBg_003Eb__164_0()
	{
	}

	private void _003COnShowAvatarTramsformAnimAfterSingleAnim_003Eb__176_0()
	{
	}

	private void _003CSetPropertyBtnCDNBg_003Eb__180_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Transform _003C_003EiFixBaseProxy_GetPrimeCountDownPos()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetNoPrimeTipsTrans()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowOptionalDownloadInfo(List<ResourceID> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTempHidePreview()
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	public FrontendPreviewType _003C_003EiFixBaseProxy_GetFrontendPreviewType(uint P0)
	{
		return FrontendPreviewType.Lobby;
	}

	public void _003C_003EiFixBaseProxy_OnGachaSceneShowTypeChange(UIGachaSceneShowType P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeNavigationToGachaReward()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationToGachaReward(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseRewardPanel()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
