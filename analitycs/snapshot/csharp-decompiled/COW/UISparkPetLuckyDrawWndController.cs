using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISparkPetLuckyDrawWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SparkGachaPoolRewardInfo> _003C_003E9__16_0;

		public static Comparison<SparkGachaPoolRewardInfo> _003C_003E9__31_0;

		internal int _003CRefreshView_003Eb__16_0(SparkGachaPoolRewardInfo x, SparkGachaPoolRewardInfo y)
		{
			return 0;
		}

		internal int _003CSyncRewardListDataFromModel_003Eb__31_0(SparkGachaPoolRewardInfo x, SparkGachaPoolRewardInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public bool scrollFinished;

		internal void _003CPlayDrawAnimation_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UISparkPetLuckyDrawWndController _003C_003E4__this;

		public SparkGachaPoolRewardInfo reward;

		internal void _003CShowCommonRewardWnd_003Eb__0()
		{
		}
	}

	private sealed class _003CPlayDrawAnimation_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISparkPetLuckyDrawWndController _003C_003E4__this;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		private float _003CscrollMaxDuration_003E5__2;

		private float _003CscrollStartTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayDrawAnimation_003Ed__27(int _003C_003E1__state)
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

	private UISparkPetLuckyDrawWndView m_View;

	private UIModelSparkPet m_ModelSparkPet;

	private List<SparkGachaPoolRewardInfo> m_RewardList;

	private Coroutine m_DrawAnimationCoroutine;

	private bool m_IsDrawAnimating;

	private bool m_DrawResultReceived;

	private bool m_DrawResultSuccess;

	private bool m_IsMockDraw;

	private SparkGachaPoolRewardInfo m_DrawReward;

	private ExchangeChangeData m_DrawRewards;

	private const int LUCKY_DRAW_POPUP_MIN_DEPTH = 70;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void RefreshView(bool resetScroll = false)
	{
	}

	private void RefreshNonListView(bool refreshDrawButtonState)
	{
	}

	private void RefreshDrawButtonState(SparkGachaPoolInfo poolInfo)
	{
	}

	private void OnDrawBtnClick()
	{
	}

	private void OnDrawBtnDisableClick()
	{
	}

	private void StartDrawAnimation(bool isMock)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void HideAllRewardHighlights()
	{
	}

	private IEnumerator PlayDrawAnimation()
	{
		return null;
	}

	private bool ScrollToRewardItem(SparkGachaPoolRewardInfo reward, float maxDuration, Action onFinished)
	{
		return false;
	}

	private UISparkPetLuckDrawItemController GetRewardItemController(SparkGachaPoolRewardInfo reward)
	{
		return null;
	}

	private int GetRewardIndex(SparkGachaPoolRewardInfo reward)
	{
		return 0;
	}

	private void SyncRewardListDataFromModel()
	{
	}

	private void ShowCommonRewardWnd(SparkGachaPoolRewardInfo reward, ExchangeChangeData rewards)
	{
	}

	private List<CommonRewardItemInfo> BuildRewardInfoList(SparkGachaPoolRewardInfo reward, ExchangeChangeData rewards)
	{
		return null;
	}

	private void RefreshDrawRewardObtained(SparkGachaPoolRewardInfo reward)
	{
	}

	private void SetDrawButtonBusy(bool isBusy)
	{
	}

	private void ClearDrawEffects()
	{
	}

	private SparkGachaPoolInfo GetSparkGachaPoolInfo()
	{
		return null;
	}

	private SparkPetDisplaySettings GetDisplaySettings()
	{
		return null;
	}

	private float GetLuckyDrawWinningVfxDuration()
	{
		return 0f;
	}

	private float GetLuckyDrawHighlightVfxDuration()
	{
		return 0f;
	}

	private float GetLuckyDrawPrizeScrollSpringStrength()
	{
		return 0f;
	}

	private float GetLuckyDrawPrizeScrollMaxDuration()
	{
		return 0f;
	}

	private void ShowDrawFailedTips()
	{
	}

	private void MockDrawAnimationResult()
	{
	}

	private void StopDrawAnimationCoroutine()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
