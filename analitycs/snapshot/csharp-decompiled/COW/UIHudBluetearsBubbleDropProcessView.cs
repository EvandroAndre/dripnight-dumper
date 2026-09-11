using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBluetearsBubbleDropProcessView : UIBaseView
{
	public GameObject UIHudBluetearsBubbleDropProcess;

	public UIWidget BoundsWidget;

	public Transform BubbleSpawnPos;

	public UIHudBluetearsBubbleDropProcessIcon BubbleSpawnIcon;

	public UILabel TimeLabel;

	public GameObject CountDown;

	public GameObject FinishedLabel;

	public UIProgressBar ProgressBar;

	public UISprite ProgressBarFront;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
