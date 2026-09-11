using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLWSORoundStartView : UIBaseView
{
	public GameObject RoundStartContainer;

	public UILabel RoundNum;

	public UILabel GamezoneName;

	public UISprite HPKnife;

	public UIGrid MyFactionHPGrid;

	public UILabel MyName;

	public UISprite MyFactionIcon;

	public UILabel MyTeamRank;

	public UIGrid OppoFactionHPGrid;

	public UILabel OppoName;

	public UISprite OppoFactionIcon;

	public UILabel OppoTeamRank;

	public GameObject Final;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
