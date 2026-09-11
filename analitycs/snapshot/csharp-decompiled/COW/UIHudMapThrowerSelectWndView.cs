using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapThrowerSelectWndView : UIBaseView
{
	public UISprite Item1Icon;

	public UIButton Item1Btn;

	public UISprite Item2Icon;

	public UIButton Item2Btn;

	public UISprite Item3Icon;

	public UIButton Item3Btn;

	public GameObject Item1;

	public GameObject Item2;

	public GameObject Item3;

	public Animation main;

	public UIWidget Item_All;

	public UIMapThrowerSelectWndDragDropItem DragDropItem;

	public UIWidget mainWidget;

	public GameObject PointIcon;

	public Transform UIFXContainer;

	public UISprite PointItemIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
