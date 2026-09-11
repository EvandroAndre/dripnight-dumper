using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarChampionshipInfoView : UIBaseView
{
	public GameObject RoundStage;

	public GameObject Qualifier;

	public GameObject QualifierMatch;

	public GameObject QualifierSettlement;

	public UIButton BtnInQualifier;

	public GameObject Eliminator;

	public GameObject EliminatorWarmUp;

	public GameObject EliminatorMatch;

	public GameObject EliminatorSettlement;

	public UILabel BtnTextInQualifier;

	public GameObject TimeTip;

	public UICountDownLabel QualifierTimeLabel;

	public GameObject QualifierMatchProcess;

	public UISlider QualifierMatchSlider;

	public GameObject QualifierMatchProcessComplete;

	public UILabel QualifierMatchGapProcessLabel;

	public GameObject QualifierMatchInProcess;

	public UILabel PointsLabelInQualifierSettlement;

	public Transform TopUserInQualifierSettlement;

	public UILabel QualifierSettlementScoreTargetInTitle;

	public UILabel EliminatorTitleTargetRank;

	public UIButton EliminatorTipBtn;

	public UIButton EliminatorMatchPoolBtn;

	public UIButton EliminatorBattleBtn;

	public GameObject MatchPoolBtnTip;

	public UICountDownLabel EliminatorBattleBtnTimeLabel;

	public UITable EliminatorBtnTable;

	public UISlider EliminatorMatchSlider;

	public UILabel EliminatorMatchTargetRankLabel;

	public UILabel EliminatorMatchTargetRankScoreLabel;

	public UILabel EliminatorMatchCurRankScoreLabel;

	public GameObject EliminatorSuccess;

	public GameObject EliminatorFail;

	public Transform TopUserInEliminatorSettlement;

	public GameObject EliminatorMatchNoRankLabel;

	public Transform AwardRoot;

	public UILabel QualifierScoreLabel;

	public UILabel EliminatorScoreLabel;

	public UILabel EliminatorFinalRank;

	public UIButton EquipTitleBtn;

	public UILabel RegionNameWithTitle;

	public GameObject EliminatorFinish;

	public UIButton OutTipBtn;

	public UILabel regionName;

	public GameObject ScoreWithOutRegionName;

	public GameObject ScoreWithRegionName;

	public GameObject Result;

	public GameObject Out;

	public UILabel FinishTipLabel;

	public GameObject QualifierSuccess;

	public GameObject QualifierOut;

	public GameObject EliminatorMatchTargetRankScore;

	public UILabel LabelWarmUp;

	public UILabel LabelOpen;

	public UILabel LabeSettle;

	public UISprite SpriteWarmUp;

	public UISprite SpriteOpen;

	public GameObject EliminatorMatchEnd;

	public UILabel EliminatorMatchProcessComplete;

	public UILabel ResultLabel;

	public Transform AwardTransForm;

	public GameObject QualifierWarmUp;

	public UILabel PointsLabelInQualifierWarmUp;

	public UIButton RuleBtnInQualifierWarmUp;

	public UILabel QualifierSignUpRuleTitle;

	public UIButton RuleBtnInQualifierMatch;

	public UILabel PointsLabelInQualifierMatch;

	public GameObject EliminatorWarmUpLabel;

	public UILabel EliminatorWarmUpTargetRank;

	public GameObject EliminatorLastRoundWarmUp;

	public UILabel EliminatorMatchRankLabel;

	public UILabel EliminatorMatchRankRegionLabel;

	public UILabel EliminatorMatchTargetRankTip;

	public UILabel AdVancedPointTipLabelInQualifierWarm;

	public UILabel AdVancedPointTipLabelInQualifierMatch;

	public UILabel QualifierMatchInProcessTipLabel;

	public UILabel EliminatorFinalRoundWarmUpRegionName;

	public UILabel EliminatorSettleRankLabel;

	public UILabel EliminatorSettleRankRegionLabel;

	public UISprite SelfClanFrameInQualifier;

	public UISprite SelfClanIconInQualifier;

	public UINetworkTexture SelfClanCDNInQualifier;

	public UISprite SelfClanFrameInEliminator;

	public UISprite SelfClanIconInEliminator;

	public UINetworkTexture SelfClanCDNInEliminator;

	public UILabel QualifierSignUpRulesAndTimeTable;

	public UILabel EliminatorWarmUpRulesAndTimeTable;

	public GameObject QualifierEnableBtnbg;

	public GameObject QualifierDisableBtnbg;

	public GameObject EliminatorDisableBtnbg;

	public GameObject EliminatorEnableBtnbg;

	public UIToggleButton ResultTab;

	public UIToggleButton RankTab;

	public GameObject ResultPage;

	public GameObject RankPage;

	public UIEasyList MiniLeaderboardEasyList;

	public UIScrollView MiniLeaderboardScrollView;

	public Transform SelfPos;

	public UIToggleButtonGroup FinishTabToggleGroup;

	public Transform ClanBriefBoxTran;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
