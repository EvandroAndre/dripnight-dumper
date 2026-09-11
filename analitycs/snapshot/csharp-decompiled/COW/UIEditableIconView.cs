using GCommon;
using UnityEngine;

namespace COW;

public class UIEditableIconView : UIBaseView
{
	public UISprite TargetIcon;

	public UIButton TargetIconBtn;

	public UIEditableIconDropItem MoveDropItem;

	public TweenAlpha TwinkleAnim;

	public GameObject EditeContainer;

	public UISprite BorderIcon;

	public GameObject DeleteBtnContainer;

	public GameObject CopyBtnContainer;

	public GameObject ScalingBtnContainer;

	public GameObject RotatingBtnContainer;

	public UIButton DeleteBtn;

	public UIButton CopyBtn;

	public UIEditableIconDropItem ScalingBtn;

	public UIEditableIconDropItem RotatingBtn;

	public Animation Main;

	public UISprite Line01;

	public UISprite Line02;

	public UISprite Line03;

	public UISprite Line04;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
