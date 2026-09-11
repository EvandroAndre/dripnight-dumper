using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class UGCAimAssistEntity : MonoBehaviour, OKEAMEELLBB
{
	private UGCAimAssistEntityRepItem CKMPCLHODHP;

	private Transform FKEMOMBMHEM;

	private bool PIKCADEGMOH;

	private Collider _003CACAGMJJNMCN_003Ek__BackingField;

	public Vector3 MOEFFAIDCBP
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion LFCNHAJBHEE
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

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

	public virtual bool IsVisible()
	{
		return false;
	}

	public virtual bool IsStreamerVisible()
	{
		return false;
	}

	public void AddExtraScript()
	{
	}

	public void CreateUGC(BaseLevelObject HACIJIFIDKM)
	{
	}

	public void CreateUGC(OGIJAGDFGAM HACIJIFIDKM)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void LPJOHBOGMCN()
	{
	}

	public virtual bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public virtual string GetUGCEntityID()
	{
		return null;
	}

	public virtual void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	public virtual void TakeHealing(DLOFHLEHHNP LDOJBPIKBIK, List<float> LFLPGCMLPFM = null)
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
}
