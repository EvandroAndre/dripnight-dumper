using GCommon;

namespace COW;

public class MatchResultShareDataConfig : CSVBaseData, IGetId
{
	public string Key;

	public uint ShowParam4;

	public uint ShowParam3;

	public uint ShowParam2;

	public uint ShowParam1;

	public uint RankParam;

	public uint Sortid;

	public uint id;

	public uint Type;

	public uint Gamemode;

	public uint TopParam;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
