using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAskPurchaseItemController : UIEasyListItemController
{
	private UIHudAskPurchaseItemView m_View;

	private AskCSPurchaseInfo m_Info;

	private static Color ENABLE_COLOR;

	private static Color DISABLE_COLOR;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetUIData(AskCSPurchaseInfo info)
	{
	}

	private void RefreshLeadarboardTitle()
	{
	}

	private void RefreshPayBtnStatus()
	{
	}

	public void ClearData()
	{
	}

	private void OnClickPurchaseBtn()
	{
	}

	private void OnCoinChange(int data)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private bool CheckMushroomCanBuy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
