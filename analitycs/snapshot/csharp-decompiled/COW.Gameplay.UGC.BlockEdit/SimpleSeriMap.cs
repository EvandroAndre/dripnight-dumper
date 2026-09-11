using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public class SimpleSeriMap
{
	private List<KeyValuePair<string, ISerializableValue>> values;

	public int Count => 0;

	// C# has no syntax for parameterized property 'Item'.
	public KeyValuePair<string, ISerializableValue> get_Item(int index)
	{
		return default(KeyValuePair<string, ISerializableValue>);
	}

	public void set_Item(int index, KeyValuePair<string, ISerializableValue> value)
	{
	}

	public void Set(string key, ISerializableValue value)
	{
	}

	public void Add(string key, ISerializableValue value)
	{
	}

	public bool Remove(string key)
	{
		return false;
	}

	public int IndexOf(string key)
	{
		return 0;
	}

	public bool ContainsKey(string key)
	{
		return false;
	}

	public ISerializableValue Get(string key)
	{
		return null;
	}

	public bool TryGetValue(string key, out ISerializableValue value)
	{
		value = null;
		return false;
	}

	public void Clear()
	{
	}

	public string ToJson()
	{
		return null;
	}
}
