using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public interface IBlockSerializer<T> where T : class
{
	bool SerializeString(T data, string key, string value, bool ignoreIfNull = false);

	bool SerializeBool(T data, string key, bool value);

	bool SerializeInt(T data, string key, int value);

	bool SerializeLong(T data, string key, long value);

	bool SerializeFloat(T data, string key, float value);

	bool SerializeVector3(T data, string key, Vector3 value);

	bool SerializeArray<ItemT>(T data, string key, List<ItemT> items, Func<IBlockSerializer<T>, T, ItemT, bool> serializeContentFunc, bool itemIsObject) where ItemT : class;

	bool SerializeObject(T data, string key, Func<IBlockSerializer<T>, T, bool> serializeContentFunc);

	bool SerializeTypeInfo(T data, string key, TypeInfo value);
}
