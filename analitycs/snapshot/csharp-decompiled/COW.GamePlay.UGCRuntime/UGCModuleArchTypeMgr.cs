using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCModuleArchTypeMgr : IUGCModule, IUGCModuleArchTypeMgr
{
	private UGCRuntime ugcRuntime;

	private Dictionary<string, ArchType> archTypeMap;

	private ArchType archTypeHandler;

	private List<ArchType> archTypeFilterHandler;

	private Dictionary<long, List<long>> abbrArchType2expArchTypeCache;

	private Dictionary<string, long[]> m_cachedArchTypeToComponents;

	public UGCModuleArchTypeMgr Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void Destroy()
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	private Tuple2<ArchType, bool> _GetArchTypeByID(string archTypeID)
	{
		return default(Tuple2<ArchType, bool>);
	}

	public long[] GetExpandComponentsID(long[] typeIDs)
	{
		return null;
	}

	public List<long> GetExpandComponentsIDByCache(long[] typeIDs)
	{
		return null;
	}

	public string GetArchTypeIDByComponents(long[] typeIDs)
	{
		return null;
	}

	public Tuple2<string[], bool> GetArchTypesByFilter(UGCArchTypeFilter filter)
	{
		return default(Tuple2<string[], bool>);
	}

	private List<long> ParseArchTypeID(string archTypeID)
	{
		return null;
	}

	public long[] GetArchTypeComponents(string archTypeID)
	{
		return null;
	}

	public bool ArchTypeHas(string archTypeID, long typeID)
	{
		return false;
	}

	public bool ArchTypeHas(string archTypeID, long[] typeIDs)
	{
		return false;
	}

	public bool ArchTypeNot(string archTypeID, long typeID)
	{
		return false;
	}

	public bool ArchTypeNot(string archTypeID, long[] typeIDs)
	{
		return false;
	}

	public bool ArchTypeAny(string archTypeID, long[] typeIDs)
	{
		return false;
	}

	public string ArchTypeAddComponents(string archTypeID, long[] typeIDs)
	{
		return null;
	}

	public string ArchTypeRemoveComponents(string archTypeID, long[] typeIDs)
	{
		return null;
	}
}
