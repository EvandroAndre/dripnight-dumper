using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelDynamicColliderAttackScript : MonoBehaviour, OKEAMEELLBB
{
	private LevelDynamicCollider DLCNNHPLJGL;

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

	public bool IDFBHMDOBLL => false;

	public bool HLFBNDNFMCL => false;

	GameObject OKEAMEELLBB.EPJPNAKMFMB => null;

	public void Create(LevelDynamicCollider HACIJIFIDKM)
	{
	}

	public Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public float GetAttackableRadius()
	{
		return 0f;
	}

	public Vector3 GetHitDamagePos()
	{
		return default(Vector3);
	}

	public bool NeedAssit()
	{
		return false;
	}

	public bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	public bool IsSameTeamWithPlayerID(BHGGAEEHJCO KIFNGKDMHGM)
	{
		return false;
	}

	public bool IsVisible()
	{
		return false;
	}

	public bool IsStreamerVisible()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected void LPJOHBOGMCN()
	{
	}

	public bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public string GetUGCEntityID()
	{
		return null;
	}

	public void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	public void TakeHealing(DLOFHLEHHNP LDOJBPIKBIK, List<float> LFLPGCMLPFM = null)
	{
	}

	public uint GetAttackableID()
	{
		return 0u;
	}

	public DPNIICGMOJG GetAttackableType()
	{
		return DPNIICGMOJG.EAttackableType_None;
	}
}
