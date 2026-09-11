using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Playables;
using proto;

namespace COW;

public class UIGachaIIVTWContentController : UIGachaContentBase, ILuckySpinContent
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

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public List<ChestSpecialExchangeDesc> exchangeList;

		public int i;

		public Predicate<ChestSpecialExchangeDesc> _003C_003E9__0;

		internal bool _003CRefreshExtraRewardList_003Eb__0(ChestSpecialExchangeDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public UIGachaIIVTWContentController _003C_003E4__this;

		public bool needSkipAnim;

		public bool needSkipKillNotify;

		internal void _003CDoCircle_003Eb__0()
		{
		}

		internal void _003CDoCircle_003Eb__2()
		{
		}

		internal void _003CDoCircle_003Eb__1()
		{
		}

		internal void _003CDoCircle_003Eb__3()
		{
		}

		internal void _003CDoCircle_003Eb__4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public UIGachaIIVTWContentController _003C_003E4__this;

		public UINetworkTexture netTexture;

		internal void _003CSetCDNTexture_003Eb__0()
		{
		}
	}

	private sealed class _003CPlayLuckyVFX_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaIIVTWContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayLuckyVFX_003Ed__113(int _003C_003E1__state)
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

	private const float CIRCLE_REWARD_DISPLAY_TIME_Quick = 0.00325f;

	private const float CIRCLE_REWARD_DISPLAY_TIME_MIN = 0.05f;

	private const float SELECT_REWARD_DISPLAY_TIME_MAX = 0.4f;

	private const float SELECT_REWARD_DISPLAY_TIME = 0.3f;

	private const float SHOW_REWORD_DELAY = 0.5f;

	private const int FAKE_CIRCLE_CNT = 8;

	private const int QUICK_CIRCLE_CNT_MIN = 2;

	private const float GuaranteedThresholdRate = 0.2f;

	private const int QUICK_CIRCLE_CNT_MAX = 6;

	private const string ForcePlayerWatchAnim = "ForcePlayerWatchRyomenSukunaAnim";

	private const string PlayerWatchAnimDaily = "PlayerWatchRyomenSukunaAnimDaily";

	private int m_ItemCount;

	private GachaInfo m_GachaInfo;

	private ClientChestType m_ClientChestType;

	private UIGachaIIV1_TWIIVContentView m_View;

	private List<GachaShowItem> m_ItemList;

	private List<UIGachaIIVTWItemController> m_RewardItemList;

	private List<UIGachaIIVTWExchangeItemController> m_ExchangeItemList;

	private UIWishListBtnController m_WishListBtnCtrl;

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

	private bool m_NoShowConfirmWnd;

	private bool m_DontClearPreviewItemIdSet;

	private bool m_PauseUpdateDoCircle;

	private bool m_PlayedClothChangeAnim;

	private bool m_MagnifierDefault;

	private UnlimitedChestViewState m_CurrentState;

	private bool m_IsBare;

	private bool m_IsTMLSkipped;

	private bool m_SoundPlayed;

	public const uint OutputBundleId = 710052002u;

	public const string OutputBundleShareCDN = "OB52/CSH/IIVTW/SharePage_1.jpg";

	private const uint RobeFormSetId = 1680u;

	private const uint BareFormSetId = 1714u;

	private const float SkipAnimTime = 4.9f;

	private GameObject m_RyomenSukunaTML;

	private PlayableDirector m_RyomenSukunaTMLPD;

	private GameObject m_FormChangeSound;

	private GameObject m_RyomenSukunaSound;

	private GameObject m_TMLBGEndSound;

	private int m_TMLHalfBGSoundTicket;

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

	private void OnDisable()
	{
	}

	private void DestroyRyomenSukunaTMLBGHalfSound()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnRecoverPreview()
	{
	}

	protected override void OnNavigationToGachaReward(uint itemId)
	{
	}

	public override void OnShowContent()
	{
	}

	private void ResetUI()
	{
	}

	private void PlayRyomenSukunaInAnim()
	{
	}

	private void TryForcePlayerWatchAnim()
	{
	}

	private void DestroyRyomenSukunaTML()
	{
	}

	private void PlayRyomenSukunaTML()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void PreparePuchase()
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

	private void RefreshProbabilityTipsLabel()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void OnPurchasePrepare(object[] param)
	{
	}

	private void OnBooyahPassPreviewSmallItemClick(object[] data)
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private void DestroyRyomenSukunaSound()
	{
	}

	private void DestroyRyomenSukunaTMLEndSound()
	{
	}

	private void DestroyFormChangeSound()
	{
	}

	private void OnRobeFormBtnClick()
	{
	}

	private void OnBareFormBtnClick()
	{
	}

	private void OnSukunaFormsGoPosBtnClick()
	{
	}

	private void OnIPTagGoposBtnClick()
	{
	}

	private void OnReplayBtnClick()
	{
	}

	private void OnMaginifierBtnClick()
	{
	}

	private void OnSkipAnimBtnClick()
	{
	}

	private void SkipRyomenSukunaTML()
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

	private void OnGuaranteedDropBtnClick()
	{
	}

	private void OnClickSelectChestItem(int index, bool force = false)
	{
	}

	private void CheckPreviewGrandPrize(bool grandPrize, bool showIPTag = false)
	{
	}

	private void SelectRoymenSukunaForm()
	{
	}

	private void InitRewardPool()
	{
	}

	private UIGachaIIVTWItemController GetChestItemController(bool grandPrize, Transform parent)
	{
		return null;
	}

	private void RefreshRewardPool()
	{
	}

	private void RefreshGuaranteedDrop()
	{
	}

	private IEnumerator PlayLuckyVFX(uint currentPoint, uint totalPoint)
	{
		return null;
	}

	private void SetOutstand(int idx, UIGachaIIVTWItemController.ViewStage stage, float alpha = 1f)
	{
	}

	private void SetSingleOutstand(int idx, UIGachaIIVTWItemController.ViewStage stage, float alpha = 1f)
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

	private void SwitchState(UnlimitedChestViewState state, bool needSkipAnim = false, bool needSkipKillNotify = false, bool skipAnim = false, bool forcePlay = false)
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	public override void OnPurchaseResult(bool isSuccess, bool isRepurchase)
	{
	}

	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	private bool OnLoopAnimation()
	{
		return false;
	}

	private void DoCircle(bool needSkipAnim = false, bool needSkipKillNotify = false, bool skipAnim = false, bool forcePlay = false)
	{
	}

	private void ShowItemPreview(BaseItemInfo item, bool needSkipAnim = false, bool needSkipKillNotify = false, bool SkipAnim = false, bool forcePlay = false)
	{
	}

	private void UpdateIdle(bool grandPrize)
	{
	}

	private void PlaySpecialIdle()
	{
	}

	private void ForcePlaySpecialIdle()
	{
	}

	private void PlayNormalIdle()
	{
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

	private void PlayRyomenSukunaSound()
	{
	}

	private void OnRyomenSukunaInStart()
	{
	}

	public void TryRyomenSukunaInFinish()
	{
	}

	private void OnRyomenSukunaInFinish()
	{
	}

	private void OnRyomenSukunaUIIn()
	{
	}

	private void PlayTMLFullBGSound()
	{
	}

	private void PlayTMLHalfBGSound()
	{
	}

	private void PlayTMLBGSoundEnd()
	{
	}

	private void OnRyomenSukunaPlayIdle()
	{
	}

	private void HideContent()
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

	private void _003CRefreshCDN_003Eb__83_0()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__87_0()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecoverPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationToGachaReward(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
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
