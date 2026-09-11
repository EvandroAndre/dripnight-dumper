using GCommon;

namespace COW;

public class ReplayMatchEventData : CSVBaseData
{
	private ResourceID m_EventIcon;

	private ResourceID m_EventIconIndia;

	public const uint EVENT_TYPE_CONTINUOUS_KILL = 16u;

	public const uint EVENT_TYPE_ACCUMULATE_KILL = 20u;

	public uint AchievementGroup;

	public string Condition;

	public string m_EventIconName;

	public string m_EventName;

	public uint Score;

	public uint EventType;

	public uint GameMode;

	public uint Priority;

	public uint AfterSecond;

	public uint BeforeSecond;

	public uint SubEventType;

	public uint AchievementID;

	public uint EventID;

	public string EventName => null;

	public ResourceID EventIcon => default(ResourceID);

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
