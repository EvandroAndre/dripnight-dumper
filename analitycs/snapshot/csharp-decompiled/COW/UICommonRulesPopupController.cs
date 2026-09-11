using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICommonRulesPopupController : UIPopupWindowController, IEasyList
{
	protected UICommonRulesPopupView m_View;

	private RuleType m_Type;

	private string m_InitSelectRule;

	private object m_ExtralData;

	private GameObject m_CurrentScrollViewObj;

	private List<RuleMapping> m_RuleDataList;

	protected Transform m_TabItemParent;

	public Action CloseCallBack;

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

	protected override void OnUIInit()
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

	private void SetTitleKey(RuleType type)
	{
	}

	public virtual List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	public virtual UICommonRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	private void OnSelectRule(object[] param)
	{
	}

	protected virtual void RuleSelectedCallback(RuleMapping rule)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private bool _003CSetViewData_003Eb__18_0(RuleMapping e)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
