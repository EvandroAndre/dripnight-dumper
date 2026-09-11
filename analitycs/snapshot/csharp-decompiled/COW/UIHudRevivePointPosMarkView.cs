using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRevivePointPosMarkView : UIBaseView
{
	public GameObject Container;

	public UISprite ProgressBg;

	public UILabel PointStatusLabel;

	public UISprite StateIcon;

	public TweenAlpha StateIconTween;

	public UISprite StateBg;

	public UILabel Timer;

	public UILabel DistanceLabel;

	public UILabel TeamInfo;

	public UISprite Icon;

	public GameObject Vfx;

	public VFXCreateHelper vfx_2;

	public VFXCreateHelper vfx_3;

	public VFXCreateHelper vfx_4;

	public GameObject AdvancedVFXBg;

	public Transform ActivityNode;

	public GameObject NormalStatus;

	public Transform fightingBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
