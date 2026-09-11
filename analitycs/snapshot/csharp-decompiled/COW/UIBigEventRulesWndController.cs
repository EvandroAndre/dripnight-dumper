using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEventRulesWndController : UIPopupWindowController, IEasyList
{
	protected UIBigEventRulesWndView m_View;

	protected bool m_IsOpenWebView;

	public ulong m_StartShowTime;

	public int m_ShowTime;

	public ulong m_StartPauseTime;

	public int m_PauseTime;

	private RuleType m_Type;

	private string m_InitSelectRule;

	private object m_ExtralData;

	private UIBigEventRulesItemController m_RulesItemCtrl;

	private List<RuleMapping> m_RuleDataList;

	protected Transform m_TabItemParent;

	protected Transform m_ItemParent;

	public string InitSelectRule
	{
		set
		{
		}
	}

	public RuleType Type
	{
		set
		{
		}
	}

	public object ExtralData
	{
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	public virtual ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	private string GetWebViewPageName()
	{
		return null;
	}

	private string GetRulesWndPageName()
	{
		return null;
	}

	public virtual UIBigEventRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	public virtual UIBigEventRulesItemController OpenChildItemContrller()
	{
		return null;
	}

	public void OnWebViewOpen()
	{
	}

	protected virtual void OnWebViewClose(object[] data)
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OnApplicationPauseEvent(object[] data)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewDataBySelfRules(int mappingIndex = 0, int ruleIndex = 0)
	{
	}

	private void SetViewData()
	{
	}

	private void OnSelectRule(object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private bool _003CSetViewData_003Eb__33_0(RuleMapping e)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
