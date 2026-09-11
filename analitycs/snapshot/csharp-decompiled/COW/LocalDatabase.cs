using System;
using System.Collections.Generic;
using LitJson;
using message;

namespace COW;

[Serializable]
public class LocalDatabase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ImporterFunc<double, float> _003C_003E9__7_0;

		internal float _003CParseLocalSheetDataFromJson_003Eb__7_0(double input)
		{
			return 0f;
		}
	}

	public List<LocalSheetDataEntry> SheetDatas;

	private const int MAX_RECURSION_DEPTH = 128;

	public static LocalSheetValue ConvertUGCVarValueToLocalSheetValue(UGCVarValueDataV2 varValue)
	{
		return null;
	}

	private static LocalSheetValue ConvertUGCVarValueToLocalSheetValue(UGCVarValueDataV2 varValue, int depth)
	{
		return null;
	}

	public static bool IsValueEqual(LocalSheetValue value1, LocalSheetValue value2)
	{
		return false;
	}

	public static bool IsItemDataEqual(LocalSheetItemData item1, LocalSheetItemData item2)
	{
		return false;
	}

	public static bool IsSheetDataDictEqual(Dictionary<string, Dictionary<string, LocalSheetItemData>> dict1, Dictionary<string, Dictionary<string, LocalSheetItemData>> dict2)
	{
		return false;
	}

	public static Dictionary<string, Dictionary<string, LocalSheetItemData>> ParseLocalSheetDataFromJson(string jsonString, string targetSheetName)
	{
		return null;
	}
}
