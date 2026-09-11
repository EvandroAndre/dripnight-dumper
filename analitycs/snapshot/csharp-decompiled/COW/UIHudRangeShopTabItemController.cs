using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRangeShopTabItemController : UIEasyListItemController
{
	private enum RangeShopTabId
	{
		Weapon = 1,
		GunPart,
		Tool,
		Skill,
		NBSkill
	}

	private UIHudRangeShopTabItemView m_View;

	private GEBFHCDMEDA m_Catagory;

	private Color normalIconCol;

	private Color hlIconCol;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void _003CSetViewData_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
