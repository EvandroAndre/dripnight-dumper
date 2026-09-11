using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPopMenuController : UIBaseController
{
	private UIPopMenuView m_View;

	public PopMenuDelegate onPopMenuClose;

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

	public void SetPopMenu(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot)
	{
	}

	public void SetCustomizePopMenu<T>(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, bool showBg = true, bool showCustomizedBg = true, bool setSize = false) where T : UIPopMenuItemBaseController
	{
	}

	private void UpdateViewUI()
	{
	}

	public void SetPopMenuDepth(int d)
	{
	}

	private void OnMaskClick()
	{
	}

	private void OnClickeMenuItem(object[] data)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void DisableMask()
	{
	}

	public void ResetMutilPopMenuItemState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
