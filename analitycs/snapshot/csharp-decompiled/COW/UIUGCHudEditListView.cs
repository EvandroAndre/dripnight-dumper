using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudEditListView : UIBaseView
{
	public UIButton CloseBtn;

	public UISprite Panel;

	public UIButton UIButtonEditLayoutBtn;

	public UISprite UISpriteEditLayoutBtn;

	public UIButton UIButtonEditScriptBtn;

	public UISprite UISpriteEditScriptBtn;

	public UILabel HudCount;

	public UIButton AddBtn;

	public UIScrollView ScrollView;

	public UIEasyList Grid;

	public GameObject HudInfo;

	public GameObject NoHudTips;

	public UILabel Label;

	public UIWidget GuideClipMask;

	public UIButton UseTemplateBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
