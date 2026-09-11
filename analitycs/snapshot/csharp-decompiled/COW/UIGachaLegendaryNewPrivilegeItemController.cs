using GCommon;
using proto;

namespace COW;

public class UIGachaLegendaryNewPrivilegeItemController : UIBaseController
{
	private UIGachaLegendaryNewPrivilegeItemView m_View;

	private uint m_LegendClothId;

	private LegendClothPrivilege m_Data;

	private UIGachalegendaryNewContentController.ExtendedGachaPrivilege m_ExtendedData;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(LegendClothPrivilege data, uint legendClothId)
	{
	}

	public void SetExtendedViewData(UIGachalegendaryNewContentController.ExtendedGachaPrivilege extendedData, uint legendClothId)
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
