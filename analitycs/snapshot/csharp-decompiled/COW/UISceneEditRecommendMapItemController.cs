using GCommon;

namespace COW;

internal class UISceneEditRecommendMapItemController : UIBaseController
{
	private enum ERecType
	{
		Recommended,
		ReconmendationPop
	}

	private SceneEditSlotInfo m_SlotInfo;

	private UISceneEditRecommendMapItemView m_View;

	private ERecType m_RecType;

	private int m_RecommendedIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(SceneEditSlotInfo data, int index = 0)
	{
	}

	protected virtual void ShowMapIcon()
	{
	}

	private void OnItemBtnClick()
	{
	}

	private void _003CShowMapIcon_003Eb__9_0()
	{
	}

	private void _003CShowMapIcon_003Eb__9_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
