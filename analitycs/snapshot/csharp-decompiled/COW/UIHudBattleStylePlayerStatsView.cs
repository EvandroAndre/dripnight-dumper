using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleStylePlayerStatsView : UIBaseView
{
	public UIWidget GuideWidget;

	public UIButton GuideBtn;

	public UISprite BuildIcon;

	public TweenPosition BuildIconTween;

	public UILabel LevelText;

	public UISprite ExpBar;

	public UIEventListener PopoverPressBtn;

	public Transform PopoverPivot;

	public GameObject NextInfo;

	public UISprite NextBuildIcon;

	public TweenPosition NextBuildIconTween;

	public UILabel NextText;

	public GameObject anchor;

	public UILabel Message;

	public TweenScale MessageTween;

	public UILabel Messageshow;

	public UISprite Bg;

	public GameObject levelBg;

	public Transform ExpBar_Container;

	public GameObject MaxContainer;

	public UISprite MaxBuildIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
