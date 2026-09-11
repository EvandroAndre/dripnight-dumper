using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW.GamePlay;

internal class AKCCDPEKHLG : SingletonModule<AKCCDPEKHLG>
{
	private enum FDEEJOOKEBD
	{
		Range = 1,
		BoostDamage,
		Silencer,
		OnceAmmo,
		AmmoClipSize,
		ReloadSpeed,
		FireInterval,
		ScatterSpeed,
		ScatterSpeedCrouchCreep,
		ScatterRecoverSpeed,
		PlayerSpeedFactorWhileFiring
	}

	public enum EPCMKHJBMNM
	{
		DmgRedfactor,
		BiteResist,
		DmgRedfactorExplode,
		DurabilityMax,
		ExtraCapacity,
		CoverArea,
		AmmoClipSize,
		ReloadSpeed,
		ScatterSpeed,
		PlayerSpeedFacterWhileFiring,
		ScatterRecoverSpeed,
		FireInterval,
		Silencer,
		DamageRatioLimb,
		DurabilityLossReduction,
		Range
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CAOKNOOGCDE> _003C_003E9__251_0;

		internal int ODAFJNFHOMJ(CAOKNOOGCDE MDFHMBHHGGF, CAOKNOOGCDE OGECPGHMIHA)
		{
			return 0;
		}
	}

	private Dictionary<uint, HENEHAGJCLI> CEAMKHPENJI;

	private Dictionary<uint, HENEHAGJCLI> BOEPEOAONPP;

	private Dictionary<uint, AGACNOCEEFP> DPJFCNFIIPG;

	private Dictionary<uint, AGACNOCEEFP> OELCBCFAKCI;

	private Dictionary<uint, FNKICBAFMLD> OLLFNBBFHBM;

	private Dictionary<uint, BCPNECMKNFO> MFDKFIKOKLK;

	private Dictionary<uint, WeaponSwitchBySightData> DNIEGNPABCI;

	private Dictionary<uint, JMOJNHKDPDB> BFBGDCIHOFO;

	private Dictionary<uint, LIAFPDJNAPH> AEIFBOBPOLP;

	private Dictionary<uint, LIAFPDJNAPH> GEJCADBNNHP;

	private Dictionary<uint, BLAMIMLKPKG> OEFNMEAPCJM;

	private Dictionary<uint, ANPDKBBGMEL> DKMJMOODHIK;

	private Dictionary<uint, Dictionary<int, BLAMIMLKPKG>> EJKEBALCFDP;

	private Dictionary<uint, string> PMPMHDGIPKD;

	private Dictionary<uint, GPOMIKBBFNG> COAJEMNKHOL;

	private Dictionary<uint, ACCGPLLICKE> MNJMNDPIHHO;

	private Dictionary<uint, HIFHCDJIHHD> HKBLMDAMBHB;

	private Dictionary<uint, IFGPNNNJIIK> IEFALAJLHOG;

	private Dictionary<uint, DLIJJDDLLKM> BHICOEEGAPL;

	private Dictionary<uint, AOOJDJHLHJL> PLDNAAOCAFC;

	private Dictionary<uint, LFEEICKEBGH> PEMDEOPJENL;

	private Dictionary<uint, LFEEICKEBGH> JJNGCFNJFMI;

	private Dictionary<uint, EJNFNOJNCPE> FOPLDIBAOJP;

	private Dictionary<uint, FMGKFMHDOMH> ICALLMLIGCE;

	private Dictionary<uint, List<CEIEOHBKCNM>> BJGOHAALKGI;

	private Dictionary<uint, KIDBEABFENA> AOEIBBFBNHM;

	private Dictionary<uint, DFBPGIINGFN> LCMFHOKBHAI;

	private Dictionary<uint, CAOKNOOGCDE> MPFHOGDPOCE;

	private Dictionary<uint, IIIAMPMFMNA> AAAHBIBCOHE;

	private Dictionary<uint, GMECHKEDOJP> LEPIPIGHDLO;

	private Dictionary<uint, CJHNFGDBOGD> MEIHDKKJJNN;

	private Dictionary<uint, ANJDOHLOHMH> APGAIJMEMLD;

	private Dictionary<uint, AJMGIJJMNAH> JPDDDOLACFM;

