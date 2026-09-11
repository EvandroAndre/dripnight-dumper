using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudHeadView : UIBaseView
{
	public Transform Container;

	public UILabel Name;

	public UIColor HpBar;

	public UIColor AniHpBar;

	public UILabel Lv;

	public UISprite HpBg;

	public UIColor line;

	public UISprite LvBgSide;

	public UISprite LvBg;

	public UISprite bg;

	public UIPanel UIUGCHudHead;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
