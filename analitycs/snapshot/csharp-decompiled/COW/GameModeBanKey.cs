using System;

namespace COW;

public struct GameModeBanKey(uint subType, uint matchMode) : IEquatable<GameModeBanKey>
{
	public uint SubType = 0u;

	public uint MatchMode = 0u;

	public bool Equals(GameModeBanKey other)
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

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}
}
