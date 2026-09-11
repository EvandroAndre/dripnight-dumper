using System;
using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public static class GraphUpgradeUtil
{
	private static readonly List<Func<JsonData, bool>> GraphUpgradeFunctions;

	private static readonly List<Func<SerializedGraph, bool>> GraphUpgradeFunctionsForSerMap;

	public static Func<string, long, string> PropertyIndexToPropertyName;

	public static bool UpgradeProjectToCurrent(int editorVersionCode, byte[] sourceProjectData, out byte[] resultProjectData)
	{
		resultProjectData = null;
		return false;
	}

	public static bool UpgradeProjectToCurrent(int sourceGraphVersionCode, JsonData jsonData)
	{
		return false;
	}

	public static bool UpgradeProjectToCurrent(JsonData jsonData)
	{
		return false;
	}

	public static void PreProcessIgnoreVersion(JsonData jsonData, string key)
	{
	}

	public static void MigrateDeprecatedVarType(JsonData jsonData, string key)
	{
	}

	public static void MigrateDeprecatedVarType(SerializedGraph serializedMap, string key)
	{
	}

	private static void MigrateDefLocalVarTypeEnum(JsonData jsonData)
	{
	}

	public static bool UpgradeProjectToCurrent(int sourceGraphVersionCode, SerializedGraph serializedMap)
	{
		return false;
	}

	public static bool UpgradeProjectToCurrent(SerializedGraph serializedMap)
	{
		return false;
	}

	public static void PreProcessIgnoreVersion(SerializedGraph serializedMap, string key)
	{
	}

	private static void MigrateDefLocalVarTypeEnum(SerializedGraph serializedMap)
	{
	}

	private static byte[] ToBytes<T>(T data)
	{
		return null;
	}

	private static T ToObject<T>(byte[] bytes)
	{
		return default(T);
	}

	public static void UpgradePropertyIndexToPropertyValue(JsonData jsonData, int typeSelectorIndex, int propertySelectorIndex)
	{
	}

	public static void UpgradePropertyIndexToPropertyValue(SerializedGraph serializedMap, int typeSelectorIndex, int propertySelectorIndex)
	{
	}
}
