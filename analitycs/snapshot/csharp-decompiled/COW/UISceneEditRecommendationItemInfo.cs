using proto;

namespace COW;

public class UISceneEditRecommendationItemInfo
{
	public SceneEditSlotInfo SlotInfo;

	public EUGCScene Scene;

	public long Play_at;

	public string Cdn;

	public bool IsShowCrown;

	public static implicit operator UISceneEditRecommendationItemInfo(WorkshopRecommendSeriesInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditRecommendationItemInfo(WorkshopHotInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditRecommendationItemInfo(WorkshopLatestInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditRecommendationItemInfo(WorkshopPersonalRecommendationInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditRecommendationItemInfo(SceneEditSlotInfo data)
	{
		return null;
	}
}
