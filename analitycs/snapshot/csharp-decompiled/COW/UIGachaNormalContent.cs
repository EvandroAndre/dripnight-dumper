using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaNormalContent : UIGachaContentBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__28_0;

		internal void _003CShowExchangeResultWnd_003Eb__28_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public List<ItemTagInfo> launchTagItems;

		internal CommonRewardItemInfo _003CShowExchangeResultWnd_003Eb__1(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003CIEDestroyAnimation_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaNormalContent _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEDestroyAnimation_003Ed__49(int _003C_003E1__state)
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

	private UIGachaNormalContentView m_View;

	private List<UIGachaExtraListItemController> m_ExtraList;

	private List<UIGachaADItemController> m_AdList;

	private UIGachaPreviewController m_RewardPoolCtrl;

	private bool m_IsOpenRewardPool;

	private GameObject m_DrawAnimation;

	private ClientChestType m_ClientChestType;

	private GachaInfo m_GachaInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	protected override void OnCloseRewardPanel()
	{
	}

	private void OnClickLotteryMachineEvt(object[] data)
	{
	}

	private void OnClickLotteryMachine()
	{
	}

	public override void CloseRewardPool()
	{
	}

	private void OnRewardPoolOpen()
	{
	}

	private void OnRewardPoolClose(object[] data)
	{
	}

	protected override void OnNavigationToGachaReward(uint itemId)
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

	public override void OnSkipAnim()
	{
	}

	public override void OnPurchaseResult(bool isSuccess, bool isRepurchase)
	{
	}

	private void SetextraAwardActive(bool enable)
	{
	}

	private void ShowExchangeResultWnd(object[] data)
	{
	}

	private void CheckLuckyPointReset(bool showResetTips)
	{
	}

	private void OnWeaponCgUIShow(object[] data)
	{
	}

	private void OnWeaponCgUIHide(object[] data)
	{
	}

	private void OnLuckyPointClick()
	{
	}

	public void RefreshExtraRewardList(uint chestID)
	{
	}

	private void RefreshEnergyPoint(bool needAnim = false)
	{
	}

	private void ShowExtraPreviewWnd(object[] data)
	{
	}

	public override void OnShowContent()
	{
	}

	public override void OnShowContent(bool needSkipAnim)
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	public void RefreshCDNView()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	private UICommonRewardWndController.WndStyleEnum GetRewardStyle(GachaResultInfo resultInfo, UIModelGacha.GachaDrawType darwType)
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	private void BeginPlayDrawAnim(bool isRepurchase)
	{
	}

	private void ShowResult(bool showAnime)
	{
	}

	private void PlayDropBoxAnim()
	{
	}

	private void EndPlayDrawAnim()
	{
	}

	private void TryStopAnimation(string evt)
	{
	}

	public void ClearCache()
	{
	}

	private IEnumerator IEDestroyAnimation()
	{
		return null;
	}

	private void _003CRefreshCountDownLabel_003Eb__38_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnCloseRewardPanel()
	{
	}

	public void _003C_003EiFixBaseProxy_CloseRewardPool()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationToGachaReward(uint P0)
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

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent(bool P0)
	{
	}
}
