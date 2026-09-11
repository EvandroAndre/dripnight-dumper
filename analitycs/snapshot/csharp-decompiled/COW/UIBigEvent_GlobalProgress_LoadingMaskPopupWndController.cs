using GCommon;

namespace COW;

public class UIBigEvent_GlobalProgress_LoadingMaskPopupWndController : UIBigEvent_Template_LoadingMaskPopupWndBaseController, IUIModelDataChangeObserver
{
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnSetNavigationController()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void SetInfoBeforeRefreshView()
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

	protected override void OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoBeforeRefreshView()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshLoadingMaskNeedDownloadCdn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
