using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResult2TeamsView : UIBaseView
{
	public GameObject TeamInfoContainer;

	public GameObject LocalTeamIcon;

	public GameObject OptTeamIcon;

	public GameObject Team2Icon;

	public GameObject Team1Icon;

	public UILabel LocalTeamScore;

	public UILabel OptTeamScore;

	public UILabel Defeat;

	public UILabel Booyah;

	public GameObject GridContainer;

	public GameObject GridTitle;

	public UIGrid GridLeft;

	public UIGrid GridRight;

	public UIButton BtnMask;

	public UIButton BtnShare;

	public UIButton BtnNext;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
