using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINinth_GachaContentController : UIGachaContentBase, ILuckySpinContent
{
	private enum NinthGachaViewState
	{
		None,
		IdleLoop,
		Selected,
		SingleLoop,
		MultiLoop,
		LotteryAnimation,
		LotteryAnimationV2,
		OnShowRwardWnd
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public List<ChestSpecialExchangeDesc> exchangeList;

		public int i;

		public Predicate<ChestSpecialExchangeDesc> _003C_003E9__0;

		internal bool _003CRefreshExtraRewardList_003Eb__0(ChestSpecialExchangeDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public UINinth_GachaContentController _003C_003E4__this;

		public bool needSkipAnim;

		public bool needSkipKillNotify;

		internal void _003CDoCircle_003Eb__0()
		{
		}

		internal void _003CDoCircle_003Eb__1()
		{
		}

		internal void _003CDoCircle_003Eb__3()
		{
		}

		internal void _003CDoCircle_003Eb__2()
		{
		}

		internal void _003CDoCircle_003Eb__4()
		{
		}

		internal void _003CDoCircle_003Eb__5()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public UINinth_GachaContentController _003C_003E4__this;

		public UINetworkTexture netTexture;

		internal void _003CSetCDNTexture_003Eb__0()
		{
		}
	}

	private sealed class _003CIEShowItemPreview_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseItemInfo item;

		public UINinth_GachaContentController _003C_003E4__this;

		public bool needSkipAnim;

		public bool needSkipKillNotify;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEShowItemPreview_003Ed__121(int _003C_003E1__state)
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

	private sealed class _003CPlayLuckyVFX_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINinth_GachaContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayLuckyVFX_003Ed__101(int _003C_003E1__state)
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

	private const float IDLE_REWARD_DISPLAY_TIME = 15f;

	private const float CIRCLE_REWARD_DISPLAY_TIME_Quick = 0.00325f;

	private const float CIRCLE_REWARD_DISPLAY_TIME_MIN = 0.05f;

	private const float SELECT_REWARD_DISPLAY_TIME_MAX = 0.4f;

	private const float SELECT_REWARD_DISPLAY_TIME = 0.3f;

	private const float SHOW_REWORD_DELAY = 0.5f;

	private const int FAKE_CIRCLE_CNT = 8;

	private const int QUICK_CIRCLE_CNT_MIN = 2;

	private const int QUICK_CIRCLE_CNT_MAX = 6;

	private const float GuaranteedThresholdRate = 0.2f;

	private const int BIG_REWARD_MALE_INDEX = 0;

	private const int BIG_REWARD_FEMALE_INDEX = 1;

	private const int UPPER_ROW_START_INDEX = 2;

	private const int UPPER_ROW_END_INDEX = 7;

	public const uint OutputBundleMaleId = 710054011u;

	public const uint OutputBundleFemaleId = 710054012u;

	public const string OutputBundleShareCDN = "OB54/CSH/NineTW/FF_UI_GachaUnlimit_BG01_03.ff_extend";

	private GachaInfo m_GachaInfo;

	private ClientChestType m_ClientChestType;

	private UINinth_GachaContentView m_View;

	private int m_ItemCount;

	private List<GachaShowItem> m_ItemList;

	private List<UINinth_GachaItemController> m_RewardItemList;

	private List<UINinth_GachaExchangeItemController> m_ExchangeItemList;

	private HashSet<uint> m_PreviewItemIdSet;

	private uint m_ExchangeToken;

	private List<int> mRareIndexs;

	private List<int> mRewardIndexs;

	private GameObject m_CDNBgVFX;

	private ResourceID m_CDNBgVFXResID;

	private bool m_FirstEnter;

	private uint m_LastGuaranteedDrop;

	private uint m_CircleDC;

	private int m_MaxRewardCount;

	private int m_SelectedIndex;

	private int m_HighlightIndex;

	private int m_IterationCounter;

	private int m_NextRewardCount;

	private bool m_ChestInit;

	private bool m_PauseCircle;

	private uint m_CurrentGachaId;

	private bool m_DontClearPreviewItemIdSet;

	private bool m_PlayedClothChangeAnim;

	private bool m_PreviewUIHide;

	private bool m_PauseUpdateDoCircle;

	private bool m_SuppressNextIdleItemAnim;

	private bool m_SuppressNextIdleSelectVfx;

	private NinthGachaViewState m_CurrentState;

	public static bool IsOutputBundle(uint itemId)
	{
		return false;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnShowContent()
	{
	}

	public override void OnShowContent(bool needSkipAnim)
	{
	}

	public override void OnHideContent()
	{
	}

	private void ResetUI()
	{
	}

	public override void OnTempHidePreview()
	{
	}

	public override void OnRecoverPreview()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnNavigationToGachaReward(uint itemId)
	{
	}

	protected override void OnCloseRewardPanel()
	{
	}

	private void Update()
	{
	}

	protected override void OnRefreshUIView()
	{
	}

	private void CheckCanShowPrimeAccess()
	{
	}

	public override Transform GetPrimeCountDownPos()
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

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshCDN()
	{
	}

	private void SetCDNTexture(UINetworkTexture netTexture, string url, uint endTime)
	{
	}

	private void RefreshCDNBgVFX()
	{
	}

	private void RefreshProbabilityTipsLabel()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void OnPurchasePrepare(object[] param)
	{
	}

	public void PreparePuchase()
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private void OnGuaranteedDropBtnClick()
	{
	}

	private void OnShowPreviewUIBtnClick()
	{
	}

	private void OnBooyahPassPreviewSmallItemClick(object[] data)
	{
	}

	private void OnCenterItemClick()
	{
	}

	private void OnCarouselComplete()
	{
	}

	private void OnClickSelectChestItem(int index)
	{
	}

	private void SelectChestItem(int index, bool suppressSelectVfx)
	{
	}

	private void DispatchRewardItemPreview(int index, bool needSkipAnim)
	{
	}

	private int FindRewardIndexByItemId(uint itemId)
	{
		return 0;
	}

	private void PlayBigRewardSwitchAnimations(int selectedIndex)
	{
	}

	private void OnAvatarPlayChangeClothAnim()
	{
	}

	private void OnAvatarFinishChangeClothAnim()
	{
	}

	private void OnWeaponSkinPlayAnim()
	{
	}

	private void OnWeaponSkinFinishAnim(object[] data)
	{
	}

	private void ShowHidePreviewUI(bool show)
	{
	}

	private void ShowHideExchangeContainer()
	{
	}

	private UINinth_GachaItemController OpenNinthGachaItemControllerForSlot(int slotIndex, Transform parent)
	{
		return null;
	}

	private List<Transform> BuildRewardSlotList()
	{
		return null;
	}

	private void InitRewardPool()
	{
	}

	private void RefreshRewardPool()
	{
	}

	private void RefreshGuaranteedDrop()
	{
	}

	private IEnumerator PlayLuckyVFX()
	{
		return null;
	}

	private bool IsBigRewardIndex(int idx)
	{
		return false;
	}

	private void SetOutstand(int idx, UINinth_GachaItemController.ViewStage stage, float alpha = 1f, bool silent = false, bool suppressSelectVfx = false)
	{
	}

	private void SetSingleOutstand(int idx, UINinth_GachaItemController.ViewStage stage, float alpha = 1f)
	{
	}

	private void InitExchangeList()
	{
	}

	private void RefreshExtraRewardList(bool needAnim = false)
	{
	}

	public void SetExchangeInfo()
	{
	}

	private void SetExchangeTokenInfo(UISprite tokenIcon, UILabel tokenLabel)
	{
	}

	private bool CanSpecialExchangePurchase(ChestSpecialExchangeDesc item)
	{
		return false;
	}

	private int SpecialExchangeSort(ChestSpecialExchangeDesc x, ChestSpecialExchangeDesc y)
	{
		return 0;
	}

	private void SwitchState(NinthGachaViewState state, bool needSkipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void ClearCache()
	{
	}

	private void ClearAnimation()
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	public override void OnPurchaseResult(bool isSuccess, bool isRepurchase)
	{
	}

	private void ShowResult(bool showAnime)
	{
	}

	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	private UICommonRewardWndController.WndStyleEnum GetRewardStyle(GachaResultInfo resultInfo, UIModelGacha.GachaDrawType darwType)
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	private bool OnLoopAnimation()
	{
		return false;
	}

	private void DoCircle(bool needSkipAnim = false, bool needSkipKillNotify = false)
	{
	}

	private IEnumerator IEShowItemPreview(BaseItemInfo item, bool needSkipAnim = false, bool needSkipKillNotify = false)
	{
		return null;
	}

	private int RandomFindIdx(ExchangedAward award)
	{
		return 0;
	}

	private void GenRewardIndexList(GachaResultInfo info)
	{
	}

	public override void OnSkipAnim()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void TryStopAnimation(string evt)
	{
	}

	private void EndPlayDrawAnim()
	{
	}

	public void RefreshLuckySpinBtn()
	{
	}

	public void OpenRewardWnd()
	{
	}

	private void _003CUpdate_003Eb__64_0()
	{
	}

	private void _003CRefreshCDN_003Eb__72_0()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__76_0()
	{
	}

	private void _003COnAvatarFinishChangeClothAnim_003Eb__91_0()
	{
	}

	private void _003COnWeaponSkinFinishAnim_003Eb__93_0()
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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTempHidePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecoverPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationToGachaReward(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseRewardPanel()
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

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}
}
