using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReviveCardBubbleTipsView : UIBaseView
{
	public UISprite Card;

	public UILabel CurPrice;

	public UILabel OriginPrice;

	public UILabel PlayerNumber;

	public GameObject Main;

	public UIColor IndexColor;

	public UISprite IndexSprite;

	public GameObject InVFX;

	public Animation TipsAnimation;

	public Transform FreeVfxNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
