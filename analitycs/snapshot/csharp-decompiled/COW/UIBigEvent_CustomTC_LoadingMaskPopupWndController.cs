using GCommon;

namespace COW;

public class UIBigEvent_CustomTC_LoadingMaskPopupWndController : UIBigEvent_Template_LoadingMaskPopupWndBaseController, IUIModelDataChangeObserver
{
	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshLoadingMaskNeedDownloadCdn()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshLoadingMaskNeedDownloadCdn()
	{
	}
}
