using GCommon;
using UnityEngine;

namespace COW;

public class UIHudObserverReviveMissionView : UIBaseView
{
	public UISlider Progress;

	public UITable TagRoot;

	public GameObject ReviveMissionTipsLabel;

	public UIEventListener IconRoot;

	public TweenPositionArcWithScaleAndAlpha FlyVfx;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
