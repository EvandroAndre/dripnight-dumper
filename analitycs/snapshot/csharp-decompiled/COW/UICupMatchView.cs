using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchView : UIBaseView
{
	public UIButton NoticeBtn;

	public Transform LeftTabContainer;

	public GameObject MainPage;

	public UILabel ModeName;

	public UILabel PlayerCount;

	public UILabel NoWeaponSkinBonus;

	public UILabel OpenTimeInWeek;

	public UILabel OpenTimeInDay;

	public Transform Reward1;

	public Transform Reward2;

	public Transform Reward3;

	public Transform Reward4;

	public UIButton BtnShowAllReward;

	public GameObject SeasonInfo;

	public UILabel SeasonName;

	public UILabel MatchTime;

	public UILabel SeasonNum;

	public UIButton SeasonTipsBtn;

	public Transform Center;

	public GameObject SeasonIcon;

	public UINetworkTexture NetworkTexture;

	public GameObject DefaultIcon;

	public UIToggleButton PrepareBtn;

	public UIToggleButton OpenBtn;

	public UIToggleButton CheckBtn;

	public UIToggleButton SettleBtn;

	public UILabel TierMain;

	public UILabel TierDescriptionMain;

	public UIButton BtnNewMore;

	public Transform BottomRight;

	public UIButton StartMatchBtn;

	public UISprite StartMatchBtnBG;

	public GameObject VFXStartClickable;

	public UIButton BtnMainPageJoin;

	public GameObject VFX_JoinBlink;

	public UIButton BtnMainPageRecuit;

	public GameObject VFX_RecruitBlink;

	public UILabel RemainSessionLabel;

	public GameObject TeamPage;

	public GameObject CoursePage;

	public GameObject AccomplishedPage;

	public UIButton BtnAccomplished;

	public UILabel BtnAccomplishedLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
