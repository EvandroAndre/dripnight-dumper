using GCommon;

namespace COW;

internal class UIUGCImageSharePreviewWindowController : UIImageSharePreviewWindowController
{
	private UIUGCPhotoShareWidgetController m_UGCPhotoShareWidgetCtrl;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	protected override void UpdateShareImage()
	{
	}

	public void HideFFLogo()
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public override bool IsUGCPreviewWindow()
	{
		return false;
	}

	public void UpdateShareWidgetInfo(string mapName, string authorName, string modeName, string workshopCode)
	{
	}

	protected override void SetCobrandedView(FrameSelectItemData frameData)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateShareImage()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_IsUGCPreviewWindow()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetCobrandedView(FrameSelectItemData P0)
	{
	}
}
