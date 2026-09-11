using GCommon;
using UnityEngine;

namespace COW;

public class UIReplayNodeView : UIBaseView
{
	public GameObject UIReplayNode;

	public GameObject ReplayContent;

	public UIEasyList ReplayList;

	public GameObject ReplayEmpty;

	public UIToggleButtonGroup SaveToggleBtnGroup;

	public UIToggleButton All;

	public UIToggleButton Saved;

	public UIToggleButton Unsaved;

	public UIToggleButtonGroup ReplayToggleBtnGroup;

	public UIToggleButton BtnOn;

	public UIToggleButton BtnOff;

	public UIButton BtnTips;

	public UILabel LblMemory;

	public UISprite IconMemory;

	public UISprite IconReplayMemory;

	public GameObject PopMenu;

	public UIButton EnableUploadBtn;

	public UIButton DebugReplayUploadBtn;

	public UIButton CannotUploadBtn;

	public GameObject HightLightNode;

	public UICheckboxButton HighLightCheckboxBtn;

	public UILabel HighLightLabel;

	public GameObject SearchNoFoundNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
