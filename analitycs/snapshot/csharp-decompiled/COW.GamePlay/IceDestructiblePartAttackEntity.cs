using System.Collections.Generic;

namespace COW.GamePlay;

internal class IceDestructiblePartAttackEntity : AttackableEntity
{
	private LogicIceDestructiblePart FPCKIIONGKI;

	private LevelIceDestructible CIOEGLKOMBG;

	public override bool HLFBNDNFMCL => false;

	public void SetContainer(LevelIceDestructible MLBAMPFOCGP)
	{
	}

	public void SetLogicPart(LogicIceDestructiblePart MAMHOPHGONK)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public override uint GetAttackableID()
	{
		return 0u;
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	public void TakeDamageByVehicle(BHGGAEEHJCO PGEGMKJKOKI, int HPPACPHIPCP)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_get_IsMovableEntity()
	{
		return false;
	}
}
