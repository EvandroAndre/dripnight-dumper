using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRangeShopCatagoryItemController : UIEasyListItemController
{
	private UIHudRangeShopCatagoryItemView m_View;

	private GEBFHCDMEDA catagory;

	private Color normalIconCol;

	private Color hlIconCol;

	private Color colorPointBlue;

	private Color colorPointGreen;

	private Color colorPointRed;

	private Color colorPointYellow;

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
