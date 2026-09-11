using UnityEngine;

public class UICutsceneBlackMask : MonoBehaviour
{
	private enum EAnimStep
	{
		AnimStep_Finished,
		AnimStep_FirstChange,
		AnimStep_Stable,
		AnimStep_SecondChange
	}

	public UISprite MaskSprite;

	private float m_AnimChangeDuration;

	private float m_AnimStableDuration;

	private EMaskAnimType m_AnimType;

	private bool m_isAnimFinsihDisableMask;

	private float m_AnimChangeTimePass;

	private float m_AnimStableTimePass;

	private EAnimStep m_AnimStep;

	private Color m_LerpBeginAnimColor;

	private Color m_LerpEndAnimColor;

	public void BeginMaskAnim(EMaskAnimType maskAnimType, bool isAnimFinsihDisableMask, float changeDuration, float stableDuration = 0f)
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
}
