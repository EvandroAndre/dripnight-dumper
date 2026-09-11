using System.Collections.Generic;
using GCommon;

namespace COW;

public class ServerSettingsDataManager : SingletonModule<ServerSettingsDataManager>
{
	private static ServerSettingsData m_Default;

	private Dictionary<int, ServerSettingsData> m_Datas;

	public List<ServerSettingsData> GetDataList()
	{
		return null;
	}

	public ServerSettingsData GetDataByServer(string server)
	{
		return null;
	}

	public ServerSettingsData GetDataByIndex(int index)
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
