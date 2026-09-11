using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInventoryItemView : UIBaseView
{
	public UIToggle ItemToggle;

	public UIInventoryItemDragDropContainer DragDropContainer;

	public UIInventoryItemDrapDrop DragDropItem;

	public GameObject NonDragGO;

	public UILabel ItemName;

	public UILabel ItemCount;

	public UISprite SpriteBg;

	public GameObject OpBtnGO;

	public UIButton OpBtn;

	public GameObject HighlightGO;

	public UISprite ItemIcon;

	public GameObject DragGO;

	public UISprite ItemDragIcon;

	public GameObject DeleteMask;

	public Animation FXUIGuideBoxEffect;

	public UISprite CustomBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
