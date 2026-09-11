using GCommon;
using UnityEngine;

namespace COW;

public class UIAwardItemView : UIBaseView
{
	public AwardItemView AwardItem;

	public UILabel ItemNameLabel;

	public UIToggle AwardToggle;

	public UISprite SelectedSprite;

	public UISprite UnSelectedSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
