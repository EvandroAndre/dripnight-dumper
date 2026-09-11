using System.Collections.Generic;
using GCommon;

namespace COW;

public class TeamClothPrivilegeManager : SingletonModule<TeamClothPrivilegeManager>
{
	private Dictionary<uint, TeamConfigData> m_dictIdToTeamConfig;

	private Dictionary<uint, PrivilegeData> m_dictIdToPrivilegeData;

	private uint m_ActiveTeamId;

	private ResourceID m_ResourceId;

	private static Dictionary<int, string> m_PrivbiligeTypeToIcon;

	private static Dictionary<int, string> m_PrivbiligeTypeToTitle;

	private static Dictionary<int, string> m_PrivbiligeTypeToDesc;

	public ResourceID ResourceId
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public List<TeamClothPrivilegeDetail> GetClothPrivilegeDetailByID(uint Id)
	{
		return null;
	}

	public bool CheckClothPrivilegeById(uint Id)
	{
		return false;
	}

	public uint GetPrivilegeClothIdById(uint Id)
	{
		return 0u;
	}

	public List<uint> GetPrivilegeClothIdByBundleId(uint Id)
	{
		return null;
	}

	public void CheckClothPrivilege(List<UIMaleAvatar> avatars)
	{
	}

	private void ApplicatePrivilege(uint teamId)
	{
	}

	public uint CheckActiveTeamID(List<UIMaleAvatar> avatars)
	{
		return 0u;
	}

	public void CancleCurrentPrivilege()
	{
	}
}
