using System;
using UnityEngine;

[Serializable]
public class ParachuteParam
{
	public float UpOffset;

	public float BackOffset;

	public float FOV;

	public bool ImmediateChange;

	public AnimationCurve AnimCur;

	public CameraShakeParam ShakeParam;

	public float TransSpeed;

	public float NearClip;
}
