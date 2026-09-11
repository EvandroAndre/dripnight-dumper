using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFeedbackPopOverView : UIBaseView
{
	public GameObject DetailBg;

	public UISprite DetailBgSprite;

	public UITable DetailTable;

	public UIHudFeedbackPopOverItem DetailItem;

	public UIScrollView ScrollView;

	public Transform UIHudFeedbackPopOver;

	public GameObject DownArrowPanel;

	public UISprite BgTeam;

	public UISprite BgPlayer;

	public UIButton ClickMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
