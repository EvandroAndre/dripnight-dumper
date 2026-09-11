using GCommon;

namespace COW;

public class EventTriggerData : CSVBaseData, IGetId
{
	public uint ID;

	public uint BehaviorType1;

	public uint value1;

	public uint BehaviorType2;

	public uint value2;

	public uint BehaviorType3;

	public uint value3;

	public string Desc;

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

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
