using GCommon;

namespace COW;

public class UIVirtualBrandDownloadConfirmController : UISecondConfirmContoller, IUIModelDataChangeObserver
{
	private uint m_BrandID;

	private bool m_HasDownloadStarted;

	private UIModelVirtualBrand m_ModelVirtualBrand;

	private UIModelOptionalDownload m_ModelDownload;

	private UINewDownloadInfoController m_DownloadCtrl;

	protected override void OnUIInit()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetConfirmData(uint id)
	{
	}

	private void SetDownloadController()
	{
	}

	private void StartDownload()
	{
	}

	private void UpdateLabel()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
