using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGachaIchisOverviewPopupWndController : UIPopupWindowController
{
	private UIGachaIchisOverviewPopupWndView m_View;

	private UIModelIchis m_ModelIchis;

	private List<UIGachaIchisOverviewItemController> m_ItemCtrls;

	private bool m_IsRewardVisible;

	private uint m_ChestId;

	private uint m_ChestSubId;

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

	public void SetChestIds(uint chestId, uint chestSubId)
	{
	}

	private void OnClose()
	{
	}

	private void OnToggleRewardBtnClick()
	{
	}

	public void RefreshUI()
	{
	}

	private void RefreshPoolNumLabel()
	{
	}

	private List<IchisOverviewTierData> BuildTierData()
	{
		return null;
	}

	private void ClearItems()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
