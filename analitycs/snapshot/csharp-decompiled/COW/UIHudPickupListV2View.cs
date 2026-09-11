using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPickupListV2View : UIBaseView
{
	public UIScrollView InventoryTrashScrollview;

	public UIGrid InventoryTrashItemListGrid;

	public Transform InventoryTrashItemListGridTF;

	public Transform CustomNode;

	public UIScrollView ScrollViewRoot;

	public UISprite Mask;

	public UISprite WeaponIcon;

	public GameObject WeaponNormalBG;

	public GameObject WeaponUpdateBG;

	public UISprite WeaponUpdateTriangleBG;

	public UISprite WeaponUpdateColorBG;

	public UIEasyList Grid;

	public UISprite MaskFullRegion;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
