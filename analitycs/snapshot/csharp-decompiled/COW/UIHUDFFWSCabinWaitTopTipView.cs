using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDFFWSCabinWaitTopTipView : UIBaseView
{
	public GameObject MatchMakingContainer;

	public UIWidget ContainerWidget;

	public UIPanel UIHUDFFWSCabinWaitTopTip;

	public GameObject IconFlyRoot;

	public UISprite FlagIcon;

	public EffectMovement FlyIcon;

	public UISprite FlyIconSprite;

	public TweenScale FlyIconTween;

	public VFXCreateHelper VfxRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
