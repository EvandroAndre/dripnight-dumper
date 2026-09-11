using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaTurntableContent : UIGachaContentBase
{
	private enum CircleStage
	{
		NORMAL_RUNNING,
		GET_REWARD,
		END
	}

	private class RewardIdx
	{
		public int idx;

		public int iterationIdx;
	}

	private class RateCurve
	{
		public float a;

		public int powers;

		public float endY;
	}

	private class PropsUI
	{
		public UIEventListener eventListener;

		public UISprite icon;

		public UILabel count;

		public void SetActive(bool value)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GachaShowItem> _003C_003E9__38_0;

		public static Action _003C_003E9__44_0;

		internal bool _003COnRefreshUIView_003Eb__38_0(GachaShowItem e)
		{
			return false;
		}

		internal void _003CShowExchangeResultWnd_003Eb__44_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public CSSharedItemData itemData;

		internal void _003COnRefreshUIView_003Eb__1(GameObject e)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public List<ItemTagInfo> launchTagItems;

		internal CommonRewardItemInfo _003CShowExchangeResultWnd_003Eb__1(ExchangedAward item)
		{
			return null;
		}
	}

	private UIGachaTurntableContentView m_View;

	private List<RewardIdx> m_RewardIdxList;

	private List<GameObject> m_ItemPosList;

	private List<UIGachaTurntableItemController> m_ItemCtrlList;

	private List<UIGachaExtraListItemController> m_ExtraList;

	private int m_CurRewardIdx;

	private int m_IterationCounter;

	private uint m_CircleDC;

	private bool m_IsSingleCircle;

	private bool m_IsSkip;

	private const int FAKE_CIRCLE_CNT = 3;

	private const int TURNTABLE_REWARD_CNT = 12;

	private const float GET_REWARD_SHOW_SECOND = 1f;

	private const float FAST_ROUND_CD_SECOND = 0.05f;

	private UICountDownController m_CountDownCtrl;

	private RateCurve m_Curve;

	private List<PropsUI> m_PropsUIs;

	private float m_ItemAnimCheckTime;

	private int m_NextItemIndex;

	private bool m_CanPlayItemAnim;

	private int m_ItemAnimInterval;

	public bool IsSkip
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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnShowContent()
	{
	}

	private void Update()
	{
	}

	private void ResetItemAnim()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	private void ProcessAnimEvt(object[] data)
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

	private void RefreshCountDownLabel()
	{
	}

	private void ShowExchangeResultWnd(object[] data)
	{
	}

	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public override void OnSkipAnim()
	{
	}

	public void Circle(GachaResultInfo info)
	{
	}

	private void AssembleTurntable()
	{
	}

	private void ShowExtraPreviewWnd(object[] data)
	{
	}

	private void RefreshExtraRewardList(uint chestID)
	{
	}

	private void GenRewardIndexList(GachaResultInfo info)
	{
	}

	private int RandomFindIdx(ExchangedAward award)
	{
		return 0;
	}

	private void BuildFirstLapRateCurve()
	{
	}

	private float RateSample(int curIterationCounter)
	{
		return 0f;
	}

	private float RateCelling(float rate)
	{
		return 0f;
	}

	private void DoCircle()
	{
	}

	private void SetOutstand(int idx, UIGachaTurntableItemController.ViewStage stage)
	{
	}

	private CircleStage GetCircleStage(int curIterationCounter)
	{
		return CircleStage.NORMAL_RUNNING;
	}

	private void Reset()
	{
	}

	private void ShowResultView()
	{
	}

	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	private void OnHatchingDoorClick()
	{
	}

	private void OnRareProbabilityClick()
	{
	}

	private void ShowRareProbabilityTips(object[] param)
	{
	}

	private void EnableInterfaceMask(bool v)
	{
	}

	private bool IsInFirstCircle(int curIdx)
	{
		return false;
	}

	private void PlayTurntableShowSound()
	{
	}

	private void DEBUG_ID(GachaResultInfo info)
	{
	}

	private void DEBUG_IDX()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__43_0()
	{
	}

	private void _003CShowResultView_003Eb__61_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
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

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}
}
