using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleCustomView : UIBaseView
{
	public GameObject Top;

	public GameObject TopLeft;

	public GameObject Left;

	public GameObject AdjustContainer;

	public UISlider AlphaSliderBar;

	public UILabel AlphaSliderValue;

	public UISlider SizeSliderBar;

	public UILabel SizeSliderValue;

	public UIButton CancelBtn;

	public UIButton ResetBtn;

	public UIButton ConfirmBtn;

	public GameObject ConfirmEnable;

	public GameObject ConfirmDisable;

	public TweenHeight BGTween;

	public UIButton BtnArrow;

	public GameObject TopRight;

	public GameObject BottomLeft;

	public GameObject BottomRight;

	public GameObject Bottom;

	public CustomHudItem HudVehicleHorn;

	public UIButton SizeUpButton;

	public UIButton SizeRightButton;

	public UIButton SizeDownButton;

	public UIButton SizeLeftButton;

	public Transform TransCaseContainer;

	public Transform TransButtonGrid;

	public Transform ButtonGrid;

	public Transform TransTopPanel;

	public Transform TransMoveableLogo;

	public TweenPosition TweenMoveableLogo;

	public UISprite HighLightCircle;

	public TweenScale TweenCircle;

	public UISprite HighLightSquare;

	public TweenScale TweenSquare;

	public UIWidget WidgetBGCollider;

	public UIGroupWaitingDropItem DropBGCollider;

	public BoxCollider BGCollider;

	public CustomHudItem UIHudVehicleStats;

	public GameObject UIHudTurnRight;

	public GameObject UIHudTurnLeft;

	public GameObject UIHudAccelerator;

	public GameObject UIHudBrake;

	public GameObject HudMovingJoystick;

	public CustomHudItem HudVehicleReset;

	public GameObject UIHudVehicleOverdrive;

	public GameObject UIHudVehicleOverdriveSingleHand;

	public UISprite KillIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
