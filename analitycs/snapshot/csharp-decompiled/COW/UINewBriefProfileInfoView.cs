using GCommon;
using UnityEngine;

namespace COW;

public class UINewBriefProfileInfoView : UIBaseView
{
	public UIButton UINewBriefProfileInfo;

	public UILabel nickname;

	public GameObject Self;

	public UIButton Btnclose;

	public UISprite NormalBanner;

	public GameObject RankLimitBanner;

	public GameObject MIC;

	public GameObject Mute;

	public UIButton invite;

	public GameObject Captain;

	public GameObject Ready;

	public GameObject LadderIconSrollContainer;

	public UIScrollView LadderIconSroll;

	public UICenterOnChild LadderCenterOnChild;

	public UIWrapContent UIWrapCOntent;

	public GameObject StreakIconContainer;

	public UISprite StreakIcon;

	public UILabel StreakTxt;

	public GameObject LadderIconContainer;

	public Transform CSRankIconContainer;

	public Transform BRRankIconContainer;

	public GameObject NotReady;

	public GameObject MicSpeaking;

	public UISprite MicSpeakingSprite;

	public GameObject RankLimitVFX;

	public GameObject GameVoiceBtnGroup;

	public UIButton MicToggle;

	public GameObject MicBanStyle2;

	public UISprite MicSprite;

	public UISprite MicMask;

	public UISprite MicTeam;

	public UIButton SpeakerToggle;

	public UISprite SpeakerSprite;

	public UISprite SpeakerMask;

	public UISprite SpeakerTeam;

	public Transform GroupMemeberSpeaker;

	public GameObject NoMicStatus;

	public UIButton GoToCreditBtn;

	public GameObject MicBanContainer;

	public GameObject MicBanStyle1;

	public Transform HCRankIconContainer;

	public Transform LimitedTimeRankIconContainer;

	public GameObject PrivilegeIcon;

	public UIGrid BottomGrid;

	public GameObject PrimeBanner;

	public GameObject SelfMain;

	public GameObject MicDisconnectContainer;

	public GameObject SpeakerDisconnectContainer;

	public GameObject MicNormalContainer;

	public GameObject SpeakerNormalContainer;

	public UIButton MicDisconnectBtn;

	public UIButton SpeakerDisconnectBtn;

	public Transform CSPeakContainer;

	public GameObject CSPeakIconContainer;

	public GameObject MicPressedVFX;

	public Transform GroupMemeberMic_NoPress;

	public Transform GroupMemeberMic;

	public GameObject AntiAddictionIcon;

	public GameObject OtherPlayerStats;

	public UILabel OtherPlayerStatsLabel;

	public GameObject MemberGameState;

	public UILabel GameTime;

	public UILabel GameMode;

	public GameObject MixedGroupIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
