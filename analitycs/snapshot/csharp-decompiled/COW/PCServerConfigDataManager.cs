using GCommon;

namespace COW;

internal class PCServerConfigDataManager : SingletonModule<PCServerConfigDataManager>
{
	private const string overrideFileName = "serverList.json";

	private ServerListConfig m_ServerListConfig;

	public ServerListConfig ServerListConfig => null;

	protected override void OnInit()
	{
	}

	public void OverrideGameConfig(object data)
	{
	}

	protected override void OnCleanup()
	{
	}
}
