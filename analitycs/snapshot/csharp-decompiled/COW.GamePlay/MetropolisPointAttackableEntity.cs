using System.Collections.Generic;

namespace COW.GamePlay;

internal class MetropolisPointAttackableEntity : AttackableEntity
{
	public LevelMetropolisPoint LevelPoint;

	public override uint GetAttackableID()
	{
		return 0u;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}
}
