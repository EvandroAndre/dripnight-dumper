using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudAliveTeamItemView : UIBaseView
{
	public UISprite TeamIcon;

	public UITexture LeftBG;

	public UILabel TeamName;

	public UISprite CountryIcon;

	public UISprite P1Alive;

	public UISprite P1Dead;

	public UISprite P2Dead;

	public UISprite P2Alive;

	public UISprite P3Dead;

	public UISprite P3Alive;

	public UISprite P4Alive;

	public UISprite P4Dead;

	public UISprite RightBG;

	public UISprite P1Fallen;

	public UISprite P2Fallen;

	public UISprite P3Fallen;

	public UISprite P4Fallen;

	public GameObject FakeTeamIcon;

	public UITexture CustomRightBG;

	public UIGrid Middle;

	public UILabel WinRate;

	public UITexture WinRateTextureBg;

	public GameObject WinrateDefaultBg;

	public GameObject Bottom;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
