using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentTabItemController : UIBaseController, ITipsDelegate
{
	private static Color selectArrowColor;

	private static Color unselectArrowColor;

	private UIPaymentTabItemView m_View;

	private List<UIPaymentSubTabItemController> m_SubTabList;

	private bool m_IsFolded;

	private bool m_IsSelected;

	private UIPaymentController.Tab m_Tab;

	private UIPaymentController.TabInfo m_TabInfo;

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

	public void SetData(UIPaymentController.Tab tab, UIPaymentController.TabInfo info)
	{
	}

	private void CreateSubTab(UIPaymentController.Tab tab)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void SelectSubTab(int subTabIndex)
	{
	}

	private void SetRedDot(ETipsType type, int num)
	{
	}

	private void OnButtonClick()
	{
	}

	private void RefreshSubTabView()
	{
	}

	private void OnTabUnSelected()
	{
	}

	void ITipsDelegate.OnTipsDataChange(ETipsType type, int num)
	{
	}

	public void OnSubTabClick(int subIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
