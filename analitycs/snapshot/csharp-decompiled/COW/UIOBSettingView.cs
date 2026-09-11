using GCommon;
using UnityEngine;

namespace COW;

public class UIOBSettingView : UIBaseView
{
	public UIToggleButtonGroup DelayOBEnabled;

	public UIToggleButton DelayOBOn;

	public UIToggleButton DelayOBOff;

	public UIToggleButtonGroup ReplayEnabled;

	public UIToggleButton ReplayOn;

	public UIToggleButton ReplayOff;

	public UIToggleButtonGroup PlayerSightEnabled;

	public UIToggleButton PlayerSightOn;

	public UIToggleButton PlayerSightOff;

	public UIToggleButtonGroup PerspectiveColoring;

	public UIToggleButton StuffedColor;

	public UIToggleButton HollowColor;

	public UIToggleButtonGroup FrameLimit;

	public UIToggleButton UnlimitFrame;

	public UIToggleButton LimitedFrame;

	public UIToggleButtonGroup ErrorTipsEnabled;

	public UIToggleButton ErrorTipsOn;

	public UIToggleButton ErrorTipsOff;

	public UIToggleButtonGroup PerspectiveType;

	public UIToggleButton NormalMode;

	public UIToggleButton TeamMode;

	public UIToggleButtonGroup OpeningCamEnabled;

	public UIToggleButton OpeningCamOn;

	public UIToggleButton OpeningCamOff;

	public UIToggleButtonGroup TeamBillboard;

	public UIToggleButton TeamBillboardOn;

	public UIToggleButton TeamBillboardOff;

	public UIToggleButtonGroup SpHudCsPlayerInfoEnabled;

	public UIToggleButton SpHudCsPlayerInfoOn;

	public UIToggleButton SpHudCsPlayerInfoOff;

	public UILabel MatchIDTxt;

	public UILabel cameraSpeedText;

	public UILabel cameraRotateSpeedText;

	public UIToggleButtonGroup SlideChangeColor;

	public UIToggleButton SlideChangeColorOn;

	public UIToggleButton SlideChangeColorOff;

	public UIToggleButtonGroup InGameFlag;

	public UIToggleButton InGameFlagOn;

	public UIToggleButton InGameFlagOff;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
