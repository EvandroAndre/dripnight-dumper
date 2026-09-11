using System;
using UnityEngine;

namespace UMA;

[Serializable]
public class OverlayColorData : IEquatable<OverlayColorData>
{
	public const string UNSHARED = "-";

	public string name;

	public Color[] channelMask;

	public Color[] channelAdditiveMask;

	public Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool IsASharedColor => false;

	public OverlayColorData()
	{
	}

	public OverlayColorData(int channels)
	{
	}

	public void Reset(int channels)
	{
	}

	public OverlayColorData Duplicate()
	{
		return null;
	}

	public bool HasName()
	{
		return false;
	}

	public static bool SameColor(Color color1, Color color2)
	{
		return false;
	}

	public static bool DifferentColor(Color color1, Color color2)
	{
		return false;
	}

	public static implicit operator bool(OverlayColorData obj)
	{
		return false;
	}

	public bool Equals(OverlayColorData other)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public static bool operator ==(OverlayColorData cd1, OverlayColorData cd2)
	{
		return false;
	}

	public static bool operator !=(OverlayColorData cd1, OverlayColorData cd2)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public int GetChannels()
	{
		return 0;
	}

	public void EnsureChannels(int channels)
	{
	}

	public void AssignTo(OverlayColorData dest)
	{
	}

	public void AssignFrom(OverlayColorData src)
	{
	}
}