	private Dictionary<uint, LFAAGMJOKHG> NNLIGCGNEHG;

	private Dictionary<uint, LFAAGMJOKHG> CBKJNIOFEMJ;

	private Dictionary<uint, LFAAGMJOKHG> HGHPCBPDHEO;

	private Dictionary<uint, LFAAGMJOKHG> EFIMPEHBLOD;

	private Dictionary<uint, LFAAGMJOKHG> GHBBOJDJIFO;

	private Dictionary<uint, JLMLMPFKGNC> KFAFABFBAIC;

	private Dictionary<uint, FCNBEONDHIF> HMMALKLDEOC;

	private Dictionary<uint, KAABOJLLPHK> JGNGBKHOABK;

	private Dictionary<uint, WeaponExpansionAbilityConfigData> MHMKPCJBMBN;

	private Dictionary<uint, CAALOOLMHJF> JMNCDLJFMDN;

	private Dictionary<uint, FPCNNIEBHIB> FJMCHEFKOEG;

	private Dictionary<uint, InGameBonusDesc> BADJKGEAIJH;

	private Dictionary<uint, BMMOOPHPPDB> KAFMNJHCADK;

	private Dictionary<uint, BMMOOPHPPDB> GMLEKPHEDMK;

	private Dictionary<uint, OAICFPKEJNE> BCBEAHHDIGP;

	private Dictionary<uint, OAICFPKEJNE> DLOOCEHJLKO;

	private Dictionary<uint, EJOKDFLEONG> NGKINILOCDF;

	private Dictionary<uint, EJOKDFLEONG> FNGCFKOFIFC;

	private Dictionary<uint, BLDNPMGHCAB> BHAKFEOKMEM;

	private Dictionary<uint, FMNEJIBCMID> ADKGAIPFOBH;

	private Dictionary<uint, GEFOFFLCOLD> ENNLODGJBAO;

	private Dictionary<uint, FAAMKFENIDC> GFOLJPFJKMK;

	private Dictionary<uint, BMEBLEJJGKD> JILMHKBJKJO;

	private CSVAsyncDataMap<uint, KAHEDKBCGMI> OCJFIPDGEBK;

	private Dictionary<uint, FMDLJGLHAAN> DEKHIKFAKJE;

	private Dictionary<uint, FloaterCannonTable> AJKBJMJBEHC;

	private Dictionary<uint, IFPHENLEIDF> OJDGPFIGNJB;

	private Dictionary<uint, LEGHFJPAFIO> BALPIECIHCB;

	private Dictionary<uint, EPKKDCLOINP> MCGDOACNOGE;

	private Dictionary<uint, JJLCALJHHDF> JOCFEOFOLHD;

	private Dictionary<uint, LDNECDGGOJF> DANOMGOHJIP;

	private CSVAsyncDataMap<uint, SkillPowerUpData> KNGDJPIFDPP;

	private Dictionary<uint, uint> ACPFALLCJDC;

	private CSVAsyncDataMap<uint, MBGCNIPDLIE> OJJMHCOINOO;

	private Dictionary<uint, IOEECCGHJFA> JNJACOIGDMN;

	private Dictionary<uint, FoldWingConfigData> BPIKPBKAECL;

	private Dictionary<uint, HashSet<uint>> EKFGIAJHDLD;

	private Dictionary<uint, List<GEBFHCDMEDA>> GIJDMEDBFEO;

	private Dictionary<uint, GKLDCJLLGHP> HOHLMANFMEK;

	private Dictionary<uint, AHNCIADMDNH> PJJPMJMKFLJ;

	private Dictionary<uint, JPNIIJKAANJ> LCDBAPGPNDJ;

	private Dictionary<uint, DEJNKCJELOP> IMPAOLKOFAI;

	private Dictionary<uint, GrenadeTypeSettingData> CNHBNOIBLHB;

	private Dictionary<uint, IIFKDGHFMDB> LNKPJJMGNHF;

	private List<LFAAGMJOKHG> LMBEKLGMBFE;

	private List<LFAAGMJOKHG> KIEGDNCOEKF;

	private List<LFAAGMJOKHG> DFIBADDBJOE;

	private Dictionary<uint, IGOKECDKMIO> FOLHADOEJMP;

	private Dictionary<uint, IGOKECDKMIO> FPOOFMEFEKP;

