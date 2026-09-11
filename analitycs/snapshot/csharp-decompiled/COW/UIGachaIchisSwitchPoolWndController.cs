using System;
using GCommon;

namespace COW;

public class UIGachaIchisSwitchPoolWndController : UIPopupWindowController
{
	private UIGachaIchisSwitchPoolWndView m_View;

	private UIModelIchis m_ModelIchis;

	private UIGachaIchisNormalTableController m_TableCtrl;

	private Action m_OnConfirm;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private uint m_JackPot;

	private bool m_HasPreviewData;

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

	public void SetConfirmCallback(Action callback)
	{
	}

	public void SetPoolPreviewData(uint chestId, uint chestSubId, uint jackPot)
	{
	}

	private void OnConfirmClick()
	{
	}

	private void OnCancelClick()
	{
	}

	private void RefreshPoolPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
