using GCommon;
using UnityEngine;

namespace COW;

internal class UIMaskController : UIBaseController
{
	private enum EAnimStep
	{
		AnimStep_Finished,
		AnimStep_FirstChange,
		AnimStep_Stable,
		AnimStep_SecondChange
	}

	private UIMaskView m_View;

	private float m_CurAnimStepChangeDuration;

	private float m_FadeDuration;

	private float m_LightDuration;

	private float m_AnimStableDuration;

	private EMaskAnimType m_AnimType;

	private bool m_isAnimFinsihDisableMask;

	private float m_AnimChangeTimePass;

	private float m_AnimStableTimePass;

	private EAnimStep m_AnimStep;

	private Color m_LerpBeginAnimColor;

	private Color m_LerpEndAnimColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetMask(bool enabled)
	{
	}

	public void SetMaskColor(Color color)
	{
	}

	public void BeginMaskAnim(EMaskAnimType maskAnimType, bool isAnimFinsihDisableMask, float fadeDuration, float lightDuration, float stableDuration = 0f)
	{
	}

	private bool IsTwiceChangeAnim()
	{
		return false;
	}

	private bool IsCurFadeChange()
	{
		return false;
	}

	private bool IsCurLightChange()
	{
		return false;
	}

	private void InitCurChangeAnimStep()
	{
	}

	private void Update()
	{
	}

	private void UpdateAnim()
	{
	}

	private void UpdateChangeAnim()
	{
	}

	private void OnChangeAnimEnd()
	{
	}

	private void UpdateStableAnim()
	{
	}

	private void OnStableAnimEnd()
	{
	}

	private void OnAnimFinished()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
