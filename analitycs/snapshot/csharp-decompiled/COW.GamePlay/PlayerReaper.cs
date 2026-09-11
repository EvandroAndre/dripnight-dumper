using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class PlayerReaper : PlayerNetwork
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__14_0;

		internal void POGLPAJKDDN()
		{
		}
	}

	private const string APJIABGKKPH = "Bip01";

	private new Transform LKCDAFFDJNK;

	private const int DBGFIPKGBOP = 0;

	private const int IIENLGDEIHM = 1;

	private const int MBNKDJHNEBJ = 2;

	private const int LEPDMNFPNFC = 3;

	private GameObject FCJDPPMPLIK;

	private bool _003CGLLKKJKGEHG_003Ek__BackingField;

	private GameObject IMHHHECHJIK;

	private Dictionary<int, int> LLIBOKEAMBJ;

	private Dictionary<int, int> OOMAPGALPLI;

	private Dictionary<KeyCode, int> JOGMFGNMGCG;

	public override Collider HPOEJIGALCP => null;

	private Transform LOOENPHNHMM => null;

	private bool CJEIINDHJNM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private void ABCKFNLJFIB(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	public uint GetSoul()
	{
		return 0u;
	}

	private void CBMBBGFFGKK(bool LODLJINCKLF, bool PHCLPAOEAOP)
	{
	}

	private void CCPEFHBMAGA(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	private void FHODICLCELB(bool OLNEKOCLJOM)
	{
	}

	public bool GetReaperState()
	{
		return false;
	}

	public void TestSetSoulCount(ushort PNLDKNOFPNG)
	{
	}

	public override void OnTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	public override void OnTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public override void Dead(int LPHNICDPDBN, uint ENJBDKJIKJO, BHGGAEEHJCO FNOOENEHBJP, bool IECLLKLGNME = false, bool GGLDMJEFGCG = false, bool FCGHCIOGMGK = false, bool FAJBOHLHDHO = false)
	{
	}

	private void CEDFBFMBAOE(Transform PFJFADHEJLJ)
	{
	}

	protected override void JFDMEGLIOEK(JECKDOPHBBJ ADFNDGOCBMN)
	{
	}

	public override void RequestExitTransform()
	{
	}

	protected override void MPHPENGOJMO()
	{
	}

	private void FPMIAFAILGC(bool KLLHNNPMHHM)
	{
	}

	public override void OnActSkillFinished(DMPADEOHJNJ LENJFKDNPMO)
	{
	}

	private ResourceID HJOJGBFDBBD()
	{
		return default(ResourceID);
	}

	private ResourceID GPKBALKMIKE()
	{
		return default(ResourceID);
	}

	public override bool IsIgonreWeaponFireControl()
	{
		return false;
	}

	public override Dictionary<int, int> GetGameControlMappingToSkillIndexMap()
	{
		return null;
	}

	public override Dictionary<KeyCode, int> GetKeyCodeToSkillIndexMap()
	{
		return null;
	}

	public override Dictionary<int, int> GetUGCActionMappingToSkillIndexMap()
	{
		return null;
	}

	public override bool IsOverrdieFastRunControl()
	{
		return false;
	}

	public override void ShowAttMsg(string APHHNHEDHKD)
	{
	}

	public override bool IsIgnorePlayerAudioComponent()
	{
		return false;
	}

	public override bool IsIgnoreHighFalling()
	{
		return false;
	}

	public override bool IsNeedAimAssists()
	{
		return false;
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	private void GKDNPLOEMFC()
	{
	}

	public Collider _003C_003EiFixBaseProxy_get_HeadCollider()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTriggerEnter(Collider P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTriggerExit(Collider P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public new void _003C_003EiFixBaseProxy_Dead(int P0, uint P1, BHGGAEEHJCO P2, bool P3, bool P4, bool P5, bool P6)
	{
	}

	public void _003C_003EiFixBaseProxy_JFDMEGLIOEK(JECKDOPHBBJ P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RequestExitTransform()
	{
	}

	public void _003C_003EiFixBaseProxy_MPHPENGOJMO()
	{
	}

	public void _003C_003EiFixBaseProxy_OnActSkillFinished(DMPADEOHJNJ P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsIgonreWeaponFireControl()
	{
		return false;
	}

	public Dictionary<int, int> _003C_003EiFixBaseProxy_GetGameControlMappingToSkillIndexMap()
	{
		return null;
	}

	public Dictionary<KeyCode, int> _003C_003EiFixBaseProxy_GetKeyCodeToSkillIndexMap()
	{
		return null;
	}

	public Dictionary<int, int> _003C_003EiFixBaseProxy_GetUGCActionMappingToSkillIndexMap()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsOverrdieFastRunControl()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ShowAttMsg(string P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsIgnorePlayerAudioComponent()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsIgnoreHighFalling()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedAimAssists()
	{
		return false;
	}

	public new Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}
}
