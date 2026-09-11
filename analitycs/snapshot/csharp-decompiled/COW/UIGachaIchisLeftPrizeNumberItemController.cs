using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisLeftPrizeNumberItemController : UIBaseController
{
	public const float ROLL_DURATION = 0.32f;

	public const float ROLL_DELAY_INTERVAL = 0.05f;

	public const float HIGHLIGHT_DURATION = 0.15f;

	private const float ROLL_OFFSET_Y = 30f;

	private const float HIGHLIGHT_BRIGHTNESS = 1.25f;

	private UIGachaIchisLeftPrizeNumberItemView m_View;

	private int m_CurrentDigit;

	private int m_TargetDigit;

	private float m_RollDelay;

	private float m_RollElapsed;

	private float m_HighlightElapsed;

	private bool m_IsRolling;

	private bool m_IsHighlighting;

	private bool m_LabelStateCached;

	private Vector3 m_NumberBaseLocalPosition;

	private Vector3 m_ChangeBaseLocalPosition;

	private Color m_NumberBaseColor;

	private Color m_ChangeBaseColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetDigit(int digit)
	{
	}

	public void SetDigitImmediate(int digit)
	{
	}

	public void SetDigit(int digit, float delay, bool animate)
	{
	}

	public void SetText(string text)
	{
	}

	public int GetCurrentDigit()
	{
		return 0;
	}

	private void Update()
	{
	}

	private void UpdateRollAnimation(float deltaTime)
	{
	}

	private void FinishRollAnimation()
	{
	}

	private void UpdateHighlightAnimation(float deltaTime)
	{
	}

	private void SetDigitImmediateInternal(int digit)
	{
	}

	private void StopDigitAnimation()
	{
	}

	private void CacheLabelState()
	{
	}

	private void ResetLabelState()
	{
	}

	private void ApplyLabelState(UILabel label, Color baseColor, float alpha, float brightness, Vector3 localPosition)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
