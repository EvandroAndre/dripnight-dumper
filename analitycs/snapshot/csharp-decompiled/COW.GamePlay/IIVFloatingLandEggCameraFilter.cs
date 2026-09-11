using System;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Serializable]
public class IIVFloatingLandEggCameraFilter
{
	public NMPBHPDCEIH EggType;

	public Color FogColor;

	public float FogStartDistance;

	public float FogEndDistance;

	public bool BloomEnable;

	public float UltraIntensity;

	public float UltraThreshold;

	public float UltraSoftKnee;

	public float UltraDiffusion;

	public Color BloomColor;
}
