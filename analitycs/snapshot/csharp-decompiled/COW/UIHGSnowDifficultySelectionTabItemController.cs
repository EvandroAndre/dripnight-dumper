using GCommon;
using proto;

namespace COW;

internal class UIHGSnowDifficultySelectionTabItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private PVEChapterInfoDesc m_ChapterDesc;

	private UIHGSnowDifficultySelectionTabItemView m_View;

	private UINewDownloadInfoController m_Downloader;

	private UIModelHuntingGround m_Model;

	private MapModeData m_MapModeData;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelOptionalDownload m_ModelDownload;

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

	private void OnSelectTab(object[] data)
	{
	}

	private void UpdateDownloadList()
	{
	}

	protected void TryDownloadMapRes()
	{
	}

	private void OnBtnSelectClick()
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
