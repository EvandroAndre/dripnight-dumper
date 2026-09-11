using GCommon;

namespace COW;

internal class UICommonSettingDragableSliderItemController : UICommonSettingDragableItemBaseController
{
	private UICommonSettingDragableSliderItemView m_View;

	private CommonSettingDragableSliderItemData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void RefreshContent()
	{
	}

	public void SetViewData(CommonSettingDragableSliderItemData data, ICommonSettingDragParent settingParent)
	{
	}

	private void OnSliderChange()
	{
	}

	private void OnSliderIncrease()
	{
	}

	private void OnSliderDecrease()
	{
	}

	private float GetSliderValueFromSetting()
	{
		return 0f;
	}

	private float GetSettingValueFromSlider(float sliderValue)
	{
		return 0f;
	}

	public override void UpdateHighLightState(uint itemId, bool up = false)
	{
	}

	public override void ResetHighLightState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateHighLightState(uint P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetHighLightState()
	{
	}
}
