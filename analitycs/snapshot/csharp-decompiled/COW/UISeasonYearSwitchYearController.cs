using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISeasonYearSwitchYearController : UIBaseController
{
	private UISeasonYearSwitchYearView m_View;

	private UIModelSeasonYear m_ModelSeasonYear;

	private List<UISeasonYearSwitchYearItemController> m_YearItemControllers;

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

	private void InitYearToggle()
	{
	}

	private void ClearYearToggleItems()
	{
	}

	public void SetView(uint seasonyearId)
	{
	}

	private void ShowGiftAndCsLabel()
	{
	}

	public void RefreshGiftIcon()
	{
	}

	private void OnSwitchYearSelect(UIToggleButton toggleButton)
	{
	}

	private void ShowGuide()
	{
	}

	public void SetButtonState(bool enable)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
