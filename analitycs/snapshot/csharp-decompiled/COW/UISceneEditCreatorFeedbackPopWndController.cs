using GCommon;

namespace COW;

public class UISceneEditCreatorFeedbackPopWndController : UIPopupWindowController
{
	private UISceneEditCreatorFeedbackPopWndView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelSceneEdit.CreatorFeedBackData m_LastSaveData;

	private ulong m_MapLike;

	private ulong m_MapSubscription;

	private ulong m_MapDifLike;

	private ulong m_MapDifSubscription;

	private ulong m_MapDifExperience;

	private ulong m_MapDifLook;

	private ulong m_AssetLike;

	private ulong m_AssetBuy;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void UpdateMapView()
	{
	}

	private void UpdateAssetView()
	{
	}

	private void ShowMapNode(uint type)
	{
	}

	public static ulong RandomULong(ulong a, ulong b)
	{
		return 0uL;
	}

	private bool IsFillCondition(uint type, ulong data)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
