using System;
using GCommon;

namespace COW;

public class UIRoomCheckSliderTemplateController : UIBaseController
{
	private UIRoomCheckSliderTemplateView m_View;

	private int m_DataID;

	private int m_MinValue;

	private int m_MaxValue;

	private int m_Interval;

	private int m_CurValue;

	private Action<int> m_SliderCB;

	private Action<bool> m_ToggeleCB;

	public int DataID => 0;

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

	public void SetSlider(int dataID, string key, int max, int min, int interval, int def, bool toggleVal, bool showToggle = true)
	{
	}

	public void SetCallBack(Action<int> sliderCB, Action<bool> toggleCB)
	{
	}

	public void ResetCallBack()
	{
	}

	private void OnToggleChanged()
	{
	}

	private void OnSliderChanged()
	{
	}

	private void OnPlusClick()
	{
	}

	private void OnMinusClick()
	{
	}

	public void SetToggleWithoutNotify(bool val)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
