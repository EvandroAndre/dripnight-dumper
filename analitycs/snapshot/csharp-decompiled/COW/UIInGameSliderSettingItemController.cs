using GCommon;

namespace COW;

internal class UIInGameSliderSettingItemController : UICommonSettingSliderItemController
{
	protected InGameSettingItemDataSlider m_SliderData;

	private uint m_MainType;

	private uint m_SubType;

	public uint MainType => 0u;

	public uint SubType => 0u;

	public uint TypeID => 0u;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(CommonSettingItemDataBase baseData, int type)
	{
	}

	protected override void UpdateWidgetBounds()
	{
	}

	private void OnSliderClick()
	{
	}

	private void OnInGameSettingItemClicked(object[] objects)
	{
	}

	private void _003CSetViewData_003Eb__11_0()
	{
	}

	private void _003CSetViewData_003Eb__11_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_SetViewData(CommonSettingItemDataBase P0, int P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateWidgetBounds()
	{
	}
}