	private Dictionary<uint, FPPCollectionWeapon> AOFMJIKKEJF;

	private Dictionary<uint, FPPCollectionWeapon> OODGPOHHMPJ;

	private Dictionary<uint, ACCGPLLICKE> KHIADGAKMHA;

	private Dictionary<uint, List<WeaponHistoryData>> DDINJPKPKFC;

	private Dictionary<uint, Dictionary<uint, CrossoverTriggerSetting>> PLAMBLFHCCN;

	private List<ResourceID> HDNKGAKIIOE;

	private CSVAsyncDataMap<uint, WeaponVehicleIKFixData> EGFMCLPBAIA;

	private CSVAsyncDataMap<uint, AnimationEventSoundData> LNDJPCKCFFB;

	private CSVAsyncDataMap<uint, BooyahBountyInfo> MOFHHFJCIFB;

	private CSVAsyncDataMap<uint, TechDeviceTable> KHOJIJDCIOF;

	private CSVAsyncDataMap<uint, InfiniteAirdropConfig> PBDLEHHONJE;

	private CSVAsyncDataMap<uint, WeaponAimAssistAutoAbsorbData> BMEBFPCGHEC;

	private CSVAsyncDataMap<uint, WeaponMountGrenadeData> ELPLBAJJGBF;

	private CSVAsyncDataMap<uint, WeaponMultiLineData> OKCECCOOHBP;

	private CSVAsyncDataMap<uint, BomberMakerData> PBGIJCKKPNB;

	private Dictionary<uint, TreasureTable> NNOKHHFCNGF;

	public string[] GADNHEIKFNL;

	public string[] JOAGIOLFOED;

	public string[] AMGIOBMMNCG;

	public string[] HGMKPEBIDAD;

	public string[] HEFIOCIDMDO;

	public string[] INDHLBLHJKL;

	public string[] GCNABAJPAOE;

	public string[] IPGCJJPKPBC;

	public string[] EDBDJJNBFDG;

	public Dictionary<uint, uint> NODOOKEJLFI;

	private bool FLCAKPJHKNM;

	private bool KHCDLMLDMPF;

	private CSVAsyncDataMap<uint, HENEHAGJCLI> KDMIOHBAFLC;

	private CSVAsyncDataMap<uint, AGACNOCEEFP> CMCFMPLGMFC;

	private CSVAsyncDataMap<uint, LFEEICKEBGH> LMMKEOBHJBM;

	private CSVAsyncDataMap<uint, EJNFNOJNCPE> MBEMPKBLFFF;

	private CSVAsyncDataMap<uint, DFBPGIINGFN> IDOKDGAHMAH;

	private CSVAsyncDataMap<uint, KIDBEABFENA> PCPNPLMNACG;

	private CSVAsyncDataMap<uint, HippoCrisisKeyConnectData> LMMJIKABOJJ;

	private CSVAsyncDataMap<uint, HippoCrisisItemData> DLPIGBLGCLD;

	private CSVAsyncDataMap<uint, HippoCrisisWeaponData> HOIPJLFNEMM;

	private CSVAsyncDataMap<uint, HippoCrisisConsumableData> BDOJKBEFDJJ;

	private CSVAsyncDataMap<uint, HippoCrisisAttachmentData> MHLLCFKNLHA;

	private CSVAsyncDataMap<uint, HippoCrisisAttachmentTable_EquipmentData> FIDGMDNKFLB;

	private CSVAsyncDataMap<uint, HippoCrisisEquipment> GIPOCPHFNCP;

	protected override void OnCleanup()
	{
	}

	public void KPKKFPJBIHC(object FJEPEDPFODO)
	{
	}

	public void LJBOBKOMIOD()
	{
	}

	protected override void OnInit()
	{
	}

	private void EHNHOMNACEN()
	{
	}

	public void FDBNNPCEFDK()
	{
	}

	public void JIMOHAJIBHI()
	{
	}

	public void FHIPJPGEBJK()
	{
	}

	private void LNALKMGFGGC(ResourceID BKCGGKCMEMN, Dictionary<uint, LFAAGMJOKHG> EGIAIANPMED)
	{
	}

	private void MEDGCGGMILC(List<LFAAGMJOKHG> KIHPKONJHDM, ref Dictionary<uint, LFAAGMJOKHG> LDCHOKJOGBH)
	{
	}

