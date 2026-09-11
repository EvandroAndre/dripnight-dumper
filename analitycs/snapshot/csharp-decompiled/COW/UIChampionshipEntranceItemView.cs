using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipEntranceItemView : UIBaseView
{
	public Animation ShowDetailedInfoAnim;

	public TweenPosition UIChampionshipEntranceItem;

	public UIButton DetailedInfoBackBtn;

	public UILabel DetailedTitle;

	public UILabel CurState;

	public UIToggleButton PrepareBtn;

	public UIToggleButton OpenBtn;

	public UIToggleButton CheckBtn;

	public UIToggleButton SettleBtn;

	public UITable MatchInfo;

	public UILabel ModeName;

	public GameObject PlayerCountLabel;

	public UILabel PlayerCount;

	public UILabel PlayerCountLimitLabel;

	public GameObject MinMatchLabel;

	public UILabel MinMatchNum;

	public UILabel NoWeaponSkinBonus;

	public GameObject MonSelect;

	public GameObject MonUnSelect;

	public GameObject TueSelect;

	public GameObject TueUnSelect;

	public GameObject WedSelect;

	public GameObject WedUnSelect;

	public GameObject ThuSelect;

	public GameObject ThuUnSelect;

	public GameObject FriSelect;

	public GameObject FriUnSelect;

	public GameObject SatSelect;

	public GameObject SatUnSelect;

	public GameObject SunSelect;

	public GameObject SunUnSelect;

	public Animation Animation;

	public UIButton EntranceBtn;

	public GameObject OpenEffect;

	public GameObject ClickEffect;

	public GameObject OpenInfo;

	public GameObject SubscriptInfo;

	public UILabel Subscript;

	public UILabel OpenTimeDesc;

	public UILabel OpenTimeInDay;

	public UILabel OpenTimeInWeek;

	public UILabel StartTime;

	public UILabel SettleTime;

	public UILabel MatchFinished;

	public GameObject ComingSoon;

	public UILabel ComingTime;

	public UIButton Ticket;

	public UILabel RemainSessionLabel;

	public UILabel SeasonTime;

	public UILabel SeasonName;

	public Transform CountDown;

	public UISprite CupDefault;

	public UINetworkTexture CupCDN;

	public UITipsButton ApplyRedPoint;

	public UITipsButton TrialOpenRedPoint;

	public GameObject ClaimRewardRedPoint;

	public UIButton DetailedInfoBtn;

	public GameObject LockNode;

	public GameObject LevelCondition;

	public UILabel LevelConditionContent;

	public GameObject ScoreCondition;

	public UILabel ScoreConditionContent;

	public GameObject CreditBanNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
