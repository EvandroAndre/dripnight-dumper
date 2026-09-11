using GCommon;
using UnityEngine;

namespace COW;

public class UICustomRoomView : UIBaseView
{
	public GameObject LeftContainer;

	public UISprite Map;

	public UIPanel MapExtraInfoPanel;

	public UISprite weatherBg;

	public UISprite WeatherIcon;

	public UILabel MapName;

	public UIButton WSBtnFullPreview;

	public UINetworkTexture MapTexture;

	public GameObject WSMapContainer;

	public UILabel RoomMode;

	public UILabel PlayerNum;

	public UILabel GameMode;

	public UIButton tipsbutton;

	public GameObject WorkShopGo;

	public GameObject WorkShopTag;

	public UIGrid Tags;

	public UILabel WorkShopDesc1;

	public UITable WorkShopInfoTable;

	public UILabel WorkShopDesc2;

	public UILabel AuthorName;

	public UIButton AuthorBtn;

	public GameObject WorkShopCode;

	public UILabel CodeNum;

	public UIButton CopyCodeBtn;

	public GameObject RoomSettingDragCollider;

	public UIScrollView RoomSettingtScrollView;

	public UIPanel RoomSettingtPanel;

	public UIGrid SettingGrid;

	public UIButton InfoPanelOpenBtn;

	public UIButton InfoPanelCloseBtn;

	public UILabel RoomId;

	public UIGrid Flags;

	public GameObject Lock;

	public GameObject Emulator;

	public UIGrid TopBtnGrid;

	public UIButton SubscriptionBtn;

	public GameObject SubscriptionIdle;

	public GameObject SubscriptionSuccess;

	public UIButton CustomizeBtn;

	public UISprite SettingBtnBG;

	public UILabel CustomizeTxt;

	public UIButton LookOverBtn;

	public UIButton OtherBtn;

	public UIButton WorkShopShareBtn;

	public UISprite InfoPanelBG;

	public Transform InfoPanelTop;

	public Transform InfoPanelBottom1;

	public Transform InfoPanelBottom2;

	public Transform BGBottom1;

	public GameObject BGBottom2;

	public Transform BGTop;

	public UISprite LanguageSprite;

	public GameObject RightContainer;

	public UILabel RoomStatus;

	public UIButton ToggleDisplayTypeBtn;

	public UILabel DisplayTypeLabel;

	public UIButton InviteBtn;

	public UISprite InviteBtnBG;

	public UIButton ClearBtn;

	public UIButton SearchBtn;

	public UISprite SearchBtnSprite;

	public UIInput SearchInput;

	public UIButton Start;

	public UICountDownLabel CountDownTxt;

	public UIButton Ready;

	public UILabel ReadyLabel;

	public GameObject Waiting;

	public UILabel WatingLabel;

	public UILabel RoomCardTipsLabel;

	public GameObject RoomCardTips;

	public GameObject RoomCardGo;

	public UIButton RoomCardBtn;

	public GameObject LoadoutGo;

	public GameObject ObserverListGo;

	public UIScrollView ObserverListScrollView;

	public UIGrid ObserverListGrid;

	public UIButton OBHideBtn;

	public UIButton OBShowBtn;

	public UILabel OBTitle;

	public UILabel OBCount;

	public UIScrollView PlayerListScrollView;

	public UIEasyList PlayerListGrid;

	public UIButton BackBtn;

	public GameObject ChatContainer;

	public UIScrollView RoomChatScrollView;

	public UIPanel RoomChatPanel;

	public UITable MessageTable;

	public UIWidget DragCollider;

	public UIButton ChatDragColliderBtn;

	public UISprite ChatBG;

	public GameObject NoMessage;

	public UISlider ProgressBar;

	public GameObject ChatStyle1;

	public UIButton CommonChatBtn;

	public GameObject ChatStyle2;

	public UIButton ChatBtn2;

	public GameObject VoiceChatBtn;

	public UIButton MicToggle;

	public UISprite MicSprite;

	public UISprite MicMask;

	public UISprite MicBan;

