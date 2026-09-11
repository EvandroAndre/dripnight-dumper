using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal class LevelKnockDownShield : AttackableBaseLevelObject
{
	public Animator Anim;

	public GameObject Colliders;

	public BHGGAEEHJCO m_OwnerID;

	private float AHPBGMIBGMO;

	private uint NJMGAILDBPJ;

	protected override void OnAwake()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public void SetOwner(BHGGAEEHJCO LIKPJDHGPFG)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void EnableColliders(bool HCLGHJNEFIC)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	public override bool IsSameTeamWithPlayerID(BHGGAEEHJCO KIFNGKDMHGM)
	{
		return false;
	}

	private void DGDKODHOPGK()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSameTeamWithPlayerID(BHGGAEEHJCO P0)
	{
		return false;
	}
}
