using System;

namespace GCommon;

public struct AnimationID : IEquatable<AnimationID>
{
	private readonly int m_Value = 0;

	public static readonly AnimationID INVALID;

	private AnimationID(int value)
	{
	}

	public static implicit operator int(AnimationID id)
	{
		return 0;
	}

	public static implicit operator AnimationID(int value)
	{
		return default(AnimationID);
	}

	public static bool operator ==(AnimationID a, AnimationID b)
	{
		return false;
	}

	public static bool operator !=(AnimationID a, AnimationID b)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public int GetLayerIndex()
	{
		return 0;
	}

	public int GetID()
	{
		return 0;
	}

	public static int MakeAnimationID(int id, int layerIndex = 0)
	{
		return 0;
	}

	public bool Equals(AnimationID other)
	{
		return false;
	}
}
