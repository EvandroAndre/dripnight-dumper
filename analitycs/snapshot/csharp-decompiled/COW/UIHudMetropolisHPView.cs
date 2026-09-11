using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisHPView : UIBaseView
{
	public UISprite HpSprite;

	public TweenFill HpFill;

	public UIHudMetropolisFactionStar FactionStar;

	public UIGrid StarGrid;

	public UISlider SliderFront;

	public GameObject VFX_Protect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
