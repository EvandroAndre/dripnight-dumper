using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTeamBattleMatchResultDataItemView : UIBaseView
{
	public GameObject SelfBG;

	public GameObject FakeBg;

	public UIEffectSprite BannerBg;

	public UILabel Nickname;

	public UILabel ClanName;

	public UIHudMatchResultItemProgressBar InfoBar1;

	public UIHudMatchResultItemProgressBar InfoBar2;

	public UIHudMatchResultItemProgressBar InfoBar3;

	public UIHudMatchResultItemProgressBar InfoBar4;

	public GameObject DataRoot;

	public UILabel InfoDataTxt1;

	public UIHudMatchResultItemProgressBar InfoBar5;

	public UIButton ProfileBtn;

	public UICustomParamUtil uiCustomParamUtil;

	public UIEffectAlphaFollowParentV2 UIEffectAlphaFollowParentV2;

	public GameObject ToxicCheck;

	public GameObject RatingContainer;

	public GameObject MvpAndRatingContainer;

	public GameObject WinMVPRatingGrade;

	public GameObject FailMVPRatingGrade;

	public UILabel InfoDataTxt2;

	public UIEffectSprite HeadIcon;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	public UIScrollView GradeScroll;

	public UICenterOnChild GradeWrapContent;

	public GameObject GradeContainer;

	public GameObject WinMVPGrade;

	public GameObject FailMVPGrade;

	public UISprite FailMVPSprite;

	public UILabel NormalGrade;

	public GameObject StreakContainer;

	public UISprite StreakIcon;

	public UILabel StreakTxt;

	public UISprite RatingBG;

	public GameObject UIFX_Silvery;

	public GameObject UIFX_Golden;

	public GameObject UIFX_MVPWin;

	public GameObject UIFX_MVPLose;

	public GameObject UIFX_MVPWinMain;

	public GameObject UIFX_MVPLoseMain;

	public GameObject SilveryMedalSprite;

	public GameObject GoldenMedalSprite;

	public UILabel MvpAndRatingPointStroke_Gold;

	public UILabel MvpAndRatingPointStroke_Silvery;

	public UILabel MvpAndRatingPointStroke_Gary;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
