using System;
using System.Collections.Generic;
using System.Reflection;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIRulePopmenuSettingV3Controller : UIBaseController
{
	private UIRulePopmenuSettingV3View m_View;

	public CPopMenuData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private UIPopMenuSmallControler m_PopMenu;

	private List<PopMenuData> m_PopMenuList;

	private string m_CurrentSelection;

	private Action m_ValueChangeCallback;

	private FieldInfo m_FieldInfo;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected void OnEnable()
	{
	}

	public void SetViewData(CPopMenuData data, float width, int index, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private void GeneratePopList()
	{
	}

	protected virtual void SelectItemCallback(object data)
	{
	}

	private void SetValue(int newValue)
	{
	}

	private int GetValueAsIndex()
	{
		return 0;
	}

	private int CheckAndFixIndex(int index)
	{
		return 0;
	}

	public void SetOffset(Vector3 offset)
	{
	}

	public void SetValueChangeCallback(Action callback)
	{
	}

	private void Log()
	{
	}

	protected void OnValueChanged()
	{
	}

	protected void OnValueChangedWithCallback()
	{
	}

	protected void OnItemsChanged()
	{
	}

	private bool _003CGetValueAsIndex_003Eb__18_0(CPopMenuData.PopMenuItem item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
