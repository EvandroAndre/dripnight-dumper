namespace COW.GamePlay.UGCRuntime;

public interface IUGCModuleArchTypeMgr : IUGCModule
{
	string GetArchTypeIDByComponents(long[] typeIDs);

	Tuple2<string[], bool> GetArchTypesByFilter(UGCArchTypeFilter filter);

	long[] GetArchTypeComponents(string archTypeID);

	long[] GetExpandComponentsID(long[] typeIDs);

	bool ArchTypeHas(string archTypeID, long typeID);

	bool ArchTypeHas(string archTypeID, long[] typeIDs);

	bool ArchTypeNot(string archTypeID, long typeID);

	bool ArchTypeNot(string archTypeID, long[] typeIDs);

	bool ArchTypeAny(string archTypeID, long[] typeIDs);

	string ArchTypeAddComponents(string archTypeID, long[] typeIDs);

	string ArchTypeRemoveComponents(string archTypeID, long[] typeIDs);
}
