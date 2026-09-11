using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbyIceWallDisplayItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UILobbyIceWallDisplayItemController _003C_003E4__this;

		public CSSharedItemData skinData;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UILobbyIceWallDisplayItemView m_View;

	private UIModelIceWallDisplay m_Model;

	private List<ResourceID> m_NeedDownloadList;

	private UIModelOptionalDownload m_optionalDownloadModel;

	private static int DefaultIceWallIconSize;

	private static int SkinIceWallIconSize;

	private WeaponItemData m_Info;

	private UINewDownloadInfoController m_Downloader;

	private UICommonGuideController m_guideController;

	private string m_skinName;

	private bool m_LastAbReady;

	private bool m_LastIconAbReady;

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

	public void ShowGuide()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshIceWallIconSize()
	{
	}

	private void RefreshDownloadState(bool isAbready)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void Update()
	{
	}

	private void SetQualityBG(uint quality)
	{
	}

	private void OnButtonClicked()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void RemoveIceWall(object[] data)
	{
	}

	private void ChangeIceWall(object[] data)
	{
	}

	private void _003CChangeIceWall_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
