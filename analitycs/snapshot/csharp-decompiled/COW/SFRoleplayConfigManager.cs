using GCommon;

namespace COW;

public class SFRoleplayConfigManager : SingletonModule<SFRoleplayConfigManager>
{
	private CSVAsyncDataMap<uint, SFRoleplayPlayerAbilityConfig> m_dictIdToSFRoleplayPlayerAbilityConfig;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public SFRoleplayPlayerAbilityConfig GetSFRoleplayPlayerAbilityConfigByID(uint id)
	{
		return null;
	}

	public SFRoleplayPlayerAbilityConfig GetSFRoleplayPlayerAbilityConfigByType(uint type)
	{
		return null;
	}

	public static void GetTitleSpriteName(uint level, out string iconName)
	{
		iconName = null;
	}

	public static void GetDeadKillerSpriteName(uint level, out string iconName)
	{
		iconName = null;
	}
}
