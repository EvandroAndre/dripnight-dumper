using GCommon;
using UnityEngine;

namespace COW;

public class UICommonSettingDragableItemView : UIBaseView
{
	public UILabel LeftLabel;

	public UITable MenuItemTable;

	public UIToggle ExpandToggleBtn;

	public GameObject FoldedArrow;

	public GameObject UnfoldedArrow;

	public UIButton TipBtn;

	public UICommonSettingDragDropContainer DragDropContainer;

	public UICommonSettingDragDropItem DragDropItem;

	public BoxCollider DragCollider;

	public UIWidget Widget;

	public UIToggleButtonGroup ToggleGroup;

	public CommonSettingToggleItem ToggleContainer1;

	public CommonSettingToggleItem ToggleContainer2;

	public UIWidget WidgetBounds;

	public UICommonSettingDragDropItem DragDropBtn;

	public GameObject DraggingHighLight;

	public GameObject DownHighLight;

	public GameObject UpHighLight;

	public UIWidget DragItem;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
