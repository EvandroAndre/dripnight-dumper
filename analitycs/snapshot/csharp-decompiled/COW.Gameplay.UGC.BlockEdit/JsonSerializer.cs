using System;
using System.Collections.Generic;
using LitJson;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public class JsonSerializer : IBlockSerializer<JsonWriter>
{
	public bool SerializeString(JsonWriter serializedData, string key, string value, bool ignoreIfNull = false)
	{
		return false;
	}

	public bool SerializeBool(JsonWriter serializedData, string key, bool value)
	{
		return false;
	}

	public bool SerializeInt(JsonWriter serializedData, string key, int value)
	{
		return false;
	}

	public bool SerializeLong(JsonWriter serializedData, string key, long value)
	{
		return false;
	}

	public bool SerializeFloat(JsonWriter serializedData, string key, float value)
	{
		return false;
	}

	public bool SerializeVector3(JsonWriter serializedData, string key, Vector3 value)
	{
		return false;
	}

	public bool SerializeArray<ItemT>(JsonWriter serializedData, string key, List<ItemT> items, Func<IBlockSerializer<JsonWriter>, JsonWriter, ItemT, bool> serializeContentFunc, bool itemIsObject) where ItemT : class
	{
		return false;
	}

	public bool SerializeObject(JsonWriter serializedData, string key, Func<IBlockSerializer<JsonWriter>, JsonWriter, bool> serializeContentFunc)
	{
		return false;
	}

	public bool SerializeTypeInfo(JsonWriter serializer, string key, TypeInfo value)
	{
		return false;
	}
}
