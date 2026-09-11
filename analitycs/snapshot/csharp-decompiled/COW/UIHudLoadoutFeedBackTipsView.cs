using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLoadoutFeedBackTipsView : UIBaseView
{
	public UITable InfoTable;

	public UILabel TeamIndex;

	public UISprite TeamBG;

	public UILabel TipsTxt;

	public UISprite WeaponIcon;

	public UISprite WeaponIconShadow;

	public GameObject ReinforceWeapon;

	public GameObject SupportBuff;

	public UISprite bg1;

	public UISprite bg2;

	public UISprite bg3;

	public UISprite bg4;

	public UISprite Line1;

	public UISprite Line21;

	public UISprite BotIcon;

	public Animation TipAnim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
