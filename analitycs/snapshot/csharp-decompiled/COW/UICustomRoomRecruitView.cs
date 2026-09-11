using GCommon;
using UnityEngine;

namespace COW;

public class UICustomRoomRecruitView : UIBaseView
{
	public UIButton RecruitBtn;

	public GameObject ExtraSendContainer;

	public GameObject SendToLabel;

	public UITable SendToTable;

	public UIToggle WorldToggle;

	public UIWidget WorldWidget;

	public UIToggle ClanToggle;

	public UIWidget ClanWidget;

	public GameObject ContentTable;

	public GameObject RightBottomButtonContainer;

	public UILabel WorldLabel;

	public UIButton StopRecruitBtn;

	public UILabel GameModeLabel;

	public UILabel GroupModeLabel;

	public UILabel MapNameLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
