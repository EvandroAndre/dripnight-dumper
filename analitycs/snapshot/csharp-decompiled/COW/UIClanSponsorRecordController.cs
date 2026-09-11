using GCommon;
using proto;

namespace COW;

public class UIClanSponsorRecordController : UIPopupWindowController
{
	public enum EClanSponsorRecordType
	{
		CurrentSponsorTitle,
		HistorySponsorTitle,
		SponsorItem
	}

	private UIClanSponsorRecordView m_View;

	private CSClanPrivilegeRecordsRes m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(CSClanPrivilegeRecordsRes data)
	{
	}

	private void InitView()
	{
	}

	private void InitSponsorItemTemplate()
	{
	}

	private void RefreshSponsorList()
	{
	}

	private void RefreshCurrentSponsorList()
	{
	}

	private void RefreshHistorySponsorList()
	{
	}

	private UITable2.IUITable2Item _003CInitSponsorItemTemplate_003Eb__7_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitSponsorItemTemplate_003Eb__7_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitSponsorItemTemplate_003Eb__7_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
