using COW.GamePlay;
using GCommon;

namespace COW;

public class WereWolvesQuickChatData : CSVBaseData, IGetId
{
	public uint Id;

	public string ChatVis;

	public string ChatFormat;

	public bool HasTarget;

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

	public string GetChatString(BHGGAEEHJCO playerId)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
