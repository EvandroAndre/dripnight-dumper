using System;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIModelPresence : UIBaseModel
{
	private Dictionary<int, ulong> m_LastSendTime;

	private Dictionary<ulong, PresenceInfo> m_PresenceCache;

	private List<Action> m_OnTCPFriendPresnceListNtfCallBack;

	public ulong AutoRefreshFriendsTime;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public bool IsInRefreshPlayerPresenceCD(EPresenceListType presenceType)
	{
		return false;
	}

	public void RequestPresence(EPresenceListType presenceType, ulong[] ids, bool force = false, int cpuKey = 0)
	{
	}

	public void AddTCPFriendPresnceListNtfCallBack(Action callBack)
	{
	}

	public void OnTCPPresnceListNtf(PresenceListRes resData, bool cachedData = false)
	{
	}

	private void OnTcpNotify_Friend()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
