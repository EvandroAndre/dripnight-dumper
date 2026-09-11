using GCommon;

namespace COW;

public class UIPopMenuItemController : UIBaseController
{
	private UIPopMenuItemView m_View;

	private PopMenuData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot)
	{
	}

	private void SetSelectedState(bool selected)
	{
	}

	private void OnPopMenuItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
