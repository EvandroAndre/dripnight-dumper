using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureView : UIBaseView
{
	public GameObject UIPaymentSquadTreasure;

	public GameObject Top;

	public UIButton HelpBtn;

	public GameObject CountDown;

	public GameObject Bottom;

	public GameObject TeamContentContainer;

	public UIGrid Grid;

	public GameObject UnJoinState;

	public GameObject JoinState;

	public UIButton BtnJoin;

	public GameObject CreateContainer;

	public UIButton BtnCreaet;

	public GameObject Right;

	public GameObject ProgressBar;

	public UILabel ProgressTitle;

	public UIButton ProgressHelpBtn;

	public GameObject ItemPanel;

	public GameObject Panel;

	public UIProgressBar LuckyProgressBar;

	public UISprite ProgressBarSpirte;

	public UILabel TeamInfoLabel;

	public UILabel TeamDescLabel;

	public UIButton BtnRefresh;

	public UILabel RefreshLabel;

	public UIButton BtnTeamList;

	public Transform TeamListBoxPos;

	public UIButton BtnInvite;

	public GameObject RecommendTeamInfoContainer;

	public GameObject JoinedTeamInfoContainer;

	public UILabel TeamCodeLabel;

	public UIButton BtnCopyTeamCode;

	public UIButton BtnShare;

	public UIButton BtnExit;

	public GameObject TopUpCountDownPos;

	public UIButton BtnTopup;

	public UIButton BtnClaimReward;

	public UILabel JoinedTeamNameLabel;

	public UIButton BtnConfig;

	public GameObject Center;

	public UITable TopUpFininshVFXContainer;

	public GameObject CanClaimState;

	public GameObject NoClaimState;

	public Transform BtnClaimRewardRedDotPos;

	public UINetworkTexture TitleCDN;

	public Transform TeamListRedDotPos;

	public UILabel JoinedTeamDescLabel;

	public GameObject TeamCodeTitleLabel;

	public GameObject EndPos;

	public GameObject StartPos;

	public GameObject EnableTeamList;

	public GameObject DisableTeamList;

	public GameObject CreateTeamBubble;

	public GameObject BG_small;

	public GameObject BG_big;

	public UINetworkTexture BGCDN;

	public VFXCreateHelper Flush;

	public Transform TopUpFinishStartPos;

	public Transform TopUpFinishEndPos;

	public GameObject TopUpFinishVFXContainer;

	public EffectMovement EffectMovement;

	public VFXCreateHelper VFXCreateHelper;

	public GameObject BurstVFX;

	public GameObject UIFX_ProgressBar;

	public Animation Main;

	public UILabel CreateTeamBubbleLabel;

	public UIWidget Guide1;

	public UIWidget Guide2;

	public UIButton BtnCountDownTips;

	public UILabel TitleDescUpLabel;

	public UILabel TitleDescDownLabel;

	public GameObject NoticeJoinBubble;

	public GameObject NoticeChangeProprtyBubble;

	public UILabel JoinedTeamSecretDescLabel;

	public UIButton BtnSecretShare;

	public UIButton BtnTakePhoto;

	public UILabel BtnTopUpLabel;

	public GameObject TakePhotoBubble;

	public GameObject TakePhotoHightLightState;

	public GameObject TakePhotoCommonState;

	public GameObject TakePhotoVFXContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
