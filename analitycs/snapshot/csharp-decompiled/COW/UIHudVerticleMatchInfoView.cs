using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVerticleMatchInfoView : UIBaseView
{
	public Transform myTeam;

	public UIGrid MyteamGrid;

	public Transform oppoTeam;

	public UIGrid OppoTeamGrid;

	public UILabel myWinNum;

	public UILabel remainTime;

	public UILabel oppoWinNum;

	public UILabel curRound;

	public UIButton BtnLeaderboard;

	public UIWidget WidgetBtnLeaderboard;

	public UISprite leftBG;

	public UISprite rightBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
