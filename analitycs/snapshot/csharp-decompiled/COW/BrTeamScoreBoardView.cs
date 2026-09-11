using GCommon;
using UnityEngine;

namespace COW;

public class BrTeamScoreBoardView : UIBaseView
{
	public GameObject TitleSkillPage;

	public GameObject TitleWeaponPage;

	public UIButton WeaponBtn;

	public UIButton SkillBtn;

	public UIButton BackMask;

	public UIGrid TeammateGrid;

	public UIHudTeamBattleScoreTitle TeamScoreTitle;

	public UIButton AddFriendBtn;

	public UIButton ReportBtn;

	public GameObject InteractionSwitchBtnGroup;

	public UILabel TitleRating;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
