using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileFightDataItemView : UIBaseView
{
	public Animation Animation;

	public GameObject ProfileNode;

	public GameObject FiveDMap;

	public UILabel FirstDimension;

	public GameObject WinrateVFX;

	public GameObject WinrateVFX2;

	public Transform WinrateVFX3;

	public UILabel SecondDimension;

	public GameObject KillVFX;

	public GameObject KillVFX2;

	public Transform KillVFX3;

	public UILabel ThirdDimension;

	public GameObject SkillVFX;

	public GameObject SkillVFX2;

	public Transform SkillVFX3;

	public UILabel FourthDimension;

	public GameObject ExploreVFX;

	public GameObject ExploreVFX2;

	public Transform ExploreVFX3;

	public UILabel FifthDimension;

	public GameObject SurvivalVFX;

	public GameObject SurvivalVFX2;

	public Transform SurvivalVFX3;

	public MeshRenderer MapRenderer;

	public MeshFilter MapMeshFilter;

	public Transform PointWinRate;

	public GameObject PointWinRateVfx;

	public Transform PointSurvival;

	public GameObject PointSurvivalVfx;

	public Transform PointExplore;

	public GameObject PointExploreVfx;

	public Transform PointSkill;

	public GameObject PointSkillVfx;

	public Transform PointKill;

	public GameObject PointKillVfx;

	public UIStarSprite mapRender;

	public UISprite LineWinRate;

	public UISprite LineKill;

	public UISprite LineSkill;

	public UISprite LineExplore;

	public UISprite LineSurvival;

	public GameObject BasicDataPanel;

	public UILabel PlayTimes;

	public UILabel WinTimes;

	public UILabel KillTimes;

	public UISprite nameicon;

	public UILabel namelabel;

	public UILabel LabelGameMode;

	public GameObject detailpanel;

	public UIButton detailbtn;

	public UISprite arrow;

	public UILabel detaillabel;

	public GameObject detailselect;

	public Transform Line02;

	public GameObject ThreeDMap;

	public GameObject CSWinrateVFX;

	public GameObject CSWinrateVFX2;

	public Transform CSWinrateVFX3;

	public GameObject CSSurvivalVFX;

	public GameObject CSSurvivalVFX2;

	public Transform CSSurvivalVFX3;

	public GameObject CSExploreVFX;

	public GameObject CSExploreVFX2;

	public Transform CSExploreVFX3;

	public GameObject CSSkillVFX;

	public GameObject CSSkillVFX2;

	public Transform CSSkillVFX3;

	public GameObject CSKillVFX;

	public GameObject CSKillVFX2;

	public Transform CSKillVFX3;

	public MeshRenderer ThreedMapRenderer;

	public MeshFilter ThreedMapMeshFilter;

	public Transform PointCsLeader;

	public GameObject PointCsLeaderVfx;

	public Transform PointCsSupport;

	public GameObject PointCsSupportVfx;

	public Transform PointCskill;

	public GameObject PointCskillVfx;

	public Transform PointCsDamage;

	public GameObject PointCsDamageVfx;

	public Transform PointCsParticipation;

	public GameObject PointCsParticipationVfx;

	public UIStarSprite ThreedmapRender;

	public UISprite LineCsLeader;

	public UISprite LineCsSupport;

	public UISprite LineCskill;

	public UISprite LineCsDamage;

	public UISprite LineCsParticipation;

	public GameObject CSModeBasicDataPanel;

	public UILabel CSPlayTimes;

	public UILabel CSWinTimes;

	public UILabel CSKillTimes;

	public UILabel KDATimes;

	public Transform MiniRankInfoContainer;

	public UILabel LabelSeason;

	public Transform ScrollView;

	public Transform RightPanel;

	public GameObject DetailDataPanel;

	public GameObject DetailBG;

	public UIGrid DetailGrid;

	public GameObject TopNsNode;

	public UILabel TopNsLabel;

	public UILabel Top10s;

	public GameObject TopNRateNode;

	public UILabel TopNRateLabel;

	public UILabel Top10Rate;

	public GameObject KDRatioNode;

	public GameObject KDRatioLabel;

	public UILabel KDRatio;

	public GameObject AVGDisTravNode;

	public GameObject AVGDisTravLabel;

	public UILabel AVGDisTrav;

	public GameObject AVGSurvivalTimeNode;

	public GameObject AVGSurvivalTimeLabel;

	public UILabel AVGSurvivalTime;

	public GameObject RevivesNode;

	public GameObject RevivesLabel;

	public UILabel Revives;

	public GameObject MostKillNode;

	public GameObject MostKillLabel;

	public UILabel MostKill;

	public GameObject GameTimesNode;

	public GameObject GameTimesLabel;

	public UILabel GameTimes;

	public GameObject WinCountNode;

	public GameObject WinCountLabel;

	public UILabel WinCount;

	public GameObject KillCountNode;

	public GameObject KillCountLabel;

	public UILabel KillCount;

	public GameObject MaxRankNode;

	public GameObject MaxRankLabel;

	public UILabel MaxRank;

	public GameObject AVGDamageNode;

	public GameObject AVGDamageLabel;

	public UILabel AVGDamage;

	public GameObject RoadKillNode;

	public UILabel RoadKillLabel;

	public UILabel RoadKill;

	public GameObject HeadShotNode;

	public GameObject HeadShotLabel;

	public UILabel HeadShot;

	public GameObject HeadShotRatioNode;

	public GameObject HeadShotRatioLabel;

	public UILabel HeadShotRatio;

	public GameObject KnockDownNode;

	public GameObject KnockDownLabel;

	public UILabel KnockDown;

	public GameObject WinRateNode;

	public GameObject WinRateLabel;

	public UILabel CSWinRate;

	public GameObject MVPNode;

	public GameObject MVPLabel;

	public UILabel CSMvp;

	public GameObject TotalKillNode;

	public GameObject TotalKillLabel;

	public UILabel CSTotalKill;

	public GameObject DoubleKillNode;

	public UILabel DoubleKillLabel;

	public UILabel CSDoubleKill;

	public GameObject ThreekillNode;

	public UILabel ThreekillLabel;

	public UILabel CSThreeKill;

	public GameObject FourKillNode;

	public UILabel FourKillLabel;

	public UILabel CSFourKill;

	public AnimatedAlpha Arrow;

	public UIScrollView DetailScrollview;

	public UISprite KillsIcon;

	public UISprite CSKillIcon;

	public GameObject CSRankRatingNode;

	public UIButton CSRankRatingTip;

	public UILabel CSRankRatingPoint;

	public UILabel CSRankRatingLabel;

	public UIButton RankRatingTip;

	public UILabel RatingNum;

	public UILabel RankRatingLabel;

	public GameObject RatingNode;

	public GameObject MedalNode;

	public UILabel GoldMedalNumberLabel;

	public UILabel SilverMedalNumberLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
