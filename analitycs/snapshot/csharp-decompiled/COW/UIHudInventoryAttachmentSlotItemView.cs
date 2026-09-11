using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInventoryAttachmentSlotItemView : UIBaseView
{
	public UIToggle ItemToggle;

	public UIInventoryItemDragDropContainer DragDropContainer;

	public UIInventoryItemDrapDrop DragDropItem;

	public GameObject NonDragGO;

	public UISprite ItemIcon;

	public UILabel ItemLevelInfoLabel;

	public UISprite ItemLevelInfo;

	public UISprite ItemBg;

	public GameObject HighlightGO;

	public UISprite HighlightSprite;

	public GameObject DragGO;

	public UISprite ItemDragIcon;

	public GameObject DeleteMask;

	public UISprite UpdateProgress;

	public GameObject UpdateContainer;

	public GameObject GradeLv1;

	public GameObject GradeLv2;

	public GameObject GradeLv3;

	public UISprite HarmIcon;

	public UISprite QulityBg;

	public UISprite QulityLight;

	public GameObject AwakenIcon;

	public GameObject QualityMark;

	public GameObject QualityMark1;

	public GameObject QualityMark2;

	public GameObject QualityMark3;

	public GameObject CanAwakenIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
