using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIAntiHackWindowController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private enum EAntiHackTabType
	{
		ProfileCredit,
		ProfileReport,
		ProfileCompensation,
		ProxyWebView,
		BanList
	}

	private UIAntiHackWindowView m_View;

	private WebView m_WebViewAntiHack;

	private WebView m_WebViewBanList;

	private WebView.Rect m_WebViewRect;

	private UIModelCredit m_CreditModel;

	private List<CreditReportInfo> m_CreditReportList;

	private List<CreditPenaltyInfo> m_CreditPenzaltyList;

	private List<CreditCompensationInfo> m_CreditCompensationList;

	private UIModelAntiHackWindow m_AntiHackWindowModel;

	private UIStandardTopTabController m_topTabController;

	private List<StandardTopTabItemViewData> m_TabDataList;

	private int m_CurrentTabIndex;

	private string m_ReportHistoryName;

	private string m_ReportHistoryTime;

	private string m_ReportHistoryType;

	private string m_ReportHistorySchedule;

	private string m_ReportHistoryDesc;

	private string m_ReportHistoryReason;

	private string m_PenzaltyHistoryType;

	private string m_PenzaltyHistoryTime;

	private string m_PenzaltyHistoryDay;

	private string m_PenzaltyHistoryDesc;

	private string m_ReportHistoryTimeStamp;

	private string m_PenzaltyHistoryTimeStamp;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitTips()
	{
	}

	private void ClearReportTips()
	{
	}

	private void ClearPenzaltyTips()
	{
	}

	private void ClearCompensationTips()
	{
	}

	private void InitState()
	{
	}

	private void OnTopTabItemClick(int index)
	{
	}

	private void RefreshItemName()
	{
	}

	private void HideCurrentContent()
	{
	}

	private void RefreshContent()
	{
	}

	private void RefreshReportList()
	{
	}

	private void RefreshPenzaltyList()
	{
	}

	private void RefreshCompensationList()
	{
	}

	private void ClearAllWebViews()
	{
	}

	private WebView GetCurrentWebView()
	{
		return null;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void ShowAntiHackWeb()
	{
	}

	private void ShowBanListWeb()
	{
	}

	private WebView.Rect WebViewRect()
	{
		return null;
	}

	private void RefreshWebView()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
