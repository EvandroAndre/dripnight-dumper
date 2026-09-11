using GCommon;
using UnityEngine;

namespace COW;

public class UINewAutoPickUpSettingView : UIBaseView
{
	public UIButton SettingTypeHelpBtn;

	public UIGrid UIGridSettingTypeTitleGrid;

	public UIToggleButtonGroup UIToggleButtonGroupSettingTypeTitleGrid;

	public UIToggleButton SettingTypeTitleToggleButton;

	public UIScrollView SettingContainerScrollView;

	public UITable ContentTable;

	public UITable PriorityTable;

	public UITable FreezeTable;

	public Transform CommonSettingContainer;

	public GameObject SeperatorWidget1;

	public UISprite BtnBg;

	public UIWidget DragItem;

	public UIWidget DragBound;

	public UICommonSettingDragDropContainer DragDropBottomContainer;

	public UICommonSettingDragDropContainer DragDropTopContainer;

	public GameObject PickUpSeed;

	public UIPanel DragItemPanel;

	public UIWidget GuideWidget;

	public Transform SettingTypeBtnSelected;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
