using GCommon;
using UnityEngine;

namespace COW;

public class UIEditableImageView : UIBaseView
{
	public UITexture TargetImageTexture;

	public UIButton TargetImageBtn;

	public UIEditableImageDropItem MoveDropItem;

	public TweenAlpha TwinkleAnim;

	public UIWidget EditContainer;

	public UISprite BorderIcon;

	public UIWidget DeleteBtnContainer;

	public UIWidget CopyBtnContainer;

	public UIWidget ScalingBtnContainer;

	public UIWidget RotatingBtnContainer;

	public UIButton DeleteBtn;

	public UIButton CopyBtn;

	public UIEditableImageDropItem ScalingBtn;

	public UIEditableImageDropItem RotatingBtn;

	public Animation Main;

	public UISprite Line01;

	public UISprite Line02;

	public UISprite Line03;

	public UISprite Line04;

	public UIWidget EditBtnContainer;

	public UIEditableImageDropItem EditBtn;

	public GameObject UIEditableImage;

	public UIColor Bg;

	public UIColor BgShadow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
