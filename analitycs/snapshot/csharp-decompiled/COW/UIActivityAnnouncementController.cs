using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIActivityAnnouncementController : UIActivityBaseController
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public uint id;

		internal bool _003CSelectItem_003Eb__0(AnnoucementInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public StandardTabItemViewData tabData;

		public UIActivityAnnouncementController _003C_003E4__this;

		internal void _003CSetData_003Eb__0()
		{
		}
	}

	private UIActivityAnnouncementView m_View;

	private List<AnnoucementInfo> m_GroupDescs;

	private AnnoucementInfo m_SelectInfo;

	private CommunityWebsiteData m_websiteData;

	private UIModelAnnouncement m_ModelAnnouncement;

	private List<StandardTabItemViewData> m_TabDataList;

	private UIStandardTabController m_TabCtrl;

	private UIActivityADContentController m_ADCtrl;

	private UIActivityWebviewController m_WebViewCtrl;

	private uint m_CurrentSelectedGroupId;

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

	protected override void OnVisibilityChanged()
	{
	}

	public override uint GetCurrentSelectedGroupId()
	{
		return 0u;
	}

	public override void SelectItem(uint id, bool needScroll = true)
	{
	}

	public void ActivityGroupSelected(AnnoucementInfo info)
	{
	}

	public override void SetData(object data)
	{
	}

	private void OnTabItemSelect(StandardTabItemViewData viewData)
	{
	}

	private void OnOperate()
	{
	}

	private void OpenCommunityWebsite(bool facebook = false, bool offical = false, bool ins = false)
	{
	}

	private CommunityWebsiteData GetCommunityWebsiteData()
	{
		return null;
	}

	private void _003COnUIInit_003Eb__11_0()
	{
	}

	private void _003COnUIInit_003Eb__11_1()
	{
	}

	private void _003COnUIInit_003Eb__11_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentSelectedGroupId()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_SelectItem(uint P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
