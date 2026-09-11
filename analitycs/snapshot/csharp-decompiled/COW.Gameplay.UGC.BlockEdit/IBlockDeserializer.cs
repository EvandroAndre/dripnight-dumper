using System.Collections;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public interface IBlockDeserializer<T> where T : class
{
	string ToJson(T data);

	bool TryGetStringValue(T data, string key, out string result);

	bool TryGetBoolValue(T data, string key, out bool result);

	bool TryGetIntValue(T data, string key, out int result);

	bool TryGetLongValue(T data, string key, out long result);

	bool TryGetFloatValue(T data, string key, out float result);

	bool TryGetVector3Value(T data, string key, out Vector3 result);

	bool TryGetArrayValue(T data, string key, out IList result);

	bool TryGetObjectValue(T data, string key, out T result);

	bool TryGetTypeInfoValue(T data, string key, out TypeInfo result);
}
