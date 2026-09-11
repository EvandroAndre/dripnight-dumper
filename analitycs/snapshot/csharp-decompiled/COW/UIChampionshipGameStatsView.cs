using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipGameStatsView : UIBaseView
{
	public UILabel SeasonLabel;

	public UILabel SeasonInfoLabel;

	public UITable MatchStatsTable;

	public UILabel mMatchCount;

	public UILabel mMostRankPoint;

	public UILabel mWins;

	public UILabel mTop10P;

	public UILabel mTop50P;

	public UILabel mSurvialTime;

	public UILabel mMoveDistance;

	public UITable BattleStatsTable;

	public UILabel bTotalKill;

	public UILabel bAvgKill;

	public UILabel bAvgDamage;

	public UILabel bKD;

	public UILabel bMostKill;

	public UILabel bMostDamage;

	public UILabel bHeadShot;

	public UIButton ViewMatchHistoryBtn;

	public UIButton ShareBtn;

	public Animator ShareIconAnimator;

	public UISprite ScreenshotTopBanner;

	public UINetworkTexture HeadshotRemote;

	public GameObject HeadshotDefault;

	public UIEffectSprite HeadshotLocal;

	public UILabel PlayerNickname;

	public UILabel PlayerID;

	public UISprite FreeFireLogo;

	public Transform TeamOverview;

	public GameObject bTotalKillObj;

	public GameObject bHeadShotObj;

	public GameObject bKDObj;

	public GameObject bAvgKillObj;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
