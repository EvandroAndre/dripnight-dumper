using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILuckyWheelController : UINavigationController, IUIModelDataChangeObserver, IEasyList
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

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public UILuckyWheelController _003C_003E4__this;

		public UISecondConfirmContoller secondConfirmCtrl;

		internal void _003COnRefreshRewardPoolBtnClick_003Eb__0()
		{
		}
	}

	private sealed class _003CIERefreshRewardPool_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILuckyWheelController _003C_003E4__this;

		private List<CSLuckyWheelShopItemDesc> _003CcurrentRewardList_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIERefreshRewardPool_003Ed__72(int _003C_003E1__state)
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

	public const uint CDNSUBTYPETITLE = 1u;

	public const uint CDNSUBTYPEBG = 2u;

	public const uint CDNSUBTYPESHARETITLE = 3u;

	public const uint CDNSUBTYPELOBBYCDNICON = 22u;

	private UILuckyWheelView m_View;

	private UIModelLuckyWheel m_Model;

	private UIModelCDNAd m_CDNModel;

	private UICountDownController m_CountDownCtrl;

	private List<Transform> m_AwardContainerList;

	private List<UILuckWheelRewardPoolItemController> m_RewardPoolItemControllerList;

	private List<UILuckyWheelItemController> m_WheelItemControllerList;

	private List<GameObject> m_GlowObjList;

	public bool NeedResetWheel;

	private bool m_IsRefreshing;

	private bool m_IsInPreview;

	private uint m_DrawBtnDelayCall;

	private uint m_RefreshBtnDelayCall;

	private uint m_RefreshRewardPoolDiscountDelayCall;

	private Coroutine m_RefreshCoroutine;

	private GameObject m_CommonLoadingGO;

	private bool m_DescReady;

	private bool m_InfoReady;

	private bool m_ContentLoaded;

	private RateCurve m_Curve;

	private List<RewardIdx> m_RewardIdxList;

	private int m_CurRewardIdx;

	private int m_IterationCounter;

	private uint m_CircleDC;

	private const int FAKE_CIRCLE_CNT = 2;

	private const int TURNTABLE_REWARD_CNT = 8;

	private const float GET_REWARD_SHOW_SECOND = 1f;

	private const float FAST_ROUND_CD_SECOND = 0.05f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override bool NeedWaitDataReady()
	{
		return false;
	}

	protected override void OnWaitDataReady()
	{
	}

	protected override void OnOnDataReady()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void SetCDNTitle()
	{
	}

	private void SetBGCDN()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshRefreshBtnState()
	{
	}

	private void SetFinishedLuckyWheelView()
	{
	}

	private void RefreshPreviewRewardPoolItem()
	{
	}

	private void RefreshCurrentDiscount()
	{
	}

	private void RefreshDiscountAfterDraw()
	{
	}

	private void ShowRewardPoolDiscount()
	{
	}

	private void InitView()
	{
	}

	private void ResetVfx()
	{
	}

	private void ResetRewardPoolItemVfx()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void SkipAnimation()
	{
	}

	private void InitAwardContainer()
	{
	}

	private void InitItemControllers()
	{
	}

	private void InitGlowObjects()
	{
	}

	private void InitRewardPoolItemControllers()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void RefreshDrawBtnState()
	{
	}

	private void RefreshRightPanelVfx()
	{
	}

	private void RefreshRewardPoolBtnState()
	{
	}

	private void RefreshViewAfterBuyItem()
	{
	}

	private void RefreshRewardPoolItem(bool needRefreshAnim = false)
	{
	}

	private void RefreshWheelItem()
	{
	}

	private void OnDrawBtnClick()
	{
	}

	private void OnRewardPoolBtnClick()
	{
	}

	private void OnRewardPoolPreviewCloseBtnClick()
	{
	}

	private void OnPrperbilityClick()
	{
	}

	private void OnRefreshRewardPoolBtnClick()
	{
	}

	private void SetNoNeedConfirmRefreshRewardPool(bool flag)
	{
	}

	private void RequestRefreshRewardPool()
	{
	}

	private void PlayResetWheelAnimation()
	{
	}

	public void PlayDrawBntHintAnimaation()
	{
	}

	private void ShowResult()
	{
	}

	private void PlayShowDiscountVfx()
	{
	}

	private void PlayDrawResultAnimation()
	{
	}

	private void PlayRefreshRewardPoolVfx()
	{
	}

	private void RefreshTime()
	{
	}

	public void SetCurrentDiscountLabel(CSLuckyWheelDiscountDesc discount)
	{
	}

	private IEnumerator IERefreshRewardPool()
	{
		return null;
	}

	private void ResetAnimation()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void Circle(uint id)
	{
	}

	private void EnableInterfaceMask(bool v)
	{
	}

	private void SetOutstand(int idx, UILuckyWheelItemController.ViewStage stage)
	{
	}

	private void ResetGlowItem()
	{
	}

	private void DoCircle()
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

	private bool IsInFirstCircle(int curIdx)
	{
		return false;
	}

	private CircleStage GetCircleStage(int curIterationCounter)
	{
		return CircleStage.NORMAL_RUNNING;
	}

	private int RandomFindIdx(uint id)
	{
		return 0;
	}

	private void Reset()
	{
	}

	private void GenRewardIndexList(uint id)
	{
	}

	private void BuildFirstLapRateCurve()
	{
	}

	private void _003CSetCDNTitle_003Eb__32_0()
	{
	}

	private void _003COnDrawBtnClick_003Eb__57_0()
	{
	}

	private void _003CRequestRefreshRewardPool_003Eb__63_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnWaitDataReady()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOnDataReady()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
