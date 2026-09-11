using LitJson;

namespace COW.Gameplay.UGC;

public static class UGCTutorialMaskParamResolver
{
	public static object Deserialize(JsonData paramJson)
	{
		return null;
	}

	private static bool TryGetBool(JsonData json, string key, out bool value)
	{
		value = default(bool);
		return false;
	}

	private static string GetString(JsonData json, string key, string defaultValue)
	{
		return null;
	}
}
