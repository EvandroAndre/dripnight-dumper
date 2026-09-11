using System;

namespace COW;

public class CommonSettingDragableSliderItemData : CommonSettingDragableItemBaseData
{
	public bool ShowSlider;

	public float MinValue;

	public float MaxValue;

	public Action<float> OnSliderChanged;

	public Func<float> OnSliderIncreaseClick;

	public Func<float> OnSliderDecreaseClick;

	public Func<float> CurrentSettingValue;
}
