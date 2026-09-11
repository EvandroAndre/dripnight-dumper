using GCommon;
using UnityEngine;

namespace COW;

public class UIBigRewardEditableIconView : UIBaseView
{
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

	public UILabel FirstLabel;

	public UILabel NumLabel;

	public UILabel SecondLabel;

	public Animation Main;

	public UISprite bg;

	public UISprite Numbg;

	public GameObject TargeTransform;

	public UIEditableIconDropItem MoveDropItem;

	public TweenAlpha TwinkleAnim;

	public UIButton TargetIconBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
