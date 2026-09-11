using System;
using GCommon;

namespace COW;

public class UIGachaIchisNormalSwitchPoolKellyWndController : UIPopupWindowController
{
	private const string LOC_KEY_POOL_GOOD = "T_54_ZT_ICHIS59";

	private const string LOC_KEY_NEXT_BOARD = "T_54_ZT_ICHIS65";

	private const string LOC_KEY_GUARANTEE_KEEP = "T_54_ZT_ICHIS66";

	private UIGachaIchisNormalSwitchPoolKellyWndView m_View;

	private UIModelIchis m_ModelIchis;

	private Action m_OnConfirm;

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

	public void SetContentData(uint chestId, uint chestSubId)
	{
	}

	private void SetLabelText(UILabel label, string locKey)
	{
	}

	private void SetLabelVisible(UILabel label, bool visible)
	{
	}

	private void OnConfirmClick()
	{
	}

	private void OnCancelClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
