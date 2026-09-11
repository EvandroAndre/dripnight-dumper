using GCommon;
using UnityEngine;

namespace COW;

public class UIWishBriefBoxItemView : UIBaseView
{
	public Transform ItemTransform;

	public GameObject InWishIcon;

	public GameObject NotWishIcon;

	public GameObject IconBG;

	public Animation WishAnimation;

	public GameObject LimitLabel;

	public UIButton WishButton;

	public UISprite EmptyIcon;

	public UILabel WishNum;

	public GameObject PlusOne;

	public GameObject Hot;

	public GameObject IconBGWithNum;

	public Animation WishAnimWithNum;

	public GameObject NotWishIconWithNum;

	public GameObject InWishIconWithNum;

	public Transform ZeroWishNumPos;

	public UILabel PlusOneLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
