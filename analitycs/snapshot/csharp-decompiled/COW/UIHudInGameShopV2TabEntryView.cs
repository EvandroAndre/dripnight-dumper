using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopV2TabEntryView : UIBaseView
{
	public UIButton TabButton;

	public GameObject Selected;

	public GameObject NotSelected;

	public UISprite SelectedIcon;

	public UILabel SelectedLabel;

	public UISprite NotSelectedIcon;

	public UILabel NotSelectedLabel;

	public Transform SelectedContentRoot;

	public Transform NotSelectedContentRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
