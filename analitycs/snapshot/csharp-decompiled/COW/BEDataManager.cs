using System.Collections.Generic;
using ECAPackage;
using GCommon;
using message;

namespace COW;

public class BEDataManager : SingletonModule<BEDataManager>
{
	public static bool DebugShowUnsafeBlock;

	private static string m_DebugSourceText;

	private ECADescriptionData m_DescriptionData;

	public readonly List<string> BasicVarType;

	public static HashSet<string> TweenableTypes;

	public static readonly HashSet<string> PropertyFactorAPI;

	public static readonly HashSet<string> RefTypeBlockName;

	public static readonly HashSet<string> SupportContinuousOperationArithmeticType;

	public static readonly HashSet<string> ResourceSelectEnumType;

	private static bool m_IsLoadManually;

	public static string DebugSourceText => null;

	public ECADescriptionData DescriptionData => null;

	public static void LoadManually(string sourceTxt)
	{
	}

	public void UnloadMainDescriptionData()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void LoadMainDescriptionData(string sourceStr = "", bool buildImmediately = true)
	{
	}

	public void InitDescriptionFile()
	{
	}

	public void LoadAdditionalDescription(string sourceTxt)
	{
	}

	public UGCVarValueDataV2 ParseValueData(ECADefineBase data, string type)
	{
		return null;
	}

	public void GetEventLstByOwnerType(ref List<string> eventNames, string owner)
	{
	}

	public ECAVarTypeDefine GetVarTypeDefine(string varName)
	{
		return null;
	}

	public List<ECADefineBase> GetEntityProperties(string entityName, bool writablePropertyOnly, bool includeCustomProperty = true)
	{
		return null;
	}

	public string GetPropertyValueType(string entityType, long propertyIndex, bool excludeReadOnly)
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

	public bool IsActionObsolete(UGCBlockConfigData configData)
	{
		return false;
	}

	public bool IsDataObsolete(UGCBlockConfigData configData)
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

	public bool IsItemDefineObsolete(ECADefineBase def)
	{
		return false;
	}

	public bool IsItemPropertyReadOnly(ECADefineBase def)
	{
		return false;
	}

	public static string PropertyIndexToPropertyName(string entityType, long propertyIndex)
	{
		return null;
	}
}
