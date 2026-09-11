using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class ModeConfig : IModeConfig
{
	private Dictionary<string, bool> boolConfigTable;

	private Dictionary<string, int> intConfigTable;

	private Dictionary<string, float> floatConfigTable;

	private Dictionary<string, string> stringConfigTable;

	public ModeConfig Create()
	{
		return null;
	}

	public bool Load(string path)
	{
		return false;
	}

	public bool GetBool(string key, bool defaultValue)
	{
		return false;
	}

	public int GetInt(string key, int defaultValue)
	{
		return 0;
	}

	public float GetFloat(string key, float defaultValue)
	{
		return 0f;
	}

	public string GetString(string key, string defaultValue)
	{
		return null;
	}

	public void ForUnittestSetInt(string key, int targetValue)
	{
	}

	public void ForUnittestSetBool(string key, bool targetValue)
	{
	}
}
