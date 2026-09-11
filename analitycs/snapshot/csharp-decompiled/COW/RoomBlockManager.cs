using System.Collections.Generic;
using GCommon;

namespace COW;

public class RoomBlockManager : SingletonModule<RoomBlockManager>
{
	private const string BLOCKED_ROOM_ID = "BLOCKED_ROOM_ID";

	private const string BLOCKED_ROOM_TIME = "BLOCKED_ROOM_TIME";

	private Dictionary<ulong, Dictionary<ulong, ulong>> m_AccountIdToRoomId;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void OnTicked(ulong roomid)
	{
	}

	public bool CheckIsBlocked(ulong roomid)
	{
		return false;
	}
}
