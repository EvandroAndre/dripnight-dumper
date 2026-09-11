using GCommon;
using UnityEngine;

namespace COW;

public class UIHudGiantMatchInfoView : UIBaseView
{
	public Transform myTeam;

	public Transform oppoTeam;

	public UILabel myWinNum;

	public UILabel remainTime;

	public UILabel oppoWinNum;

	public UILabel curRound;

	public UISprite Team1ShowSpr;

	public UISprite Team2ShowSpr;

	public UIButton BtnLeaderboard;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
