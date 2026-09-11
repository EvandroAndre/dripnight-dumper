using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class CustomRoomPreviewSettingHelper : SingletonModule<CustomRoomPreviewSettingHelper>
{
	private enum SettingType
	{
		RoomSetting,
		RoomSetting2,
		RoomSetting3
	}

	private enum SpecialSettingType
	{
		AFKPunish,
		Weather
	}

	private abstract class SettingComparisonConfig
	{
		public abstract bool Compare(uint roomSetting, uint roomSetting2, uint roomSetting3, RoomPreviewSettings previewConfig, bool currentAFKOpen, uint currentVisualStyle, UIModelCustomRoom modelRoom);
	}

	private class BitFlagComparisonConfig : SettingComparisonConfig
	{
		private readonly SettingType m_SettingType;

		private readonly uint m_Flag;

		public BitFlagComparisonConfig(SettingType settingType, uint flag)
		{
		}

		public override bool Compare(uint roomSetting, uint roomSetting2, uint roomSetting3, RoomPreviewSettings previewConfig, bool currentAFKOpen, uint currentVisualStyle, UIModelCustomRoom modelRoom)
		{
			return false;
		}

		private uint GetSettingValue(uint roomSetting, uint roomSetting2, uint roomSetting3)
		{
			return 0u;
		}

		private uint GetPreviewSettingValue(RoomPreviewSettings previewConfig)
		{
			return 0u;
		}
	}

	private class RangeValueComparisonConfig : SettingComparisonConfig
	{
		private readonly SettingType m_SettingType;

		private readonly uint m_StartFlag;

		private readonly uint m_EndFlag;

		public RangeValueComparisonConfig(SettingType settingType, uint startFlag, uint endFlag)
		{
		}

		public override bool Compare(uint roomSetting, uint roomSetting2, uint roomSetting3, RoomPreviewSettings previewConfig, bool currentAFKOpen, uint currentVisualStyle, UIModelCustomRoom modelRoom)
		{
			return false;
		}

		private uint GetSettingValue(uint roomSetting, uint roomSetting2, uint roomSetting3)
		{
			return 0u;
		}

		private uint GetPreviewSettingValue(RoomPreviewSettings previewConfig)
		{
			return 0u;
		}
	}

	private class SpecialComparisonConfig : SettingComparisonConfig
	{
		private readonly SpecialSettingType m_SpecialType;

		public SpecialComparisonConfig(SpecialSettingType specialType)
		{
		}

		public override bool Compare(uint roomSetting, uint roomSetting2, uint roomSetting3, RoomPreviewSettings previewConfig, bool currentAFKOpen, uint currentVisualStyle, UIModelCustomRoom modelRoom)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public uint drop;

		internal bool _003CUpdateRoomPreviewSettings_003Eb__0(DropListConfigInfo e)
		{
			return false;
		}
	}

	private Dictionary<uint, List<uint>> m_SpecialModeGameSettingPriorityDict;

	private List<uint> m_CommonModeGameSettingPriority;

	private Dictionary<uint, bool> m_GameSettingSwitch;

	private Dictionary<uint, string> m_CustomRoomGameSettingTitle;

	private bool m_IsInitialized;

	private static readonly Dictionary<uint, SettingComparisonConfig> SettingComparisonConfigs;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void EnsureInitialized()
	{
	}

	private void InitModeGameSetting()
	{
	}

	public void InitCustomRoomSettingTitle()
	{
	}

	public Dictionary<uint, string> GenerateCustomRoomGameSettingDict(tcp.RoomInfo roomInfo)
	{
		return null;
	}

	public Dictionary<uint, string> GenerateCustomRoomGameSettingDict(RoomCreateReq req)
	{
		return null;
	}

	public Dictionary<uint, string> GenerateCustomRoomGameSettingDict(tcp.RoomBasicInfo basicInfo)
	{
		return null;
	}

	private void InitRegionSwitch(tcp.ERoom.Type roomType)
	{
	}

	public List<UIRoomBaseController.RoomGameSettingData> PrepareGameSettingDataForCurrentRoom(tcp.RoomInfo roomInfo)
	{
		return null;
	}

	public List<UIRoomBaseController.RoomGameSettingData> PrepareGameSettingDataForPreset(RoomCreateReq presetData)
	{
		return null;
	}

	public List<UIRoomBaseController.RoomGameSettingData> PrepareGameSettingDataForBasicRoomInfo(tcp.RoomBasicInfo roomInfo)
	{
		return null;
	}

	private List<UIRoomBaseController.RoomGameSettingData> PrepareGameSettingDataInternal(uint gameMode, Dictionary<uint, string> gameSettingDict, uint roomSetting2, uint roomSetting = 0u, uint roomSetting3 = 0u, RoomPreviewSettings previewConfig = null, bool currentAFKOpen = false, uint currentVisualStyle = 0u)
	{
		return null;
	}

	public bool IsRoomMatchDropPresetQuickJoinSettings(tcp.RoomBasicInfo roomInfo, DropListConfigInfo dropInfo)
	{
		return false;
	}

	private static bool IsDropPresetUnlimitedThrowablesEnabled(proto.ERoom.DropPresetState state)
	{
		return false;
	}

	private static bool IsDropPresetHeadShotOnlyEnabled(proto.ERoom.DropPresetState state)
	{
		return false;
	}

	public RoomPreviewSettings GetRoomPreviewSettings(tcp.RoomBasicInfo roomInfo)
	{
		return null;
	}

	private void UpdateRoomPreviewSettings(RoomPreviewSettings settingDetail, tcp.RoomBasicInfo roomInfo)
	{
	}

	private void SetRoomSetting(ref uint setting, uint flag, bool value)
	{
	}

	private void SetRoomSettingRangeValue(ref uint setting, uint start, uint end, uint value)
	{
	}

	public byte[] GetRoomPreviewSettingsBytes(RoomPreviewSettings data)
	{
		return null;
	}

	private void GenerateCustomRoomGameSettingDictByRoomSetting(Dictionary<uint, string> dict, uint roomSetting, UIModelCustomRoom modelRoom)
	{
	}

	private void GenerateCustomRoomGameSettingDictByRoomSetting2(Dictionary<uint, string> dict, uint roomSetting2, UIModelCustomRoom modelRoom)
	{
	}

	private void GenerateCustomRoomGameSettingDictByRoomSetting3(Dictionary<uint, string> dict, uint roomSetting3, UIModelCustomRoom modelRoom)
	{
	}

	private string GetSettingString(uint roomSetting, uint setting, UIModelCustomRoom modelRoom, bool reverse = true)
	{
		return null;
	}

	private static bool IsRoomSettingsTrue(uint roomSetting, uint setting)
	{
		return false;
	}

	private bool IsSettingEqualsToDefault(uint gameSetting, uint roomSetting, uint roomSetting2, uint roomSetting3, RoomPreviewSettings previewConfig, bool currentAFKOpen, uint currentVisualStyle)
	{
		return false;
	}
}
