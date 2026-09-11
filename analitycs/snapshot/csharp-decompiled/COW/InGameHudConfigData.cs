using System.Collections.Generic;
using GCommon;
using LitJson;

namespace COW;

public class InGameHudConfigData : SingletonModule<InGameHudConfigData>
{
	public const int MaxHudCount = 4;

	public const string HudVersionKey = "HudVersion";

	public const string JumpKey = "HudJump";

	public const string LeftFireKey = "HudAuxFire";

	public const string MovingJoystickKey = "HudMovingJoystick";

	public const string HudInteractKey = "HudInteract";

	public const string SightKey = "HudSight";

	public const string HudTeamRally = "HudTeamRally";

	public const string AcceleratorKey = "HudAccelerator";

	public const string BrakeKey = "HudBrake";

	public const string TurnLeftKey = "HudTurnLeft";

	public const string TurnRightKey = "HudTurnRight";

	public const string VehicleStatsKey = "HudVehicleStats";

	public const string VehicleMovingJoystickKey = "HudVehicleMovingJoystick";

	public const string LeaveVehicleKey = "HudLeaveVehicle";

	public const string VehicleHornKey = "HudVehicleHorn";

	public const string VehiclePlayerPrefsKey = "OB44_HUDConfigVehicle";

	public const string VehicleResetKey = "HudVehicleReset";

	public const string HudVehicleOverdriveKey = "HudVehicleOverdrive";

	public const string HudVehicleOverdriveSingleHandKey = "HudVehicleOverdriveSingleHand";

	public const string HudFourPlayerPrefsKey = "OB51_HUDConfigFour";

	public const string HudExchangeItemPanel = "HudExchangeItemPanel";

	public const string HudWeaponSwitch = "HudWeaponSwitch";

	public const string HudWeaponInfoUpgrade = "HudWeaponInfoUpgrade";

	public const string HudWeaponInfo = "HudWeaponInfo";

	public const string HudSwichWeaponSkin = "HudSwichWeaponSkin";

	public const string HudTriggerGrenade = "HudTriggerGrenade";

	public const string HudPlayerSkillBuff = "HudPlayerSkillBuff";

	public const string HudPlayerStats = "HudPlayerStats";

	public const string HudPlayerArmorStats = "HudPlayerArmorStats";

	public const string HudPlayerFollowEmote = "HudPlayerFollowEmote";

	public const string HudKillNotification = "HudKillNotification";

	public const string HudQuickChatV2Combo = "HudQuickChatV2Combo";

	public const string HudLoginAge18 = "HudLoginAge18";

	public const string FireKey = "HudFire";

	public const string CrouchKey = "HudCrouch";

	public const string CreepKey = "HudCreep";

	public const string ActionKey = "HudInteract";

	public const string HudWLSnowSlidePlayerStatsKey = "HudWLSnowSlidePlayerStats";

	public const string HudModeCommonEntranceKey = "HudModeCommonEntrance";

	public const string HudQuitButton = "HudQuitButton";

	public const string HudPresetPickEntrance = "HudPresetPickEntrance";

	public const float HudWeaponInfoWidth = 257f;

	public const float HudWeaponInfoHeight = 85f;

	private Dictionary<string, HudConfigItem> m_HudDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudNewDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudThreeDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudFourDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudNewCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudThreeCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudFourCustomizeConfigDic;

	public Dictionary<string, HudConfigItem> m_HudCurrentDefaultConfigDic;

	public Dictionary<string, HudConfigItem> m_HudCurrentCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudVehicleDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudVehicleCustomizeConfigDic;

	private Dictionary<string, InGamePhotoVerticalHudData> m_InGamePhotoVerticalHudConfigDic;

	private JsonData[] m_CachedHudJsonData;

	public const float HudWeaponSwitchWidth = 261f;

	public const float HudWeaponSwitchHeight = 86f;

	public const float HudWeaponInfoUpgradeWidth = 53f;

	public const float HudWeaponInfoUpgradeHeight = 37f;

	public Dictionary<string, HudConfigItem> HudDefaultConfigDic => null;

	public Dictionary<string, HudConfigItem> HudNewDefaultConfigDic => null;

	public Dictionary<string, HudConfigItem> HudCustomizeConfigDic => null;

	public Dictionary<string, HudConfigItem> HudNewCustomizeConfigDic => null;

	public Dictionary<string, HudConfigItem> HudThreeDefaultConfigDic => null;

	public Dictionary<string, HudConfigItem> HudVehicleDefaultConfigDic => null;

	public Dictionary<string, HudConfigItem> HudThreeCustomizeConfigDic => null;

	public Dictionary<string, HudConfigItem> HudVehicleCustomizeConfigDic => null;

	public Dictionary<string, HudConfigItem> HudCurrentCustomizeConfigDic => null;

	public Dictionary<string, HudConfigItem> HudFourDefaultConfigDic => null;

	public Dictionary<string, HudConfigItem> HudFourCustomizeConfigDic => null;

	protected override void OnInit()
	{
	}

	private void LoadDefaultConfig()
	{
	}

	public void DeepCopyConfigs(Dictionary<string, HudConfigItem> dic1, Dictionary<string, HudConfigItem> dic2)
	{
	}

	public void SetCurrent()
	{
	}

	private void CheckHudGrendeChange()
	{
	}

	private void ChangeGrenadeToOldPosNoCustom()
	{
	}

	private void AdjustPosIfNoCustom(string key, Dictionary<string, HudConfigItem> defaultDic, Dictionary<string, HudConfigItem> customDic)
	{
	}

