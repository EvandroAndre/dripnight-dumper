using System;
using UnityEngine;

[Serializable]
public class TweenMaterialPropertyConfig
{
	public TweenPropertyType PropertyType;

	public string PropertyName;

	public float FromFloat;

	public float ToFloat;

	public int Vec4Index;

	public Gradient ColorGradient;

	public TweenPlayStyle PlayStyle;

	public AnimationCurve Curve;

	public float DurationTime;

	public float StartDelay;
}
