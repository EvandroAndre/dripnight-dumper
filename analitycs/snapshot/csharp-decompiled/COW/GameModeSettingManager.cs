using System.Collections.Generic;
using GCommon;

namespace COW;

internal class GameModeSettingManager : SingletonModule<GameModeSettingManager>
{
	private GameModeSetting m_DefaultGameSetting;

	private Dictionary<ulong, GameModeSetting> m_GameModeSettings;

	private Dictionary<ulong, GameModeSetting> m_GameModeSettingsBackup;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public GameModeSetting GetModeSetting(uint map_id, uint mode_id)
	{
		return null;
	}

	private ulong GetModeSettingKey(uint map_id, uint mode_id)
	{
		return 0uL;
	}

	private GameModeSetting LoadModeSetting(ResourceID resID, GameModeSetting defaultSetting = null)
	{
		return null;
	}

	public bool GetIsHeadShotOnly()
	{
		return false;
	}

	public void OverwriteKeyValueList(List<CSVBaseData> datas)
	{
	}

	private void PostSetGameModeSetting(GameModeSetting setting)
	{
	}

	public void CleanOverwriteKeyValues()
	{
	}
}
