using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchEndShowTime_HippoCrisisView : UIBaseView
{
	public Animator Animator;

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

	public GameObject LeftClanInfo;

	public UISprite LeftClanFrame;

	public UINetworkTexture LeftClanCdnIcon;

	public UISprite LeftClanIcon;

	public GameObject RightClanInfo;

	public UISprite RightClanFrame;

	public UISprite RightClanIcon;

	public UINetworkTexture RightClanCDNIcon;

	public Transform RankingTipsTransFrom;

	public UILabel LeftClanName;

	public UILabel RightClanName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
