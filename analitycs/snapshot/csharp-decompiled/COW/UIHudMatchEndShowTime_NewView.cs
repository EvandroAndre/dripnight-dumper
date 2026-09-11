using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchEndShowTime_NewView : UIBaseView
{
	public Animation Animator;

	public GameObject ScoreContainer;

	public UISprite LeftTeamScoreBG;

	public UILabel LeftTeamScore;

	public GameObject LeftTeamIconOB;

	public UISprite LeftTeamIcon;

	public UISprite LeftTeamClanIcon;

	public UISprite RightTeamScoreBG;

	public UILabel RightTeamScore;

	public UISprite RightTeamClanIcon;

	public GameObject RightTeamIconOB;

	public UISprite RightTeamIcon;

	public GameObject BooyahContainer;

	public TweenPosition BoooyahTweenP;

	public TweenScale BoooyahTweenS;

	public GameObject BOOYAHSprite;

	public GameObject DefeatedContainer;

	public GameObject Lose;

	public UIButton ShowResultBtn;

	public UILabel ShowResultLabel;

	public UILabel Time;

	public UILabel LoseLabel;

	public GameObject TieContainer;

	public GameObject SingleTeamContainer;

	public UILabel TeamScore;

	public GameObject TeamIconOB;

	public UISprite bg_icon;

	public UISprite bg_icon_1;

	public GameObject SoloMatchContainer;

	public GameObject GroupMatchContainer;

	public UIButton SoloQuickNextBtn;

	public UIButton MultQuickNextBtn;

	public UIButton ReadyBtn;

	public GameObject MatchMaking;

	public GameObject ReadyLabel;

	public GameObject CancelReadyLabel;

	public UILabel MentionLabel;

	public UIButton DisableBtn;

	public UILabel DisableBtnLabel;

	public GameObject QuickMatchContainer;

	public GameObject NoticeVFX;

	public GameObject BriefMatchResult;

	public UIAnchor BriefMatchResultAnchor;

	public UILabel LabelRankNum;

	public UILabel LabelAmount;

	public UILabel OldScoreLabel;

	public UILabel DeltaScoreLabel;

	public UILabel LabelKillNum;

	public Animation Main;

	public GameObject GroupMedals;

	public UIGridAnimPopAsideHelper AnimQueueHelper;

	public Transform TeambattlePos;

	public GameObject BOOYAH_New;

	public GameObject Defeate_BG_Middle;

	public UILabel Label;

	public GameObject Name_Feedback;

	public VFXCreateHelper UIFX;

	public GameObject LeftClanInfo;

	public UISprite LeftClanFrame;

	public UISprite LeftClanIcon;

	public UINetworkTexture LeftClanCdnIcon;

	public GameObject RightClanInfo;

	public UISprite RightClanFrame;

	public UISprite RightClanIcon;

	public UINetworkTexture RightClanCDNIcon;

	public Transform RankingTipsTransFrom;

	public UILabel LeftClanName;

	public UILabel RightClanName;

	public GameObject EasterEggTelescopeRoot;

	public GameObject CSPeakMatchResult;

	public UIAnchor CSPeakResultAnchor;

	public UILabel CSPeakTitle;

	public UILabel CSPeakOldScoreLabel;

	public UILabel CSPeakDeltaScoreLabel;

	public UISprite LeftTeamInfoBGNew;

	public UISprite RightTeamInfoBGNew;

	public UISprite LeftTeamLine01;

	public UISprite LeftTeamLine02;

	public UISprite RightTeamLine01;

	public UISprite RightTeamLine02;

	public GameObject CSPeakBooyahVFX;

	public UIColor ColorBG;

	public GameObject Rating;

	public UILabel RatingNum;

	public UIGrid BriefMatchResultGrid;

	public UIButton InviteDuelBtn;

	public GameObject WaitingDuelWidget;

	public UIButton AcceptDuelBtn;

	public GameObject RefuseDuelWidget;

	public GameObject PostMatchBigContainer;

	public UIButton PostMatchTeamUpBtn;

	public UILabel PostMatchTeamUpBtnLabel;

	public UIProgressBar ProcessBar;

	public UIButton PostMatchBtnSmallDrop;

	public UIButton PostMatchQuickNextBigBtn;

	public GameObject PostMatchTeamUpBtnPopup;

	public UILabel ReasonLabel;

	public UIButton PostMatchCancelBigBtn;

	public VFXCreateHelper ThumbPos;

	public GameObject ColorBGGold;

	public GameObject ColorBGSilver;

	public GameObject MedalContainer;

	public UILabel RatiingNumGold;

	public UILabel RatiingNumSilver;

	public UILabel RatiingNumNormal;

	public GameObject RatingGoldVFX;

	public GameObject RatingSilverVFX;

	public UISprite RatingMedalBG;

	public GameObject CountdownContainer;

	public UILabel CountDownLabel;

	public UISprite CountdownIcon;

	public GameObject PostMatchTeammateContainerPos;

	public UILabel NewScrollLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
