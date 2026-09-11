using GCommon;

namespace COW;

public class ProfileModuleCDNDataManager : SingletonModule<ProfileModuleCDNDataManager>
{
	private CSVAsyncDataMap<uint, ProfileModuleCDNData> m_Dict;

	private const uint BASE_PRIME_LEVEL_INDEX = 8u;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public ProfileModuleCDNData GetPrimeCDNDataByLevel(uint level)
	{
		return null;
	}

	public ProfileModuleCDNData GetRoleCDNDataByLevel(uint level)
	{
		return null;
	}

	public ProfileModuleCDNData GetProfileModuleCDNDataByType(uint type)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
