using GCommon;

namespace COW;

public class BattleStyleLoadoutLevelData : CSVBaseData, IGetId
{
	public uint ID;

	public uint Level;

	public string DescKey;

	public string gainKey;

	public string AbilityIcon;

	public string ShowAbilityIcon;

	public uint Ability;

	public uint LevelExpRequest;

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
