using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal abstract class LevelObjectSpawnedAttackable : LevelObjectSpawned, OKEAMEELLBB
{
	private bool _003CBCDAKCDENFD_003Ek__BackingField;

	private Collider _003CACAGMJJNMCN_003Ek__BackingField;

	public abstract int DCMNDCMNAAH { get; }

	public bool DBELGKKHKJP
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public Collider JDNPECFMMFP
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool IDFBHMDOBLL => false;

	public virtual bool HLFBNDNFMCL => false;

	GameObject OKEAMEELLBB.EPJPNAKMFMB => null;

	protected override void OnStart()
	{
	}

	protected override void HHIFACHHBAH()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	protected void KCPBEILJECC()
	{
	}

	public virtual uint GetAttackableID()
	{
		return 0u;
	}

	public virtual DPNIICGMOJG GetAttackableType()
	{
		return DPNIICGMOJG.EAttackableType_None;
	}

	public virtual float GetAttackableRadius()
	{
		return 0f;
	}

	public virtual Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetHitDamagePos()
	{
		return default(Vector3);
	}

	public virtual bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public virtual bool NeedAssit()
	{
		return false;
	}

	public virtual bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	public virtual string GetUGCEntityID()
	{
		return null;
	}

	public virtual bool IsSameTeamWithPlayerID(BHGGAEEHJCO KIFNGKDMHGM)
	{
		return false;
	}

	protected MMJPICCOJOM MNLNIMBDCNP()
	{
		return null;
	}

	public virtual void TakeDamageByVehicle(int FCAOOKIBKJK, BHGGAEEHJCO PGEGMKJKOKI, LLEDPGIGCMO CCFHNBDPCOE, int HPPACPHIPCP)
	{
	}

	public virtual void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public virtual void TakeHealing(DLOFHLEHHNP LDOJBPIKBIK, List<float> LFLPGCMLPFM = null)
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_HHIFACHHBAH()
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
