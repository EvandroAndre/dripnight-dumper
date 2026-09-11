using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyIceWallDisplayView : UIBaseView
{
	public TweenPosition RightTween;

	public Transform PopMenu;

	public UIScrollView ScrollView;

	public UIEasyList Grid;

	public GameObject Empty;

	public UIButton GoShopButton;

	public UIButton RemoveButton;

	public UIWidget GuideRoot;

	public UIButton AutoRotateToggle;

	public GameObject ShowOn;

	public GameObject ShowOff;

	public UIWidget AutoRotateGuideRoot;

	public UIButton GotoShopCollectionSkin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
