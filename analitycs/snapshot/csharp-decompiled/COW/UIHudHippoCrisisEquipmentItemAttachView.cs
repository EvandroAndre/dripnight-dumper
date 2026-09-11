using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisEquipmentItemAttachView : UIBaseView
{
	public UIHippoCrisisDragResponseContainer ResponseContainer;

	public UIHudHippoCrisisDragDropItem DragDropItem;

	public BoxCollider ResponseContainerBox;

	public UIButton ClickBtn;

	public UISprite DragIcon;

	public UISprite ItemIcon;

	public UIColor QualityBg;

	public GameObject NotEmpty;

	public GameObject Empty;

	public GameObject BreathVFX;

	public UISprite LightBG;

	public GameObject Selected;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
