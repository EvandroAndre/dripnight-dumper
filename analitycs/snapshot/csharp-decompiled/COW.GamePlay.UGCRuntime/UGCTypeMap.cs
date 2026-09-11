using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTypeMap : IUGCTypeMap
{
	public static readonly OLHOBAPCNMI TypeMapping;

	private const long Type_Object = 0L;

	private const string TypeName_Object = "Object";

	private OOCHHFPFBMG typeTree;

	private Dictionary<string, long> typeName2ID;

	private Dictionary<long, CJHOFLOHKLA> typeMap;

	private UGCTypeMapCyclePool cyclePool;

	private Dictionary<long, UGCComponentProp> propID2PropsDesc;

	private Dictionary<int, UGCComponentProp> syncID2PropsDesc;

	private Dictionary<long, List<UGCComponentProp>> componentProps;

	private Dictionary<long, KILAKLLLNAJ> componentTypeMap;

	public UGCTypeMap Create(OOCHHFPFBMG typeTreeBytes)
	{
		return null;
	}

	private void _ParseTypeTree()
	{
	}

	public void InitCustomTypeMap(OOCHHFPFBMG customTypeMap)
	{
	}

	public long TypeNameToID(string typeName)
	{
		return 0L;
	}

	public bool IsCustomType(long typeID)
	{
		return false;
	}

	public string TypeIDToName(long typeID)
	{
		return null;
	}

	public Tuple2<CJHOFLOHKLA, bool> FindType(long typeID)
	{
		return default(Tuple2<CJHOFLOHKLA, bool>);
	}

	public KILAKLLLNAJ FindComponent(long typeID)
	{
		return null;
	}

	public Tuple2<CJHOFLOHKLA, bool> FindTypeByName(string typeName)
	{
		return default(Tuple2<CJHOFLOHKLA, bool>);
	}

	public bool IsSubclassOfByName(string targetBaseTypeName, string typeName)
	{
		return false;
	}

	public bool IsSubClassOf(long targetBaseTypeID, long typeID)
	{
		return false;
	}

	private List<long> _InternalGetType2ObjectBaseTypes(List<long> result, CJHOFLOHKLA targetType)
	{
		return null;
	}

	public List<long> GetType2ObjectBaseTypes(long targetTypeID)
	{
		return null;
	}

	public List<long> ExpandTypeID2Components(long typeID)
	{
		return null;
	}

	public bool ContainsDeclare(int declare, JBBFEMPHGOL keyword)
	{
		return false;
	}

	public Tuple2<long, bool> GetEnumConstType(long targetTypeID)
	{
		return default(Tuple2<long, bool>);
	}

	public bool IsEnumConstType(long enumTypeID, long targetTypeID)
	{
		return false;
	}

	public bool IsTypeAccept(long hostTypeID, long targetTypeID)
	{
		return false;
	}

	public UGCComponentProp GetComponentProp(long propID)
	{
		return null;
	}

	public List<UGCComponentProp> GetComponentProps(long cmpTypeID)
	{
		return null;
	}

	public ECmpPropAccessType GetPropAccessType(long propID)
	{
		return ECmpPropAccessType.ECmpPropAccessType_Unknown;
	}

	public long GetPropType(long propID)
	{
		return 0L;
	}

	public long GetPropOwnerComponentID(long propID)
	{
		return 0L;
	}

	public long ConvertSyncID2PropID(int syncID)
	{
		return 0L;
	}

	public bool IsReadOnly(long propID)
	{
		return false;
	}

	public bool IsObservable(long propID)
	{
		return false;
	}

	public static bool IsTRSPropID(long propID)
	{
		return false;
	}

	public static bool IsTRSVector3PropID(long propID)
	{
		return false;
	}

	public static bool IsTRSVector3PropID_NotOnlyServer(long propID)
	{
		return false;
	}

	public static bool IsTRSVector3PropID_OnlyServer(long propID)
	{
		return false;
	}

	public static bool IsTRSQuaternionPropID(long propID)
	{
		return false;
	}

	public static bool IsTRSQuaternionPropID_NotOnlyServer(long propID)
	{
		return false;
	}

	public static bool IsTRSQuaternionPropID_OnlyServer(long propID)
	{
		return false;
	}

	public bool IsEntityType(long typeID)
	{
		return false;
	}
}
