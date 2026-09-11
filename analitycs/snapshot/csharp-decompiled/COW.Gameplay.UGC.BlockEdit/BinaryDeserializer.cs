using System.Collections;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public class BinaryDeserializer : IBlockDeserializer<SerializedGraph>
{
	public string ToJson(SerializedGraph data)
	{
		return null;
	}

	public bool TryGetStringValue(SerializedGraph data, string key, out string result)
	{
		result = null;
		return false;
	}

	public bool TryGetBoolValue(SerializedGraph data, string key, out bool result)
	{
		result = default(bool);
		return false;
	}

	public bool TryGetIntValue(SerializedGraph data, string key, out int result)
	{
		result = default(int);
		return false;
	}

	public bool TryGetLongValue(SerializedGraph data, string key, out long result)
	{
		result = default(long);
		return false;
	}

	public bool TryGetFloatValue(SerializedGraph data, string key, out float result)
	{
		result = default(float);
		return false;
	}

	public bool TryGetVector3Value(SerializedGraph data, string key, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	public bool TryGetArrayValue(SerializedGraph data, string key, out IList result)
	{
		result = null;
		return false;
	}

	public bool TryGetTypeInfoValue(SerializedGraph data, string key, out TypeInfo result)
	{
		result = default(TypeInfo);
		return false;
	}

	public bool TryGetObjectValue(SerializedGraph data, string key, out SerializedGraph result)
	{
		result = null;
		return false;
	}
}
