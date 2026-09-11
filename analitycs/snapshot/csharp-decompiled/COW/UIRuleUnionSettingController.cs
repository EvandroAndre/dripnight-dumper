using System;
using GCommon;

namespace COW;

public class UIRuleUnionSettingController : UIBaseController
{
	private UIRuleUnionSettingView m_View;

	public CUninonData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private Action m_ValueChangeCallback;

	private Action m_OnRepositionCallback;

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

	public void SetViewData(CUninonData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private void OnTipEnabledChanged()
	{
	}

	public void AddElement(IModeEditComponentData data, int width, int index, Action callback)
	{
	}

	private void OnEnableChanged()
	{
	}

	public void SetOnRepositionCallback(Action callback)
	{
	}

	private void OnReposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
