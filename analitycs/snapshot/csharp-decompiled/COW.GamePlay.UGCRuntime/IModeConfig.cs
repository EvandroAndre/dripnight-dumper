namespace COW.GamePlay.UGCRuntime;

public interface IModeConfig
{
	bool GetBool(string key, bool defaultValue);

	int GetInt(string key, int defaultValue);

	float GetFloat(string key, float defaultValue);

	string GetString(string key, string defaultValue);
}
