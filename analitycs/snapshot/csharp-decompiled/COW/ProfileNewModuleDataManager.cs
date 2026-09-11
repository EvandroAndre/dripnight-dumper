using System.Collections.Generic;
using GCommon;

namespace COW;

public class ProfileNewModuleDataManager : SingletonModule<ProfileNewModuleDataManager>
{
	private CSVAsyncDataMap<uint, ProfileNewModuleData> m_Dict;

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

	public ProfileNewModuleData GetProfileNewModuleDataById(uint id)
	{
		return null;
	}

	public List<ProfileNewModuleData> GetProfileNewModuleDataList()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
