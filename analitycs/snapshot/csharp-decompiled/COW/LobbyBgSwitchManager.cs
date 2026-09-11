using GCommon;

namespace COW;

public class LobbyBgSwitchManager : SingletonModule<LobbyBgSwitchManager>
{
	private CSVAsyncDataMap<uint, LobbyBgSwitchData> m_Data;

	private LobbyBgSwitchData m_DefaultData;

	private LobbyBgSwitchData DefaultData => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public ResourceID GetLobbyBgByRegion(string region)
	{
		return default(ResourceID);
	}
}
