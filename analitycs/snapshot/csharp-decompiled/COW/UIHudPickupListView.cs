using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPickupListView : UIBaseView
{
	public UIScrollView InventoryTrashScrollview;

	public UIGrid InventoryTrashItemListGrid;

	public Transform InventoryTrashItemListGridTF;

	public Transform CustomNode;

	public UIScrollView ScrollViewRoot;

	public UIGrid ItemListGrid;

	public Transform ItemListGridTF;

	public UISprite Mask;

	public UISprite WeaponIcon;

	public GameObject WeaponNormalBG;

	public GameObject WeaponUpdateBG;

	public UISprite WeaponUpdateTriangleBG;

	public UISprite WeaponUpdateColorBG;

	public UISprite MaskFullRegion;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
