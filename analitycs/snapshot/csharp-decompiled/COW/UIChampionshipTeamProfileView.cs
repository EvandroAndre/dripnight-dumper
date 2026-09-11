using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipTeamProfileView : UIBaseView
{
	public GameObject TeamOverview;

	public UIGrid NewTeam;

	public UIButton CreateTeam;

	public UILabel CreateTeamLabel;

	public UIButton JoinTeam;

	public GameObject Left;

	public UIMenu Menu;

	public UILabel MenuLabelSelect;

	public UILabel MenuLabelUnSelect;

	public UITipsButton RedPoint;

	public GameObject Info;

	public UILabel TeammateCntText;

	public UIButton TeamInfoRefresh;

	public GameObject TeamInfoRefreshIcon;

	public UICountDownLabel TeamInfoRefreshCD;

	public UIEasyList InfoEasyList;

	public UIButton Recruit;

	public UIButton BtnApplyAndInvite;

	public UITipsButton ApplyAndInviteRedPoint;

	public UIButton BtnInvite;

	public UITipsButton InviteRedPoint;

	public UIButton BtnInviteNoTeam;

	public UITipsButton InviteNoTeamRedPoint;

	public GameObject NoTeamTips;

	public GameObject Record;

	public UIEasyList RecoardEasyList;

	public UIButton RecordDetail;

	public GameObject RecordNoData;

	public GameObject RecordNoTeam;

	public UILabel RecordTips;

	public UIButton Exit;

	public UIButton ChampionshipRecruitBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
