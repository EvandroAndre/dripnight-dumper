using System.Collections.Generic;
using GCommon;

namespace COW;

public class VerticleViewDataManager : SingletonModule<VerticleViewDataManager>
{
	private Dictionary<int, InGameVerticleViewRoleData> m_RoleDict;

	private Dictionary<uint, VerticleViewBuffData> m_BuffDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public InGameVerticleViewRoleData GetRoleDataById(int roleId)
	{
		return null;
	}

	public VerticleViewBuffData GetBuffDataById(uint buffId)
	{
		return null;
	}

	public List<int> GetRoleIds()
	{
		return null;
	}
}
