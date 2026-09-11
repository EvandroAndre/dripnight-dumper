using System;
using System.Collections.Generic;
using LitJson;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public static class JsonUtil
{
	public static string LogTitle;

	public static string ReadError;

	public static string WriteError;

	public static void LogErrorMissingField(JsonData jsonData, string fieldName)
	{
	}

	public static void LogErrorWrongType(JsonData jsonData, string fieldName, JsonType type)
	{
	}

	public static void LogErrorDataIsNull()
	{
	}

	public static void LogErrorValueIsNull()
	{
	}

	public static void LogErrorCastEnumFailed(JsonData jsonData, string enumName, int value)
	{
	}

	public static JsonData CheckData(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static bool BuildBool(ref bool value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static bool BuildInt(ref long value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static bool BuildFloat(ref float value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static string BuildString(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static JsonData BuildObject(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static JsonData BuildArray(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static bool BuildVector3(ref Vector3 value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static bool BuildTypeInfo(ref TypeInfo value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static bool BuildFuncType(ref int value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static bool BuildEventType(ref int value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static bool CheckWriterAndKey(JsonWriter jsonWriter, string key)
	{
		return false;
	}

	public static bool WriteBool(JsonWriter jsonWriter, string key, bool value)
	{
		return false;
	}

	public static bool WriteInt(JsonWriter jsonWriter, string key, long value)
	{
		return false;
	}

	public static bool WriteFloat(JsonWriter jsonWriter, string key, float value)
	{
		return false;
	}

	public static bool WriteString(JsonWriter jsonWriter, string key, string value, bool ignoreIfNull = false)
	{
		return false;
	}

	public static bool WriteVector3(JsonWriter jsonWriter, string key, Vector3 value)
	{
		return false;
	}

	public static bool WriteTypeInfo(JsonWriter jsonWriter, string key, TypeInfo typeInfo)
	{
		return false;
	}

	public static bool WriteList<T>(JsonWriter jsonWriter, string key, List<T> value, Func<JsonWriter, T, bool> itemWriteFunc)
	{
		return false;
	}

	public static void ReplaceValueRecursively(JsonData sourceJsonData, string key, Action<JsonData, string> handler)
	{
	}

	public static void ReplaceValueRecursively(JsonData sourceJsonData, List<string> keys, Action<JsonData, string> handler)
	{
	}
}
