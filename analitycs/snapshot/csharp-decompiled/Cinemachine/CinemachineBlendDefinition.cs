using System;
using UnityEngine;

namespace Cinemachine;

[Serializable]
public struct CinemachineBlendDefinition(CinemachineBlendDefinition.Style style, float time)
{
	public enum Style
	{
		Cut,
		EaseInOut,
		EaseIn,
		EaseOut,
		HardIn,
		HardOut,
		Linear,
		Custom
	}

	public Style m_Style = Style.Cut;

	public float m_Time = 0f;

	public AnimationCurve m_CustomCurve = null;

	private static AnimationCurve[] sStandardCurves;

	public AnimationCurve BlendCurve => null;

	private void CreateStandardCurves()
	{
	}
}
