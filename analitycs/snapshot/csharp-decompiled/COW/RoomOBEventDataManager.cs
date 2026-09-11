using System.Collections.Generic;
using GCommon;

namespace COW;

public class RoomOBEventDataManager : SingletonModule<RoomOBEventDataManager>
{
	private Dictionary<byte, RoomOBEventData> m_GlobalEventDataDic;

	private Dictionary<byte, RoomOBEventData> m_LocalEventDataDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public RoomOBEventData GetOBEventDataByID(byte eID)
	{
		return null;
	}

	public RoomOBEventData GetGlobalEventDataByTypeName(string typeName)
	{
		return null;
	}

	public Dictionary<byte, RoomOBEventData> GetGlobalObEventDatas()
	{
		return null;
	}

	public Dictionary<byte, RoomOBEventData> GetLocalObEventDatas()
	{
		return null;
	}

	public int[] GetPollEventCounts()
	{
		return null;
	}

	public int[] GetPollDurations()
	{
		return null;
	}
}
