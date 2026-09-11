using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class NetworkAIPawn : AttackableEntity, CNMHJGNKOOF, HDIAOJDIPII
{
	protected class LJBAALIHDEE : ShadowStateBase
	{
		public JPEOBBKALLB OGGJIIHFHMM;

		public Vector3 AALEAHDJAMC;

		public Vector3 PHEOMEDPGED;

		public Quaternion DOGHPBHDLCJ;

		public Quaternion GBHPAJHAAMF;
	}

	private enum OEOIOLJKHOB
	{
		None,
		KnockdownAndKeep,
		KnockdownAndRise
	}

	public class JHPGEEJFBOM
	{
		private NPPJNPPJBBI HLKPINBJMFA;

		private Dictionary<uint, NPPJNPPJBBI> BGMFGFCAJCN;

		private NetworkAIPawn _003CMALAOHNCOBI_003Ek__BackingField;

		public NetworkAIPawn NKPFAEIGJLB
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public JHPGEEJFBOM(NetworkAIPawn LDCIMNAAGNO)
		{
		}

		public bool IFKNFDKPLFN(JPEOBBKALLB DJAILDIOGAF)
		{
			return false;
		}

		public void IDPLHNGKDNL(JPEOBBKALLB MDKCAEBHPMA)
		{
		}
	}

	public class NPPJNPPJBBI
	{
		private JHPGEEJFBOM _003CGDJMHCFAGGK_003Ek__BackingField;

		private JPEOBBKALLB _003CNNCEFCACACE_003Ek__BackingField;

		protected JHPGEEJFBOM BGFEDOELHFB
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected NetworkAIPawn NKPFAEIGJLB => null;

		public JPEOBBKALLB BGDMAEFKAFK
		{
			get
			{
				return JPEOBBKALLB.EPHYSXSTATE_WALKING;
			}
			private set
			{
			}
		}

		public NPPJNPPJBBI(JHPGEEJFBOM AELNCKDCENH, JPEOBBKALLB CBCAJJJCKLH)
		{
		}

		public void LKKDFPHJKGB(JPEOBBKALLB OLAHOFPELBC)
		{
		}

		public void LLAFPLELHOE(JPEOBBKALLB GCJPAAPKMMA)
		{
		}

		protected virtual void KNOJLLAMIIM(JPEOBBKALLB GCJPAAPKMMA)
		{
		}

		protected virtual void NKFCJNLBDDI(JPEOBBKALLB OLAHOFPELBC)
		{
		}
	}

	private class DJLGPEDMIIP : NPPJNPPJBBI
	{
		public DJLGPEDMIIP(JHPGEEJFBOM AELNCKDCENH)
			: base(null, JPEOBBKALLB.EPHYSXSTATE_WALKING)
		{
		}

		protected override void NKFCJNLBDDI(JPEOBBKALLB OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(JPEOBBKALLB GCJPAAPKMMA)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(JPEOBBKALLB P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(JPEOBBKALLB P0)
		{
		}
	}

	private sealed class BDFABDHGBDG
	{
		public GameObject IMLPCBHNLPB;

		internal void AKKMOGJGPBO()
		{
		}
	}

	private sealed class KAKBGFMOIDL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public KAKBGFMOIDL(int CBPPJACCGOH)
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

	private float OAKAKJGBMDK;

	private bool DDCEJAEGEPG;

	private bool AEMGNGCGFFP;

	private float JANEABACEFC;

	private Vector3 FDCJJAMLBOM;

	protected Vector3 JKBEIJCPLGK;

	protected float FAAKCCMEJLN;

	protected BHGGAEEHJCO BMIGBNMBAJH;

	private int _003CGPCOJMNJGMP_003Ek__BackingField;

	protected int PACCGGMBJAL;

	private bool _003CGNLICNONEPC_003Ek__BackingField;

	protected string MOKGDCJLJFI;

	protected bool GIHKFDJDLJN;

	protected ITransformNode LDGMAOHBPHI;

	protected ITransformNode KBAAOMBJHLN;

	protected NetworkAIPawnAnimBaseComponent IBELJNLNFCI;

	protected BoxCollider KMFBOIABMFD;

	protected AIPawnBodyMaterialComponent JBLJBCHKHOL;

	public static float DEFAULT_BODY_RADIUS;

	protected CapsuleCollider INKDFABPIHC;

	protected JHPGEEJFBOM CGCLIPJNOND;

	protected OEJNMIAKKAG HKNDHOOEGMG;

	protected PECEGPLNGOG CNIHCIPMGIM;

	protected uint NDKKMGPPCNF;

	protected KOMBEECHGHA DPIDELIDKKB;

	protected uint CHEDCJJDEMD;

	protected JCCLHHIAFMA NLDEDKDMBPK;

	protected DDBAFLHKLIC BMEPLIKKJPO;

	protected Dictionary<int, LFNOJLGCLFF> KJDPGAMLHIJ;

	protected bool BNKFPBNLBDI;

	protected uint IAPBBEEDLCG;

	protected LJBAALIHDEE LAPJPJICGJD;

	protected float ANPANCNNEBC;

	protected bool PMLHDCLPGHJ;

	private bool _003CBGBGDNNMCIH_003Ek__BackingField;

	private bool _003CICIKKLICFND_003Ek__BackingField;

	private uint ENGDBFJCPEC;

	private uint BDEDDOCKEJH;

	private bool _003CIPJLLIGEOBB_003Ek__BackingField;

	public OLDPIGPFIHA m_zombieSyncEvent;

	private float _003CJONMBMKJHMN_003Ek__BackingField;

	private bool _003CGHBDLBOFLCA_003Ek__BackingField;

	private bool _003CFMGBJCAIGIG_003Ek__BackingField;

	private bool _003CBOMLNFKBFMJ_003Ek__BackingField;

	public bool m_IsSkillGod;

	private int HPOGPMILDLF;

	public string AIName;

	protected Dictionary<byte, Vector2> JEDDOEBMEJK;

	private GhostShadowEffectPlayer AJMOJCNBKGN;

	private bool MOCECGGHHCO;

	private int CMHKBBBFFPB;

	protected Transform DAAFGKPMOAL;

	public bool IsNeedFixPostion;

	public bool FixPositionForVehicle;

	private static readonly Dictionary<int, int> LFFNFPPGOKG;

	private Dictionary<int, bool> ALPAEMCNFPG;

	protected float DOHPLAHENPH;

	protected Vector3 HPKLMDKGEML;

	protected float AMEEICOHMEA;

	protected bool OHJDLICEBIA;

	private GameObject JJJLHCDFCEF;

	private Collider[] KBGLDEJOLCH;

	private float DHBADHAHEGH;

	protected bool LLKCNCIFGBD;

	private List<ReusableObject> FMEKMDFGOIP;

	private Coroutine AACFPMPHEJH;

	private string KJIDFCKDFIG;

	private string MNEGLOEOKKB;

	private string BMPIMEMICHD;

	private string HHNCGGGKNJC;

	private UGCDummyAIPawnAnim MDCHFLJFFAB;

	protected NetworkAIPawnAnimBaseComponent ALGEGAAINIK;

	private UGCAimAssistEntityRepItem CKMPCLHODHP;

	private UGCAnimationControllerEntity BADOJEHBFBI;

	private GameObject HCADLKJMILA;

	private uint AMLAIKOLMKG;

	private ResourceID ICOIJHPMGOD;

	public float MMFCKOAGEKL
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float HLIONANLJHH => 0f;

	public Vector3 JLOFDNBMHIH => default(Vector3);

	public BHGGAEEHJCO BHGGAEEHJCO
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		protected set
		{
		}
	}

	public int EBPGIBLHIOP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ONKEBKHNBLB
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool DFDNDDFIEGL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string CGJONMHGBPG
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public NetworkAIPawnAnimBaseComponent JFDNEEKDHMA => null;

	public AIPawnBodyMaterialComponent CEBPPCCFPLA => null;

	public Transform JJFOMOPHMGF => null;

	public Transform NHNFBFCJEIK => null;

	public virtual Transform OFCEDFBHAMO => null;

	public bool DNICHHILMHG => false;

	public float GHKPJDHKGGF
	{
		protected get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool HIPAIILAMMG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NMBFCFOCBHK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint DCMNDCMNAAH => 0u;

	public uint MAININAJIBK => 0u;

	public virtual int FMFIBPLPGOJ
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ACGLKDEKPLJ CNOAHJKLPAI
	{
		get
		{
			return ACGLKDEKPLJ.EAIShieldStatus_Normal;
		}
		set
		{
		}
	}

	public bool NKOKJCMJJHO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float LNEHDJBBKPP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool OIENKHIJFAN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NCKBEIIDMAC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool BFPEDKPFCHF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HJFIJKOAHOB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int PJOJHKCDMHL => 0;

	public bool PBPMPGNIJEH => false;

	public int JHGPGIDKKHN => 0;

	public Vector3 AAPGPMPKMBD
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float ECFLGMOENGJ => 0f;

	public override bool HLFBNDNFMCL => false;

	private bool DNPKHMEFHDJ => false;

	public override void InitEntityInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected virtual void KFOLHOPJBAC(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	protected virtual void IADNNOOHLBD(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void MFPCLOHLOPC(uint EGIMICLPAJP, uint IJFOOEENBBG)
	{
	}

	public override bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public override float GetAttackableRadius()
	{
		return 0f;
	}

	public bool ShowDamageInHitPosition()
	{
		return false;
	}

	public override Vector3 GetHitDamagePos()
	{
		return default(Vector3);
	}

	protected bool HDLBGGHMFEI()
	{
		return false;
	}

	protected override void OnAwake()
	{
	}

	public virtual void CreateInit(Transform MLBAMPFOCGP, DNFBGBPINLE GDEKAGHDGKC)
	{
	}

	public virtual void ReuseInit(Transform MLBAMPFOCGP, DNFBGBPINLE GDEKAGHDGKC)
	{
	}

	protected virtual void NMDLLBLPNLD(ushort CDOIICIPKLB)
	{
	}

	protected virtual void JJKIOJOGJMI(ushort CCNBNLAPJFM)
	{
	}

	private void LLDNAACIGBN()
	{
	}

	protected void NNFGHAGANFC(DNFBGBPINLE GDEKAGHDGKC)
	{
	}

	protected virtual void FNHECJEMNCB()
	{
	}

	protected virtual void IEGLNDCGOOE(Transform NAGHAPBBLKF)
	{
	}

	protected void HHGEGEEEPBO(NetworkAIPawnAnimComponent FDHAHMKIPOG)
	{
	}

	protected void IGDPFBIFHJI()
	{
	}

	protected void PNCENCLIPEI(List<GLOIHOIKIDJ> NBLHNPAHGNA)
	{
	}

	protected float IFHJMJPNADO(FDAEPHMIEPC.DBENAPILEBC CCNBNLAPJFM)
	{
		return 0f;
	}

	private float LFGOAGFIHIN()
	{
		return 0f;
	}

	public void SetCollisionEnable(bool HCLGHJNEFIC)
	{
	}

	protected void JLFJAJPKOIF()
	{
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public void SyncAIMove(INIIGGGGLIG AOFCDPKJKJO)
	{
	}

	public void SyncAISkillData(LLMNEOBBAAN AOFCDPKJKJO)
	{
	}

	public LFNOJLGCLFF GetSkill(DCEDLLLOGBO CCNBNLAPJFM)
	{
		return null;
	}

	public void Explode()
	{
	}

	protected virtual void BCJKDHFCNMB()
	{
	}

	public void Dead(int LPHNICDPDBN, BHGGAEEHJCO FNOOENEHBJP, bool IECLLKLGNME = false, bool FHHDNGKMAMJ = false)
	{
	}

	private void NMFILBGDKHE(bool FHHDNGKMAMJ)
	{
	}

	private void CPGFNIFNJFC(float EJALCFGHJNC)
	{
	}

	private float OGBJCHEJAJB()
	{
		return 0f;
	}

	public void ChangeToKnockdownBev(bool DHFADMKLDJC)
	{
	}

	protected virtual void EHOPJMAHOKL()
	{
	}

	public void OnRecyle()
	{
	}

	protected override void UnRegisterEntity()
	{
	}

	public virtual void UpdateBehavior(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void UpdateKinematics(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void PostUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void PlayWalkSound()
	{
	}

	private bool ALBKNILIHJJ()
	{
		return false;
	}

	private void PNJJHFGLDIJ()
	{
	}

	public Vector3 FixPosition(Vector3 HDFILHFDBKB)
	{
		return default(Vector3);
	}

	private bool OJLHPHJOJEI()
	{
		return false;
	}

	public virtual void OnSkillPhaseEnter(FNLMGJPJIDN PPPGENPKBIN, DCEDLLLOGBO LENJFKDNPMO, float EFICABLDOBG, float HBJNAHBKLDB, bool FGMPOFHPGKG)
	{
	}

	public virtual void OnSkillPhaseExit(FNLMGJPJIDN PPPGENPKBIN, DCEDLLLOGBO LENJFKDNPMO)
	{
	}

	public void UpdateSkillAnim(DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN PPPGENPKBIN, int AEGNEFBOJLB, float AFCGDIOJMGI)
	{
	}

	protected virtual bool NCHMLFPGPND(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
		return false;
	}

	protected virtual bool LFPJNODPDCF()
	{
		return false;
	}

	protected virtual void BEOILBIHNKN(float OKJIFBCMDAD, float HOGHEFNINAE, bool IOMIJKAFEFO)
	{
	}

	private void KHHJLMNGJFF()
	{
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public virtual void TakeDamage(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, LOAEBBHPMEK AOJANNHGCEA, LLEDPGIGCMO CCFHNBDPCOE = LLEDPGIGCMO.None, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u, GLLLEDKLLDA PMMCGNJHOOA = null)
	{
	}

	protected virtual void HEPIOPPPFNG(int LEFJOGGGJFN, LLEDPGIGCMO KHLIJODOLOF)
	{
	}

	private void KCFHBEONJLD(LLEDPGIGCMO IBKBOEAENIM, Player DCAPIHJMMBL)
	{
	}

	protected virtual bool PMKMBEHBBPL(LLEDPGIGCMO KHLIJODOLOF)
	{
		return false;
	}

	public void ShowMatchAICoinAnimation()
	{
	}

	public bool IsAnimationPlaying(int PNLKPJNLDGB, string JCIFFMHHBHK)
	{
		return false;
	}

	public virtual Vector3 GetHeadPosition()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetHipPosition()
	{
		return default(Vector3);
	}

	public void PushAISyncedStateData(object CHDPPLFBCJA, uint OJFBGFOOKEK)
	{
	}

	public void StartHitfly()
	{
	}

	public void StopHitfly()
	{
	}

	protected virtual bool NJDEPBCMNDP()
	{
		return false;
	}

	protected virtual bool OGCILNADMBN()
	{
		return false;
	}

	protected virtual bool GKPNGMJCFLO()
	{
		return false;
	}

	protected virtual void BDMMLILOIHJ()
	{
	}

	protected void LOIPCGHANPN(ResourceID GGMIDNEJGNO, Vector3 HDFILHFDBKB, float GLPLIHEECAP = 1f)
	{
	}

	public void PlayAshot(ResourceID LIKPJDHGPFG, EAudioGroupType CCNBNLAPJFM = EAudioGroupType.Zombie_GeneralSkill, bool LEJKJFFACPM = true, float LHNALOCGHBP = 1f)
	{
	}

	public void PlayAshot(ResourceID LIKPJDHGPFG, ResourceID MLLNECIEOOK, EAudioGroupType CCNBNLAPJFM = EAudioGroupType.Zombie_GeneralSkill, bool LEJKJFFACPM = true, float LHNALOCGHBP = 1f)
	{
	}

	public GameObject Play3DLoopSFX(ResourceID LIKPJDHGPFG, float LHNALOCGHBP = 1f)
	{
		return null;
	}

	public void Stop3DLoopSFX(GameObject ILIBHNPCPEL)
	{
	}

	public override uint GetAttackableID()
	{
		return 0u;
	}

	public override DPNIICGMOJG GetAttackableType()
	{
		return DPNIICGMOJG.EAttackableType_None;
	}

	public void PlayEffect(ResourceID GGMIDNEJGNO)
	{
	}

	public void PlayAnimEffect(string PEHJODPGACF)
	{
	}

	public void PlayAnimSound(string PEHJODPGACF)
	{
	}

	public bool CanUseShadowEffect()
	{
		return false;
	}

	public void PlayShadowEffect(bool JICFLMHLDJJ = true, float KOMBNJOIMCN = 0f, float KKMJNBDKHNH = 0f)
	{
	}

	public void StopShadowEffect()
	{
	}

	public void DisActiveExistShadowEffect()
	{
	}

	public void ShowModel()
	{
	}

	public void HideModel()
	{
	}

	public void DisableColliders()
	{
	}

	public void EnableColliders()
	{
	}

	public void OnPRIStateIndexChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected void IIHEDJAFEKL(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	public void OnPRITransformLevelChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void OPCMPFKGPFC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void SkillTryToTransform()
	{
	}

	public void TryToTransform(int MDLKEENGELE)
	{
	}

	public void ClearCurModel()
	{
	}

	public void TransformChangeModel()
	{
	}

	private void CKKHNGBIJKE(Transform ILGNFMLMAGL, ResourceID FDCHEJPLEBI)
	{
	}

	private void GGHBJKDGFBE(Transform NAGHAPBBLKF, ResourceID JNEEGHAJAIF)
	{
	}

	public void OnSkillUpdateMsgCome(uint BACDJKFBHJE, DCEDLLLOGBO LENJFKDNPMO, object APHHNHEDHKD)
	{
	}

	public void RegisterSkillMsgHandler<T>(uint BACDJKFBHJE, DCEDLLLOGBO LENJFKDNPMO, DDBAFLHKLIC.OMKNNIKDOKI<T> ILOFJIAIBHI)
	{
	}

	public virtual void PostAddedToGame()
	{
	}

	private void KNOHHPGJKDM()
	{
	}

	public virtual void OnBossEnterNewPhase(int DMJJFJOAGNH)
	{
	}

	public GameObject GetEffectInstance(ResourceID LIKPJDHGPFG, bool CCJEPOOEGFO = true)
	{
		return null;
	}

	private void MOFHJIICPHD()
	{
	}

	private void CBHNJMAKAPF()
	{
	}

	private IEnumerator KDHLHEAKAEF()
	{
		return null;
	}

	public virtual float GetRefPosHeight()
	{
		return 0f;
	}

	public virtual bool HudNameEnemyNeedWorldPos()
	{
		return false;
	}

	public virtual ResourceID GetAnimationAudioSourceReourceID()
	{
		return default(ResourceID);
	}

	protected void GIOOLINDHHG(string GDDEBLAFLLG)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void GIDCJBJENHB(long LLAOHBCIHEE, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	public void UGCRefreshVisibility()
	{
	}

	public void OnCameraCullingMaskChanged()
	{
	}

	private void DAANNOMCOBG()
	{
	}

	private void GONDGFLANJD()
	{
	}

	private void HDGIALLLDFG()
	{
	}

	public string UGCEntityID()
	{
		return null;
	}

	public string UGCArchTypeID()
	{
		return null;
	}

	bool CNMHJGNKOOF.IsStatic()
	{
		return false;
	}

	public void OnResetServerTime()
	{
	}

	public void InitEliteEffect()
	{
	}

	private void IODPOFCCLFL(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	public void RecyleEliteEffect()
	{
	}

	private void FGNIDAIPHMG()
	{
	}

	private void EJEFHPBECON()
	{
	}

	private void FFJLBKOMAJP()
	{
	}

	private void EAPIMEMFOCA()
	{
	}

	private void CKBICOOCHFI()
	{
	}

	private void DLMGJOPFODP()
	{
	}

	private void HHPHKBOCJAL()
	{
	}

	private void HFNJMIHHCIP()
	{
	}

	private void IGLEAMAPNHG()
	{
	}

	private void DBCKLDEKCLA()
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanAssistByUGC(float P0)
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public float _003C_003EiFixBaseProxy_GetAttackableRadius()
	{
		return 0f;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetHitDamagePos()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return 0u;
	}

	public DPNIICGMOJG _003C_003EiFixBaseProxy_GetAttackableType()
	{
		return DPNIICGMOJG.EAttackableType_None;
	}

	public bool _003C_003EiFixBaseProxy_get_IsMovableEntity()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
