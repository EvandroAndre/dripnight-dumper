using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TwoTeam_ShowTimeView : UIBaseView
{
	public GameObject ScoreContainer;

	public UILabel LeftTeamScore;

	public GameObject LeftTeamIconOB;

	public UISprite LeftTeamIcon;

	public GameObject LeftTeamDefaultIconBG;

	public UILabel RightTeamScore;

	public GameObject RightTeamIconOB;

	public UISprite RightTeamIcon;

	public GameObject RightTeamDefaultIconBG;

	public GameObject BooyahContainer;

	public GameObject DefeatedContainer;

	public GameObject DrawContainer;

	public GameObject VictoryContainer;

	public UIButton ReturnBtn;

	public UILabel ReturnBtnContent;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
