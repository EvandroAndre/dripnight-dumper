using System;

namespace COW;

public class CommonSettingItemDataSlider : CommonSettingItemDataBase
{
	public bool IsSlider;

	public Func<float> GetSliderValueFunc;

	public Action<float> SetSliderValue;

	public float MinValue;

	public float MaxValue;

	public Func<float> OnMinusClick;

	public Func<float> OnPlusClick;
}
