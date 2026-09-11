using System;
using GCommon;
using proto;

namespace COW;

public class UIUGCRecommendationPopMapSlotController : UIUGCUnifiedMapSlot1Controller
{
	public Action<SceneEditSlotInfo> OnClickMap;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(UISceneEditRecommendationItemInfo info, ERecommendationType type, uint series_id = 0u)
	{
	}

	public void SetViewData(WorkshopEditorChoiceInfo info, bool isMain)
	{
	}

	private void SetFromInfoForRecommendation(ERecommendationType type, uint series_id)
	{
	}
}
