using message;

namespace COW.Gameplay.UGC.BlockEdit;

public static class ValueTypeUtil
{
	public static bool CheckLegalityBefore(TypeInfo blockType, TypeInfo slotType)
	{
		return false;
	}

	public static MMMJICAOFBJ CastCompareType(int compareType)
	{
		return MMMJICAOFBJ.EUGCCompareType_Unknown;
	}

	public static bool IsComparable(MMMJICAOFBJ compareType, ValueData left, ValueData right)
	{
		return false;
	}

	public static void UpdateComparerFormalTypes(MMMJICAOFBJ compareType, ValueData left, ValueData right)
	{
	}

	public static string CastConstSaveType(string type)
	{
		return null;
	}

	public static TypeInfo GetPropertyValueType(string entityType, long propertyIndex, bool excludeReadOnly)
	{
		return default(TypeInfo);
	}

	public static TypeInfo GetTypeInfo(string typeString)
	{
		return default(TypeInfo);
	}

	public static string GetNumberValueType(ValueData value)
	{
		return null;
	}
}
