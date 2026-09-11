using GCommon;

namespace COW;

internal class IPPrivilegeTagDataManager : SingletonModule<IPPrivilegeTagDataManager>
{
	private CSVAsyncDataMap<uint, IPPrivilegeTagData> m_dictIdToIpPrivilegeTagData;

	protected override void OnInit()
	{
	}

	public void LoadCSVData()
	{
	}

	protected override void OnCleanup()
	{
	}

	public IPPrivilegeTagData FindIpPrivilegeTagDataById(uint id)
	{
		return null;
	}
}
