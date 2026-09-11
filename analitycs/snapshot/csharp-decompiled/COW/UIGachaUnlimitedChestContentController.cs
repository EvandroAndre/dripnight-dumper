using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaUnlimitedChestContentController : UIGachaContentBase, ILuckySpinContent
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

		public static EventDelegate.Callback _003C_003E9__57_0;

		public static EventDelegate.Callback _003C_003E9__60_0;

		internal void _003CShowCouponGuide_003Eb__57_0()
		{
		}

		internal void _003CShowExchangeGuide_003Eb__60_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public UIGachaUnlimitedChestContentController _003C_003E4__this;

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

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public UIGachaUnlimitedChestContentController _003C_003E4__this;

		public UINetworkTexture netTexture;

		internal void _003CSetCDNTexture_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public ulong curTimeStamp;

		internal bool _003CRefreshInfoCDN_003Eb__0(AdvertDesc item)
		{
			return false;
		}
	}

	private sealed class _003CCoShowCouponGuide_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaUnlimitedChestContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowCouponGuide_003Ed__56(int _003C_003E1__state)
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

	private sealed class _003CIEDestroyAnimation_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaUnlimitedChestContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEDestroyAnimation_003Ed__126(int _003C_003E1__state)
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

	private sealed class _003CIEShowItemPreview_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseItemInfo item;

		public UIGachaUnlimitedChestContentController _003C_003E4__this;

		public bool needSkipAnim;

		public bool needSkipKillNotify;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEShowItemPreview_003Ed__118(int _003C_003E1__state)
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

	private sealed class _003CInitInfoCDN_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaUnlimitedChestContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitInfoCDN_003Ed__80(int _003C_003E1__state)
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

	private GachaInfo m_GachaInfo;

	private ClientChestType m_ClientChestType;

	private UIGachaUnlimitedChestContentView m_View;

	private int m_MaxItemCount;

	private List<GachaShowItem> m_ItemList;

	private List<UIGachaUnlimitedChestItemController> m_RewardItemList;

	private int m_ExchangeItemCount;

	private List<UIGachaUnlimitedExchangeItemController> m_ExchangeItemList;

	private HashSet<uint> m_PreviewItemIdSet;

	private List<uint> mExchangeToken;

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

	private void SetExchangeBtnText()
	{
	}

	private void RefreshProbabilityTipsLabel()
	{
	}

	private void RefreshNewBieTipsLabel()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void OnRareProbabilityClick()
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

	private UIGachaUnlimitedChestItemController GetChestItemController(uint type, Transform parent)
	{
		return null;
	}

	private void RefreshRewardPool()
	{
	}

	private void RefreshGuaranteedDrop()
	{
	}

	private void SetOutstand(int idx, UIGachaUnlimitedChestItemController.ViewStage stage, float alpha = 1f)
	{
	}

	private void SetSingleOutstand(int idx, UIGachaUnlimitedChestItemController.ViewStage stage, float alpha = 1f)
	{
	}

	private void InitExchangeList()
	{
	}

	private void RefreshExtraRewardList(bool needAnim = false)
	{
	}

	public void SetExchangeInfo(bool needAnim)
	{
	}

	private void SetExchangeTokenInfo(bool needAnim, UISprite tokenIcon, UILabel tokenLabel, int tokenIndex)
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

	private void _003CShowExchangeGuide_003Eb__60_1()
	{
	}

	private void _003CUpdate_003Eb__65_0()
	{
	}

	private void _003CRefreshCDN_003Eb__77_0()
	{
	}

	private void _003CRefreshCDN_003Eb__77_1()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__85_0()
	{
	}

	private void _003COnAvatarFinishChangeClothAnim_003Eb__90_0()
	{
	}

	private void _003COnWeaponSkinFinishAnim_003Eb__92_0()
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
