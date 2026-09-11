using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class NetworkPet : COWReplicationEntity
{
	public class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 AALEAHDJAMC;

		public Vector3 PHEOMEDPGED;

		public Vector3 OLBLBINCGBD;

		public Quaternion GBHPAJHAAMF;

		public GJCFANLGPJN GGGOHPFBLFA;

		public byte CMLJNBGPOAK;
	}

	private sealed class JHLIGACCBHM
	{
		public List<PetActionData> CKIOPFBGFKB;

		internal void CLILLLHIMMM(PetActionData HBODNPDNELK)
		{
		}
	}

	protected LJBAALIHDEE LAPJPJICGJD;

	protected uint IAPBBEEDLCG;

	public GameObject m_Model;

	public PetAnimComponent m_AnimComp;

	public Transform NamePos;

	public bool ParachuteBinding;

	public string ParachuteBindBoneName;

	public Vector3 ParachuteTargetOffset;

	public Vector3 ParachuteTargetAngle;

	public bool ParachuteSimulation;

	protected float KHCHPNDJJJH;

	protected float DFGOMNFDBLB;

	protected float BFJJEDEPKHI;

	protected float NCMKHJPJABE;

	private float IACKNEJAIPH;

	private Vector3 NIEIFJPDBHA;

	private float EJFHCFNMJCB;

	private float MOHDLLOBKNL;

	private float JGFGNAEIJIC;

	private float IMKCHJLMILH;

	private float PJFGONFFIJM;

	private float MBPAOLDIBEC;

	public CCMGHIMDPLC Category;

	public uint Id;

	public Player Owner;

	public BHGGAEEHJCO OwnerID;

	public string Name;

	public int DataID;

	public int Level;

	private bool JBCABAIPDHD;

	private bool OKLDENEJLJJ;

	private float JGABPGPFJME;

	public GJCFANLGPJN m_CurrentAction;

	public byte m_CurrentActionParam;

	public bool m_LowQuality;

	public bool m_HidingForRole;

	public bool m_SkipShowAnimForRole;

	public int m_SyncTick;

	public int m_UpdateTick;

	public float m_LastUpdateVisibilityTime;

	protected Transform CIOEGLKOMBG;

	protected bool JOFGBIHLHJO;

	protected float EAENPLEFMKM;

	public List<uint> UnclockedActionIDs;

	protected List<ECAIGDLJKJO> HOEENKIDPLP;

	public ResourceID m_ResId;

	private bool m_IsHiddenShell;

	private bool _003CIHFGCIBCDNK_003Ek__BackingField;

	private static bool CFBLLDLCHKO => false;

	public bool KKAJCEAGCLI => false;

	public bool ODECAADMPEH => false;

	public bool LGOELOAAFIN
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public void Init(CCMGHIMDPLC GEEKOPPNKAP, uint LIKPJDHGPFG, Player LDCIMNAAGNO, string JCIFFMHHBHK, int HIDANNMJCDP, int FJCPAJEPBOD, PetData JCONDDPFBKK, PetSkinData BOBIDPBLHPL, bool FAHMIEKMODJ)
	{
	}

	protected void JLFJAJPKOIF()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public List<ECAIGDLJKJO> GetSkills()
	{
		return null;
	}

	public ECAIGDLJKJO GetSkill(KCLBKEBAILK CCNBNLAPJFM)
	{
		return null;
	}

	public ECAIGDLJKJO GetSkill(string CCNBNLAPJFM)
	{
		return null;
	}

	public void AddSkill(ECAIGDLJKJO GKKELMDDGBJ)
	{
	}

	private void PBIGLAPNKBA()
	{
	}

	public void ChangeSkills(List<message.ECAIGDLJKJO> LNDBIIGBHEK)
	{
	}

	protected void NIKLDFOLOJD()
	{
	}

	protected void OECHPGECOKF()
	{
	}

	public List<PetActionData> GetAllActionData()
	{
		return null;
	}

	public List<PetActionData> GetUnlockedActionData()
	{
		return null;
	}

	public float GetCurrentPetSkillCD()
	{
		return 0f;
	}

	public PetSkillLevelData GetCurrentPetSkill()
	{
		return null;
	}

	private static void IHAFAFDCFPH(int PDEAMOFACJG, List<uint> NAFMFFAGFMD, Action<PetActionData> CEHELPAIELA)
	{
	}

	public float GetNameHeight()
	{
		return 0f;
	}

	public static bool IsMoving(GJCFANLGPJN DNNNJDJIBMP)
	{
		return false;
	}

	protected void PGMEHBOBJKA()
	{
	}

	protected void JPJKNAFCIDK()
	{
	}

	protected void HEGAMHJNIKJ(bool OGECPGHMIHA)
	{
	}

	protected void DIEIBPPEABB()
	{
	}

	protected virtual void NHOAAMNLODH(bool EOGOGFLCEHL, bool OBNPLABHICH)
	{
	}

	public void RequestPlayAnim(uint LIKPJDHGPFG, bool OMBAEMJHFBM = false)
	{
	}

	public void RequestShowPet()
	{
	}

	public void RequestHidePet()
	{
	}

	private void GIGMKAAMOCK(object[] DJAPBCKDFKA)
	{
	}

	private void PGAPKJAFOMJ(bool DDAGMJJDIGK = false)
	{
	}

	private void FHPOBKJOOLN(bool FLCHNFMJHBH, bool DJAAFPNGLGB, bool IDCHCEECMBE = false)
	{
	}

	public void SyncState(uint HDMGPPFLPBA, NDCAEFAMDJI CKIOPFBGFKB)
	{
	}

	private void AKHIIHGOPAA(uint HDMGPPFLPBA, NDCAEFAMDJI CKIOPFBGFKB)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void MPEKNDGCLHC(bool KGCJIPDLBJI, bool MOGMMKIJJBF, float OKJIFBCMDAD)
	{
	}

	private bool JMKFMHGKIIE()
	{
		return false;
	}

	public void SimParachutting(float HOGHEFNINAE)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected void HBKEFDMEIID(float HOGHEFNINAE)
	{
	}

	protected void IKCLIAPGMEI()
	{
	}

	protected void LGPDHLHENAP(GJCFANLGPJN FLPJIBDNEPA, uint HDMGPPFLPBA, NDCAEFAMDJI CKIOPFBGFKB)
	{
	}

	public void ForceShowHide()
	{
	}

	protected bool OKLJEOLMGHG()
	{
		return false;
	}

	protected void INOFPKNHFAA(bool KGOHDEBHENF, bool PJBJOHAFPHA)
	{
	}

	protected bool PGOMDNBPDHM()
	{
		return false;
	}

	protected void EGMNJHHODPH()
	{
	}

	protected void BKGABBEEEJD()
	{
	}

	protected void NDFDGAIEPFE(float HOGHEFNINAE)
	{
	}

	private void AAGGMNDEHLJ()
	{
	}

	public void ChangeSkin(uint OMFKMIPGAGE)
	{
	}

	public void DestorySelf()
	{
	}

	protected virtual void KNFEKHNOAIM()
	{
	}

	public void OnResetServerTime()
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
