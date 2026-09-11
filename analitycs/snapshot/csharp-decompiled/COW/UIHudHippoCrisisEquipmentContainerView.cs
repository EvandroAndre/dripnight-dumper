using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisEquipmentContainerView : UIBaseView
{
	public Transform EquipmentContainer;

	public GameObject BackpackAndSafeBoxContainer;

	public UIButton CloseMask;

	public Transform ItemBriefBoxRoot;

	public GameObject bg_OnlyEquip;

	public GameObject bg_EquipAndBackpack;

	public GameObject TrashPanel;

	public UIHippoCrisisDragResponseContainer DropDragAll;

	public UIWidget DropDragAllWidget;

	public UISprite DropDragAllHover;

	public UISprite DropDragAllNormal;

	public UIHippoCrisisDragResponseContainer DropDragLeft;

	public UIWidget DropDragLeftWidget;

	public UILabel DropNumLabel;

	public UISprite DropDragLeftHover;

	public UISprite PartialAllScrollBar;

	public UISprite DropDragLeftNormal;

	public UIHippoCrisisDragResponseContainer DropDragRight;

	public UIWidget DropDragRightWidget;

	public UISprite DropDragRightHover;

	public UISprite DropDragRightHover_R;

	public UISprite DropDragRightNormal;

	public UISprite DropDragRightNormal_R;

	public GameObject PartialAllScrollCon;

	public UISprite PartialAllLine;

	public GameObject ParticalAllLineCon;

	public GameObject PartialLine1;

	public GameObject PartialLine5;

	public UIWidget GuideWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
