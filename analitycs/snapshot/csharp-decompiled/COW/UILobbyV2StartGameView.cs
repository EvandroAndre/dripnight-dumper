using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2StartGameView : UIBaseView
{
	public Transform Main;

	public UILobbyNewSkinChangeView RightBottomView;

	public Animation MainAnim;

	public Transform OptionalDownloaderContainer;

	public GameObject ModeMask;

	public UILabel gameModeSelected;

	public UILabel BgameModeSelected;

	public GameObject ChampionshipBonusReward;

	public UILabel GoldBonusLabel;

	public UILabel ExpBonusLabel;

	public UILabel BmapModeSelected;

	public UIButton HelperBtn;

	public UIWidget RankCompetitionGuide;

	public UIButton teamModeBtn;

	public UIWidget teamModeWidget;

	public UISprite teamIcon;

	public TweenPosition TweenPosPanelRightBottom;

	public Transform LoadOutContainer;

	public UIWidget LoadoutGuideWidget;

	public GameObject soloPanel;

	public GameObject GameObjectMatchMaking;

	public UISprite UISpriteMatchMaking;

	public UILabel SoloMatchMakingLabel;

	public UISprite LobbyStartIcon;

	public UILabel StartMatchLabel;

	public Transform SoloBonusInfoAttachPoint;

	public GameObject Guide_start_Anim;

	public UILabel SoloBtnEnterDisLabel;

	public Transform pveWeaponInfo;

	public Transform groupPanel;

	public GameObject TalentContainer;

	public UIWidget TalentGuideWidget;

	public UIButton TalentGuideMask;

	public GameObject TalentTipsIcon;

	public UIButton TalentBtn;

	public Animation NormalVeiw;

	public GameObject InRoom;

	public UISprite InRoomBG;

	public UIButton InRoomBtn;

	public UILabel InRoomLabel;

	public UIButton IncreaseBtn;

	public GameObject LadderContainer;

	public UIButton LadderBtn;

	public Transform LadderBtnTransform;

	public UIWidget LadderBtnUIWidget;

	public UIButton EnterGameBtn;

	public UISprite MapModeBtnBg;

	public UIButton MapModeBtn;

	public GameObject MapModeTipsAnim;

	public GameObject mapProtectionIcon;

	public GameObject BonusVeiw;

	public GameObject MapModeView;

	public GameObject MapModeViewLeftPos;

	public GameObject MapModeViewRightPos;

	public Transform AdsContainer;

	public GameObject EnterGameDisable;

	public UIWidget EnterGameGuideWidget;

	public UIWidget CsGuideWidget;

	public GameObject CSSpecialMatchContainer;

	public UISprite CSSpecialMatchIcon;

	public GameObject VeteranProtect;

	public GameObject mapRP;

	public GameObject BrRp;

	public GameObject CsRp;

	public UILabel mapModeSelectedLabel;

	public UITable mapMode;

	public GameObject RankProtectSheildVFX;

	public GameObject AdsMask;

	public GameObject IncreaseIcon;

	public GameObject DailyFirstWin;

	public GameObject mapModeDownloader;

	public GameObject BonusMapModeDownloader;

	public UITable BonusMapMode;

	public GameObject BonusReward;

	public UILabel BonusLabel;

	public Transform OptionalDownloaderContainerLeftPos;

	public Transform OptionalDownloaderContainerRightPos;

	public GameObject mapProtectionNode;

	public UILabel mapProtection;

	public UILabel ClanWarGroupNotFullLabel;

	public Transform BRRankIconContainer;

	public Transform CSRankIconContainer;

	public Transform LadderRedPointTrans;

	public VFXCreateHelper SeasonYearCloseVFX;

	public UISprite NewSeasonIcon;

	public UILabel NewSeasonLabel;

	public GameObject NewSeasonContainer;

	public GameObject ClanWarNode;

	public VFXCreateHelper SpecialMissionCloseVFX;

	public UILabel VeteranProtectLabel;

	public UIButton SlayDragonBuffBtn;

	public UISprite SlayDragonBuffIcon;

	public Transform SelectUIFXTrans;

	public UILabel SpecialBgStartLabel;

	public GameObject NewPlayeCon;

	public GameObject CraftlandContainer;

	public UISprite CraftlandIcon;

	public UIButton CraftlandButton;

	public GameObject teamModesPanel;

	public UIPanel UILobbyV2StartGame;

	public Transform CrossModeBannerContainer;

	public Transform NewPlayerUnlockFeatureContainer;

	public GameObject NewPlayerTempUnlockContainer;

	public UIWidget LadderBtnGuideWidget;

	public Transform LadderBtnGuideTransform;

	public GameObject InHippoCrisis;

	public UIButton InHippoCrisisBtn;

	public UISprite InHippoCrisisBG;

	public Transform GroupRankingTipsTransFrom;

	public UIButton CraftLandDetailBtn;

	public GameObject RightMask;

	public UISprite TeamModeBG;

	public GameObject BanMatchContainer;

	public UILabel BanMatchLabel;

	public Transform BanMatchTime;

	public UIButton BanMatchBtn;

	public Transform CSPeakTournamentRankIconContainer;

	public UISprite DoubleWinIcon;

	public UISprite CSPeakBg;

	public GameObject CSPeakSquadOnly;

	public UITable CSPeakSquadOnlyTable;

	public UILabel CSPeakGameModeLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
