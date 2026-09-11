using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopItemDescView : UIBaseView
{
	public UILabel DescItemName;

	public UILabel ItemType;

	public UITable TagTable;

	public UITable PropertyTable;

	public UITable DescDetailTable;

	public UILabel DescItemInfo;

	public UIButton CloseBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
