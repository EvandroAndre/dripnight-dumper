using GCommon;

namespace COW;

internal class UIBooyahPassSeasonPopoverController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIBooyahPassSeasonPopoverView m_View;

	private const string BOOYAHPASS_POPOVER_LOG = "BooyahPassPopover";

	private UIModelBooyahPass m_ModelBooyahPass;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	private void OnGotoBpBtnClick()
	{
	}

	private void OnContinueBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
