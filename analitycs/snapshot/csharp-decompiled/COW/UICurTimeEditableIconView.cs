using GCommon;
using UnityEngine;

namespace COW;

public class UICurTimeEditableIconView : UIBaseView
{
	public UIButton TargetIconBtn;

	public UIEditableIconDropItem MoveDropItem;

	public Transform TargetTransform;

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

	public UILabel TimeLabel;

	public TweenAlpha TwinkleAnim;

	public Transform SyncTransform;

	public UISprite Line01;

	public UISprite Line02;

	public UISprite Line03;

	public UISprite Line04;

	public UISprite TargetIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
