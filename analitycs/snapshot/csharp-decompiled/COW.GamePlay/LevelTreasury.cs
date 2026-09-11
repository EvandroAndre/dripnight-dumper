using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelTreasury : BaseLevelObject, IQuickChatLevelObject
{
	public enum PONNBKMDCJN
	{
		Add,
		Destroy
	}

	private enum GPKJFECAFHO
	{
		ETreasuryModelAction_ShowOrHide,
		ETreasuryModelAction_OpenChanged
	}

	public Transform m_GateRoot1;

	public Transform m_GateRoot2;

	public BoxCollider m_TriggerCollider;

	public Animator m_GateAnimation;

	public Transform m_NormalLoot;

	public Transform m_UpgradeLoot;

	private GameObject MKPLKJHIPGN;

	private GameObject EKCKIMHGKCM;

	private bool CGBAKJELOCN;

	private bool HGCMCPMJPFI;

	private int NKBCCCAHCOE;

	private bool GOIFNPJJMOH;

	private uint CEDDMKMONHH;

	private bool OIPPHPMHHIC;

	private bool KLKCOJOBMGI;

	private GameObject DAAFGKPMOAL;

	private ResourceID CGNMNDNLJAB;

	private ResourceID NHHAHGGKGBN;

	private TreasuryModel ALOIELMGMOC;

	private TreasuryUI GCIGMFPNNDC;

	private PFDCIANOKLN NNDOACOEKJA;

	private List<Material> KEOHHKIFIMJ;

	private List<Material> PEEIMBPNPCI;

	private static bool BNKDCDBJIPI;

	private static bool COOOHGCKPJL;

	private Color GHOKLPPHNFG;

	private Color IGDHEAGBGAE;

	private Color OPCAOFCDJCE;

	private Color GFMCFPKDDHB;

	private Color LMLEKFBGDAP;

	private MutableString LLJMOMFBMFJ;

	public Transform m_VfxRoot;

	private bool JEFNNDNGJDG;

	private bool PENOBAFIBAN;

	private byte AGAPEPNHNCC;

	private byte HOBFBHMABHH;

	private byte IJFFKOBAAJL;

	private float OMKCLMINHFH;

	private float HBNAEKHJJMG;

	private const float LJEPFFBBCLA = 3.7f;

	private bool AIEEJAEAFDD;

	private uint EJKOKJDILOC;

	private ResourceID IDKOEINNGOE;

	private ResourceID ACFBLCLMCIH;

	private Dictionary<BHGGAEEHJCO, byte> BIFFCIJDBIC;

	private EUIHudTreasuryMapState JIMOONFFOCO;

	private uint IMBJHPAPPAC;

	private uint HKIABFADGMA;

	private EntityVisualEffectManager HJCIADKBDMF;

	public CapsuleCollider m_MissionTrigger;

	private uint JHLIHMGPNNL;

	private bool LKDLAKMAICF;

	private bool KKNDLGPBOIE;

	private uint LAOIPPBFKPJ;

	private uint FEKOFPHIMJL;

	private uint INJAHFPHDEN;

	private uint GEOEJNIOKLH;

	private uint OIHEMPJMKIH;

	private bool EILBPCIPBMF;

	private GameObject GEJDPGKIBIH;

	private uint IAOCKOAELGP;

	private uint KCANBOEHKLJ;

	private ResourceID OHJKJIFCHNG;

	private uint MHNJJKFBPAG;

	private ResourceID DPMNFIPLJFH;

	private uint OLGIBEKODGL;

	private bool MEJDBLCKGEL;

	private uint HFDADIABEPN;

	private ResourceID FFBALMCCKOL;

	private Transform LAIJKBCPNHP;

	private bool NNEOMKMEKKN;

	private LevelNBOrangeFoxTreasuryBreak ENHABBCENGM;

	public bool LEGPHLKJOLF => false;

	public int COIIHLCDJGB => 0;

	public bool PEFPJDOHNNF => false;

	public bool ELNNLCKANCF => false;

	public bool MFHDLKMBHML => false;

	public byte NFMEFOHEMIH => 0;

	public bool EGECFNGHBII => false;

	public bool KJLJHIOLPGA => false;

	public bool BCIKELEABBC => false;

	public bool NFACLDOOHMB => false;

	public bool IEOPDPPKAJL => false;

	private EntityVisualEffectManager GOKDPINCDCJ()
	{
		return null;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void BNGPCJHHCDF()
	{
	}

	private void EMKMNCKFKMB(bool KGOHDEBHENF)
	{
	}

	private void KEMAJOBLIHP()
	{
	}

	protected virtual void FFFOAONOGPG(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	protected virtual void NCDLAELFPKF(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void DOFPOGNFPIG(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void EMIGBGIJANL(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void FCODDLFNIOM()
	{
	}

	private void AFMANFIGKKC()
	{
	}

	public override void OnRecycle()
	{
	}

	public override void OnReUse()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	private void MGPNKIHOAMC()
	{
	}

	protected override void OnStart()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void IICNPHNPLAL(bool EOGOGFLCEHL)
	{
	}

	private void OOLNNLNNGNO(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void CKLOJIBBCJA()
	{
	}

	private void IDOHMLKONIL()
	{
	}

	private Texture LONNLJJDCFE()
	{
		return null;
	}

	private void JDEGEDNKOCD()
	{
	}

	protected override void OnAwake()
	{
	}

	private void KCANMFOKBLJ()
	{
	}

	public void OnLocalPlayerEnter(bool IOMKAHBNFBN)
	{
	}

	public void OnLocalPlayerExit()
	{
	}

	private void MAHIMDNCLDH()
	{
	}

	private void FCPIACINDGC()
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void ShowInMap()
	{
	}

	public void UpdateModelEffect()
	{
	}

	public void SetMissionInfo(byte KDICGNFNKPP, float FOGJPHBEABM, ResourceID NAOHDOFAEOL)
	{
	}

	public EUIHudTreasuryMapState GetTreasuryState()
	{
		return EUIHudTreasuryMapState.Default;
	}

	protected void MHNNNLCDFMG(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected void BGGEFKHJMKN(bool HGODAPBOLLF)
	{
	}

	private void AMGDCMMAEPK(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void OLMMBJKHCCE(bool EOGOGFLCEHL)
	{
	}

	private void CALCAICDEGL()
	{
	}

	private void AAHJAOAJAKB()
	{
	}

	public void OnAddPlayer(uint OBMFMAKFDDL)
	{
	}

	public void OnRemovePlayer(uint OBMFMAKFDDL)
	{
	}

	public void OnSyncTriggerPlayers(List<uint> EGCEDNNLAIE)
	{
	}

	public bool IsMultiTeamInTrigger()
	{
		return false;
	}

	public int TeammateCountInTrigger(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return 0;
	}

	public float GetChargeProgress()
	{
		return 0f;
	}

	public bool IsInChargeTrigger()
	{
		return false;
	}

	public bool InTriggerAllIsEnemy()
	{
		return false;
	}

	private bool ABNAOELKKAI(ulong DNIIJMENOJH)
	{
		return false;
	}

	private void ALAIAGIMBFA(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public override string GetBotAgentRuntimeData()
	{
		return null;
	}

	public bool TryUpgradeTreasury()
	{
		return false;
	}

	public void OnTreasuryUpgrade(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	private void DJEGJCLHIKO()
	{
	}

	private void JLLNJANAEJD()
	{
	}

	private void FKDMLDNIMNB()
	{
	}

	protected virtual void DMOIPEHPJFC(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private bool FJEGIGHFFKO()
	{
		return false;
	}

	private void PBKFNKAMMPD(object[] DJAPBCKDFKA)
	{
	}

	private void NDMECMAJCEL(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void NILNGOKHKGP(bool BDPCHJEOKPO, ResourceID BIHBIINNGIK, ResourceID PPNFFDDNMJE, Transform FKODMCNOBDM = null)
	{
	}

	private void NIHGNDBAOJM()
	{
	}

	private void HIHHIKPCPKG()
	{
	}

	private void HHFKIBLCNMB()
	{
	}

	private uint HGKHJKNHMGH(ResourceID EJPBBEFLHNA, Transform FKODMCNOBDM = null)
	{
		return 0u;
	}

	private void IMMLDOLINMF(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	private void PEJICEMJFNJ(GameObject PEPALKNIJGF, bool CNNNACBIDFO)
	{
	}

	private void EAPBMMDBFOH(GameObject PEPALKNIJGF)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	protected virtual void GMGOHDDJEPP(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void AHBFKADDOJA()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnReUse()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}

	public string _003C_003EiFixBaseProxy_GetBotAgentRuntimeData()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