	public void MJAKDPHMNFL(AGACNOCEEFP JCONDDPFBKK)
	{
	}

	public void HNAEGGECLKC()
	{
	}

	public void NBCFHFONDEF(IGOKECDKMIO JCONDDPFBKK)
	{
	}

	public void LBNPNLGNPLG()
	{
	}

	public void HLPPOJCHHBF(ACCGPLLICKE JCONDDPFBKK)
	{
	}

	public void IIMFIOHKBDM()
	{
	}

	public void EFNBDECMJAH(FPPCollectionWeapon JCONDDPFBKK)
	{
	}

	public void KMKDLBGDCEE()
	{
	}

	public void OGFJIIAKABP(LFAAGMJOKHG JCONDDPFBKK)
	{
	}

	public void NPLJCNJDIPE(LFAAGMJOKHG JCONDDPFBKK)
	{
	}

	public void EILPEDGHHPF(BMMOOPHPPDB JCONDDPFBKK)
	{
	}

	public void FKDILPNMBJB(OAICFPKEJNE JCONDDPFBKK)
	{
	}

	public void AHELKFNHMDI(EJOKDFLEONG JCONDDPFBKK)
	{
	}

	public void EHAAGKOBOLE()
	{
	}

	public void ODLEHAMBJOA()
	{
	}

	public void FFNMMGDKGJD()
	{
	}

	public HENEHAGJCLI KDPOOJEHBJK(uint KMGCELIAKDO)
	{
		return null;
	}

	public KIDBEABFENA KHKNHJGNNDJ(uint JKNLMKFADBG)
	{
		return null;
	}

	public List<HENEHAGJCLI> CMBEJLELGBI(PIJKGPDBNJC CCNBNLAPJFM)
	{
		return null;
	}

	public HENEHAGJCLI CEJEBJLDNOP(uint KMGCELIAKDO)
	{
		return null;
	}

	public KAABOJLLPHK KLDPALMDLOJ(uint KMGCELIAKDO)
	{
		return null;
	}

	public LIAFPDJNAPH NMHDIHGMMIK(uint KMGCELIAKDO)
	{
		return null;
	}

	public LIAFPDJNAPH CAADBFMCIAE(uint BCGFIJHEDBO)
	{
		return null;
	}

	public JMOJNHKDPDB HOJJOMAPIMB(uint KMGCELIAKDO)
	{
		return null;
	}

	public WeaponAimAssistAutoAbsorbData KGCABJNMGMM(uint KMGCELIAKDO)
	{
		return null;
	}

	public WeaponMountGrenadeData DOLFPMGJKFG(uint KMGCELIAKDO)
	{
		return null;
	}

	public WeaponMultiLineData EAMJIKODOEC(uint KMGCELIAKDO)
	{
		return null;
	}

	public BomberMakerData IEEPCADKMDP(uint KMGCELIAKDO)
	{
		return null;
	}

	public BCPNECMKNFO AEGAKAHOKLL(uint KMGCELIAKDO)
	{
		return null;
	}

	public WeaponSwitchBySightData CCEGIHNGGDD(uint KMGCELIAKDO)
	{
		return null;
	}

	public ANPDKBBGMEL MLABPCCBBLI(uint KMGCELIAKDO)
	{
		return null;
	}

	public List<ANPDKBBGMEL> INDLLGFNLKJ(uint EKNHBDJHGDC)
	{
		return null;
	}

	public uint BDIGPFJCCAC(uint LPHNICDPDBN, uint GCPMGHNMLLP)
	{
		return 0u;
	}

	public BLAMIMLKPKG IDKGPFGBBIL(uint EEJMLMLKCFH)
	{
		return null;
	}

	public BLAMIMLKPKG ECLLHGBCAAK(uint IHDILLEBHEE, int NIBBKONKPHP)
	{
		return null;
	}

	public bool EOGLOPLLJIA(uint FHCABCCIOGP)
	{
		return false;
	}

	public bool LGGDKKBDJPH(uint FHCABCCIOGP)
	{
		return false;
	}

	public bool OBIGADBPCCK(uint EEJMLMLKCFH)
	{
		return false;
	}

	public string FOGHLPMKHLI(uint LIKPJDHGPFG)
	{
		return null;
	}

