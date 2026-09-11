using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudGameplayModifierCarouselItemViewData
{
	public enum Source
	{
		None,
		GlobalMission,
		GameplayAffix
	}

	public Source ViewDataSource;

	public ResourceID ModifierIconResID;

	public string ModifierTitleLocKey;

	public UIHudGameplayModifierCarouselItemViewData(CALJGNKGEME globalMissionData)
	{
	}

	public UIHudGameplayModifierCarouselItemViewData(GameplayAffixConfigData affixConfigData)
	{
	}
}
