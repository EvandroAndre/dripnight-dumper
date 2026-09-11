using System.Collections.Generic;
using GCommon;

namespace COW;

public class CollectionPrivilegeTagDataManager : SingletonModule<CollectionPrivilegeTagDataManager>
{
	private Dictionary<uint, CollectionPrivilegeTagData> m_CollectionPrivilegeTagDataDic;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public CollectionPrivilegeTagData GetPrivilegeTagDataByType(CollectionPrivilegeTagType type)
	{
		return null;
	}
}
