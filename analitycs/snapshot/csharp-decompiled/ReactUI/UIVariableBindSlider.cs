namespace ReactUI;

public sealed class UIVariableBindSlider : UIEventBind
{
	private string valueBind;

	public float minValue;

	public float maxValue;

	private UISlider m_slider;

	public UIInput RefInput;

	private bool m_isRegisterRefInputEvent;

	private UIVariable m_sliderVariable;

	private float m_targetSliderValue;

	private bool m_isInTween;

	private string eventName;

	private SignalDelegateList m_delegateList;

	private bool m_isChangingRefInput;

	private bool m_isChangingSliderFromRefInput;

	private float userValue2SliderValue(float value)
	{
		return 0f;
	}

	private float sliderValue2UserValue(float value)
	{
		return 0f;
	}

	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	protected override void RefreshBind()
	{
	}

	private void OnSliderFinished()
	{
	}

	private void checkRefInput()
	{
	}

	private void applyValueToRefInput()
	{
	}

	private void OnRefInputValueChanged()
	{
	}

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private void InitSliderValue()
	{
	}

	private void RefreshSliderValue()
	{
	}

	private new void Awake()
	{
	}
}
