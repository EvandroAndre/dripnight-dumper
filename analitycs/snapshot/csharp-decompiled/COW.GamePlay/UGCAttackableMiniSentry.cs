using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class UGCAttackableMiniSentry : AttackableEntity
{
	public UGCLevelMiniSentry mMiniSentry;

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected MMJPICCOJOM MNLNIMBDCNP()
	{
		return null;
	}

	public void TakeDamageByVehicle(int FCAOOKIBKJK, BHGGAEEHJCO PGEGMKJKOKI, LLEDPGIGCMO CCFHNBDPCOE, int HPPACPHIPCP)
	{
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public override bool NeedAssit()
	{
		return false;
	}

	public override bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public override string GetUGCEntityID()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CanAssistByUGC(float P0)
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public string _003C_003EiFixBaseProxy_GetUGCEntityID()
	{
		return null;
	}
}
