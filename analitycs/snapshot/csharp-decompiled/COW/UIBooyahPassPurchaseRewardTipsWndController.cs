using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIBooyahPassPurchaseRewardTipsWndController : UIPopupWindowController, IEasyList
{
	private UIBooyahPassPurchaseRewardTipsWndView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private const uint PURCHASE_PP_REWARD_SHOW_COUNT = 10u;

	public ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	private void RefreshView()
	{
	}

	public bool CheckSequenceEqual(List<BaseItemInfo> imediateBaseItemInfoList, List<BaseItemInfo> futureBaseItemInfoList)
	{
		return false;
	}

	public void SetViewData()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnPurchaseClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
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
