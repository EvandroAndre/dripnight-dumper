using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyWeaponSlotView : UIBaseView
{
	public UIButton SlotButton;

	public WeaponRackDragDropItem DragDropItem;

	public UIButton DeleteButton;

	public GameObject GunRoot;

	public UISprite GunIcon;

	public GameObject GrenadeRoot;

	public UISprite GrenadeIcon;

	public GameObject Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
