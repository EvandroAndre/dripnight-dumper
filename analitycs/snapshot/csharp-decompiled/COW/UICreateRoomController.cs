using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UICreateRoomController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<DropListConfigInfo> _003C_003E9__169_0;

		public static Comparison<DropListConfigInfo> _003C_003E9__169_1;

		public static Comparison<DropListConfigInfo> _003C_003E9__169_2;

		public static Comparison<DropListConfigInfo> _003C_003E9__169_3;

		public static Predicate<DropListConfigInfo> _003C_003E9__220_1;

		internal bool _003CRefreshGameDropInfo_003Eb__169_0(DropListConfigInfo cfg)
		{
			return false;
		}

		internal int _003CRefreshGameDropInfo_003Eb__169_1(DropListConfigInfo a, DropListConfigInfo b)
		{
			return 0;
		}

		internal int _003CRefreshGameDropInfo_003Eb__169_2(DropListConfigInfo a, DropListConfigInfo b)
		{
			return 0;
		}

		internal int _003CRefreshGameDropInfo_003Eb__169_3(DropListConfigInfo a, DropListConfigInfo b)
		{
			return 0;
		}

		internal bool _003CRefreshGameSettingTabNewTag_003Eb__220_1(DropListConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass209_0
	{
		public uint mapConfigId;

		internal void _003CUpdateRoomMapItemDownloadStatus_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass214_0
	{
		public uint drop;

		internal bool _003CSelectDropListItem_003Eb__0(UIRoomDropListItemController i)
		{
			return false;
		}
	}

	protected UICreateRoomView m_View;

	protected RoomCreateRuleDataManager m_DataManager;

	protected UIModelCustomRoom m_CustomRoomModel;

	protected List<PopMenuData> m_DataList;

	protected uint m_MapConfigId;

	protected string m_Name;

	protected string m_Code;

	protected uint m_GroupMode;

	protected uint m_MemberNum;

	protected uint m_SpectatorNum;

	protected uint m_LevelLimitNum;

	protected string m_Hp;

	protected string m_Ep;

	protected string m_Speed;

	protected string m_JumpHeght;

	protected uint m_ReviveSwitch;

	protected string m_CSTotalRound;

	protected uint m_CSInitEcoId;

	protected string m_FightClubTotalRound;

	protected bool m_OBEnabled;

	protected int m_OBSwitchSeatEnabled;

	protected bool m_IsAdvRoomChosen;

	protected bool m_IsAFKPunishOpen;

	protected bool m_IsScoreBoardOpen;

	protected uint m_CurMatchStartBuffKey;

	protected int m_CurAirDropTypeKey;

	protected bool m_IsWaitingRoomCard;

	protected bool m_EmulatorCheck;

	protected uint m_VisualStyle;

	protected uint m_RoomSetting;

	protected uint m_RoomSetting2;

	protected uint m_RoomSetting3;

	protected bool m_EnableLimitedEventGameplay;

	protected bool m_EnableSkillBP;

	protected int m_ScoreVisible;

	protected bool m_RoleCheck;

	protected string m_CDNLink;

	protected bool m_SoloActiveSkill;

	protected UIStandardTabController m_TabCtrl;

	protected UIRoomToggleBtnTemplateController m_WeatherCtrl;

	protected UIRoomToggleBtnTemplateController m_LimitedAmmoCtrl;

	protected UIRoomToggleBtnTemplateController m_LimitedThrowablesCtrl;

	protected UIRoomToggleBtnTemplateController m_FallDamageCtrl;

	protected UIRoomToggleBtnTemplateController m_AutoRevivalCtrl;

	protected UIRoomToggleBtnTemplateController m_LoadoutCtrl;

	protected UIRoomToggleBtnTemplateController m_AirdropCtrl;

	protected UIRoomToggleBtnTemplateController m_SaveZoneSpeedCtrl;

	protected UIRoomToggleBtnTemplateController m_NoHotZoneCtrl;

	protected UIRoomToggleBtnTemplateController m_BRMoveSafeZoneCtrl;

	protected UIRoomToggleBtnTemplateController m_SkillCtrl;

	protected UIRoomToggleBtnTemplateController m_VehicleCtrl;

	protected UIRoomToggleBtnTemplateController m_SaveZoneDamageCtrl;

	protected UIRoomToggleBtnTemplateController m_UAVCtrl;

	protected UIRoomToggleBtnTemplateController m_BombCtrl;

	protected UIRoomToggleBtnTemplateController m_ReplayCtrl;

	protected UIRoomToggleBtnTemplateController m_EmulatorCtrl;

	protected UIRoomToggleBtnTemplateController m_ZeppelinCtrl;

	protected UIRoomToggleBtnTemplateController m_ItemGeneratorCtrl;

	protected UIRoomToggleBtnTemplateController m_GameAffixCtrl;

	protected UIRoomToggleBtnTemplateController m_HideClothCtrl;

	protected UIRoomToggleBtnTemplateController m_FriendlyFireCtrl;

	protected UIRoomToggleBtnTemplateController m_HideHudCtrl;

	protected UIRoomToggleBtnTemplateController m_RoomInGameChatCtrl;

	protected UIRoomToggleBtnTemplateController m_ShopFlowCtrl;

	protected UIRoomToggleBtnTemplateController m_UseRandomMapCtrl;

	protected UIRoomToggleBtnTemplateController m_AuxAimCtrl;

	protected UIRoomToggleBtnTemplateController m_GameMissionCtrl;

	protected UIRoomToggleBtnTemplateController m_GlobalMissionCtrl;

	protected UIRoomToggleBtnTemplateController m_AFKPunishmentCtrl;

	protected UIRoomToggleBtnTemplateController m_HeadShotOnlyCtrl;

	protected UIRoomToggleBtnTemplateController m_SoloActiveSkillCtrl;

	protected UIRoomToggleBtnTemplateController m_BRWeaponBoxCtrl;

	protected UIRoomToggleBtnTemplateController m_PrivilegeVoiceCtrl;

	protected UIRoomToggleBtnTemplateController m_PrivilegeScoreBoardCtrl;

	protected UIRoomToggleBtnTemplateController m_BanPickCtrl;

	protected UIRoomShowWinRateToggleController m_ShowWinRateCtrl;

	protected UIRoomDropListTemplateController m_MembersCtrl;

	protected UIRoomDropListTemplateController m_SpectatorsCtrl;

	protected UIRoomDropListTemplateController m_LevelLimitCtrl;

	protected UIRoomDropListTemplateController m_HPCtrl;

	protected UIRoomDropListTemplateController m_EPCtrl;

	protected UIRoomDropListTemplateController m_SpeedCtrl;

	protected UIRoomDropListTemplateController m_JumpHeghtCtrl;

	protected UIRoomDropListTemplateController m_ReviveSwitchCtrl;

	protected UIRoomDropListTemplateController m_MatchStartBuffCtrl;

	protected UIRoomDropListTemplateController m_AirdropTypeCtrl;

	protected UIRoomDropListTemplateController m_CSTotalRoundCtrl;

	protected UIRoomDropListTemplateController m_CSInitEcoCtrl;

	protected UIRoomDropListTemplateController m_FightClubTotalRoundCtrl;

	protected UIPopMenuSmallControler m_SelectModePopMenuSmallCtrl;

	protected uint m_RoomType;

	protected UIRoomToggleBtnTemplateController m_PowerGunCtrl;

	protected UICreateRoomSettingCSAdController m_SettingCSAdCtrl;

	protected const int ROOM_CODE_MAX_LENGTH = 10;

	protected const uint ESPORTS_DROP_ID = 9u;

	protected const uint RANDOM_ROOM_DROP_ID = 10u;

	protected const float GAME_SETTING_PLAYER_MEMBER_POPMENU_OFFEST = 195f;

	protected const float GAME_SETTING_DROP_LIST_GRID_POPMENU_OFFSET = 189f;

	protected const float GAME_SETTING_CS_GRID_POPMENU_OFFSET = 189f;

	protected bool m_IsSettingController;

	protected Color disableColor;

	protected List<uint> m_MapIdList;

	private List<UICreateRoomMapItem> m_MapItemList;

	private List<StandardTabItemViewData> m_tabs;

	private bool m_CheatCodeInit;

	private bool m_PowerGunShow;

	private bool m_ShowWinToggleStateInitialized;

	private string m_ShowWinToggleStateInitializedKey;

	protected RoomPreviewSettings m_RoomPreviewConfig;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private List<UIRoomDropListItemController> m_RoomDropListItems;

	public uint MapConfigId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string CSTotalRound => null;

	public uint RoomType => 0u;

	protected List<UICreateRoomMapItem> MapItemList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void Awake()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void RecordRoomSettingsAfterInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void InitPopMenus()
	{
	}

	protected override void OnInitDepth()
	{
	}

	private void InitStandardTabs()
	{
	}

	protected virtual void InitToggleBtns()
	{
	}

	protected void RefreshClanRoomBtn()
	{
	}

	protected virtual void RefreshRoomCard()
	{
	}

	protected EInventory.ItemSubType GetCurrentRoomCardType()
	{
		return EInventory.ItemSubType.ItemSubType_NONE;
	}

	private void InitRegionSwitch()
	{
	}

	private void SetTogglesStatus()
	{
	}

	private void RefreshGameMissionToggleStatus()
	{
	}

	private void RefreshGlobalMissionToggleStatus()
	{
	}

	protected virtual void CalMapConfig()
	{
	}

	private void InitUIContents()
	{
	}

	private void RefreshShowWinRateToggle(bool forceRefresh)
	{
	}

	private void InitShowWinToggleStateIfNeeded()
	{
	}

	private bool GetInitialShowWinToggleState()
	{
		return false;
	}

	private string GetRoomCreateRuleKey()
	{
		return null;
	}

	private uint GetRoomCreateRuleShowWinState()
	{
		return 0u;
	}

	protected bool ShouldShowShowWinRateToggle()
	{
		return false;
	}

	protected bool GetShowWinUploadValue()
	{
		return false;
	}

	protected uint ApplyShowWinSetting3(uint roomSetting3, bool showWin)
	{
		return 0u;
	}

	private void OnSelectMap(UIToggleButton button)
	{
	}

	protected void OnSoloToggleClick()
	{
	}

	protected void OnDuoToggleClick()
	{
	}

	protected void OnQuadToggleClick()
	{
	}

	protected void OnPentaToggleClick()
	{
	}

	protected void OnHexaToggleClick()
	{
	}

	protected void OnGroupModeToggleClick(uint groupMode)
	{
	}

	protected void OnBtnLeagueNormalRoomClick()
	{
	}

	protected void OnBtnNormalRoomClick()
	{
	}

	protected void OnBtnAdvanceRoomClick()
	{
	}

	protected virtual void OnAdvanceStateChanged()
	{
	}

	private void RefreshAdvancedRoomToggleState()
	{
	}

	protected void OnBtnCasualRoomClick()
	{
	}

	protected void OnBtnBatchRoomClick()
	{
	}

	private void OnRoomSettingClick()
	{
	}

	private void OnGameSettingClick()
	{
	}

	private void OnOBSettingClick()
	{
	}

	private void OnCSAdSettingClick()
	{
	}

	private void ShowUnAvaliblePanelIfNeeded()
	{
	}

	private UIToggleButton GetGroupModeToggleBtn(uint groupMode)
	{
		return null;
	}

	protected void SetFirstValidGroupMode()
	{
	}

	protected void SetValidMenuData()
	{
	}

	private void RefreshGameSettingInfo()
	{
	}

	protected void RefreshGameDropInfo(bool selectDefault = true)
	{
	}

	protected void RepositionAllSettings()
	{
	}

	protected void SetGameModeSpecificUI()
	{
	}

	private void UpdateBtnGrid()
	{
	}

	private List<PopMenuData> GenerateMembersMenuData()
	{
		return null;
	}

	private void OnMemberSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateLevelLimitMenuData()
	{
		return null;
	}

	private void OnLevelLimitSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateSpectatorsMenuData()
	{
		return null;
	}

	private void OnSpectatorSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateHPMenuData()
	{
		return null;
	}

	private void OnHPSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateEPMenuData()
	{
		return null;
	}

	private void OnEPSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateSpeedMenuData()
	{
		return null;
	}

	private void OnSpeedSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateJumpHeightMenuData()
	{
		return null;
	}

	private void OnJumpHeightSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateReviveMenuData()
	{
		return null;
	}

	private void OnReviveSelected(object data)
	{
	}

	private List<PopMenuData> GenerateMatchStartBuffData()
	{
		return null;
	}

	private void OnMatchStartBuffDSelected(object data)
	{
	}

	private List<PopMenuData> GenerateAirdropTypeData()
	{
		return null;
	}

	private void OnAirDropTypeSelected(object data)
	{
	}

	public void AutoRevivalSetStates()
	{
	}

	public void RefreshADCSRelatedInfo(object[] data)
	{
	}

	public bool IsGameAffixOn()
	{
		return false;
	}

	public void RefreshGameAffix()
	{
	}

	private List<PopMenuData> GenerateFightClubRoundNumMenuData()
	{
		return null;
	}

	private void OnFightClubRoundNumSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateRoundNumMenuData()
	{
		return null;
	}

	private void OnRoundNumSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateInitCoinMenuData()
	{
		return null;
	}

	private void OnInitCoinSelected(object obj)
	{
	}

	private bool IsSocialRoomMode(uint modeId)
	{
		return false;
	}

	private bool IsCurrentSocialRoomMode()
	{
		return false;
	}

	protected void GenerateGameModeMenuData()
	{
	}

	protected void RefreshHelpBtn()
	{
	}

	protected void OnModeSelected(object obj)
	{
	}

	protected void RefreshMapGridView()
	{
	}

	protected void UpdateRoomMapItemDownloadStatus(uint mapID, uint gameMode, UICreateRoomMapItem item)
	{
	}

	protected void OnMapToggleSelect(uint configID)
	{
	}

	protected void OnMapItemClick()
	{
	}

	private void ProcessWeatherOnMapSelected()
	{
	}

	protected uint SetFirstValidMapByMode(uint modeId)
	{
		return 0u;
	}

	protected void SelectDropListItem(uint drop, bool isInit)
	{
	}

	private bool CanDropListItemClick()
	{
		return false;
	}

	protected void OnDropListItemSelected(object[] param)
	{
	}

	protected void InitOtherSettingsByDrop(DropListConfigInfo info)
	{
	}

	private void UpdateSkillLoadoutExclusiveState()
	{
	}

	private void UpdateBanPickState()
	{
	}

	private void RefreshGameSettingTabNewTag()
	{
	}

	private void UpdateSkillHelpKey()
	{
	}

	private void UpdateLoadoutHelpKey()
	{
	}

	private void ApplyDefaultRoundNum(string defaultRound)
	{
	}

	private void ApplyDefaultEconomy(string defaultEco)
	{
	}

	private void ApplyDefaultAirdropType(string defaultAirdrop)
	{
	}

	private void ApplyDefaultLevelLimit()
	{
	}

	protected void OnBtnConfirm()
	{
	}

	protected bool ShowBuyItemPop(EInventory.ItemSubType cardType)
	{
		return false;
	}

	private void OnCreateRuleCDNClick()
	{
	}

	private void OnHelpBtnCLick()
	{
	}

	private void ConfirmCreateRoom()
	{
	}

	protected void ShowNormalConfirmPop()
	{
	}

	private void CloseUI(object[] data)
	{
	}

	private void OnBtnClose()
	{
	}

	private void OnBtnReset()
	{
	}

	private bool IsRoomSettingsTrue(ECustomRoomSetting setting)
	{
		return false;
	}

	private void SetRoomSetting(ECustomRoomSetting setting, bool value)
	{
	}

	private void SetRoomSetting(uint setting, bool value)
	{
	}

	private bool IsRoomSettingsTrue(uint setting)
	{
		return false;
	}

	protected void SetRoomSettingValue(ECustomRoomSetting start, ECustomRoomSetting end, uint value)
	{
	}

	protected uint GetRoomSettingValue(ECustomRoomSetting start, ECustomRoomSetting end)
	{
		return 0u;
	}

	protected uint GetRoomSetting3Value(ECustomRoomSetting3 start, ECustomRoomSetting3 end)
	{
		return 0u;
	}

	private bool IsRoomSettings3True(ECustomRoomSetting3 setting)
	{
		return false;
	}

	private void SetRoomSetting3(ECustomRoomSetting3 start, ECustomRoomSetting3 end, uint value)
	{
	}

	private void SetRoomSetting3(ECustomRoomSetting3 setting, bool value)
	{
	}

	private bool IsRoomSettings2True(ECustomRoomSetting2 setting)
	{
		return false;
	}

	private void SetRoomSetting2(ECustomRoomSetting2 setting, bool value)
	{
	}

	private void SetRoomSetting2(uint setting, bool value)
	{
	}

	private bool IsRoomSettings2True(uint setting)
	{
		return false;
	}

	private void SetInGameChatEnableOnRoomTypeChange()
	{
	}

	protected void SetRoomSetting2Value(ECustomRoomSetting2 start, ECustomRoomSetting2 end, uint value)
	{
	}

	protected uint GetRoomSetting2Value(ECustomRoomSetting2 start, ECustomRoomSetting2 end)
	{
		return 0u;
	}

	protected void OnBtnPresetSave()
	{
	}

	protected void OnPresetChosen()
	{
	}

	private void RefreshPresetBtns()
	{
	}

	private void RefreshSaveBtnState(bool isSocialIsland)
	{
	}

	public void PreparePresetRoomCreateOverride(MapModeData mapModeData, PresetRoomCreateRuleInfo ruleInfo, DropListConfigInfo dropInfo)
	{
	}

	public void RequestCreateRoomForPreset()
	{
	}

	private static uint GetPresetFirstValue(uint[] values, uint defaultValue)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CInitToggleBtns_003Eb__128_0()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_1()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_2()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_3()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_4()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_5()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_6()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_7()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_8()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_9()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_10()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_11()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_12()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_13()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_14()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_15()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_16()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_17()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_18()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_19()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_20()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_21()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_22()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_23()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_24()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_25()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_26()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_27()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_28()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_29()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_30()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_31()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_32()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_33()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_34()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_35()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_36()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_37()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_38()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_39()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_40()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_41()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_42()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_43()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_44()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_45()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_46()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_47()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_48()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_49()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_50()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_51()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_52()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_53()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_54()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_55()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_56()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_57()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_58()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_59()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_60()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_61()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_62()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_63()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_64()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_65()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_66()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_67()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_68()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_69()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_70()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_71()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_72()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_73()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_74()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_75()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_76()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_77()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_78()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_79()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_80()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_81()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_82()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_83()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_84()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_85()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_86()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_87()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_88()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_89()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_90()
	{
	}

	private void _003CInitToggleBtns_003Eb__128_91()
	{
	}

	private bool _003CRefreshMapGridView_003Eb__208_0(uint mapId)
	{
		return false;
	}

	private bool _003COnDropListItemSelected_003Eb__216_0(StandardTabItemViewData t)
	{
		return false;
	}

	private bool _003CRefreshGameSettingTabNewTag_003Eb__220_0(StandardTabItemViewData t)
	{
		return false;
	}

	private void _003COnBtnConfirm_003Eb__227_0()
	{
	}

	private void _003CShowBuyItemPop_003Eb__228_0(string s)
	{
	}

	private void _003COnBtnReset_003Eb__235_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitDepth()
	{
	}
}
