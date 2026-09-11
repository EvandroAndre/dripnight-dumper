using GCommon;
using UnityEngine;

namespace COW;

public class UILobbySkyboardDisplayView : UIBaseView
{
	public TweenPosition RightTween;

	public UISprite BG;

	public UIButton GotoShopCollectionSkin;

	public UIScrollView ScrollView;

	public UIEasyList Grid;

	public UIButton CenterButton;

	public UIButton RemoveButton;

	public UIWidget GuideRoot;

	public UIButton AutoRotateToggle;

	public GameObject ShowOn;

	public GameObject ShowOff;

	public UIWidget AutoRotateGuideRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
