using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCabinWaitingWishItemView : UIBaseView
{
	public GameObject UIHudCabinWaitingWishItem;

	public GameObject LimitLabel;

	public GameObject IconBG;

	public Animation WishAnimation;

	public GameObject NotWishIcon;

	public GameObject InWishIcon;

	public UIButton WishButton;

	public UISprite ItemIcon;

	public UISprite EmptyIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
