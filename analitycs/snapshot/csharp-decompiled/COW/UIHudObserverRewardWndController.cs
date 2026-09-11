using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudObserverRewardWndController : UIBaseController
{
	private enum ECoinState
	{
		None,
		BiggerThanDesc,
		SmallerThanDesc,
		NoMoneyToReward
	}

	private UIHudObserverRewardWndView m_View;

	private UIModelFriendObserve m_ModelFriendObserver;

	private ECoinState m_CoinState;

	private SpectateCurrencyRewardDesc m_RewardCoinDesc;

	private ulong m_ReceiveUserID;

	private Color ENOUGH_MONEY_BG_COLOR;

	private Color NO_MONEY_BG_COLOR;

	private Color NO_MONEY_LABEL_COLOR;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitView()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateCoinState()
	{
	}

	private void RefreshView()
	{
	}

	private void BtnRewardOnClick()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(ulong receiveUserID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
