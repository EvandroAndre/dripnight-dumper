using GCommon;

namespace COW;

public class UIPopMenuItemBaseController : UIBaseController
{
	public uint ItemIdex;

	public virtual void SetItemData(PopMenuData data)
	{
	}

	public virtual void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
	{
	}

	public virtual void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot)
	{
	}
}
