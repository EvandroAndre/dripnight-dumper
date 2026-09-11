using System;
using System.Reflection;
using GCommon;

namespace COW;

internal class UIRuleSlidableNumericSettingControllerV2 : UIRuleSlidableNumericSettingController
{
	private Action m_ValueChangeCallback;

	private FieldInfo m_FieldInfo;

	protected override void OnEnable()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(CRangeData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	public void SetValueChangeCallback(Action callback)
	{
	}

	protected override void OnValueChanged()
	{
	}

	private void Log()
	{
	}

	public void _003C_003EiFixBaseProxy_OnEnable()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(CRangeData P0, float P1, UIModeEditGeneralComponentHelper P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnValueChanged()
	{
	}
}
