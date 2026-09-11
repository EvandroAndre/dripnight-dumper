using System;
using System.IO;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializedGraph : ISerializableValue
{
	private readonly SimpleSeriMap _data;

	public byte Type => 0;

	public bool AddDynamicInteger(string key, long value)
	{
		return false;
	}

	public bool Add(string key, int value)
	{
		return false;
	}

	public bool Add(string key, string value)
	{
		return false;
	}

	public bool Add(string key, string value, bool ignoreIfNull)
	{
		return false;
	}

	public bool Add(string key, bool value)
	{
		return false;
	}

	public bool Add(string key, float value)
	{
		return false;
	}

	public bool Add(string key, long value)
	{
		return false;
	}

	public bool Add(string key, Vector3 value)
	{
		return false;
	}

	public bool Add(string key, Vector2 value)
	{
		return false;
	}

	public bool Add(string key, TypeInfo typeInfo)
	{
		return false;
	}

	public bool Add(string key, SerializedGraph value)
	{
		return false;
	}

	public bool Add(string key, SerializedList value)
	{
		return false;
	}

	public long GetDynamicInteger(string key)
	{
		return 0L;
	}

	public int GetInt32(string key)
	{
		return 0;
	}

	public string GetString(string key)
	{
		return null;
	}

	public bool GetBool(string key)
	{
		return false;
	}

	public float GetFloat(string key)
	{
		return 0f;
	}

	public long GetInt64(string key)
	{
		return 0L;
	}

	public Vector3 GetVector3(string key)
	{
		return default(Vector3);
	}

	public Vector2 GetVector2(string key)
	{
		return default(Vector2);
	}

	public TypeInfo GetTypeInfo(string key)
	{
		return default(TypeInfo);
	}

	public SerializedGraph GetSerializedMap(string key)
	{
		return null;
	}

	public SerializedList GetSerilizedList(string key)
	{
		return null;
	}

	public bool Set(string key, int value)
	{
		return false;
	}

	public bool Set(string key, string value)
	{
		return false;
	}

	public bool Set(string key, bool value)
	{
		return false;
	}

	public bool Set(string key, float value)
	{
		return false;
	}

	public bool Set(string key, long value)
	{
		return false;
	}

	public bool Set(string key, Vector3 value)
	{
		return false;
	}

	public bool Set(string key, Vector2 value)
	{
		return false;
	}

	public bool Set(string key, TypeInfo typeInfo)
	{
		return false;
	}

	public bool Set(string key, SerializedGraph value)
	{
		return false;
	}

	public bool Set(string key, SerializedList value)
	{
		return false;
	}

	public bool TryGetDynamicIntegerValue(string key, out long value)
	{
		value = default(long);
		return false;
	}

	public bool TryGetValue(string key, out int value)
	{
		value = default(int);
		return false;
	}

	public bool TryGetValue(string key, out string value)
	{
		value = null;
		return false;
	}

	public bool TryGetValue(string key, out bool value)
	{
		value = default(bool);
		return false;
	}

	public bool TryGetValue(string key, out float value)
	{
		value = default(float);
		return false;
	}

	public bool TryGetValue(string key, out long value)
	{
		value = default(long);
		return false;
	}

	public bool TryGetValue(string key, out Vector3 value)
	{
		value = default(Vector3);
		return false;
	}

	public bool TryGetValue(string key, out Vector2 value)
	{
		value = default(Vector2);
		return false;
	}

	public bool TryGetValue(string key, out TypeInfo value)
	{
		value = default(TypeInfo);
		return false;
	}

	public bool TryGetValue(string key, out SerializedGraph value)
	{
		value = null;
		return false;
	}

	public bool TryGetValue(string key, out SerializedList value)
	{
		value = null;
		return false;
	}

	public string ToJson()
	{
		return null;
	}

	public byte[] ToBytes()
	{
		return null;
	}

	public void ReadBytes(byte[] bytes)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}

	public void LogErrorMissingField(string fieldName)
	{
	}

	public void ReplaceValueRecursively(string key, Action<SerializedGraph, string> handler)
	{
	}
}