	public AGACNOCEEFP HDPDEMCPCCD(uint KMGCELIAKDO)
	{
		return null;
	}

	public IGOKECDKMIO BKKCEHCPOFA(uint KMGCELIAKDO)
	{
		return null;
	}

	public Dictionary<uint, IGOKECDKMIO> IMNNNHFMPIF()
	{
		return null;
	}

	public FPPCollectionWeapon GBNBJOKKOPK(uint KMGCELIAKDO)
	{
		return null;
	}

	public List<AGACNOCEEFP> OFOCJELPMBN(List<AGACNOCEEFP> OAPMJKAMJOF, uint KMGCELIAKDO)
	{
		return null;
	}

	public FNKICBAFMLD IGMHMAOBABH(uint KMGCELIAKDO)
	{
		return null;
	}

	public GPOMIKBBFNG IMCNBOPLIEN(uint KMGCELIAKDO)
	{
		return null;
	}

	public ACCGPLLICKE ACNBAAEGMCB(uint KMGCELIAKDO)
	{
		return null;
	}

	public HIFHCDJIHHD ICDAOLDDNJF(uint KMGCELIAKDO)
	{
		return null;
	}

	public IOEECCGHJFA JPHPHJKIAEF(IOEECCGHJFA.OCJDMPBFJBE BJADOOOADEI)
	{
		return null;
	}

	public List<uint> BEAHIKBIKBO(uint JPOBFBNAMHM)
	{
		return null;
	}

	public List<GEBFHCDMEDA> MOINNJNMIIL(uint OPPPILHBLHO, uint LPABIMBDIJI)
	{
		return null;
	}

	public void MDCDEICJFBL(List<TreasureTable> MBFOAIFNOJF)
	{
	}

	public void ACKOAEDLDGF(List<InGameBonusDesc> NJLJHMKELOE)
	{
	}

	private void HGDIEEFNFPO(uint HPLIEDJLMOJ, uint ODHDICEEFDM)
	{
	}

	private void OLCJJBJJLCH()
	{
	}

	public WeaponVehicleIKFixData GGJDAPDCBGP(uint MCKNOOPJBOB)
	{
		return null;
	}

	public AnimationEventSoundData HAJHIAJBDBO(uint LIKPJDHGPFG)
	{
		return null;
	}

	public IFGPNNNJIIK EIDIOLCCEBO(uint KMGCELIAKDO)
	{
		return null;
	}

	public DLIJJDDLLKM LNHNMPKBFCM(uint LIKPJDHGPFG)
	{
		return null;
	}

	public AOOJDJHLHJL HFMJEBPJAJP(uint LPHNICDPDBN)
	{
		return null;
	}

	public BMMOOPHPPDB FIKFMDMFNKB(uint KMGCELIAKDO)
	{
		return null;
	}

	public OAICFPKEJNE PGCLMLGFFPG(uint KMGCELIAKDO)
	{
		return null;
	}

	public EJOKDFLEONG ALJFEMEFBPJ(uint KMGCELIAKDO)
	{
		return null;
	}

	public InfiniteAirdropConfig HPFELFMEPLP(uint KMGCELIAKDO)
	{
		return null;
	}

	public CJHNFGDBOGD PLCIOPCFJAI(uint KMGCELIAKDO)
	{
		return null;
	}

	public GMECHKEDOJP FOMIIGIPFIC(uint KMGCELIAKDO)
	{
		return null;
	}

	public TechDeviceTable JFAEIGIOMED(uint KMGCELIAKDO)
	{
		return null;
	}

	public TreasureTable OMMNOKDIDDH(uint LIKPJDHGPFG)
	{
		return null;
	}

	public bool AKLEGCMONLB(uint KMGCELIAKDO)
	{
		return false;
	}

	public AJMGIJJMNAH EFKGIIDLELN(uint KMGCELIAKDO)
	{
		return null;
	}

	public object MBGLGKDKMOD(uint KMGCELIAKDO)
	{
		return null;
	}

	public LFEEICKEBGH KPOHONFJGCJ(uint KMGCELIAKDO)
	{
		return null;
	}

	public void CKAGACCBEKH(LFEEICKEBGH JCONDDPFBKK)
	{
	}

	public void MEFLOJFLPFN()
	{
	}

