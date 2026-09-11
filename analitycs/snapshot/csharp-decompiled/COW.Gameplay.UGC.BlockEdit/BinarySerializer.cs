using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public class BinarySerializer : IBlockSerializer<SerializedGraph>
{
	public bool SerializeString(SerializedGraph serializedData, string key, string value, bool ignoreIfNull = false)
	{
		return false;
	}

	public bool SerializeBool(SerializedGraph serializedData, string key, bool value)
	{
		return false;
	}

	public bool SerializeInt(SerializedGraph serializedData, string key, int value)
	{
		return false;
	}

	public bool SerializeLong(SerializedGraph serializedData, string key, long value)
	{
		return false;
	}

	public bool SerializeFloat(SerializedGraph serializedData, string key, float value)
	{
		return false;
	}

	public bool SerializeVector3(SerializedGraph serializedData, string key, Vector3 value)
	{
		return false;
	}

	public bool SerializeArray<ItemT>(SerializedGraph serializedData, string key, List<ItemT> items, Func<IBlockSerializer<SerializedGraph>, SerializedGraph, ItemT, bool> serializeContentFunc, bool itemIsObject) where ItemT : class
	{
		return false;
	}

	public bool SerializeObject(SerializedGraph serializedData, string key, Func<IBlockSerializer<SerializedGraph>, SerializedGraph, bool> serializeContentFunc)
	{
		return false;
	}

	public bool SerializeTypeInfo(SerializedGraph serializedData, string key, TypeInfo value)
	{
		return false;
	}
}
