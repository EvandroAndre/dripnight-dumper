using GCommon;
using UnityEngine;

namespace COW;

public class UIBaseProfileInfoView : UIBaseView
{
	public UIButton UIBaseProfileInfo;

	public UIWidget BaseProfileWidget;

	public UILabel BadgeCntLabel;

	public UISprite EPBadge;

	public UIEffectSprite bg;

	public GameObject fakeBg;

	public UISprite gray;

	public UIButton headbtn;

	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public GameObject FakeSprite;

	public GameObject infoContainer;

	public GameObject NickNameWithGender;

	public UISprite PlayerSex;

	public UILabel NickNameWithGenderLabel;

	public UILabel nickname;

	public UILabel level;

	public UILabel clanName;

	public UISprite platformIcon;

	public UILabel online;

	public GameObject LadderEffect;

	public UISprite Favor;

	public UISprite FavorIcon;

	public UISprite PinIcon;

	public UISprite BtnPinIcon;

	public UISprite Relationship;

	public UILabel InGameTime;

	public GameObject SeparateLine;

	public UILabel GameMode;

	public GameObject GameModeContainer;

	public GameObject BtnPin;

	public UIButton NewVersionBtn;

	public GameObject CompatibleVersionContainer;

	public GameObject NewVersion;

	public GameObject OldVersion;

	public UILabel NewVersionLabel;

	public UILabel OldVersionLabel;

	public GameObject Mask;

	public UIButton GuideMaskBtn;

	public UIWidget GuideWidget;

	public Transform BRRankIconContainer;

	public Transform CSRankIconContainer;

	public GameObject ClanLogo;

	public UISprite ClanBadge;

	public UISprite ClanFrame_L;

	public UISprite ClanFrame_R;

	public UINetworkTexture ClanBadgeCDN;

	public UILabel Observing;

	public UISprite StatusIcon;

	public Transform SocialHighlightContainer;

	public UILabel LevelUpInfo;

	public Transform TipsContainer;

	public Transform LeaderBoardTitleContainer;

	public UILabel Recommendfriendlabel;

	public Animation main;

	public Transform HCRankIconContainer;

	public Transform LimitedTimeRankIconContainer;

	public GameObject PrivilegeIcon;

	public UILabel SeasonReplayDesc;

	public Transform AvatarFramePos;

	public GameObject AnonymousContainer;

	public GameObject PrimeBadgeInfo;

	public UISprite PrimeBadgeIcon;

	public UILabel PrimeLevelLabel;

	public Transform CSPeakTournamentRankIconContainer;

	public UIBaseProfileInfoShowRankIconCtrl CSRankIconShowContainer;

	public GameObject MaskPanelObj;

	public UIPanel MaskPanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
