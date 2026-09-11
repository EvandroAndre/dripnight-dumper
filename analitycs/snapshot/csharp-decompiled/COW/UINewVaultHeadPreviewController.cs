using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UINewVaultHeadPreviewController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public UINewVaultHeadPreviewController _003C_003E4__this;

		public List<ResourceID> res_list;

		public string tempname;

		internal void _003CSetHotFixDownload_003Eb__0()
		{
		}
	}

	private UINewVaultHeadPreviewView m_View;

	private UIBaseProfileInfoController m_ProfilePreview;

	private UIModelCollection m_modelCollection;

	private UINewDownloadInfoController m_DownloadCtrl;

	private uint m_HeadID;

	private uint m_PinID;

	private uint m_BannerID;

	private bool m_NeedDownload;

	private UIModelNewVault.eSecondTab m_SecondTab;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetProfilePreviewPos(UIModelNewVault.eSecondTab secondTab)
	{
	}

	private void UpdatePreview()
	{
	}

	public void UpdataHeadPic(uint headID)
	{
	}

	public void UpdateBriefBanner(uint bannerId)
	{
	}

	public void UpdatePin(uint pinId)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetHotFixDownload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
