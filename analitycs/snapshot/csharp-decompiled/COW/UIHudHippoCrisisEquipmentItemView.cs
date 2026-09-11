using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisEquipmentItemView : UIBaseView
{
	public UISprite ItemIcon;

	public UIColor QuailtyBg;

	public Transform AttachmentContainer;

	public UIHudHippoCrisisDragDropItem Drag;

	public UIWidget DragWidget;

	public UIHippoCrisisDragResponseContainer ResponseContainer;

	public BoxCollider ResponseContainerBox;

	public UIButton ClickBtn;

	public GameObject Empty;

	public GameObject NotEmpty;

	public UISprite DragIcon;

	public GameObject EmptyWarning;

	public GameObject BreathVFX;

	public UISprite LightBG;

	public UISprite EmptyIcon;

	public GameObject Selected;

	public UISprite Red;

	public UILabel DurabilityCount;

	public GameObject DurabilityCountBG;

	public UISprite LevelIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
