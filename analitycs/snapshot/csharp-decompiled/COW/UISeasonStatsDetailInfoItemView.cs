using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonStatsDetailInfoItemView : UIBaseView
{
	public GameObject BRExtraBg;

	public GameObject BRRankGroup;

	public UILabel mMatchCount;

	public UILabel bKD;

	public UILabel mWins;

	public UILabel mMostRankLevel;

	public UILabel mMostRankPoint;

	public UILabel mTop10P;

	public UILabel mTop50P;

	public UILabel mSurvialTime;

	public UILabel mMoveDistance;

	public UILabel bTotalKill;

	public UILabel bHeadShot;

	public UILabel bAvgKill;

	public UILabel bAvgDamage;

	public UILabel bMostKill;

	public UILabel bMostDamage;

	public UILabel bRevivals;

	public GameObject CSRankGroup;

	public UILabel CSMatchCount;

	public GameObject KDRatioLabel;

	public UILabel CSKDRatio;

	public GameObject GoDetailStatsCS;

	public UILabel CSWins;

	public UILabel CSMostRankLevel;

	public GameObject MVPLabel;

	public UILabel CSMvp;

	public GameObject WinRateLabel;

	public UILabel CSWinRate;

	public GameObject AVGDamageLabel;

	public UILabel CSAVGDamage;

	public GameObject RevivesLabel;

	public UILabel CSRevives;

	public GameObject TotalKillLabel;

	public UILabel CSTotalKill;

	public UILabel DoubleKillLabel;

	public UILabel CSDoubleKill;

	public UILabel ThreekillLabel;

	public UILabel CSThreeKill;

	public UILabel FourKillLabel;

	public UILabel CSFourKill;

	public GameObject HeadShotLabel;

	public UILabel CSHeadShot;

	public GameObject HeadShotRatioLabel;

	public UILabel CSHeadShotRatio;

	public GameObject GoDetailStatsPeriodic;

	public UILabel PeriodicWins;

	public UILabel PeriodicMaxRank;

	public UILabel PeriodicAVGDamage;

	public UILabel PeriodicHeadShot;

	public UILabel PeriodicTotalKill;

	public UILabel PeriodicWinRate;

	public UILabel PeriodicAssists;

	public UILabel PeriodicHeadShotKillRate;

	public UIButton ShareBtn;

	public Animator ShareIconAnimator;

	public TweenAlpha TweenAlpha;

	public TweenPosition TweenPosition;

	public UILabel PeakRank;

	public GameObject bKDContainer;

	public GameObject BRRatingContainer;

	public UILabel BRRatingNum;

	public GameObject BRMatchStatsKD;

	public UILabel BRKDNum;

	public UIGrid MatchStats;

	public GameObject CSRatingContainer;

	public UILabel CSRatingNum;

	public UILabel CSKDNum;

	public GameObject CSMatchStatsKD;

	public UIButton CSRankRatingTip;

	public UIButton BRRankRatingTip;

	public UISprite ExtraLeftBg1;

	public UISprite ExtraLeftBg2;

	public UISprite ExtraRightBg1;

	public UIGrid LeftBgGrid;

	public UIGrid RightBgGrid;

	public GameObject FormContaner;

	public UIGrid BattleStats;

	public UIGrid CSMatchStats;

	public UIGrid CSBattleStats;

	public UISprite ExtraRightBg2;

	public GameObject MedalLabel;

	public UILabel CSMedalGoldLabel;

	public UILabel CSMedalSilverLabel;

	public GameObject bMedal;

	public UILabel bMedalGoldLabel;

	public UILabel bMedalSilverLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
