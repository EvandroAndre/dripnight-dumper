using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisWeaponSlotItemView : UIBaseView
{
	public UISprite LevelIcon;

	public GameObject NotEmpty;

	public GameObject Empty;

	public UISprite DragIcon;

	public UIHudHippoCrisisDragDropItem DragDropItem;

	public UIHippoCrisisDragResponseContainer ResponseContainer;

	public BoxCollider ResponseContainerBox;

	public UIButton ClickBtn;

	public UISprite ItemIcon;

	public UIColor QualityBg;

	public GameObject BreathVFX;

	public UISprite LightBG;

	public GameObject Selected;

	public GameObject LevelContainer;

	public UILabel SightNum;

	public UISprite EmptyIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