	private void ChangeGrenadeToNewPos()
	{
	}

	private void AdjustPosIfOldPosition(string key, Dictionary<string, HudConfigItem> defaultDic, Dictionary<string, HudConfigItem> customDic)
	{
	}

	protected override void OnCleanup()
	{
	}

	private void LoadDefaultDataFromJsonDataOfIndex(int index)
	{
	}

	private void LoadVehicleDefaultDataFromJsonData()
	{
	}

	private void LoadInGamePhotoVerticalHudConfig()
	{
	}

	public InGamePhotoVerticalHudData GetInGamePhotoVerticalHudConfigByName(string hudName)
	{
		return null;
	}

	private void LoadDataFromJsonData(JsonData JObjRoot, bool isResConfig)
	{
	}

	private Dictionary<string, HudConfigItem> GetDefaultConfigDicByIndex(int index)
	{
		return null;
	}

	private void LoadNewDataFromConfig()
	{
	}

	private void LoadThreeDataFromConfig()
	{
	}

	private void LoadFourDataFromConfig()
	{
	}

	private void LoadDataFromConfig()
	{
	}

	private void InitVehicleData()
	{
	}

	public void ModifyKolHudCustomizeData(Dictionary<string, HudConfigItem> KolHudCurrentCustomizeConfigDic)
	{
	}

	private void LoadCustomizeDataFromJsonData(JsonData JHud, int setting)
	{
	}

	public string GetSeparatedHudContentLog()
	{
		return null;
	}

	private void LoadVehicleDataFromJsonData(JsonData JHud)
	{
	}

	private void LoadDataFromPlayerPref()
	{
	}

	private void LoadNewDataFromPlayerPref()
	{
	}

	private void LoadThreeDataFromPlayerPref()
	{
	}

	private void LoadFourDataFromPlayerPref()
	{
	}

	public void LoadVehicleDataFromPlayerPref()
	{
	}

	public HudConfigItem TryBuildHudWeaponSwitchAfterSeparated(HudConfigItem configItem, Dictionary<string, HudConfigItem> targetHudDic = null)
	{
		return null;
	}

	public HudConfigItem BuildHudWeaponSwitchAfterSeparated(HudConfigItem configWeaponInfoItem)
	{
		return null;
	}

	public HudConfigItem BuildHudWeaponInfoAfterSeparated(HudConfigItem configWeaponSwitchItem)
	{
		return null;
	}

	public HudConfigItem TryBuildHudWeaponInfoUpgradeSwitchAfterSeparated(HudConfigItem configItem, Dictionary<string, HudConfigItem> targetHudDic = null)
	{
		return null;
	}

	public HudConfigItem TryBuildHudPlayerArmorStatsAfterSeparated(HudConfigItem configItem, Dictionary<string, HudConfigItem> targetHudDic = null)
	{
		return null;
	}

	public HudConfigItem TryBuildHudPlayerSkillBuffAfterSeparated(HudConfigItem configItem, Dictionary<string, HudConfigItem> targetHudDic = null)
	{
		return null;
	}

	private void LogTryBuildFunc(string logContent)
	{
	}

	public bool IsKillNotiLeftAligned()
	{
		return false;
	}

	private void CheckOldVersion()
	{
	}

	public void RefreshDataFromPlayerPref()
	{
	}

	public JsonData GetHudFromJsonIndex(int index)
	{
		return null;
	}

	public JsonData GetVehicleHudFromJson()
	{
		return null;
	}

	public void SetDefaultHudConfigByStyle(int index)
	{
	}

	public bool HasCustomized(string hudName)
	{
		return false;
	}

	public HudConfigItem GetHudDefaultConfigByName(string HudName)
	{
		return null;
	}

	public HudConfigItem GetFirstDefaultConfigByName(string HudName)
	{
		return null;
	}

	public HudConfigItem GetSecondDefaultConfigByName(string HudName)
	{
		return null;
	}

	public HudConfigItem GetHudCustomizeConfigByName(string HudName)
	{
		return null;
	}

	public HudConfigItem GetHudCustomizeConfigByNameAndIndex(string HudName, int index)
	{
		return null;
	}

	public void SetVehicleCustomizeConfig(string hudName, HudConfigItem configItem)
	{
	}

	public HudConfigItem GetVehicleCustomizeConfigByName(string hudName)
	{
		return null;
	}

	public HudConfigItem GetVehicleDefaultConfigByName(string hudName)
	{
		return null;
	}

	public void ChangeCustomizedConfig(string HudName, HudConfigItem configItem)
	{
	}

	public void ChangeVehicleCustomizedConfig(string HudName, HudConfigItem configItem)
	{
	}

	public void SaveDownloadedConfig(Dictionary<string, HudConfigItem> hud, int index, bool needTryBuild = false)
	{
	}

	public void SaveCustomizedConfig(int settingIndex)
	{
	}

	public string ConfigDicToJsonStr(Dictionary<string, HudConfigItem> configDict)
	{
		return null;
	}

	public Dictionary<string, HudConfigItem> ConfigJsonStrToDic(string configJson, bool isResConfig = false)
	{
		return null;
	}

	private HudConfigItem JsonDataToConfigItem(JsonData singleConf, bool isResConfig)
	{
		return null;
	}

	public void SaveVehicleCustomizedConfig()
	{
	}

	public bool EqualToDefaultConfig(string key, HudConfigItem CustomizeConfig)
	{
		return false;
	}
}
