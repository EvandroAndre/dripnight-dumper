using System;
using UnityEngine;

namespace UMA;

[Serializable]
public class OverlayData : IEquatable<OverlayData>
{
	public OverlayDataAsset asset;

	public Rect rect;

	[NonSerialized]
	public OverlayColorData colorData;

	[NonSerialized]
	public byte additiveOrder;

	[NonSerialized]
	public int refCount;

	public string overlayName => null;

	public OverlayData Duplicate()
	{
		return null;
	}

	public OverlayData()
	{
	}

	public OverlayData(OverlayDataAsset asset)
	{
	}

	public void SetAsset(OverlayDataAsset asset)
	{
	}

	private void CreateOrResetColorData(int channels)
	{
	}

	public void Reset()
	{
	}

	public void InitMaskColor(OverlayColorData colorData)
	{
	}

	public void CopyColors(OverlayData overlay)
	{
	}

	public void EnsureChannels(int channels, bool createNewColor)
	{
	}

	public static bool Equivalent(OverlayData overlay1, OverlayData overlay2)
	{
		return false;
	}

	public static bool EquivalentAssetAndUse(OverlayData overlay1, OverlayData overlay2)
	{
		return false;
	}

	public static implicit operator bool(OverlayData obj)
	{
		return false;
	}

	public bool Equals(OverlayData other)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public static bool operator ==(OverlayData overlay, OverlayData obj)
	{
		return false;
	}

	public static bool operator !=(OverlayData overlay, OverlayData obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
