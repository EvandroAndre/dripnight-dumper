using System;
using System.Collections.Generic;
using COW.GamePlay;
using ECAPackage;
using message;

namespace COW;

public class ECADescriptionData
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ECADefineBase> _003C_003E9__20_0;

		internal bool _003CGetEntityProperties_003Eb__20_0(ECADefineBase e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public long propertyIndex;

		internal bool _003CGetPropertyByPropertyIndex_003Eb__0(ECADefineBase e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public string propertyName;

		internal bool _003CGetPropertyByName_003Eb__0(ECADefineBase e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public long id;

		internal bool _003CGetTypeDefine_003Eb__0(ECAVarTypeDefine e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public string eventName;

		internal bool _003CGetCustomEvent_003Eb__0(ECAEventDefine e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public string enumStrVar;

		public int enumIntVar;

		internal bool _003CIsUGCSelectorResObsolete_003Eb__0(FCAJEKECGME x)
		{
			return false;
		}

		internal bool _003CIsUGCSelectorResObsolete_003Eb__1(FCAJEKECGME x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public string enumStrVal;

		public long enumIntVal;

		internal bool _003CIsEnumObsolete_003Eb__0(ECADefineBase e)
		{
			return false;
		}

		internal bool _003CIsEnumObsolete_003Eb__1(ECADefineBase e)
		{
			return false;
		}
	}

	private ECADescriptionFile ECADescrFile;

	private List<ECAVarTypeDefine> EntityTypeList;

	private Dictionary<string, List<ECADefineBase>> EntityPropertyDic;

	private HashSet<string> BasicTypeSet;

	private List<ECAVarTypeDefine> AllVarType;

	private List<ECAEventDefine> AllEvents;

	private List<ECAEventDefine> CustomEvents;

	public ECADescriptionFile GetECADescriptionFile()
	{
		return null;
	}

	public void Init(string sourceText)
	{
	}

	public void InitDescriptionFile()
	{
	}

	public void Clear(bool unloadMain = false)
	{
	}

	private void ClearSelf()
	{
	}

	public void LoadAdditional(string sourceText)
	{
	}

	public void UnloadAdditionals()
	{
	}

	public UGCVarValueDataV2 ParseValueData(ECADefineBase data, string type)
	{
		return null;
	}

	public void GetEventLstByOwnerType(ref List<string> eventNames, string owner)
	{
	}

	public List<string> GetEventLstByOwnerType(string owner)
	{
		return null;
	}

	public ECAVarTypeDefine GetVarTypeDefine(string varName)
	{
		return null;
	}

	public List<long> ExpandTypeID2ComponentIds(string entityName)
	{
		return null;
	}

	public List<ECADefineBase> GetEntityProperties(string entityName, bool writablePropertyOnly, bool includeCustomProperty = true)
	{
		return null;
	}

	public void GetEntityProperties(ref List<ECADefineBase> properties, string entityName, bool writablePropertyOnly, bool includeCustomProperty = true)
	{
	}

	public List<ECADefineBase> GetCustomEntityProperties(string entityName)
	{
		return null;
	}

	public bool IsItemDefineObsolete(ECADefineBase def)
	{
		return false;
	}

	public ECADefineBase GetPropertyByPropertyIndex(string entityType, long propertyIndex, bool excludeReadOnly)
	{
		return null;
	}

	public string GetPropertyValueType(string entityType, long propertyIndex, bool excludeReadOnly)
	{
		return null;
	}

	public ECADefineBase GetPropertyByName(string entityType, string propertyName, bool excludeReadOnly)
	{
		return null;
	}

	public string GetPropertyValueTypeByName(string entityType, string propertyName, bool excludeReadOnly)
	{
		return null;
	}

	public string GetPropertyValueTypeByPropertyValue(string propertyValue, bool excludeReadOnly)
	{
		return null;
	}

	public string GetValueType(ECADefineBase define)
	{
		return null;
	}

	public ECADefineBase GetPropertyByPropertyValue(string propertyValue, bool excludeReadOnly)
	{
		return null;
	}

	public ECADefineBase PropertyDataToDefineData(string entityType, IBILCDHHNHM pData, int idx)
	{
		return null;
	}

	public List<ECAVarTypeDefine> GetEntityTypeDefineList()
	{
		return null;
	}

	public List<ECAVarTypeDefine> GetAllTypeList()
	{
		return null;
	}

	public ECAVarTypeDefine GetTypeDefine(long id)
	{
		return null;
	}

	public string TypeIdToName(long id)
	{
		return null;
	}

	public ECAEventDefine GetCustomEvent(string eventName)
	{
		return null;
	}

	public List<ECAEventDefine> GetAllCustomEvents()
	{
		return null;
	}

	public bool IsEventObsolete(UGCBlockConfigData configData)
	{
		return false;
	}

	private bool IsEventObsolete(string eventName)
	{
		return false;
	}

	public bool IsActionObsolete(UGCBlockConfigData configData)
	{
		return false;
	}

	private bool IsActionObsolete(string actionName)
	{
		return false;
	}

	public bool IsDataObsolete(UGCBlockConfigData configData)
	{
		return false;
	}

	private bool IsDataObsolete(string dataName)
	{
		return false;
	}

	private bool IsUGCSelectorResObsolete(string enumType, string enumStrVar, int enumIntVar)
	{
		return false;
	}

	public bool IsEnumObsolete(string enumType, string enumStrVal, long enumIntVal, out ECADefineBase enumItemDef)
	{
		enumItemDef = null;
		return false;
	}

	public long GetTypeId(string typeName)
	{
		return 0L;
	}

	public bool CheckIsAssignable(string definedType, string assignedType)
	{
		return false;
	}

	public bool IsList(string valueType)
	{
		return false;
	}

	public string GetEnumValueType(string enumType)
	{
		return null;
	}

	public bool IsChildTypeOf(string childType, string baseType)
	{
		return false;
	}

	public bool IsTypeOf(string targetType, string baseType)
	{
		return false;
	}

	public string GetGenericElementType(string genericType, int index)
	{
		return null;
	}
}
