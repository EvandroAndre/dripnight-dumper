using System;
using UnityEngine;

namespace COW;

[Serializable]
public class HudClickCollectionInfo
{
	public string Name;

	public Vector2 ScreenPosition;

	public Vector2 Scale;

	public float OriginalWidth;

	public float ScreenPixelRadius;

	public float NoiseThresholdMultiplier;

	public HudClickCollectionInfo()
	{
	}

	public HudClickCollectionInfo(string name, float noiseMultiplier = 1.2f)
	{
	}

	public bool IsPointValid(Vector2 point)
	{
		return false;
	}

	public float GetNoiseThreshold()
	{
		return 0f;
	}
}
