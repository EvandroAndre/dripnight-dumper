using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyWeaponRackItemView : UIBaseView
{
	public WeaponRackDragDropItem WeaponRackDragDropItemUILobbyWeaponRackItem;

	public UIDragDropContainer UIDragDropContainerUILobbyWeaponRackItem;

	public UIButton UIButtonUILobbyWeaponRackItem;

	public GameObject GunRoot;

	public UISprite GunIcon;

	public GameObject GrenadeRoot;

	public UISprite GrenadeIcon;

	public GameObject Selected;

	public UISprite OtherIcon;

	public UISprite QualityBg;

	public UISprite QulityLine;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteQualityOrangePlus;

	public GameObject Equiped;

	public GameObject TipsGO;

	public UILabel TagLabel;

	public GameObject DownloadRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
