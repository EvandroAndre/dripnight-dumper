using System;

namespace GCommon;

[Serializable]
public struct ResourceID : IEquatable<ResourceID>
{
	private readonly uint m_Value = 0u;

	public static readonly ResourceID INVALID;

	public bool IsValid => false;

	public string Name => null;

	private ResourceID(uint value)
	{
	}

	public static implicit operator uint(ResourceID id)
	{
		return 0u;
	}

	public static implicit operator ResourceID(uint value)
	{
		return default(ResourceID);
	}

	public static bool operator ==(ResourceID a, ResourceID b)
	{
		return false;
	}

	public static bool operator !=(ResourceID a, ResourceID b)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public bool Equals(ResourceID other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
