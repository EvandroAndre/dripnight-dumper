using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLWSORoundResultView : UIBaseView
{
	public GameObject WinSprite;

	public GameObject LoseSprite;

	public UISprite HPKnife;

	public UIGrid OppoFactionHP;

	public GameObject OppoFactionEliminate;

	public UILabel OppoTeamName;

	public UISprite OppoFactionIcon;

	public GameObject OppoWinVFX;

	public UIGrid MyFactionHP;

	public GameObject MyFactionEliminate;

	public UILabel MyName;

	public UISprite MyFactionIcon;

	public GameObject MyWinVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
