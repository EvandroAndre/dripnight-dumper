using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_HitObjectHPBarView : UIBaseView
{
	public UISlider SliderFront;

	public TweenFill Middle;

	public UISprite MiddleSprite;

	public UILabel ObjectName;

	public UILabel HpLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
