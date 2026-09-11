using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRM26_TW_GachaContentController : UIGachaContentBase, ILuckySpinContent
{
	private enum UnlimitedChestViewState
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__58_0;

		public static EventDelegate.Callback _003C_003E9__61_0;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__116_0;

		public static Predicate<CommonRewardItemInfo> _003C_003E9__118_0;

		public static Predicate<CommonRewardItemInfo> _003C_003E9__122_0;

		internal void _003CShowCouponGuide_003Eb__58_0()
		{
		}

		internal void _003CShowExchangeGuide_003Eb__61_0()
		{
		}

		internal CommonRewardItemInfo _003COpenRM26TWRewardWnd_003Eb__116_0(ExchangedAward item)
		{
			return null;
		}

		internal bool _003CPutRM26TWBigPrizeToCenter_003Eb__118_0(CommonRewardItemInfo reward)
		{
			return false;
		}

		internal bool _003CHasRM26TWBigPrize_003Eb__122_0(CommonRewardItemInfo reward)
		{
			return false;
		}
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

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public UIRM26_TW_GachaContentController _003C_003E4__this;

		public UIRM26_TW_GachaRewardWndController ctrl;

		public bool isLuckySpin;

		internal void _003COpenRM26TWRewardWnd_003Eb__1()
		{
		}

		internal void _003COpenRM26TWRewardWnd_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass124_0
	{
		public UIRM26_TW_GachaContentController _003C_003E4__this;

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

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIRM26_TW_GachaContentController _003C_003E4__this;

		public UINetworkTexture netTexture;

		internal void _003CSetCDNTexture_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public ulong curTimeStamp;

		internal bool _003CRefreshInfoCDN_003Eb__0(AdvertDesc item)
		{
			return false;
		}
	}

	private sealed class _003CCoShowCouponGuide_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRM26_TW_GachaContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowCouponGuide_003Ed__57(int _003C_003E1__state)
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

	private sealed class _003CIEDestroyAnimation_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRM26_TW_GachaContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEDestroyAnimation_003Ed__133(int _003C_003E1__state)
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

	private sealed class _003CIEShowItemPreview_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseItemInfo item;

		public UIRM26_TW_GachaContentController _003C_003E4__this;

		public bool needSkipAnim;

		public bool needSkipKillNotify;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEShowItemPreview_003Ed__125(int _003C_003E1__state)
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

	private sealed class _003CInitInfoCDN_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRM26_TW_GachaContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitInfoCDN_003Ed__81(int _003C_003E1__state)
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

	private const float SELECT_REWARD_DISPLAY_TIME = 0.4f;

	private const float SHOW_REWORD_DELAY = 1.35f;

	private const int FAKE_CIRCLE_CNT = 15;

	private const int QUICK_CIRCLE_CNT_MIN = 2;

	private const int QUICK_CIRCLE_CNT_MAX = 6;

	private static readonly uint[] k_HardcodedLayoutTypes;

	private static readonly string[] k_HardcodedIconOverrides;

	private GachaInfo m_GachaInfo;

	private ClientChestType m_ClientChestType;

	private UIRM26_TW_GachaContentView m_View;

	private int m_MaxItemCount;

	private List<GachaShowItem> m_ItemList;

	private List<IUIRM26TWGachaItemController> m_RewardItemList;

	private List<UIRM26_TW_GachaExchangeItemController> m_ExchangeItemList;

	private HashSet<uint> m_PreviewItemIdSet;

	private uint m_ExchangeToken;

	private List<int> mRareIndexs;

	private List<int> mRewardIndexs;

	private GameObject m_DrawAnimation;

	private GameObject m_CDNBgVFX;

	private ResourceID m_CDNBgVFXResID;

	private UIFrontEndScene m_FrontEndScene;

	private bool m_IsShowingInfoCDN;

	private uint m_CircleDC;

	private int m_MaxRewardCount;

	private int m_SelectedIndex;

	private int m_HighlightIndex;

	private int m_IterationCounter;

	private int m_NextRewardCount;

	private uint m_TempGachaId;

	private bool m_ChestInit;

	private bool m_PauseCircle;

	private uint m_CurrentGachaId;

	private bool m_NoShowConfirmWnd;

	private bool m_DontClearPreviewItemIdSet;

	private bool m_PauseUpdateDoCircle;

	private bool m_PlayedClothChangeAnim;

	private bool m_PreviewUIHide;

	private UnlimitedChestViewState m_CurrentState;

	private bool IsNewBieGacha => false;

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

	protected override void BeforeNavigationToGachaReward()
	{
	}

	protected override void OnNavigationToGachaReward(uint itemId)
	{
	}

	public override void OnHideContent()
	{
	}

	public override void OnShowContent()
	{
	}

	public override void OnShowContent(bool needSkipAnim)
	{
	}

	private void ChangeForbidEscState(bool isForbid)
	{
	}

	private IEnumerator CoShowCouponGuide()
	{
		return null;
	}

	private void ShowCouponGuide()
	{
	}

	private void ShowTenBuyBtnGuide()
	{
	}

	private void OnTenBuyGuideFinish()
	{
	}

	private void ShowExchangeGuide()
	{
	}

	private void ShowGuaranteedDropGuide()
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

	private void Update()
	{
	}

	public void PreparePuchase()
	{
	}

	public void ClearCache()
	{
	}

	private void ClearAmimation()
	{
	}

	protected override void OnCloseRewardPanel()
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

	private IEnumerator InitInfoCDN()
	{
		return null;
	}

	private void RefreshInfoCDN()
	{
	}

	private void RefreshNewBieTipsLabel()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void OnPurchasePrepare(object[] param)
	{
	}

	private void ShowHidePreviewUI(bool show)
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

	private void OnBooyahPassPreviewSmallItemClick(object[] data)
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private void OnCenterItemClick()
	{
	}

	private void OnCarouselComplete()
	{
	}

	private void ShowHideExchangeContainer()
	{
	}

	private void OnShowPreviewUIBtnClick()
	{
	}

	private void OnGuaranteedDropBtnClick()
	{
	}

	private void OnClickSelectChestItem(int index)
	{
	}

	private void InitRewardPool()
	{
	}

	private IUIRM26TWGachaItemController GetChestItemController(uint type, Transform parent)
	{
		return null;
	}

	private void RefreshRewardPool()
	{
	}

	private void RefreshGuaranteedDrop()
	{
	}

	private void SetOutstand(int idx, UIRM26TWGachaItemViewStage stage, float alpha = 1f)
	{
	}

	private void SetSingleOutstand(int idx, UIRM26TWGachaItemViewStage stage, float alpha = 1f)
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

	private void SwitchState(UnlimitedChestViewState state, bool needSkipAnim = false, bool needSkipKillNotify = false)
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

	private void OpenRM26TWRewardWnd(UIModelGacha.GachaDrawType dType, UIGachaBuyBtnController.BuyBtnState state, bool enableAnim)
	{
	}

	private void RefreshRM26TWRewardInfo(CommonRewardItemInfo rewardInfo)
	{
	}

	private void PutRM26TWBigPrizeToCenter(List<CommonRewardItemInfo> rewardInfoList, ref CommonRewardItemInfo extraRewardInfo)
	{
	}

	private int GetRM26TWRewardCenterIndex(int rewardCount)
	{
		return 0;
	}

	private void SetRM26TWRewardWndBuyAgain(UIRM26_TW_GachaRewardWndController ctrl, GachaDesc gachaDesc, UIModelGacha.GachaDrawType dType, UIGachaBuyBtnController.BuyBtnState state)
	{
	}

	private string GetRM26TWRepurchaseBtnName(GachaDesc gachaDesc, UIModelGacha.GachaDrawType dType, uint repurchaseNum)
	{
		return null;
	}

	private bool HasRM26TWBigPrize(List<CommonRewardItemInfo> rewardInfoList, CommonRewardItemInfo extraRewardInfo)
	{
		return false;
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

	private void PlayDropBoxAnim(GachaResultInfo info)
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

	private IEnumerator IEDestroyAnimation()
	{
		return null;
	}

	public void RefreshLuckySpinBtn()
	{
	}

	public void OpenRewardWnd()
	{
	}

	private void _003CShowExchangeGuide_003Eb__61_1()
	{
	}

	private void _003CUpdate_003Eb__66_0()
	{
	}

	private void _003CRefreshCDN_003Eb__78_0()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__84_0()
	{
	}

	private void _003COnAvatarFinishChangeClothAnim_003Eb__88_0()
	{
	}

	private void _003COnWeaponSkinFinishAnim_003Eb__90_0()
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

	public void _003C_003EiFixBaseProxy_OnShowContent(bool P0)
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
