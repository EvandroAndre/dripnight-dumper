using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2SubSystemView : UIBaseView
{
	public UIButton CloseMask;

	public UIButton LadderMatchBtn;

	public UIButton LeadBoardBtn;

	public UIButton MileStoneBtn;

	public UIButton AntiHackCenterBtn;

	public UIButton EsportsBtn;

	public UIButton SurveyBtn;

	public Transform LadderMatchTips;

	public Transform MileStoneTips;

	public Transform SurveyTips;

	public UIWidget LadderMatchGuideWidget;

	public UIGrid EntranceGroupGrid;

	public UIButton OnlineMatchBtn;

	public Animation Main;

	public UIButton AchievementBtn;

	public Transform AchievementTips;

	public UILabel AchievementTime;

	public GameObject OnlineMatchTips;

	public GameObject EportsLive;

	public UIButton CLanBtn;

	public Transform LeaderBoardTips;

	public GameObject LadderMatchtLock;

	public UIButton GotoBindBtn;

	public Transform LadderMatchLockTransForm;

	public GameObject LeadBoardLock;

	public Transform LeadBoardLockTransForm;

	public GameObject AchievementLock;

	public Transform AchievementLockTransForm;

	public GameObject AntiHackCenterLock;

	public Transform AntiHackCenterLockTransForm;

	public GameObject EsportsLock;

	public Transform EsportsLockTransForm;

	public GameObject ClanLock;

	public Transform ClanLockTransForm;

	public GameObject GotoBindContainer;

	public UIButton QRCodeScanBtn;

	public Transform AntiHackTips;

	public UIButton TrainMapsBtn;

	public UIButton CustomerServiceBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
