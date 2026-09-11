using System;
using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCDatabaseServer
{
	private readonly UGCRuntime m_UGCRuntime;

	private readonly string m_WorkshopCode;

	private readonly Dictionary<string, UGCLocalDatabaseProxy> m_DatabaseProxyMap;

	private const uint CHECK_DATABASE_DIRTY_TIME_MS = 10000u;

	private uint m_CurrentGameTimeMs;

	public Action<uint, BEPEOKLEMIP> onGetNormalDataAction;

	public UGCDatabaseServer(UGCRuntime ugcRuntime)
	{
	}

	public void Close()
	{
	}

	public void RequestGetNormalTableData(GetUGCDatabaseNormalDataRequest req)
	{
	}

	public void RequestSetNormalTableData(SetUGCDatabaseNormalDataRequest req)
	{
	}

	public void RequestDeleteNormalTableData(DeleteUGCDatabaseNormalDataRequest req)
	{
	}

	private UGCLocalDatabaseProxy GetDatabaseProxy(string workshopCode)
	{
		return null;
	}

	private void OnTickEventHandle()
	{
	}
}
