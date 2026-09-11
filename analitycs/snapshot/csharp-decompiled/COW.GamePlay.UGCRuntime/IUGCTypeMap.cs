using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCTypeMap
{
	void InitCustomTypeMap(OOCHHFPFBMG customTypeMap);

	long TypeNameToID(string typeName);

	string TypeIDToName(long typeID);

	Tuple2<CJHOFLOHKLA, bool> FindType(long typeID);

	Tuple2<CJHOFLOHKLA, bool> FindTypeByName(string typeName);

	bool IsSubClassOf(long targetBaseTypeID, long typeID);

	bool IsSubclassOfByName(string targetBaseTypeName, string typeName);

	List<long> GetType2ObjectBaseTypes(long targetTypeID);

	List<long> ExpandTypeID2Components(long typeID);

	bool ContainsDeclare(int declare, JBBFEMPHGOL keyword);

	Tuple2<long, bool> GetEnumConstType(long targetTypeID);

	bool IsEnumConstType(long enumTypeID, long targetTypeID);

	bool IsTypeAccept(long hostTypeID, long targetTypeID);

	UGCComponentProp GetComponentProp(long propID);

	List<UGCComponentProp> GetComponentProps(long cmpTypeID);

	ECmpPropAccessType GetPropAccessType(long propID);

	long GetPropType(long propID);

	long GetPropOwnerComponentID(long propID);

	long ConvertSyncID2PropID(int syncID);

	bool IsReadOnly(long prop);

	bool IsObservable(long prop);

	bool IsCustomType(long typeID);

	KILAKLLLNAJ FindComponent(long typeID);

	bool IsEntityType(long typeID);
}
