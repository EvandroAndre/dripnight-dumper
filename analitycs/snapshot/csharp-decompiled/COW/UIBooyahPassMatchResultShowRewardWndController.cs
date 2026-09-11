using GCommon;
using UnityEngine;

namespace COW;

internal class UIBooyahPassMatchResultShowRewardWndController : UIPopupWindowController, IEasyList
{
	private UIBooyahPassMatchResultShowRewardWndView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private uint m_ShowGrade;

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

	public void SetViewData(uint showGrade)
	{
	}

	private void RefreshCurShowView()
	{
	}

	private void RefreshUnlcokView()
	{
	}

	private void RefreshView()
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
