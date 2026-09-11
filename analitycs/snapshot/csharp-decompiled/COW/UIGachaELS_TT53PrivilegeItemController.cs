using GCommon;
using proto;

namespace COW;

public class UIGachaELS_TT53PrivilegeItemController : UIBaseController
{
	private UIGachaELS_TT53PrivilegeItemView m_View;

	private uint m_LegendClothId;

	private LegendClothPrivilege m_Data;

	private int m_Index;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(LegendClothPrivilege data, uint legendClothId, int index)
	{
	}

	private void OnPrivilegeClick()
	{
	}

	private void SetQualityBG(EInventory.RareType rare)
	{
	}

	private void SetSelected()
	{
	}

	public void SetUnSelected()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
