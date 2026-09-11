using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializedList : ISerializableValue, IList, ICollection, IEnumerable
{
	private List<SerializedGraph> serializedMaps;

	public byte Type => 0;

	public int Count => 0;

	// C# has no syntax for parameterized property 'Item'.
	public SerializedGraph get_Item(int index)
	{
		return null;
	}

	public bool IsFixedSize => false;

	public bool IsReadOnly => false;

	// C# has no syntax for parameterized property 'System.Collections.IList.Item'.
	object IList.get_Item(int index)
	{
		return null;
	}

	void IList.set_Item(int index, object value)
	{
	}

	public bool IsSynchronized => false;

	public object SyncRoot => null;

	public SerializedList()
	{
	}

	public SerializedList(int capacity)
	{
	}

	public void Add(SerializedGraph value)
	{
	}

	public void Insert(int index, SerializedGraph value)
	{
	}

	public void RemoveAt(int index)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}

	public int Add(object value)
	{
		return 0;
	}

	public void Clear()
	{
	}

	public bool Contains(object value)
	{
		return false;
	}

	public int IndexOf(object value)
	{
		return 0;
	}

	public void Insert(int index, object value)
	{
	}

	public void Remove(object value)
	{
	}

	public void CopyTo(Array array, int index)
	{
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
