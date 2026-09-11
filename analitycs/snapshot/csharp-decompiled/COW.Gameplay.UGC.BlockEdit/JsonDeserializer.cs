using System.Collections;
using LitJson;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public class JsonDeserializer : IBlockDeserializer<JsonData>
{
	public string ToJson(JsonData data)
	{
		return null;
	}

	public bool TryGetStringValue(JsonData data, string key, out string result)
	{
		result = null;
		return false;
	}

	public bool TryGetBoolValue(JsonData data, string key, out bool result)
	{
		result = default(bool);
		return false;
	}

	public bool TryGetIntValue(JsonData data, string key, out int result)
	{
		result = default(int);
		return false;
	}

	public bool TryGetLongValue(JsonData data, string key, out long result)
	{
		result = default(long);
		return false;
	}

	public bool TryGetFloatValue(JsonData data, string key, out float result)
	{
		result = default(float);
		return false;
	}

	public bool TryGetVector3Value(JsonData data, string key, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	public bool TryGetArrayValue(JsonData data, string key, out IList result)
	{
		result = null;
		return false;
	}

	public bool TryGetTypeInfoValue(JsonData data, string key, out TypeInfo result)
	{
		result = default(TypeInfo);
		return false;
	}

	public bool TryGetObjectValue(JsonData data, string key, out JsonData result)
	{
		result = null;
		return false;
	}
}
