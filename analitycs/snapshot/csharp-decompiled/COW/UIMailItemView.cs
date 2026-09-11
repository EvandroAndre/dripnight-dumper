using GCommon;
using UnityEngine;

namespace COW;

public class UIMailItemView : UIBaseView
{
	public UIButton UIMailItem;

	public UISprite ItemSprite;

	public UISprite SpriteMailUnRead;

	public UISprite SpriteMailRead;

	public GameObject ReportWarning;

	public UISprite ReadSprite;

	public UILabel LabelTitle;

	public UILabel LabelTime;

	public UISprite SpriteTimeIcon;

	public UISprite SelectedBG;

	public UINetworkTexture ItemCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
