using System.Collections.Generic;
using proto;

namespace COW;

public class ClientClanActivenessAwardDesc
{
	public EClan.ActivenessType activenessType;

	public uint clanLevel;

	public uint activenessLevel;

	public uint activenessValue;

	public List<AwardDesc> awards;

	public uint activenessLimit;

	public bool isClaimed;

	public ClientClanActivenessAwardDesc(ClanActivenessAwardDesc desc)
	{
	}
}
