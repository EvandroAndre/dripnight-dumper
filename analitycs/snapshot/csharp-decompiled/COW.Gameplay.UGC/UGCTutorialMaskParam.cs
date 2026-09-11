using System;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialMaskParam
{
	public string HollowType;

	public string TargetWidget;

	public bool update;

	public bool abovePopup;

	public bool disableCollider;

	public bool maskAll;

	public string GetTargetWidgetKey()
	{
		return null;
	}
}
