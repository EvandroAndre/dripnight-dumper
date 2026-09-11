using System;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public class UGCCyberpunkSettings
{
	public float edgeIntensity;

	public float edgeSize;

	public float edgeSensitivity;

	public float glitchInterval;

	public float glitchDuration;

	public Color edgeColor1;

	public Color edgeColor2;

	public Texture2D edgeNoiseTex;
}
