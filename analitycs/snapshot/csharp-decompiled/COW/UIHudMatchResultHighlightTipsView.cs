using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultHighlightTipsView : UIBaseView
{
	public UISprite EventIcon;

	public UILabel EventLabel;

	public GameObject MatchResultStyleContainer;

	public GameObject PreviewWindowBtnStyleContainer;

	public UIWidget PreviewWindowWidget;

	public UIButton GotoHighlightBtn;

	public UISprite WindowEventIcon;

	public UILabel WindowEventLabel;

	public UIButton PlayBtn;

	public UISprite PlayBG;

	public UISprite PlayIcon;

	public Transform PlayContainer;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
