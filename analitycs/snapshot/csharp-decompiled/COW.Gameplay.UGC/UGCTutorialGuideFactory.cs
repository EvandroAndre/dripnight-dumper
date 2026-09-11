namespace COW.Gameplay.UGC;

public static class UGCTutorialGuideFactory
{
	public const string TYPE_DIALOGUE = "Dialogue";

	public const string TYPE_TUTORIAL_UI = "TutorialUI";

	public const string TYPE_COMMON_GUIDE = "CommonGuide";

	public const string TYPE_SCENE_DRAG_GUIDE = "SceneDragGuide";

	public const string TYPE_GHOST_PREVIEW = "GhostPreview";

	public static UGCTutorialGuideBase Create(string guideType)
	{
		return null;
	}
}
