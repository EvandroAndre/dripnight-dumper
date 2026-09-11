using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHypeSnowmanProcessBarView : UIBaseView
{
	public GameObject Hyper;

	public GameObject Revive;

	public GameObject Lv1Active;

	public GameObject Lv1Disable;

	public GameObject Lv2Active;

	public GameObject Lv2Disable;

	public GameObject Lv3Active;

	public GameObject Lv3Disable;

	public UISprite BallRadiusBar;

	public UIProgressScrollBar ProcessSliderBar;

	public GameObject Thumb;

	public GameObject EffectTips;

	public GameObject BuffTips;

	public Transform Ball;

	public GameObject Teammate;

	public GameObject UpIcon;

	public UIButton HyperTipsBtn;

	public UISprite BuffTipsBg;

	public UILabel DescribeLabel;

	public UILabel DebugText;

	public TweenRotation Ball_Ani;

	public GameObject FullBuffVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