	public EJNFNOJNCPE CIKLHFFODKF(uint KMGCELIAKDO)
	{
		return null;
	}

	private void MEICOCKEGKB()
	{
	}

	public CPLMBOBGNFE PBOAJNMJFKC(uint KMGCELIAKDO, uint NJMMDDMIION, uint KJAEDIGHOMN)
	{
		return null;
	}

	public KIDBEABFENA EAEEHDGEIOK(uint KMGCELIAKDO)
	{
		return null;
	}

	public DFBPGIINGFN KNGDPGFCGKC(uint KMGCELIAKDO)
	{
		return null;
	}

	public IIIAMPMFMNA KDFODBNMJLE(uint KMGCELIAKDO)
	{
		return null;
	}

	public ANJDOHLOHMH ANMEEMFPBDN(uint KMGCELIAKDO)
	{
		return null;
	}

	public LFAAGMJOKHG KEEKAIJKHKD(uint PEIOGLEDJHE, bool JNLIFCOMMAL = false)
	{
		return null;
	}

	public LFAAGMJOKHG MHGMDOFJDJI(uint PEIOGLEDJHE)
	{
		return null;
	}

	public FCNBEONDHIF BEMOECPFONG(uint OMFKMIPGAGE)
	{
		return null;
	}

	public JLMLMPFKGNC JLNLLHJCKOH(uint PEIOGLEDJHE)
	{
		return null;
	}

	public CAALOOLMHJF HACCNFBGLFC(uint PNIPGAHMBMN)
	{
		return null;
	}

	public BLDNPMGHCAB LKGHIELEKLO(uint KMGCELIAKDO)
	{
		return null;
	}

	public FMNEJIBCMID MOFNIKMLCKO(uint KMGCELIAKDO)
	{
		return null;
	}

	public FAAMKFENIDC LPLKNCCCDID(uint KMGCELIAKDO)
	{
		return null;
	}

	public GEFOFFLCOLD DOMAJILHHOD(uint LIKPJDHGPFG)
	{
		return null;
	}

	public LEGHFJPAFIO MNCCEDDKCMK(uint LIKPJDHGPFG)
	{
		return null;
	}

	public EPKKDCLOINP GADGMPNGKMF(uint LIKPJDHGPFG)
	{
		return null;
	}

	public BMEBLEJJGKD EBLECODCAMI(uint BEFCBEBOMJN)
	{
		return null;
	}

	public KAHEDKBCGMI AFHJFOCFKAE(uint GNNJDIFNNJO)
	{
		return null;
	}

	public FMDLJGLHAAN ECAFHHJDAOE(uint FODJPPOGPIH)
	{
		return null;
	}

	public FloaterCannonTable LKKFPPPJFDM(uint HIDANNMJCDP)
	{
		return null;
	}

	public FPCNNIEBHIB LDKOLKOOJHA(uint GEHJJDLAGJJ)
	{
		return null;
	}

	public JJLCALJHHDF PEFGDPMMCOP(uint LIKPJDHGPFG)
	{
		return null;
	}

	public LDNECDGGOJF CIEGNGFPBKG(uint LIKPJDHGPFG)
	{
		return null;
	}

	public LDNECDGGOJF LHNPKHAHNDK(uint BCGFIJHEDBO)
	{
		return null;
	}

	public SkillPowerUpData JIMNCJAADHG(uint LIKPJDHGPFG)
	{
		return null;
	}

	public SkillPowerUpData JCFDMHJNNBB(uint OIIEGGNFDBH)
	{
		return null;
	}

	public SkillPowerUpData HAMJNIOJOFJ(uint OIIEGGNFDBH)
	{
		return null;
	}

	public bool DOKNJGABNDH(uint OIIEGGNFDBH)
	{
		return false;
	}

	public uint CEJFLMALJPD(uint BCGFIJHEDBO)
	{
		return 0u;
	}

	private void ODEBCCGCADK()
	{
	}

	public bool NNGMBLJFENM(uint OIIEGGNFDBH)
	{
		return false;
	}

	public bool CKCGEHBKMJE(uint MLADEPCEDPM, uint NLCMNLLFJMI)
	{
		return false;
	}

	public MBGCNIPDLIE OMJIIBIBILA(uint LIKPJDHGPFG)
	{
		return null;
	}

