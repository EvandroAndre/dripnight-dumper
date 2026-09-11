using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelAirDropInteract : BaseLevelObject, IQuickChatLevelObject
{
	public class FOEMHFNGOAB
	{
		public Vector3 JLIGFBBECMC;

		public Quaternion IKKKHHFJKPF;

		public Vector3 EIAGBFMOGAE;
	}

	public Collider m_InteractCollider;

	public Color[] ActivatedStateColorArray;

	public Color[] CapturedStateColorArray;

	protected IJGHPPLGNHG BFIMDMKCIAC;

	protected int JNIPFBBODDJ;

	protected byte DDAOFDGEGJL;

	protected InteractiveState MAOHIOEAMEA;

	protected int HKCMDFADOJM;

	public float m_BaseRaduis;

	protected float CHLMDIFNCHB;

	protected FEKBCHODFLE GELFGDBLHDE;

	protected bool PNGLDPMDOKD;

	protected int FAFGEKOOBBP;

	private LevelAirdrop IDPJMDKPHIF;

	private GameObject GGCNEFDMDAG;

	private GameObject OHKEPKKNBCC;

	private Vector3 LNEACDMLALI;

	private Quaternion FEHBDAIAPOH;

	private VisualInstanceHolder PPHBEPBCLMO;

	protected GameObject KKIJFEDKIJI;

	protected Color EKBDMNAANHC;

	private uint KDBDOBILAKE;

	protected bool EECLINJADKD;

	private ResourceID GKLJDOMLLAK;

	private bool HFNAENGFAEE;

	protected bool MMCANBPAFCH;

	protected bool BBADOLJAJHE;

	protected bool BEBLCDJHOHK;

	private bool PPMGHLMPHGP;

	private int FALBLGGLHBK;

	protected bool ELBCNKJIKKH;

	protected ResourceID DBLGNFIILFA;

	protected JICFPHNAMDE MCHHNFBIFBF;

	protected JICFPHNAMDE BLCDBALNFCA;

	private ResourceID HKENGGABOCC;

	private bool ICBCIIEIKPB;

	private bool EILBPCIPBMF;

	protected virtual ResourceID JJJCNEAFKKB => default(ResourceID);

	protected virtual ResourceID DFDIHHELJME => default(ResourceID);

	protected override string GetObjectTag()
	{
		return null;
	}

	public virtual bool PrepareForDestroy(JICFPHNAMDE CBCAJJJCKLH, uint DJAPBCKDFKA, bool FEDDIHENJPK)
	{
		return false;
	}

	public virtual bool NeedHighLight()
	{
		return false;
	}

	public virtual void OnCreate(uint DFKJIKFKKDH, JICFPHNAMDE CBCAJJJCKLH, ResourceID KMMFBGMHKCJ, bool EDKFHKDEMEO, List<FOEMHFNGOAB> BOMOIEBFEFE)
	{
	}

	public virtual void SetReward(float LBDHGIGPLJI, uint JBKBONLCJKO, uint PPDNNGEFPKN)
	{
	}

	public virtual void SetPreviewItems(List<uint> IDFDAGNAHGD)
	{
	}

	protected void IAFDNBNLKCA(bool EOGOGFLCEHL, uint KFMNLPAHBJA, Vector3 IGDHIDGLOKG, uint PKGCDGIPAGE, uint DJAPBCKDFKA = 0u)
	{
	}

	protected virtual int ODHGLLHBBFC()
	{
		return 0;
	}

	public virtual DFMAGBNLCHD GetAirdropInteractType()
	{
		return DFMAGBNLCHD.AirDropInteractLock;
	}

	protected override void OnStart()
	{
	}

	private void HMLMEHOMDEK(object[] JCONDDPFBKK)
	{
	}

	private void PLOJJEKNBPO(object[] JCONDDPFBKK)
	{
	}

	private void HOABOCEONIF(object[] JCONDDPFBKK)
	{
	}

	protected Transform AAKMKIMPBHL()
	{
		return null;
	}

	protected virtual void JAMNPCINFEM()
	{
	}

	protected virtual void CMEGGJACONN(Vector3 HCPPKIHKCEP)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected virtual void OCHDAAKJPDJ(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected virtual void CAPEKCLPLAC(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected virtual void BANOMJNJEIP(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected virtual void KFLNJGHCMOA(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	public bool IsInChargeTrigger()
	{
		return false;
	}

	protected virtual void BOJNOKBLKOD(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	public void OnTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	public void OnTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	protected void OIBNKJCABBL()
	{
	}

	protected void MOFBOMKBAFG()
	{
	}

	private void LOPPFMNKGIF(bool PIDINBNGILH)
	{
	}

	protected virtual bool DDGFJLCBMPH()
	{
		return false;
	}

	protected virtual void NAJJKOALOEJ()
	{
	}

	protected virtual void KJIEAOOHGON(bool DKDEHBPECLL)
	{
	}

	protected virtual void MFBJANKIAAL(bool GPFPIAMCEMI)
	{
	}

	protected void MDMEBLMLNCA()
	{
	}

	protected virtual void LINKEEPELOH(Color[] OBNGFCLDENO)
	{
	}

	protected virtual void FCFHNAOBNMP(bool ABHOMCMECNP)
	{
	}

	public virtual void EnterSync(uint PKGCDGIPAGE, uint KANPFIDIJCI, uint IDAHCFCBLBA, byte HOLPKMJOFKG)
	{
	}

	public virtual void StayUnlockState()
	{
	}

	protected virtual void IFCEJBFBABC(bool AADAPGLEPBG, int DFMDCELBIEA)
	{
	}

	protected virtual void CLJNEGBICON(int DFMDCELBIEA)
	{
	}

	protected virtual float GHKHCJAFECD()
	{
		return 0f;
	}

	protected void AMHEPCKHBJF()
	{
	}

	private void MHHKDNGDIJK(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	private void DLOLCLHIGOM(GameObject CLACOPMJHDI)
	{
	}

	private void PEGMJIPEDFI()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	protected void CFLCFLEBLNJ(uint PKGCDGIPAGE, uint KANPFIDIJCI, uint IDAHCFCBLBA)
	{
	}

	public void ShowAirDropWeaponLevelBoxVFX(bool IHLDAIHLHKH, bool LLBIFBFCLHK, Vector3 DFNHOKCIIJK, Vector3 GLPLIHEECAP)
	{
	}

	public void RecyleAirDropWeaponLevelBoxVFX()
	{
	}

	private void FGFAHNDMILP(GameObject CLACOPMJHDI)
	{
	}

	protected virtual ResourceID JKBIHCHOBBG(ResourceID MCHOGPKOJEO, uint AODDAEDAPDO, out bool GGOMBJMHGGL)
	{
		GGOMBJMHGGL = default(bool);
		return default(ResourceID);
	}

	private void BIGCBJMAOII(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	private void LOGJHDOJDBN(GameObject CLACOPMJHDI)
	{
	}

	protected virtual Vector3 FFGLBLHDJBP()
	{
		return default(Vector3);
	}

	protected virtual void MDIKMHCGCHO(Vector3 HDFILHFDBKB)
	{
	}

	public virtual void PlayCloseEffect(JICFPHNAMDE CBCAJJJCKLH)
	{
	}

	protected void HMEFCNAMHIF()
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual bool BOGOJECHCGO()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public virtual void DoDestroy()
	{
	}

	protected void HLMNNGCBKCP()
	{
	}

	private bool ABNAOELKKAI(ulong NHCDKMIMECN)
	{
		return false;
	}

	private void GOIJNDBKLNA(ulong NHCDKMIMECN)
	{
	}

	private void HMGLICBJPCF()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}
