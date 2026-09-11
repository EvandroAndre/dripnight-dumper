using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class BadgeInfoInGame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<EPrime.PrivilegeID, uint> _003C_003E9__7_0;

		internal uint _003C_002Ector_003Eb__7_0(EPrime.PrivilegeID x)
		{
			return 0u;
		}
	}

	public BadgeType BadgeType;

	public uint SubType;

	public uint Role;

	public uint PrimeLevel;

	public readonly List<uint> PrimePrivilegeIdList;

	public BadgeInfoInGame()
	{
	}

	public BadgeInfoInGame(BadgeType badgeType, uint subType, uint role, uint primeLevel, List<uint> privilegeIdList)
	{
	}

	public BadgeInfoInGame(BadgeType badgeType, uint subType, uint role, uint primeLevel, List<EPrime.PrivilegeID> privilegeIdList)
	{
	}
}
