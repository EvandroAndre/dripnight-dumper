using GCommon;

namespace COW;

public class BattleLevelBuildConfigData : CSVBaseData, IGetId
{
	public uint BuildID;

	public uint[] AbilityID;

	public string SelectBuildIcon;

	public string BuildDescKey;

	public ResourceID SelectBuildStyleBgRes;

	public string SelectBuildAvatarIcon;

	public string BuildNameKey;

	public ResourceID MaxLevelVFX;

	public ResourceID LevelUpVFX;

	public ResourceID PlayerStatsMaxLevelUIFX;

	public ResourceID LevelUpAudio;

	public ResourceID MaxLevelAudio;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
