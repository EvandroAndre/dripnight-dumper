using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAutoSearchItemView : UIBaseView
{
	public UISprite Icon;

	public GameObject IconSelected;

	public UILabel Name;

	public GameObject HighLight;

	public UIButton UseBtn;

	public UILabel UseLabel;

	public UIButton CloseBtn;

	public UILabel CloseLabel;

	public GameObject IconEffect;

	public UIToggle SearchItem;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
