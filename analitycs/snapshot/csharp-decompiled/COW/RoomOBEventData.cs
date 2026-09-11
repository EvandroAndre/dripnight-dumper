using GCommon;

namespace COW;

public class RoomOBEventData : CSVBaseData
{
	public enum ERoomOBEventType
	{
		None,
		Local,
		Global
	}

	public byte ID;

	public ERoomOBEventType EventType;

	public string EventTypeName;

	public string EventName;

	public string SpriteName;

	public float Param;

	public string EventActiveDesc;

	public int[] GroupModeBan;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
