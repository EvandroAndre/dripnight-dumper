using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapLegendItemView : UIBaseView
{
	public UISprite Icon;

	public UIButton Toggle;

	public UILabel LabelDesc;

	public UILabel LabelTitle;

	public GameObject Selected;

	public GameObject UnSelected;

	public UISprite IconBg;

	public GameObject Line;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
