namespace COW.Gameplay.UGC;

public static class UGCTutorialContextContentResolver
{
	public const string TYPE_SCENE_ITEM = "SceneItem";

	public static bool ValidateContent(string contextType, object content)
	{
		return false;
	}

	public static UGCTutorialContextData CreateContext(string contextType, object content)
	{
		return null;
	}
}
