using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInventoryEquipSlotItemView : UIBaseView
{
	public UIToggle ItemToggle;

	public UIInventoryItemDragDropContainer DragDropContainer;

	public UIInventoryItemDrapDrop DragDropItem;

	public GameObject NonDragGO;

	public UISprite ItemLevelInfo;

	public UISprite ItemIcon;

	public UILabel ItemName;

	public UILabel ItemCount;

	public UISprite CountBG;

	public GameObject HighlightGO;

	public GameObject Attachment;

	public GameObject slotEmptyBG;

	public UIToggle BtnSlot;

	public UIWidget BtnSlotCol;

	public Transform attSlot;

	public GameObject DragGO;

	public UISprite ItemDragIcon;

	public GameObject DeleteMask;

	public UISprite Red;

	public UISprite ExtraItemDragIcon1;

	public UISprite ExtraItemDragIcon2;

	public UISprite SpecialItemBG;

	public UISprite TechDeviceBG;

	public GameObject DurationLock;

	public UISprite BorderLeft;

	public UISprite BorderRight;

	public GameObject BorderTop;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
