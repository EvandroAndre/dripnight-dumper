using GCommon;

namespace COW;

internal class UIRuleSafeZoneSettingV2Controller : UIRuleInputSlidableNumericSettingController
{
	private UIRuleSafeZoneSettingV2View m_SafeZoneView;

	public CSafeZoneData SafeZoneData;

	public new static ResourceID GetResourceID()
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

	public void SetViewData(CSafeZoneData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	protected override void OnSliderChanged()
	{
	}

	public void RefreshSceneObject()
	{
	}

	public override UIWidget GetBindWidget()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSliderChanged()
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetBindWidget()
	{
		return null;
	}
}
