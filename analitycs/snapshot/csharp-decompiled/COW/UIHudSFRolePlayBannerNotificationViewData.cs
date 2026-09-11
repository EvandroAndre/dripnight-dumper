using UnityEngine;

namespace COW;

public class UIHudSFRolePlayBannerNotificationViewData
{
	public readonly string AnimationName;

	public readonly string IconSpriteName;

	public readonly string BGSpriteName;

	public readonly string FirstLineLocKey;

	public readonly Color32 FirstLineLocKeyColor;

	public readonly string SecondLineLocKey;

	public readonly Color32 SecondLineLocKeyColor;

	public readonly bool IsFirstLineNeedDoLoc;

	public readonly bool IsSecondLineNeedDoLoc;

	public readonly int Layer;

	public UIHudSFRolePlayBannerNotificationViewData(string animationName, string iconSpriteName, string bgSpriteName, string firstLineLocKey, Color32 firstLineLocKeyColor, string secondLineLocKey, Color32 secondLineLocKeyColor, bool isFirstLineNeedDoLoc = true, bool isSecondLineNeedDoLoc = true, int layer = 5)
	{
	}
}
