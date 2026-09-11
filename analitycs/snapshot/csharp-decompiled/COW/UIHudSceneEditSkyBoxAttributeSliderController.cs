using System;
using GCommon;

namespace COW;

public class UIHudSceneEditSkyBoxAttributeSliderController : UIBaseController
{
	private UIHudSceneEditSkyBoxAttributeSliderView m_View;

	protected Action<string> m_ValueChangeCallback;

	protected string m_CurValue;

	protected float m_MinValue;

	protected float m_MaxValue;

	protected float m_StepValue;

	protected int m_DecimalPlaces;

	protected bool m_CheckStepValidation;

	protected string m_TipKey;

	private bool m_IsInt;

	protected virtual string CurValue => null;

	public void SetCurValue(string value, bool callBack = true)
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OnLogClick()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual void InitShowData(string title, string minValue, string maxValue, string stepValue, string curValue, bool isInt, int decimalPlaces, string tipKey)
	{
	}

	public void RegisetrValueChangeCallback(Action<string> callBack)
	{
	}

	private void OnInputLabelChanged()
	{
	}

	private void OnSliderBarChangedManully()
	{
	}

	protected virtual void UpdateLabelText()
	{
	}

	protected void UpdateSliderBar()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
