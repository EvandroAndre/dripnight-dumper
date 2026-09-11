using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDGGProgressBarView : UIBaseView
{
	public UILabel TimeLabel;

	public UIProgressBar MyBar;

	public UISprite MyBarValue;

	public UIProgressBar TargetBar;

	public UISprite TargetBarValue;

	public Transform MyThump;

	public Transform TargetThump;

	public UILabel TargetThumpLabel;

	public Transform WarningThump;

	public UIWidget TutorialWidget;

	public UILabel MyRankLable;

	public GameObject MyThunmLighEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
