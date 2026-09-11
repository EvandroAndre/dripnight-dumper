using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class AirdropIceDestructible : AirdropNormal
{
	private sealed class LHHJBEKPLNM
	{
		public AirdropIceDestructible KOKNHFGCGLN;

		public string DGDDJLEOPBL;

		public ResourceID OCCLMDNGINA;

		public Vector3 HDFILHFDBKB;

		internal void DOIDFOFDBJL(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
		{
		}
	}

	public const uint AirdropIceDestructibleConfigIDSolo = 10001u;

	public const uint AirdropIceDestructibleConfigIDDuo = 10002u;

	public const uint AirdropIceDestructibleConfigIDQua = 10003u;

	public const uint AirdropIceDestructibleConfigIDCS = 10004u;

	public const string BRAirdropIceDestructibleGuideKey = "BRGlooAirdropGuideKey";

	public const string CSAirdropIceDestructibleGuideKey = "CSGlooAirdropGuideKey";

	public GameObject ChangeableBoxModel;

	public BoxCollider AirdropCollision;

	private uint CCGCFFLCLBN;

	private DestructibleObjectConfigData LCNBLGGOBPM;

	private GameObject FPKLPGNCBNN;

	private readonly EntityVisualEffectManager EINPMFNJINA;

	private uint BHAAOGDLHAM;

	private GameObject GGCNEFDMDAG;

	private bool IJJKCKIHNDH;

	private FEKBCHODFLE GELFGDBLHDE;

	private int NJDEEEBLEAG;

	private int FEJNBCKFAIL => 0;

	public DestructibleObjectConfigData KNOLLPNLDOM => null;

	public override bool HLFBNDNFMCL => false;

	public void SyncInitState(uint BDPHNJLAHFE)
	{
	}

	public void SyncState(uint BDPHNJLAHFE)
	{
	}

	private void EPLGOEMCLDE()
	{
	}

	protected virtual void MKOMLLNAIJC(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void KADCJKBJFFN()
	{
	}

	private void OKKJNJFEBIG()
	{
	}

	public override void SetLevelObjectAirdrop(LevelAirdrop ELGIHHLAGFE)
	{
	}

	public override uint GetAttackableID()
	{
		return 0u;
	}

	public override DNFFHCFAHGM GetAiropDropType()
	{
		return DNFFHCFAHGM.AIRDROPNORMAL;
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u)
	{
	}

	public override void OnStable()
	{
	}

	private void NJOCFOALFMP()
	{
	}

	private void GPMFHKBBPFA()
	{
	}

	private ResourceID FBMGFBBPJCB()
	{
		return default(ResourceID);
	}

	private void NJFLJHCOOPJ()
	{
	}

	public void _003C_003EiFixBaseProxy_SetLevelObjectAirdrop(LevelAirdrop P0)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return 0u;
	}

	public DNFFHCFAHGM _003C_003EiFixBaseProxy_GetAiropDropType()
	{
		return DNFFHCFAHGM.AIRDROPNORMAL;
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStable()
	{
	}

	public bool _003C_003EiFixBaseProxy_get_IsMovableEntity()
	{
		return false;
	}
}
