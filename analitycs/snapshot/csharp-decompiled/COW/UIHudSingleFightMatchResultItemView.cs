using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSingleFightMatchResultItemView : UIBaseView
{
	public GameObject SelfBG;

	public UISprite SelfBgSprite;

	public GameObject Rank1Icon;

	public GameObject Rank2Icon;

	public GameObject Rank3Icon;

	public UILabel RankLabel;

	public GameObject FakeBg;

	public UIEffectSprite BannerBg;

	public UIEffectSprite HeadIcon;

	public UILabel Nickname;

	public UILabel ClanName;

	public UILabel Info1Txt;

	public UILabel Info2Txt;

	public UILabel Info3Txt;

	public UILabel Info4Txt;

	public UIButton AddFriendBtn;

	public UIButton ReportBtn;

	public UIButton LikeBtn;

	public GameObject LikeIcon;

	public UILabel LikeNum;

	public GameObject VFX_Like;

	public UIButton ProfileBtn;

	public Transform BtnContainer;

	public Transform UIHudSingleFightMatchResultItem;

	public UISprite BG;

	public Transform BgTransform;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

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
