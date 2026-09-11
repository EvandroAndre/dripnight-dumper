using COW.Gameplay.UGC;
using GCommon;

namespace COW;

internal class UIUGCCreateMapSelectItemController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIUGCCreateMapSelectItemController _003C_003E4__this;

		public UGCSimpleDownloadTask resDownloadTask;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__0()
		{
		}
	}

	private UIUGCCreateMapSelectItemView m_View;

	private WorkshopCreateNewConfigData m_ConfigData;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private UIModelOptionalDownload m_ModelDownload;

	private bool m_locked;

	private bool m_NeedCheckAutoDownload;

	public WorkshopCreateNewConfigData ConfigData => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void OnItemBtnUnSelect()
	{
	}

	public void SetViewData(WorkshopCreateNewConfigData info)
	{
	}

	private void OnWebTutorialClick()
	{
	}

	public bool MapCanAreaEdited()
	{
		return false;
	}

	public bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private void ShowDownload()
	{
	}

	private void HideDownload()
	{
	}

	private void OnUGCResDownloaderClick(UGCSimpleDownloadTask resDownloadTask, bool autoDownload = false)
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
}
