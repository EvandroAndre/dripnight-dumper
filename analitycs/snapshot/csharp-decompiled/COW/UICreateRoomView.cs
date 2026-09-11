using GCommon;
using UnityEngine;

namespace COW;

public class UICreateRoomView : UIBaseView
{
	public GameObject RoomTypeBtns;

	public GameObject LeagueNormalRoomTab;

	public UIToggleButton LeagueNormalToggleBtn;

	public GameObject CasualRoomTab;

	public UIToggleButton CasualToggleBtn;

	public GameObject BatchRoomTab;

	public UIToggleButton BatchToggleBtn;

	public GameObject TabBg;

	public GameObject RoomGameSettingBtnGo;

	public UILabel Title;

	public GameObject RoomCardGo;

	public GameObject InfoPanel;

	public UIPanel GameSettingMaskPanel;

	public UIButton GameSettingMask;

	public UIPanel RoomSettingPanel;

	public UIScrollView RoomSettingPanelScorll;

	public UIGrid UIGridMapGrid;

	public UIToggleButtonGroup UIToggleButtonGroupMapGrid;

	public UICreateRoomMapItem MapItemObj;

	public UIWidget GameModePopMenu;

	public UIButton HelpeBtn;

	public UIInput NameInput;

	public UIInput CodeInput;

	public UILabel GroupModeLabel;

	public GameObject Mode;

	public UIToggleButton SoloToggle;

	public UISprite SoloLabelCheckmark;

	public UILabel SoloLabel;

	public UIToggleButton DuoToggle;

	public UISprite DuoCheckmark;

	public UILabel DuoLabel;

	public UIToggleButton QuadToggle;

	public UISprite QuadCheckmark;

	public UILabel QuadLabel;

	public UIToggleButton HexaToggle;

	public UISprite HexaCheckmark;

	public UILabel HexaLabel;

	public UIGrid RoomSettingDropListGrid;

	public GameObject MembersGo;

	public GameObject SpectatorsGo;

	public UIPanel RoomSettingMaskPanel;

	public UIButton RoomSettingMask;

	public GameObject GameSettingDragCollider;

	public UIPanel UIPanelGameSettingPanel;

	public UIScrollView UIScrollViewGameSettingPanel;

	public UITable GameSettingTable;

	public UIGrid UIGridDropListGrid;

	public UIToggleButtonGroup UIToggleButtonGroupDropListGrid;

	public UILabel LblSubModeDes;

	public GameObject GameSettingCSModeGo;

	public GameObject CSTotalRoundGo;

	public GameObject CSInitCoinGo;

	public UIGrid GameSettingDropListGrid;

	public GameObject FightClubTotalRoundGo;

	public GameObject ReviveGo;

	public GameObject HPGo;

	public GameObject EPGo;

	public GameObject SpeedGo;

	public GameObject JumpHeightGo;

	public UIGrid GameSettingToggleGrid;

	public GameObject WeatherTypeGo;

	public GameObject UnlimitedAmmoGo;

	public GameObject NoFallingDamageGo;

	public GameObject NoLoadoutGo;

	public GameObject NoAirdropGo;

	public GameObject NoSkillGo;

	public GameObject NoVehicleGo;

	public GameObject PowerGunGo;

	public GameObject NoUAVGo;

	public GameObject NoBombGo;

	public GameObject NoZeppelinGo;

	public GameObject HideEnemyClothGo;

	public GameObject HideHudGo;

	public GameObject FriendDmgGo;

	public GameObject InGameChatGo;

	public GameObject ShopFlowGo;

	public GameObject UseRandomMapGo;

	public GameObject AuxAimGo;

	public GameObject GameSettingPanelArrow;

	public UIWidget OBSettingPanel;

	public UIGrid OBSettingToggleGrid;

	public GameObject OBEnabledGo;

	public GameObject AccDataGo;

	public GameObject HideKillInfoGo;

	public GameObject ReplayEnabledGo;

	public GameObject Emulator;

	public GameObject EnableRoleCheck;

	public UIButton OBSettingMask;

	public GameObject CSAdSettingPanel;

	public GameObject UnavailablePanel;

	public UILabel UnavailableTxt;

	public UIGrid BtnGrid;

	public UIButton CancelBtn;

	public UIButton ConfirmBtn;

	public UIButton ReOpenBtn;

	public UIGrid ModeGrid;

	public UIToggleButton PentaToggle;

	public UISprite PentaCheckmark;

	public UILabel PentaLabel;

	public GameObject AutoRevival;

	public GameObject SaveZoneSpeed;

	public GameObject SaveZoneDamage;

	public UIScrollView MapScrollView;

	public Transform MatchStartBuff;

	public GameObject GameMissionGo;

	public GameObject ScoreVisible;

	public GameObject LevelLimitGo;

	public GameObject BagPackLogoEnableGo;

	public GameObject GlobalMissionGo;

	public GameObject OBSwitchSeat;

	public GameObject FightReplayEnableGo;

	public Transform TechAirdrop;

	public GameObject NoHotZone;

	public UIToggleButtonGroup RoomType;

	public UIGrid RoomTypeGrid;

	public UIToggleButton NormalRoomToggle;

	public UIToggleButton AdavancedRoomToggle;

	public UILabel ConfirmNormalLabel;

	public GameObject TopLeft;

	public GameObject MoveSafeZoneGo;

	public GameObject AFKPunishment;

	public UIButton CreateRuleCDN;

	public UIButton PresetSaveBtn;

	public UICountDownLabel CountDownLabel;

	public GameObject HeadShotOnlyGo;

	public GameObject SoloActiveSkillGo;

	public GameObject DoubleKillScoreGo;

	public GameObject BRWeaponBox;

	public GameObject UnlimitedThrowables;

	public Transform PrivilegeVoice;

	public Transform ScoreBoard;

	public UILabel AdvCardCount;

	public UITable RoomSettingTable;

	public GameObject ItemGeneratorGo;

	public GameObject RoomTypePanel;

	public UISprite AdvRoomCardIcon;

	public GameObject SettingCon;

	public GameObject GameAffixGo;

	public GameObject BanPickGo;

	public GameObject ShowWinRateGo;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
