using System;
using System.Collections;
using System.Collections.Generic;
using COW.HUD;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class VerticleViewPlayer : AttackableEntity
{
	private enum LELKJKIPPOF
	{
		Idle,
		Walk,
		Dash,
		Dead,
		Upper
	}

	private enum IHDHJGGLJFL
	{
		Base,
		Fire
	}

	private class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 AALEAHDJAMC;

		public Vector3 PHEOMEDPGED;
	}

	private enum BBGFGIFMHIC
	{
		None,
		Normal,
		Skill,
		Sight
	}

	private sealed class MKHPNDJGOJA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public VerticleViewPlayer KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MKHPNDJGOJA(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public BHGGAEEHJCO VPlayerId;

	public bool HasFireInput;

	public uint GunId;

	public bool IsLocalPlayer;

	public float LifeTime;

	public Transform ModelRoot;

	public Transform ArtRoot;

	public float MoveSpeed;

	public bool IsFiring;

	public List<uint> m_GunIdList;

	public MeshRenderer EffectCircle;

	public GameObject Listener;

	public Renderer[] GunGuides;

	public float GrenadeLineOffset;

	public int GrenadePointCnt;

	public int TeamIndex;

	public bool ReverseInput;

	private uint[] IAPCHPDEMGA;

	private Vector3 KLECGNHCNGN;

	private UserControlHandler ODIGILJGPAK;

	private UIHudVerticlePlayerHPController FEFNKBHBAJH;

	private Rigidbody KKFGDJAJJNP;

	private bool IHOAFGKPPMO;

	private VerticleGunController JMPINIDIKMI;

	private Dictionary<uint, VerticleGunController> IKFHNDOBBHL;

	private UIVerticleViewGameScene MHBNFMNPCCN;

	private GIFGAGAGFLA HGEGDIMKMFM;

	private Transform NDJPKFOOIFD;

	private int FEKHOFDDAKA;

	private static float FKHPBEDOMDN;

	private Animator CEJIIGMFAMP;

	private float BHHMPGIBMCE;

	private float GJPPEDCDHNO;

	private float EHNGGFFCICH;

	private Transform OOEEKCIFKKN;

	private MeshRenderer[] NHHBJGNMDDC;

	private float DCJAIOMCCEG;

	private float FHOOGELFCBD;

	private const string ICHPKOKPCJB = "VERTICLEVIEWGUN";

	private float BHJBFINCHNF;

	private float FLMPGEPPKHI;

	private float DAGJEJIPNKO;

	private float EAMKMMHHHCB;

	private bool GKLFBCEAPNO;

	private AudioSource IBDJOMFCCIO;

	private GameObject JDLKDFBCIHJ;

	private static float ANDCPBCDECC;

	private float COJJNNNJMAC;

	private LELKJKIPPOF LMLJGMMOBKB;

	protected uint IAPBBEEDLCG;

	private LJBAALIHDEE LAPJPJICGJD;

	public bool IsInitModels;

	private BBGFGIFMHIC MBDEMHHGAME;

	public int LMNKLKFOOOF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int IOGONNLBJMO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int BPDKJJKIPDL
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int FFHMCEEPJHL
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LIAKFFPNCJE => 0;

	public int LEPLCPOGLCD => 0;

	public int LGKCONCOLAK => 0;

	private void Awake()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void JMIDEDHBJLM(object[] JCONDDPFBKK)
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected void KFOLHOPJBAC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void IADNNOOHLBD(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void NDKCIODNLDF(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void MHONHOIPEGD(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected void OBEBOGFAPNM(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void NEGHOLNOAPP(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void SetData(bool PBOLJALBIJJ, BHGGAEEHJCO KJLFMPOFELA)
	{
	}

	private uint JHKEBJGMBPP(CBLMFOAKHFH KLMONGLAMIG)
	{
		return 0u;
	}

	private void DMDAMCIDALA(CBLMFOAKHFH KLMONGLAMIG, uint BOPJOANPGLA)
	{
	}

	private Renderer HAEGMLCEJNB(CBLMFOAKHFH KLMONGLAMIG)
	{
		return null;
	}

	private void AOLELELFFML(CBLMFOAKHFH KLMONGLAMIG, bool HKGNEMEHBIG)
	{
	}

	private void IJCMKFJECDC(uint FPDHPKBIOAB)
	{
	}

	public VerticleGunController GetGunCtrlById(uint BOPJOANPGLA)
	{
		return null;
	}

	public void InitModel(ResourceID OCCLMDNGINA)
	{
	}

	private void OKIJCLKJOLL()
	{
	}

	public UserControlHandler GetUserControlHandler()
	{
		return null;
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void LateUpdate()
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void KNIGNLAAMCH()
	{
	}

	public void DrawRectMesh(float JICONOJNNJB, float GILNNBJLDGO)
	{
	}

	public void DrawSectorMeshRenderer()
	{
	}

	public void DrawGrenadeLine(int GJNKHLMGOAO, float DJAIMDCPMBI)
	{
	}

	private void IFFNFOBPIDC(LELKJKIPPOF DGDDJLEOPBL)
	{
	}

	private void JBKEMDGCEKE(IHDHJGGLJFL PNLKPJNLDGB, int DEKFJOCHLFD)
	{
	}

	private IEnumerator BOLLGJKJNGP()
	{
		return null;
	}

	private void EMNDIMLAHHN()
	{
	}

	private void MHAOKPCKJNA(bool AMDOOCONMKA)
	{
	}

	private void AOOCNBEPOFK()
	{
	}

	private void KJMHCMGDJPB(float MKCCNABIKII)
	{
	}

	private void KDDIHDGECMM(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnKillCountChanged(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void FIJJABAOMEC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnPlayerTotalDamageChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerDeadCountChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public bool IsTeammate()
	{
		return false;
	}

	public bool IsLocalTeam()
	{
		return false;
	}

	protected override void OnDead()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	private void MNEFOPPHJJN(Vector3 IGDHIDGLOKG, uint OJFBGFOOKEK)
	{
	}

	public void SyncPlayerInfo(EOAEOMMCJLP FPPGIDDBDEI, uint KBMGFBJJHAK, uint MGMLPFKMIEE)
	{
	}

	public void DoRevive(HKMAOBPNJAJ APHHNHEDHKD)
	{
	}

	public bool CanCastSkill()
	{
		return false;
	}

	public void OnTriggerShoot(bool KBJKJDLOKAE)
	{
	}

	private void MBENHAEGMJB(bool KBJKJDLOKAE)
	{
	}

	private void GIKJIPELJKE()
	{
	}

	public void DestroySelf()
	{
	}

	private void AHPBCAMJOFB(bool GPFPIAMCEMI)
	{
	}

	public void RushFollowBullet(VerticleBulletController IDEGJGHOLMA)
	{
	}

	public void ChangeRole(int OPGLGLHKGEB, int PIBGFBLEBPH)
	{
	}

	private void JDGDMIBAAII(float HOGHEFNINAE)
	{
	}

	private void OFFBLJPELBA(int FCAOOKIBKJK)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDead()
	{
	}
}
