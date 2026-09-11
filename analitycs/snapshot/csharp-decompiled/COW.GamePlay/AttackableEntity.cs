using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal abstract class AttackableEntity : COWReplicationEntity, OKEAMEELLBB
{
	private bool PIKCADEGMOH;

	private Collider _003CACAGMJJNMCN_003Ek__BackingField;

	public bool DBELGKKHKJP
	{
		get
		{
			return false;
		}
		set
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

	public virtual Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public virtual float GetAttackableRadius()
	{
		return 0f;
	}

	public virtual Vector3 GetHitDamagePos()
	{
		return default(Vector3);
	}

	public virtual bool NeedAssit()
	{
		return false;
	}

	public virtual bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	public virtual bool IsSameTeamWithPlayerID(BHGGAEEHJCO KIFNGKDMHGM)
	{
		return false;
	}

	public virtual void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	public virtual void TakeHealing(DLOFHLEHHNP LDOJBPIKBIK, List<float> LFLPGCMLPFM = null)
	{
	}

	public virtual bool IsVisible()
	{
		return false;
	}

	public virtual bool IsStreamerVisible()
	{
		return false;
	}

	protected override void OnStart()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	protected virtual void OnDead()
	{
	}

	public override void OnRecycle()
	{
	}

	public virtual string GetUGCEntityID()
	{
		return null;
	}

	public virtual uint GetAttackableID()
	{
		return 0u;
	}

	public virtual DPNIICGMOJG GetAttackableType()
	{
		return DPNIICGMOJG.EAttackableType_None;
	}

	public virtual bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}
}
