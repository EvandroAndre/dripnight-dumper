using System.Collections.Generic;
using LitJson;

namespace COW.GamePlay.UGCRuntime;

public class UGCBtNodeData
{
	public string id;

	public string name;

	public string title;

	public string description;

	public List<string> children;

	public string child;

	public Dictionary<string, object> properties;

	public T GetProperty<T>(string propertyName, T defaultValue = default(T))
	{
		return default(T);
	}

	public object GetProperty(string propertyName)
	{
		return null;
	}

	private object ParseJsonString(string s)
	{
		return null;
	}

	private float ToFloat(JsonData jsonData)
	{
		return 0f;
	}

	private byte ToByte(JsonData jsonData)
	{
		return 0;
	}
}
