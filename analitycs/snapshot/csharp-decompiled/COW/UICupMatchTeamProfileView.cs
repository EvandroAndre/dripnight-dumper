using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchTeamProfileView : UIBaseView
{
	public GameObject TeamOverview;

	public UIGrid NewTeam;

	public UIButton CreateTeam;

	public UILabel CreateTeamLabel;

	public UIButton JoinTeam;

	public GameObject Left;

	public GameObject Info;

	public UILabel TeammateCntText;

	public UILabel TeamId;

	public GameObject TeamIdTag;

	public UIButton TeamInfoRefresh;

	public GameObject TeamInfoRefreshIcon;

	public UICountDownLabel TeamInfoRefreshCD;

	public UIEasyList InfoEasyList;

	public UIButton Recruit;

	public UIButton BtnApplyAndInvite;

	public GameObject ApplyAndInviteRedPoint;

	public UIButton BtnInvite;

	public GameObject InviteRedPoint;

	public UIButton BtnInviteNoTeam;

	public GameObject InviteNoTeamRedPoint;

	public GameObject NoTeamTips;

	public UIButton Exit;

	public GameObject TicketTips;

	public UIButton RecruitBtn;

	public UIWidget RecruitBtnWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
