using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipView : UIBaseView
{
	public UIButton NoticeBtn;

	public GameObject SeasonInfo;

	public UILabel SeasonName;

	public UILabel MatchTime;

	public UISprite MatchTimeBg;

	public UILabel SeasonNum;

	public UIButton SeasonTipsBtn;

	public Transform LeftTabContainer;

	public GameObject MainPage;

	public UILabel ModeName;

	public UILabel MinMatchNum;

	public UILabel NoWeaponSkinBonus;

	public UILabel OpenTimeInWeek;

	public UILabel OpenTimeInDay;

	public Transform ChampionshipReward1;

	public Transform ChampionshipReward2;

	public Transform ChampionshipReward3;

	public Transform ChampionshipReward4;

	public UIButton BtnGotoLadderPage;

	public Transform Center;

	public GameObject SeasonIcon;

	public UINetworkTexture NetworkTexture;

	public GameObject DefaultIcon;

	public UIToggleButton PrepareBtn;

	public UIToggleButton OpenBtn;

	public UIToggleButton CheckBtn;

	public UIToggleButton SettleBtn;

	public UILabel CurState;

	public UITable StateDescTable;

	public UILabel CurStateDesc;

	public Transform CountDownContainer;

	public Transform BottomRight;

	public UIButton StartMatchBtn;

	public UISprite StartMatchBtnBG;

	public GameObject VFXStartClickable;

	public UIButton BtnMainPageJoin;

	public GameObject VFX_JoinBlink;

	public UIButton BtnMainPageRecuit;

	public GameObject VFX_RecruitBlink;

	public UIButton BtnMainPageSignUp;

	public GameObject VFX_SignUpBlink;

	public UILabel RemainSessionLabel;

	public GameObject TeamPage;

	public GameObject LadderPage;

	public Transform Left;

	public GameObject LeaderBoardNotOpen;

	public GameObject Leaderboard;

	public UIToggleButtonGroup LeaderBoardTabs;

	public UIToggleButton LeaderBoardRegion;

	public UIEasyList LeaderBoardEasyList;

	public GameObject NoLeaderBoardTips;

	public GameObject Checking;

	public GameObject LeaderBoardSelf;

	public UILabel LBTips;

	public GameObject RewardInfo;

	public Animation RewardAnimation;

	public UIGrid RewardGrid;

	public Transform Rotating01;

	public Transform NewReward1;

	public Transform Reward1;

	public Transform Rotating02;

	public Transform Reward2;

	public Transform NewReward2;

	public Transform Rotating03;

	public Transform Reward3;

	public Transform NewReward3;

	public Transform Rotating04;

	public Transform Reward4;

	public Transform NewReward4;

	public UILabel Ranktips;

	public UILabel Rank;

	public UILabel SeasonTips;

	public UILabel CompletedTips;

	public UIButton ShowAllRewardBtn;

	public GameObject ChampionshipDefaultIcon;

	public UINetworkTexture ChampionshipTexture;

	public UIGrid ChampionshipRewardGrid;

	public UILabel ChampionshipLabel;

	public UILabel PlayerCount;

	public GameObject Kills;

	public GameObject Score;

	public Transform HideKillScorePos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
