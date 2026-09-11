using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal class MovableShootingTarget : AttackableEntity
{
	private Quaternion EGCJPHCNLGI;

	private Quaternion JGEPPJPOPPL;

	private MovableShootingTargetData GFBHKKMBJLJ;

	private GameObject DAAFGKPMOAL;

	private BOLBNOJIKBM JOOENGNHJMD;

	private bool HKCHPMGNDIB;

	private float PFANNLEGIOF;

	private int ODCLEFNEFHM;

	private Vector3 OPLIBBBEDPF;

	private float KOPBIGHBDIL;

	private float OBPECEFPIMP;

	private float MJFEEPBAPPE;

	private List<Vector3> AFFKBAPNJLJ;

	private bool CNPHLDOFPLC;

	private HKGAJCJCMPE HGEGDIMKMFM;

	protected override void OnStart()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void MJMKKDEGLGF(object[] JCONDDPFBKK)
	{
	}

	protected override void OnDead()
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void NENCMEPJNPO()
	{
	}

	private void FPAHEILNJBB(MLJNBIIJBKE CCNBNLAPJFM)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override float GetAttackableRadius()
	{
		return 0f;
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public override Vector3 GetHitDamagePos()
	{
		return default(Vector3);
	}

	public override bool NeedAssit()
	{
		return false;
	}

	public override bool IsSameTeamWithPlayerID(BHGGAEEHJCO KIFNGKDMHGM)
	{
		return false;
	}

	public override uint GetAttackableID()
	{
		return 0u;
	}

	public BOLBNOJIKBM GetCurState()
	{
		return BOLBNOJIKBM.Idle;
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public void TakeLocalGrenadeDamage(float FCAOOKIBKJK)
	{
	}

	public bool CanTakeDamageInGrenadePractice()
	{
		return false;
	}

	public void UpdateTargetInGameState(BOLBNOJIKBM CBCAJJJCKLH, bool OJJNIDDIGFB)
	{
	}

	public MovableShootingTargetData GetData()
	{
		return null;
	}

	public void SetHp(float NKGBIPINKIE)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDead()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public float _003C_003EiFixBaseProxy_GetAttackableRadius()
	{
		return 0f;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public Vector3 _003C_003EiFixBaseProxy_GetHitDamagePos()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsSameTeamWithPlayerID(BHGGAEEHJCO P0)
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}
}
