using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSSORoundStartView : UIBaseView
{
	public GameObject RoundStartContainer;

	public UILabel RoundNum;

	public UILabel GamezoneName;

	public UILabel MyTeamRank;

	public UILabel OppoTeamRank;

	public GameObject NormalNum;

	public GameObject SpecialNum;

	public UISprite PlayerNum;

	public UISprite PlayerNum2;

	public UIHudCSSOTeamInfoView MyFaction;

	public GameObject MyFactionHP;

	public UILabel MyTeamLabel;

	public UIHudCSSOTeamInfoView OppoFaction;

	public GameObject OppoFactionHP;

	public GameObject NoEnemy;

	public UILabel OppoTeamLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
