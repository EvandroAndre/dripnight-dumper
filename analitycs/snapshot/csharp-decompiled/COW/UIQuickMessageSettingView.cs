using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessageSettingView : UIBaseView
{
	public UIToggleButton BRModeBtn;

	public UIToggleButton CSModeBtn;

	public UIToggleButton BSModeBtn;

	public UIToggleButton OtherModeBtn;

	public UIButton VoiceGenderBtn;

	public UIButton VoiceGenderTipsBtn;

	public UIButton SwitchBtn;

	public UIButton SaveBtn;

	public GameObject DummyDragItem;

	public GameObject DragItem;

	public GameObject ListMsgPanel;

	public GameObject RouletteMsgPanel;

	public Transform RouletteItem1;

	public Transform RouletteItem2;

	public Transform RouletteItem3;

	public Transform RouletteItem4;

	public Transform RouletteItem5;

	public Transform RouletteItem6;

	public Transform RouletteItem7;

	public Transform RouletteItem8;

	public GameObject DragItemValidStatus;

	public GameObject DragItemInValidStatus;

	public UIQuickMessageDragDropContainer DragDropBGContainer;

	public GameObject SaveBtnEnable;

	public GameObject SaveBtnDisable;

	public UIScrollView ListMsgScrollView;

	public UIPanel ListMsgScrollViewPanel;

	public UIEasyList ListMsgEasyList;

	public UIWidget Middle;

	public UIWidget Right;

	public UIWidget MsgListWidget;

	public UIWidget ListMsgScrollViewAnchorWidget;

	public UIWidget RouletteDragBounds;

	public UIWidget ListMsgDragBounds;

	public UIQuickMessageDragDropContainer DragDropListTopContainer;

	public UIQuickMessageDragDropContainer DragDropListTopContainer2;

	public UIQuickMessageDragDropContainer DragDropListBottomContainer;

	public Animation VocalBtnAnim;

	public Transform MiddleArrow;

	public GameObject DownloadCtrlContainer;

	public UIToggleButton BasicTabBtn;

	public UIToggleButton CustomizationTabBtn;

	public GameObject BasicTabs;

	public GameObject CustomizationTabs;

	public UIEasyList MsgCustomizationTabEasyList;

	public UITable2 MsgCustomizationList;

	public UIScrollView MsgCustomizationScrollView;

	public GameObject CustomizationTabRedTip;

	public UIEasyList MsgBasicTabEasyList;

	public UIScrollView MsgBasicScrollView;

	public UITable2 MsgBasicList;

	public UIScrollView MsgBasicTabScrollView;

	public UIScrollView MsgCustomizationTabScrollView;

	public UIWidget MsgTabWidget;

	public UIWidget Left;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
