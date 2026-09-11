using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLWMultiMatchInfoView : UIBaseView
{
	public UILabel remainTime;

	public UILabel curRound;

	public UIButton BtnLeaderboard;

	public UIWidget WidgetBtnLeaderboard;

	public UILabel team1Score;

	public UIGrid team1Grid;

	public Transform team1Trans;

	public UILabel team2Score;

	public UIGrid team2Grid;

	public Transform team2Trans;

	public UILabel team3Score;

	public Transform team3Trans;

	public UIGrid team3Grid;

	public GameObject Root;

	public Transform MyArrow;

	public Transform Personal1;

	public Transform Personal2;

	public Transform Personal3;

	public UISprite BgIcon2;

	public UISprite bgIcon;

	public UISprite Personal;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
