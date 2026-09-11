using GCommon;
using UnityEngine;

namespace COW;

public class UIElitePassChallengeView : UIBaseView
{
	public Transform LeftTabContainer;

	public UIButton WeeklyHelpBtn;

	public Transform CountDown;

	public GameObject WeeklyContainer;

	public UILabel WeekLabel;

	public GameObject DailyContainer;

	public UIButton ClaimAllBtn;

	public UIButton DailyHelpBtn;

	public UILabel TreasureBoxLabel;

	public UIButton TreasureBoxClaimBtn;

	public GameObject TreasureBoxNotClaim;

	public GameObject TreasureBoxCanClaim;

	public UILabel TreasureBoxNotClaimLabel;

	public UILabel TreasureBoxCanClaimLabel;

	public GameObject TreasureBoxClaimed;

	public UILabel TreasureBoxClaimedLabel;

	public UILabel WeekLabelBg;

	public UILabel DayLabel;

	public UILabel DayLabelBg;

	public GameObject BadgeIconFP;

	public GameObject BadgeIconPP;

	public UIProgressBar BPProgress;

	public GameObject BPCon;

	public UIButton BooyahPassBtn;

	public UILabel BadeLevelLabel;

	public UILabel DailyMissionProgressLabel;

	public GameObject DailyChest;

	public GameObject ImportentRewardCon;

	public UIButton ImportentRewardCheckBtn;

	public UILabel ImportentRewardLabel;

	public UIButton ImportentRewardCanClaim;

	public GameObject ImportentRewardNotClaim;

	public GameObject ImportentRewardClaimed;

	public GameObject TreasureBoxContainer;

	public UINetworkTexture FPBGTexture;

	public UINetworkTexture PPBGTexture;

	public UIButton ImportentRewardLock;

	public GameObject DailyFPRewardItem;

	public UIButton DailyFPRulesTips;

	public UILabel DailyPPRewardName;

	public UIButton DailyPPRulesTips;

	public GameObject PPDailyNotClaim;

	public GameObject PPDailyCanClaim;

	public GameObject PPDailyClaimed;

	public UIButton PPDailyClaimBtn;

	public GameObject DailyPPRewardItem;

	public UILabel HasOwnWeaponKey;

	public UISprite DailyPPNameBg;

	public GameObject DailyPPNameCon;

	public UILabel DailyPPRewardIconName;

	public Transform DailyMissionProgressLoneLyTransform;

	public VFXCreateHelper BPLevelUpVFX;

	public VFXCreateHelper BPClaimVfx;

	public UIScrollView ChallengeScrollView;

	public GameObject BackFlow;

	public GameObject TaskRefresh;

	public UILabel TaskRefreshCountLabel;

	public UILabel BackFlowExperienceLabel;

	public UIButton PrivilegeBtn;

	public UITable2 Table2;

	public Transform Table2Transform;

	public UILabel CircleRewardNum;

	public UILabel DailyMissionProgressLabelRight;

	public Animation EntryAnim;

	public UIWidget Guide1;

	public UIPanel UIElitePassChallenge;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
