using COW.Gameplay.UGC;
using GCommon;
using proto;

namespace COW;

internal class UIUGCTemplateCreateSelectItemController : UIUGCCreateSelectItemController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UIUGCTemplateCreateSelectItemController _003C_003E4__this;

		public UGCSimpleDownloadTask resDownloadTask;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__0()
		{
		}
	}

	private WorkshopTemplateConfigDesc m_TemplateConfigDesc;

	private WorkshopCreateNewConfigData m_ModeConfigData;

	private WorkshopCreateNewConfigData m_MapConfigData;

	private UIModelOptionalDownload m_ModelDownload;

	private UIModelSceneEdit m_Model;

	public string CDNCover;

	public string CDN1;

	public string CDN2;

	public string CDN3;

	private bool m_NeedCheckAutoDownload;

	private bool m_cdnLoaded;

	private bool m_infoLoaded;

	public WorkshopTemplateConfigDesc ConfigData => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	private void OnReceiveTemplateInfo(WorkshopBasicInfo basicInfo)
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void RefreshOptionalMapResDownloader()
	{
	}

	private void OnUGCResDownloaderClick(UGCSimpleDownloadTask simpleTask, bool autoDownload = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetViewData_003Eb__16_0()
	{
	}

	private void _003COnReceiveTemplateInfo_003Eb__18_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
