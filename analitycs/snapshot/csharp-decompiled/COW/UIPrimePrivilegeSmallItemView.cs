using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimePrivilegeSmallItemView : UIBaseView
{
	public UIButton Button;

	public UISprite PrivilegeIcon;

	public PrimeSmallBadgeVfxUtil PrimeSmallBadgeVfxUtil;

	public GameObject Selected;

	public GameObject ItemOwned;

	public GameObject Owned;

	public GameObject Item;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteOrangeQualityPlus;

	public UISprite ItemIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
