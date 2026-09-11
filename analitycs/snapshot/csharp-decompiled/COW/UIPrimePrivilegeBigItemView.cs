using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimePrivilegeBigItemView : UIBaseView
{
	public UIButton Button;

	public UILabel DescLabel;

	public UISprite PrivilegeIcon;

	public PrimeSmallBadgeVfxUtil PrimeSmallBadgeVfxUtil;

	public GameObject Selected;

	public GameObject Owned;

	public UILabel OwnedLabel;

	public GameObject ItemOwned;

	public UILabel DescLabel02;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteOrangeQualityPlus;

	public GameObject Item;

	public UISprite ItemIcon;

	public GameObject NotOwned;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