	public UIButton SpeakerToggle;

	public UISprite SpeakerSprite;

	public UISprite SpeakerMask;

	public GameObject SystemHint;

	public UILabel SystemHintLabel;

	public Transform DownloadContainer;

	public GameObject DownloadBg;

	public GameObject TagGo;

	public UILabel LabelTag;

	public UIHorizontalBox Table;

	public GameObject AutoMatch;

	public UICheckboxButton CheckBtn;

	public UIWidget AutoMathcGuideWidget;

	public UISprite StartBG;

	public UILabel autoLabel;

	public UILabel ModeInfo;

	public UILabel RoundInfo;

	public UILabel TeamInfo;

	public UILabel LevelLimit;

	public UIScrollView CustomRoomParamsScrollView;

	public UIWidget ScrollViewDragger;

	public UIButton CopyIDBtn;

	public UIButton Remind;

	public Animation BellAnim;

	public Animation RemindProgressAnim;

	public UIButton DisClaimBtn;

	public GameObject Disclaimer;

	public UIButton TeamInfoBtn;

	public GameObject NormalVoiceBtnGroup;

	public UILabel NormalSpeakerLabel;

	public UILabel NormalMicLabel;

	public UISprite NormalMicSprite;

	public UISprite NormalMicMask;

	public UISprite NormalSpeakerSprite;

	public UISprite NormalSpeakerMask;

	public UISprite NormalMicBan;

	public UIButton NormalMicToggle;

	public UIButton NormalSpeakerToggle;

	public Transform RoomVoicePos;

	public UINetworkTextureExt KolAuthorIcon;

	public UIButton KolAuthorButton;

	public UILabel OBHideTitle;

	public UILabel OBHideCount;

	public Transform LobbyInvitePos;

	public UILabel TeamInfolLabel;

	public GameObject NoTeamInfoBtn;

	public UILabel SKillWarningLabel;

	public GameObject SoloActiveSkillContainer;

	public GameObject DisableStart;

	public GameObject RoomQRCodeBtnGameObject;

	public UIButton RoomQRCodeBtn;

	public UIToggleButtonGroup AdvSettingContainer;

	public Transform AdvSettingLeftContontainerPosY;

	public UIToggleButton ShowLeftInfoBtn;

	public UIToggleButton ScoreBoardBtn;

	public Transform ScoreBoardOpenPos;

	public Transform NormalSettingLeftContontainerPosY;

	public GameObject AdvRoomInfoBG1;

	public GameObject AdvRoomInfoBG2;

	public GameObject NormalRoomTitle;

	public UIButton CopyIDBtnAdv;

	public UILabel AdvRoomId;

	public UISprite AdvDarkBG;

	public UISprite NotAvaliableBG;

	public UIPanel CtrlPanel;

	public Transform InfoPanelBottom2Adv;

	public Transform BGBottom2Adv;

	public UILabel AdvRoomName;

	public UISprite NotAvaliableBGLowPos;

	public GameObject SilenceContainer;

	public UILabel SilenceLabel;

	public Transform SilenceTime;

	public GameObject MicWndPos;

	public GameObject SpeakerWndPos;

	public UICountDownLabel RoomDismissCountDown;

	public UIButton RecruitBtn;

	public UITable CommonContainerTable;

	public GameObject CommonCintainer;

	public UIButton SilenceRecruitBtn;

	public UITable SilenceContainerTable;

	public GameObject observerGo;

	public GameObject BGBottom3;

	public UISprite TournamentInfoPanelBG;

	public GameObject TournamentInfo;

	public UILabel TournamentMatchName;

	public UILabel TournamentID;

	public UIButton CopyTournamentIDBtn;

	public GameObject TournamentRound;

	public UILabel TournamentRoundLabel;

	public GameObject CountDown;

	public GameObject line;

	public GameObject topContainer;

	public UICountDownLabel CountDownLabel;

	public UILabel HostInactiveStatus;

	public UIButton HostRecoverBtn;

	public GameObject MicPressedVFX;

	public Transform MicWndPos_NoPress;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
