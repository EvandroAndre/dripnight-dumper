using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDMultiTeamLeaderboard_TeammateItemView : UIBaseView
{
	public GameObject FakeBg;

	public UIEffectSprite BannerBg;

	public UIEffectSprite HeadIcon;

	public UILabel ClanName;

	public UILabel Nickname;

	public UIGrid LabelGrid;

	public GameObject LabelTemp;

	public GameObject DefaultBg;

	public UISprite SelfBg;

	public Transform TrSkillRoot1;

	public GameObject GoSkill;

	public UIButton ReportBtn;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
