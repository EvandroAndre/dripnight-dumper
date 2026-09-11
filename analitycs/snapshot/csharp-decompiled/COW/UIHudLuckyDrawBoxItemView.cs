using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLuckyDrawBoxItemView : UIBaseView
{
	public UISprite Icon;

	public UILabel Count;

	public UISprite Bg;

	public UILabel ItemName;

	public GameObject LuckyItemVfx;

	public UIEventListener UIEventListener;

	public GameObject HotItemTag;

	public GameObject NewItemTag;

	public UISprite SpecialItemBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
