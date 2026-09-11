using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisiMainWeaponView : UIBaseView
{
	public GameObject UIHudHippoCrisiMainWeapon;

	public UILabel WeaponName;

	public UILabel AmmoNum;

	public UISprite WeaponIcon;

	public Transform Attachment0;

	public GameObject Empty;

	public GameObject NotEmpty;

	public Transform Attachment5;

	public Transform Attachment4;

	public Transform Attachment2;

	public Transform Attachment1;

	public Transform Attachment3;

	public UILabel AmmoLabel;

	public UIColor QualityBg;

	public GameObject Drag;

	public UIWidget DragWidget;

	public UIHudHippoCrisisDragDropItem HippoCrisisDragDropItem;

	public UIHippoCrisisDragResponseContainer ResponseContainer;

	public BoxCollider ResponseContainerBox;

	public UIButton ClickBtn;

	public GameObject Selected;

	public UISprite DragIcon;

	public UISprite EmptyWarning;

	public UISprite EmptyIcon;

	public GameObject BreathVFX;

	public UISprite LightBG;

	public GameObject Ammo;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
