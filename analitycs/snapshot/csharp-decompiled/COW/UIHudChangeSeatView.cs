using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChangeSeatView : UIBaseView
{
	public UIButton Button;

	public GameObject CDMask;

	public UISprite ButtonIcon;

	public UIProgressBar ProgressBarCD;

	public UIProgressBar ProgressConfirmationCD;

	public GameObject ConfirmEffectGO;

	public TweenScale CDTween;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
