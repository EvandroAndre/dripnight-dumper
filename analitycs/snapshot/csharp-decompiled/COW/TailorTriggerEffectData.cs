using GCommon;

namespace COW;

public class TailorTriggerEffectData : CSVBaseData, IGetId
{
	public uint EffectItemID;

	public ResourceID ShowAnimResourceID;

	public bool IsLoop;

	public float IdleDuration;

	public int PreviewRotationY;

	public bool IsShowInLobby;

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
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

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
