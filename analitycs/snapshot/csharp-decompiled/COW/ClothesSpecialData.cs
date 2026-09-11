using GCommon;

namespace COW;

public class ClothesSpecialData : CSVBaseData, IGetId
{
	public uint iID;

	public uint avatarID;

	public uint itemID;

	public int recipeHashInLobby;

	public int recipeHashInGame;

	public uint mappedItemID;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
