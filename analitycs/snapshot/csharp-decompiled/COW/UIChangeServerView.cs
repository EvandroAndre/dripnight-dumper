using GCommon;
using UnityEngine;

namespace COW;

public class UIChangeServerView : UIBaseView
{
	public UISprite bg;

	public TweenAlpha BgTweenAlpha;

	public UIButton close;

	public UIGrid ServerListGrid;

	public GameObject Instance;

	public UILabel ServerRegion;

	public UIButton BtnConfirm;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
