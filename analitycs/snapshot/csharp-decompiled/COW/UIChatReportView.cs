using GCommon;
using UnityEngine;

namespace COW;

public class UIChatReportView : UIBaseView
{
	public UICenterTargetHelper ProfileCenterPoint;

	public UISprite HeadIcon;

	public UILabel Name;

	public UILabel PlayerID;

	public UIToggleButtonGroup ReportReason;

	public UIToggleButton Racial;

	public UIToggleButton Policy;

	public UIToggleButton Cheat;

	public UIToggleButton AD;

	public UIToggleButton Other;

	public UILabel ReportedChat;

	public UIButton CancelBtn;

	public UIButton ReportBtn;

	public GameObject ReportDisable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
