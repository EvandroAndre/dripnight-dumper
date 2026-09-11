using GCommon;

namespace COW;

public class UIMultiPopMenuItemController : UIPopMenuItemBaseController
{
	private UIMultiPopMenuItemView m_View;

	private PopMenuData m_Data;

	private MultiPopMenuItemVO m_VO;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
	{
	}

	public void SetDisableState(bool CanSelect)
	{
	}

	public void SetSelectedState(bool selected)
	{
	}

	private void OnPopMenuItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetItemData(PopMenuData P0, int P1, int P2)
	{
	}
}
