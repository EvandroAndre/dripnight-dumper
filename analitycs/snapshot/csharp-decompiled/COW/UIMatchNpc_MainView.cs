using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_MainView : UIBaseView
{
	public UINetworkTexture Left_TextureTitle;

	public UIButton Left_RuleBtn;

	public UISprite Left_OpenTime;

	public UILabel Left_OpenTimeLabel;

	public UIButton Right_BtnClose;

	public UISprite Right_CloseBtnSprite;

	public UIGrid GridLeftBtns;

	public UIButton Left_MissionEntrance;

	public UINetworkTexture MissionEntrance_Texture;

	public UISprite TotalProcessFront;

	public GameObject TotalProcessEffect;

	public UINetworkTexture LNpcCharacterTexture;

	public GameObject LNpcName;

	public UINetworkTexture LNpcIsUserTag;

	public UINetworkTexture LNpcWinIcon;

	public UILabel LNpcProcessLabel;

	public GameObject LNpcProcessEffect;

	public GameObject LNpcCountDown;

	public UICountDownLabel LNpcCounDownTimeLabel;

	public UIButton LNpcCountDownTipsBtn;

	public UINetworkTexture LNpcSingleDialogBgTexture;

	public UILabel LNpcSingleDialogLabel;

	public TypewriterEffect LNpcSingleDialogLabelEffect;

	public GameObject LNpcSingleDialogContainer;

	public UISprite LNpcProcessFront;

	public UINetworkTexture RNpcCharacterTexture;

	public GameObject RNpcName;

	public UINetworkTexture RNpcIsUserTag;

	public UINetworkTexture RNpcWinIcon;

	public UILabel RNpcProcessLabel;

	public GameObject RNpcProcessEffect;

	public UISprite RNpcProcessFront;

	public GameObject RNpcCountDown;

	public UICountDownLabel RNpcCounDownTimeLabel;

	public UIButton RNpcCountDownTipsBtn;

	public GameObject RNpcSingleDialogContainer;

	public UILabel RNpcSingleDialogLabel;

	public TypewriterEffect RNpcSingleDialogLabelEffect;

	public UINetworkTexture RNpcSingleDialogBgTexture;

	public UINetworkTexture LNpcNameBg;

	public UINetworkTexture AddTokenBtnTextureBg;

	public UIButton AddTokenNormalBtn;

	public UINetworkTexture DivideProcessIcon;

	public UINetworkTexture ShowResultBtnTextureBg;

	public UIButton ShowResultNormalBtn;

	public UINetworkTexture TextureBg;

	public TweenColor TextureBgTweenColor;

	public GameObject SpecialDialogContainer;

	public UINetworkTexture SpecialDialogBg;

	public UINetworkTexture RoundEndNoticeBg;

	public UILabel SpecialDialogLSpeakerName;

	public UINetworkTexture SpecialDialogLSpeakeNameBg;

	public UINetworkTexture TPNextBtnIcon;

	public Animation TpNextBtnEffectAim;

	public UIButton TPNextDialogBtn;

	public UIButton RepeatRewardBox;

	public UINetworkTexture RepeatRewardBoxTexture;

	public UILabel TotalProcessTotalLabel;

	public UISprite CentreTokenCount;

	public UILabel CentreTokenNum;

	public UINetworkTexture RNpcNameBg;

	public UIProgressBar RNpcProcessBar;

	public UISprite RNpcProcessBg;

	public UIProgressBar LNpcProcessBar;

	public UISprite LNpcProcessBg;

	public UILabel SpecialDialogLabel;

	public TypewriterEffect SpecialDialogTypeWriterEffect;

	public UINetworkTexture SpecialDialogRSpeakerNameBg;

	public UILabel SpecialDialogRSpeakerName;

	public UISprite TotalProcessBg;

	public UIProgressBar TotalProcessBar;

	public UINetworkTexture MissionTextureRedDot;

	public UINetworkTexture Right_CloseBtnTexture;

	public Transform BoxRewardItemContranier;

	public UINetworkTexture ShowResultBtnTextureBg_Rectangle;

	public UINetworkTexture AddTokenUnNormalTexture;

	public UIButton AddTokenUnNormalBtn;

	public UINetworkTexture RNpcProcessBg_SpecialTexture;

	public UIProgressBar RnpcProcessSpecialBar;

	public UINetworkTexture RNpcProcessFront_SpecialTexture;

	public UINetworkTexture LNpcProcessBg_SpecialTexture;

	public UIProgressBar LnpcProcessSpecialBar;

	public UINetworkTexture LNpcProcessFront_SpecialTexture;

	public UISprite MissionSpriteRedDot;

	public UINetworkTexture TotalProcessBg_Texture;

	public UINetworkTexture TotalProcessFront_Texture;

	public UIProgressBar TotalProcess_TextureBar;

	public UINetworkTexture FinishedTurnRedTextureTips;

	public GameObject FinishedTurnRedSpriteTips;

	public UIButton ShowResultBtn_Rectangle;

	public UISprite RepeatRedDotSprite;

	public UINetworkTexture RepeatRewardTextureRedDot;

	public GameObject TurnFinished;

	public UIPanel GuidePanel;

	public GameObject AddTokenBtnEffect;

	public TweenPosition AddTokenFlyInEffect;

	public GameObject AddTokenFlyInNormalEffect;

	public Transform Left_NpcName;

	public Transform LNpcProcessContainer;

	public Transform Right_NpcName;

	public Transform RNpcProcessContainer;

	public GameObject NpcUpGradeEffect;

	public GameObject PlayerUpgradeEffect;

	public GameObject RNpcTurnFinishedFlyNormalEffect;

	public TweenPosition RNpcTurnFinishedFlyEffect;

	public TweenPosition LNpcTurnFinishedFlyEffect;

	public GameObject LNpcTurnFinishedFlyInNormalEffect;

	public Transform Right_TotalProcess;

	public Transform Right_Npc;

	public Transform Left_Npc;

	public GameObject RNpcProcessUpNormalEffect;

	public GameObject LNpcProcessUpNormalEffect;

	public Animation Content;

	public Transform RepeatRewardPopWndTranform;

	public UINetworkTexture LNpcSingleDialogNextBtnTexture;

	public UINetworkTexture RNpcSingleDialogNextBtnTexture;

	public GameObject RepeatRewardEffect;

	public GameObject repeatRewardNormalEffect;

	public GameObject NpcUpGradeNormalEffect;

	public GameObject PlayerUpgradeNormalEffect;

	public GameObject AddTokenBtnNormalEffect;

	public GameObject ShowResultBtnEffect;

	public GameObject ShowResultBtnNormalEffect;

	public GameObject AddTokenContainer;

	public UILabel AddTokenBtnLabel;

	public UILabel ShowResultBtnLabel;

	public UINetworkTexture TitleProcessDescTexture;

	public GameObject AsideBg;

	public UILabel AsideLabel;

	public TypewriterEffect AsideTypewriterEffect;

	public UIButton BgDialogClick;

	public Animation CenterContainer;

	public GameObject TwoPersonTalkContainer;

	public UIButton NarragationNextBtn;

	public UINetworkTexture NarragationNextBtnIcon;

	public GameObject RNpcCountDownFinished;

	public UIButton RNpcCountDownFinishedTipsBtn;

	public GameObject LNpcCountDownFinished;

	public UIButton LNpcCountDownFinishedTipsBtn;

	public UIButton RNpcSingleDialogClickMask;

	public UIButton LNpcSingleDialogClickMask;

	public UIButton LNpcSingleDialogNextBtn;

	public UIButton RNpcSingleDialogNextBtn;

	public UISprite RNpcCountDownIcon;

	public UILabel RNpcCountDownFinishedLabel;

	public UISprite RNpcCountDownTipsIcon;

	public UISprite RNpcCountDownUnFinishedIcon;

	public UISprite RNpcCountDownTipsUnFinishedIcon;

	public UILabel LNpcCountDownFinishLabel;

	public UISprite LNpcCountDownFinishedIcon;

	public UISprite LNpcCountDownTipsUnFinishedIcon;

	public UISprite LNpcCountDownUnFinishedIcon;

	public UISprite LNpcCountDownTipsIcon;

	public GameObject RNpcUpgradeBarEffect;

	public GameObject LNpcUpGradeBarEffect;

	public GameObject BgEffect;

	public GameObject RNpcUpgradeBarNormalEffect;

	public GameObject LNpcUpGradeBarNormalEffect;

	public UILabel RepeatRewardCliamNum;

	public UILabel RepeatRewardProcessNum;

	public UILabel MissionEntranceLabel;

	public UISprite Mask;

	public GameObject DivideProcessIconEffect;

	public GameObject Left_ExtraEntrance;

	public Transform TokenTrans;

	public UIButton SkipBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
