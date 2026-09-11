using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCMultiTeamMatchResultPlayerItemView : UIBaseView
{
	public GameObject SelfBG;

	public GameObject WinMVPGrade;

	public GameObject FailMVPGrade;

	public UILabel NormalGrade;

	public GameObject FakeBg;

	public UIEffectSprite BannerBg;

	public UIEffectSprite HeadIcon;

	public GameObject IconCelebrity;

	public UILabel Nickname;

	public UILabel ClanName;

	public UILabel Info1Txt;

	public UILabel Info2Txt;

	public UILabel Info3Txt;

	public UILabel Info4Txt;

	public GameObject BtnContainer;

	public UIButton AddFriendBtn;

	public UIButton ReportBtn;

	public UIButton LikeBtn;

	public GameObject LikeIcon;

	public UILabel LikeNum;

	public GameObject VFX_Like;

	public UIButton InviteBtn;

	public GameObject TryInviteIcon;

	public GameObject FinishInviteIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