	public IFPHENLEIDF HDFIPHACECH(uint GEHJJDLAGJJ)
	{
		return null;
	}

	public GKLDCJLLGHP OPKOOFJMDLD(uint KMGCELIAKDO)
	{
		return null;
	}

	public List<HENEHAGJCLI> JIBEAONOGNH()
	{
		return null;
	}

	public List<AGACNOCEEFP> MAMPDBLIADK(FDAEPHMIEPC.DBENAPILEBC CCNBNLAPJFM)
	{
		return null;
	}

	public FoldWingConfigData NOOFDEIHEGF(uint GEHJJDLAGJJ)
	{
		return null;
	}

	public UIHudGrenadeBtnController.EGrenadeType BIMBOALGJMH(uint LIKPJDHGPFG)
	{
		return UIHudGrenadeBtnController.EGrenadeType.None;
	}

	public void GMNNLFENOMP()
	{
	}

	public GrenadeTypeSettingData DEAPGELGJOA(uint GEHJJDLAGJJ)
	{
		return null;
	}

	public Dictionary<uint, GrenadeTypeSettingData> FIMKBOFAKDL()
	{
		return null;
	}

	public AHNCIADMDNH FNMPIFNJGDH(uint KMGCELIAKDO)
	{
		return null;
	}

	public JPNIIJKAANJ ODLKGELIECF(uint ABHFDDCCINN)
	{
		return null;
	}

	public DEJNKCJELOP HNGOBLCIBOP(uint BCGFIJHEDBO)
	{
		return null;
	}

	public IIFKDGHFMDB EKIFJGCIGBK(uint BCLLKEEAMKM)
	{
		return null;
	}

	public bool CMAPBAMNBML(uint HOCFMENHNBM, uint IIMKDBMEBFG)
	{
		return false;
	}

	public List<uint> PHEBLNPNLOO(uint ABHFDDCCINN)
	{
		return null;
	}

	public Dictionary<uint, bool> HJBCOFLKMAC(uint ABHFDDCCINN, uint HOCFMENHNBM, uint IIMKDBMEBFG)
	{
		return null;
	}

	public void MAGHEJKPMME(float NFJEKAAOADN, float GPEEBKFGBPG, uint IBNLMKGIJNI, ref Dictionary<uint, bool> AEDLPHCDDOC)
	{
	}

	public void KDMGLCDFNNL(EJNFNOJNCPE BCJDJDCBPHM, uint IBNLMKGIJNI, ref Dictionary<uint, bool> AEDLPHCDDOC)
	{
	}

	public bool HJLCJBGLIJK(uint ABHFDDCCINN)
	{
		return false;
	}

	public string NLKMCKEFENO(uint IBNLMKGIJNI)
	{
		return null;
	}

	public void FMIBMGCGNNH()
	{
	}

	public CAOKNOOGCDE LMJEEFLDOAI(uint IPGKEKKDPIE)
	{
		return null;
	}

	public Dictionary<uint, CAOKNOOGCDE> MGBLINBCBJC()
	{
		return null;
	}

	public bool NJIBBBGMAGD(uint AAAGIBMCGGP, out WeaponExpansionAbilityConfigData FECBOCBHKLD)
	{
		FECBOCBHKLD = null;
		return false;
	}

	private void FHGOGDGLMJL()
	{
	}

	public List<WeaponHistoryData> GHIKJOFLHIA(uint LPHNICDPDBN)
	{
		return null;
	}

	private void OIPKAHMCMJE()
	{
	}

	public bool NDNKJCMPAAO(uint GLHCNMKLHMH)
	{
		return false;
	}

	public string ONJDDEBNKIH(uint PCNEGIDHEAA)
	{
		return null;
	}

	public void NCHBOHAGKMM()
	{
	}

	public void IINLGBHMEIK()
	{
	}

	private void FNDLGEFLCGN()
	{
	}

	private void FEIMJLFPEJB()
	{
	}

	private void CBDPOMGPKJA()
	{
	}

	private void CIAECPLHEMM()
	{
	}

	private void MPFLLKICGLF()
	{
	}

	private void LOCMAEFKEFB()
	{
	}

	public string KCJMDHPOLPE(HENEHAGJCLI BPDGEMBOGAA)
	{
		return null;
	}
}
