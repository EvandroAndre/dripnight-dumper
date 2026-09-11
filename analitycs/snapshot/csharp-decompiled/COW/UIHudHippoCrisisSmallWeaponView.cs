using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisSmallWeaponView : UIBaseView
{
	public UIWidget DragWidget;

	public UIHudHippoCrisisDragDropItem HippoCrisisDragDropItem;

	public GameObject Drag;

	public UIHippoCrisisDragResponseContainer ResponseContainer;

	public BoxCollider ResponseContainerBox;

	public UIButton ClickBtn;

	public GameObject Empty;

	public GameObject NotEmpty;

	public UISprite EmptyIcon;

	public UISprite WeaponIcon;

	public UIColor QuailtyBg;

	public UISprite DragIcon;

	public UISprite AmmoIcon;

	public UILabel AmmoLabel;

	public UISprite EmptyWarning;

	public GameObject BreathVFX;

	public UISprite LightBG;

	public GameObject Selected;

	public GameObject Ammo;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
