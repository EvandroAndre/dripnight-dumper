using GCommon;
using UnityEngine;

namespace COW;

public class UICommonTweenTipsView : UIBaseView
{
	public UIPanel TipsPanel;

	public UIWidget ParentContainer;

	public TweenPosition ParentTP;

	public Animation anim;

	public UISprite alphaSprite;

	public UILabel TipTxt;

	public UISprite Bg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
