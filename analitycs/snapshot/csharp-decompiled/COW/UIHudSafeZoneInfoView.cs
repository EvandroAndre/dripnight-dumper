using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSafeZoneInfoView : UIBaseView
{
	public GameObject InfoContainer;

	public GameObject warningTips;

	public GameObject centerModeContainer;

	public UILabel labelTips;

	public UISprite labelbgwidget;

	public UISprite warningIcon;

	public UISprite warningwidget;

	public UILabel timeCount;

	public TweenAlpha TweenAlpha;

	public GameObject miniModeContainer;

	public UISprite warningIconMini;

	public UILabel MiniTimeCount;

	public TweenAlpha TweenAlphaMini;

	public UISprite UAVIconMini;

	public UILabel UAVLabelMini;

	public Animator WarningIconAnimator;

	public UISprite attentionwidget;

	public GameObject CenterRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
