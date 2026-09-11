using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileReportController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private UIProfileReportView m_View;

	private UIModelCredit m_CreditModel;

	private List<CreditReportInfo> m_CreditReportList;

	private List<CreditPenaltyInfo> m_CreditPenzaltyList;

	private bool m_SelectFlag;

	private string m_ReportHistoryName;

	private string m_ReportHistoryTime;

	private string m_ReportHistoryType;

	private string m_ReportHistorySchedule;

	private string m_ReportHistoryDesc;

	private string m_PenzaltyHistoryType;

	private string m_PenzaltyHistoryTime;

	private string m_PenzaltyHistoryDay;

	private string m_PenzaltyHistoryDesc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnReportHistoryButtonClick(UIToggleButton button)
	{
	}

	private void OnPenzaltyHistoryButtonClick(UIToggleButton button)
	{
	}

	private void InitState()
	{
	}

	private void ChangeEasyListDesc(bool IsReportHistory)
	{
	}

	private void OnClickBtnGameSecurity()
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
