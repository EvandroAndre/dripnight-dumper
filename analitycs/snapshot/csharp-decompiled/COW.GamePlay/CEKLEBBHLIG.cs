using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class CEKLEBBHLIG
{
	public const string GNMJBJKLCJH = "Transform";

	public const string GDFBGGNDFIG = "ExChangeEpToHp";

	public const string GMFAFFKICHH = "HealingDance";

	public const string MAPPBMIAHFE = "GraffitiSanctuary";

	public const string IONPDLKPGID = "Detective";

	public const string GHNMLKEJDPL = "DetectiveScan";

	public const string PBHMEFMOPCG = "EPFastAndUpper";

	public const string NHJJOPBGIIC = "AddDamageByCostHP";

	public const string IAILONEMKKF = "SpaceShield";

	public const string JEKAFJCNNAO = "AuraSpaceShield";

	public const string GPKINLJDAHP = "FollowSpaceShield";

	public const string CNJNOCGBIMI = "BlowUpIceWall";

	public const string BKIAAPGKKID = "ShockIcewallFollowZone";

	public const string MGANIEFLNAO = "TrackingShockIcewall";

	public const string FAJHKEEOCFN = "TempIncreaseHP";

	public const string NCBHHMLNPPG = "IncreaseHPAndDecreaseScatter";

	public const string ECAEDOEKCDP = "AddHPAndRescure";

	public const string FGMCPIMEFFJ = "RunSpeedUp";

	public const string JOMDIDCMKJE = "DWShield";

	public const string NCGPJMDIIHI = "ArcShield";

	public const string DOHKLJCMJLD = "HealingDanceWithFaction";

	public const string CPPBBGIKLEG = "FootballMidfielder";

	public const string PAJHAADOPEB = "ThrowSilence";

	public const string GIGCHMPIACO = "CreateFlightBomb";

	public const string LHBGHNEILKM = "MarkIceWall";

	public const string FHOLFGFCPHD = "Teleporter";

	public const string ECFEEKNONPK = "TeleporterEX";

	public const string NGBGPMKLBOE = "SantinoDummyExplosible";

	public const string NDKDHNNCPJJ = "BoostHPAndRegeneration";

	public const string JNEGMMOFHMC = "BoostTempShield";

	public const string CKBOOLMLOIO = "GrenadeSplit";

	public const string PDNLHKJODKB = "IncreaseShootAndMoveSpeed";

	public const string EANABPHLFGG = "ChangeRescureRate";

	public const string OKLNEGLKHLN = "PlayerSprint";

	public const string DBNFMPCOIAN = "healingSpread";

	public const string AFMGPMGOMLP = "AutoPathBomb";

	public const string MEPNCNHNAPH = "ScannerMarker";

	public const string EJAEGFLIIKG = "FireBoyFlame";

	public const string LAONHPOAICP = "RemoteRescue";

	public const string BDKHDNAEIJM = "WoundedAmmo";

	public const string KDMFOOHPNCJ = "SuperArmor";

	public const string HMCELADKGDF = "PlayerSkillAlokHealAndAddSpeed";

	public const string MHNIOMHNPKC = "PlayerSkillAlokAwakening";

	public const string IAKNHDEMNGA = "Immortality";

	public const string HEJNOONEHLJ = "Teleporter";

	public const string AOIEKIHPKEO = "SwatGuy";

	public const string BAKJOJINPPG = "TeleportKnockDown";

	public const string HMEONFPABJP = "Persona";

	public const string EJKANNMBOLG = "ElectricGirl";

	public const string JKPHHABEKGG = "ElectricGirlEX";

	public const string IMJDNOJMJFP = "ElectricGirlED";

	public const string GHLFCPJBHPO = "FordRecoverHPWhenHurt";

	public const string NNBLLPGMKNF = "BloodPool";

	public const string OPJLMNHKKPI = "HealingBullet";

	public const string GAAIGLKDMFP = "SlowDownMark";

	public const string MOOJEFFGCLJ = "AuroraBoy";

	public const string DCHEOOOCKJN = "MischiefGirl";

	public const string EENBPJKNLKL = "Rasengan";

	public const string FAJFCKEDJBN = "Chidori";

	public const string KODMJLKGOHD = "Oukashou";

	public const string DFMKCIODKJM = "Gougakyu";

	public const string PJAGMAPOAFN = "Suiryuudan";

	public const string FPNIHFJPAKE = "Daitoppa";

	public const string KLLAJKBKAMG = "CityHeroBoy";

	public const string PGHELHIBJPL = "IIV_GP_PURPLE";

	public const string GHBFMMIHNKD = "IIV_GP_1v1";

	public const string MPFKGPPFJEK = "IIV_GP_FLIES";

	public const string AEFGHNNOEOE = "IIV_GP_DashBoxing";

	public const string CNLLEKCKKCN = "IIV_GP_Temple";

	public const string AHFMPAIHMOC = "IIV_FlightBomb";

	public const string MEKHJDCCAFB = "NanBombPaper";

	public const string EJAIOHLJNOB = "ItachiFlame";

	public const string DLGOBHOAMLC = "PainUniversalPull";

	public const string HPIMLEBHGOI = "2NBGP_HidanScythe";

	public const string FPPCAGGJMNM = "2NBGP_Slug";

	public const string OEHKLKCJFCG = "2NBGP_Shadow";

	public const string JHAPIMCFFFG = "2NBGP_GaaraShield";

	public const string DPEIEHEKBLM = "2NBGP_Hiraishin";

	public const string GPPOGECNEON = "2NBGP_CreateFlightBomb";

	public const string ADCDACCNNDF = "AddBuffAfterHurt";

	public const string MMJNNIPFHFE = "AddBuffAfterBreakIceWall";

	public const string GHLIMGODIMK = "NinjaGirl";

	public const string INKOFPNNPPL = "DreamlandBoy";

	public const string LKPFMDNGAKE = "Mysteryman";

	public const string JJCHLKHCKBK = "StrongMedicine";

	public const string MKLOIKABCLI = "Activity_FlightBomb";

	public const string FNICOFKJDBL = "EclipseMan";

	protected Player IAMDEGAAELH;

	protected AvatarSkillData GFBHKKMBJLJ;

	protected CEKLEBBHLIG COBMHMIPJAI;

	private BGCIPCIDJAI _003CPFOLDNJFMKE_003Ek__BackingField;

	public bool JLCNEDKAMBE;

	private CEKLEBBHLIG _003CACLOJLDLNMG_003Ek__BackingField;

	private CEKLEBBHLIG _003CCLABNIOLCOE_003Ek__BackingField;

	private ResourceID OKMKCPFJFHB;

	private int CJOCGBECGEA;

	private bool OJEDABKKJPC;

	private int JGKOAEEDOIH;

	private CollectionSkillData FHLHEPBOPPL;

	private bool NANCEDOPGEK;

	private uint AODIDJLHOCH;

	protected ResourceFallback DDGBCMNLCNH;

	public BGCIPCIDJAI JCJPDOMDIMM
	{
		get
		{
			return BGCIPCIDJAI.EPlayerSkillSourceType_Unknown;
		}
		set
		{
		}
	}

	public BGCIPCIDJAI NKOFNEKGPDK => BGCIPCIDJAI.EPlayerSkillSourceType_Unknown;

	public virtual bool OJMMPGDCKAF => false;

	public CEKLEBBHLIG FNBGPFAODLI
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CEKLEBBHLIG FICKKPJIMND
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool LANEKOGNLEP => false;

	public ResourceID OCENDMAKPBG
	{
		get
		{
			return default(ResourceID);
		}
		protected set
		{
		}
	}

	public uint NJILMJMHFHM => 0u;

	public uint ECPOBIMFKLE => 0u;

	protected ResourceManager.LoadPriority BABEDBBBKID => ResourceManager.LoadPriority.Low;

	private bool ADKFOOALBOH(CollectionSkillData BOBIDPBLHPL)
	{
		return false;
	}

	private bool CMLGEBFPMOE(CollectionSkillData BOBIDPBLHPL)
	{
		return false;
	}

	private bool FOOKKNPFHKF()
	{
		return false;
	}

	protected void IIACPGNOLOP()
	{
	}

	private bool FHFGODKLHDO()
	{
		return false;
	}

	private uint GMCJHBCOIKI()
	{
		return 0u;
	}

	public void GPCNMEPFCAO(uint OMFKMIPGAGE)
	{
	}

	private void NKMGLNKGLNN()
	{
	}

	public void EACJCGBMIDG(bool IMNAOAMNKCO, int GBIOBBIKMML = -1, int GCLBFFLOFIN = -1)
	{
	}

	private static void BMNLHLDMHLP(ICollection<ResourceID> CFJCHCNHHLA, IDictionary<ResourceID, int> KMFKDPMAMAA, int IKODHABPIGI)
	{
	}

	protected static void DNGINKJFOOH(ref ICollection<ResourceID> CFJCHCNHHLA, ref IDictionary<ResourceID, int> KMFKDPMAMAA, ResourceID OAFJFODNNEB, int CKGGOPCNMNC)
	{
	}

	protected static void CJKEMICHNCH(ref IDictionary<ResourceID, int> KMFKDPMAMAA, ResourceID OAFJFODNNEB, int CKGGOPCNMNC)
	{
	}

	public ResourceID BIKPFAMDELL(int PONCHHBJLDA)
	{
		return default(ResourceID);
	}

	public virtual void LMNGOJOJFNM(Player PGEGMKJKOKI, AvatarSkillData JCONDDPFBKK)
	{
	}

	protected virtual void IGMCMBHBGEM()
	{
	}

	public virtual void IPBPLNPADJG(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE)
	{
	}

	public virtual void IPBPLNPADJG(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref IDictionary<ResourceID, int> KMFKDPMAMAA)
	{
	}

	public virtual void IMPCADBKDCP(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE)
	{
	}

	public virtual void IMPCADBKDCP(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref IDictionary<ResourceID, int> KMFKDPMAMAA)
	{
	}

	public void IEILELDMHKO(bool IEGBCGANIFG)
	{
	}

	public virtual void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void HENHIDMMCJA()
	{
	}

	public virtual void FCOGKHGGAGN(bool EKLBHFBEEJA = false)
	{
	}

	public virtual void NPIPDAEOBAC()
	{
	}

	public virtual void OPANOPLGDAD()
	{
	}

	public AvatarSkillData DBMCAEMNGMC()
	{
		return null;
	}

	public virtual void FLODEOGPBPJ()
	{
	}

	public virtual void ELKGEOPFCEK()
	{
	}

	public virtual void GMPNNCNJGOF()
	{
	}

	public virtual void MIDFBOELMHI()
	{
	}

	public virtual void HEJFKBLKNMM()
	{
	}

	public virtual void MGGAJJHFMIN(bool LONOBDDEMCI)
	{
	}

	public virtual void KOFFLAHPKBL(bool GPFPIAMCEMI)
	{
	}

	public void PCCJCCKLPNK(CEKLEBBHLIG OGIBAPOBIFK)
	{
	}

	public CEKLEBBHLIG ICKMFEMAJCP()
	{
		return null;
	}

	public string GDBAJGMIEDK()
	{
		return null;
	}

	protected bool AAGDMPCDFFK()
	{
		return false;
	}

	public virtual void JGKEGOFHNHK()
	{
	}

	protected void LHIIJNBGLLF(ResourceID NKDAPBMCNEG, ResourceID DGDJNDPLHDB, Transform FKODMCNOBDM = null)
	{
	}

	protected void IJGLLKLPKHC()
	{
	}

	private void NMPKHKBDKNC(uint MDPGBPLMAFO)
	{
	}

	protected void HGHCICIBHMC(uint MDPGBPLMAFO, ESkillVoicePlayStage PJGIBDAGNGM)
	{
	}
}
