using System;
using System.Collections;
using System.Collections.Generic;
using COW.HUD;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW.GamePlay;

internal class FNIFJFFGDDO : DENKLLOGEHJ
{
	public enum IHBNOBOEJAP
	{
		BEGIN_PHASE = 0,
		OPEN_CAMERA = 1,
		END_PHASE = 999
	}

	public enum MADFAIIJNKM
	{
		NewBie_New = 2,
		NewBie_Execute_Spawn = 3,
		NewBie_Execute_Guide = 4,
		NewBie_Protect_Turn = 98,
		NewBie_Protect_Aim = 99
	}

	public enum CDEDNOPGLJD
	{
		PHASE_ID_0_MOVE = 100,
		PHASE_ID_1_SWITCH = 101,
		PHASE_ID_2_RELOAD = 102,
		PHASE_ID_3_FIRSTENEMY = 103,
		PHASE_ID_4_STORY_TEAMMATE = 104,
		PHASE_ID_5_AIM_FIRE = 105,
		PHASE_ID_6_SCOPE_KILL = 106,
		PHASE_ID_Extra_1_TeammateHit = 107,
		PHASE_ID_Extra_2_SecondEnemyShow = 108,
		PHASE_ID_7_USEICEWALL = 109,
		PHASE_ID_8_RESCUE = 110,
		PHASE_ID_9_ATTACK = 111,
		PHASE_ID_10_PICKMEDICATE = 112,
		PHASE_ID_11_HP_HEAL = 113,
		PHASE_END = 114,
		PHASE_ID_12_RUN = 199
	}

	public enum HPNMJPLJDCB
	{
		PHASE_ID_1_MOVE = 200,
		PHASE_ID_2_SniperRifle,
		PHASE_ID_3_SNIPER_TYPE,
		PHASE_ID_4_ENEMY1,
		PHASE_ID_5_ENEMY_USEICEWALL,
		PHASE_ID_6_MOVE_GREANDE,
		PHASE_ID_EXTRA_1_USEICEWALL,
		PHASE_ID_7_PICKGREANDE,
		PHASE_ID_8_EQUIPGRENADE,
		PHASE_ID_9_USEGRENADE,
		PHASE_ID_EXTRA_2_HELPTEAMMATE,
		PHASE_ID_EXTRA_3_NEWENEMY,
		PHASE_ID_EXTRA_4_USESKILL,
		PHASE_END
	}

	public enum HDLDINCNJOP
	{
		PHASE_END = 300
	}

	public enum GBAFONFOGDL
	{
		PLAYER_BORN,
		TARGET_2001,
		LOOT_3003,
		TARGET_14001,
		TARGET_FPS1,
		TARGET_Grenade,
		TARGET_SkillCard,
		TARGET_ICEWALL1,
		TARGET_ICEWALL2,
		TARGET_ICEWALL3,
		TARGET_ICEWALL4,
		TARGET_MEDICATE,
		TARGET_TEAMMATEEND,
		TARGET_NEW_ICEWALL,
		TARGET_HELPTEAMMATE
	}

	public enum BAIANIHCHDO
	{
		NONE = 0,
		BOT_EVALUTE_NEWPLAYER_ENEMY_1 = 1,
		BOT_EVALUTE_NEWPLAYER_ENEMY_2 = 2,
		BOT_EVALUTE_NEWPLAYER_ENEMY_3 = 3,
		BOT_EVALUTE_NEWPLAYER_ENEMY_4 = 4,
		BOT_EVALUTE_FPS_ENEMY_1 = 5,
		BOT_EVALUTE_FPS_ENEMY_2 = 6,
		BOT_EVALUTE_FPS_ENEMY_3 = 7,
		BOT_EVALUTE_FPS_ENEMY_4 = 8,
		BOT_4_ENEMY_1 = 100,
		BOT_11_TEAMMATE_1 = 101,
		BOT_11_ENEMY1 = 102,
		BOT_11_ENEMY2 = 103,
		BOT_12_ENEMY1 = 104,
		BOT_12_ENEMY2 = 105,
		BOT_12_ENEMY3 = 106,
		BOT_12_ENEMY4 = 107,
		BOT_FPS_ENEMY_1 = 201,
		BOT_FPS_ENEMY_2 = 202,
		BOT_FPS_TEAMMATE = 203,
		BOT_FPS_ENEMY_3 = 204,
		BOT_FPS_ENEMY_4 = 205,
		BOT_FPS_ENEMY_5 = 206,
		BOT_FPS_ENEMY_01 = 207,
		BOT_FPS_ENEMY_0 = 208,
		BOT_FPS_ENEMY_6 = 209,
		BOT_FPS_TEAMMATE_KNOCKDOWN1 = 211,
		BOT_FPS_TEAMMATE_KNOCKDOWN2 = 212,
		BOT_FPS_TEAMMATE_KNOCKDOWN3 = 213,
		BOT_FPS_ENEMY_LAST1 = 214,
		BOT_FPS_ENEMY_LAST2 = 215,
		BOT_FPS_ENEMY_LAST3 = 216,
		NPC = 300
	}

	public enum AHGIFAGEFNK
	{
		WELCOME,
		EXIT,
		BOOYAH
	}

	private enum CAMEMONAMDD
	{
		None,
		HitEnemy,
		HealLocalPlayer
	}

	private enum AAGACCEALJB
	{
		None,
		HealTeammate,
		HitPlayer
	}

	private sealed class JFIDOIGPMPI
	{
		public UIForceTutorialGameScene PNAAKCDLNOF;

		public BHGGAEEHJCO OBMFMAKFDDL;

		internal void MDMLNLPPNFK()
		{
		}

		internal void IGPKOODHHNJ()
		{
		}

		internal void LOCPIEHAGKC()
		{
		}
	}

	private sealed class ANCIGFAFACH
	{
		public FNIFJFFGDDO KOKNHFGCGLN;

		public BAIANIHCHDO EJMGCKAOEIK;

		internal void IMAKKPHHBID()
		{
		}
	}

	private sealed class CBJIHMLFPBP
	{
		public FNIFJFFGDDO KOKNHFGCGLN;

		public BAIANIHCHDO EJMGCKAOEIK;

		internal void GCOFAGMJJGD()
		{
		}
	}

	private sealed class PJNJAAFEOIH
	{
		public FNIFJFFGDDO KOKNHFGCGLN;

		public PlayerForceTutorialBot OKLLCLJGHNO;

		public PlayerForceTutorialBot IBFDCAFAIKI;

		internal void OFCMANOADFI()
		{
		}
	}

	private sealed class MJMDGOOOGMA
	{
		public FNIFJFFGDDO KOKNHFGCGLN;

		public CDEDNOPGLJD CCNBNLAPJFM;

		internal void DCHHIOLBBIF()
		{
		}

		internal void HANEDPMHFEP()
		{
		}

		internal void DMCDINOFPGL()
		{
		}
	}

	private sealed class FOCGJNPOFDO
	{
		public PlayerForceTutorialBot PGEGMKJKOKI;

		internal void MDBADIDNACF()
		{
		}
	}

	private sealed class DCHMJFBJHMN
	{
		public PlayerForceTutorialBot PGEGMKJKOKI;

		public MJMDGOOOGMA EDIPCAMGBNP;

		internal void CHDPFILGDEA()
		{
		}
	}

	private sealed class PAPODBBGOFE
	{
		public HPNMJPLJDCB CCNBNLAPJFM;

		public FNIFJFFGDDO KOKNHFGCGLN;

		internal void JDJCDKBIPMJ()
		{
		}

		internal void OHHGEKFHECD()
		{
		}

		internal void HFAMKKEEKKD()
		{
		}
	}

	private sealed class GPCIDFGJOBE
	{
		public UIForceTutorialGameScene PNAAKCDLNOF;

		public PlayerForceTutorialLocal CENMMLHBJKH;

		public PAPODBBGOFE EDIPCAMGBNP;

		public Action CCFACPABNHI;

		internal void GOJBDJDKDKE()
		{
		}

		internal void MBIJBHDEEBD()
		{
		}
	}

	private sealed class IIPFJKCJNHF
	{
		public PlayerForceTutorialLocal CENMMLHBJKH;

		public UIForceTutorialGameScene PNAAKCDLNOF;

		public PAPODBBGOFE HIDGOLEIPLE;

		public Action JIEMCLPGGDH;

		internal void JAMLIIBMHAM()
		{
		}

		internal void DDBLHFBGLKO()
		{
		}
	}

	private sealed class PPCJBNIEINA
	{
		public PlayerForceTutorialBot IPAJPHCNBEB;

		public PlayerForceTutorialLocal DCAPIHJMMBL;

		public FNIFJFFGDDO KOKNHFGCGLN;

		public GLLLEDKLLDA PMMCGNJHOOA;

		internal void GIIJEBCFLNI()
		{
		}
	}

	private sealed class AFDMKHEACBA
	{
		public FNIFJFFGDDO KOKNHFGCGLN;

		public PlayerForceTutorialLocal DCAPIHJMMBL;

		internal void JHLELNKKKDG()
		{
		}
	}

	private sealed class EKCIGIDMFBI
	{
		public PlayerForceTutorialBot AJADHADJBGF;

		internal void CPKBAMHGCAF()
		{
		}
	}

	private sealed class PFOMBEMIFGC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public FNIFJFFGDDO KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public PFOMBEMIFGC(int CBPPJACCGOH)
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

	private sealed class LJECJLEPKGN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public FNIFJFFGDDO KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public LJECJLEPKGN(int CBPPJACCGOH)
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

	private const uint FADJINJMJGO = 10000u;

	private const uint EENPALIJJDN = 10001u;

	private UIModelForceTutorial LJJLNPEOFLG;

	private UIModelUser CIEMKGKLNCL;

	private LevelForceMoveZone HJGGKNPCOLN;

	private LevelTutorialTrigger[] KDDKEPCIHGD;

	private ForceTutorialSkillCameraManager[] MDKDMJJGDAA;

	private readonly Dictionary<uint, float> AECAKPKABJN;

	private readonly Dictionary<uint, float> HHGGJEMDFLE;

	private byte EFBBKHOGBJJ;

	private byte EJCLOGEFPJH;

	private byte MJEEADNBGPM;

	private Dictionary<int, uint> EFKDFAPNPIJ;

	private Dictionary<int, BHGGAEEHJCO> IOFBAGCJKHG;

	private Dictionary<int, uint> HNOJNGJPIPF;

	private Dictionary<int, LevelTutorialRoutePoint[]> CBOFBNBFFPK;

	private Dictionary<int, uint> BCNLOFAFNGF;

	private Dictionary<int, bool> DPCOOABOCBI;

	private Dictionary<uint, int> GHHHCFNIGOC;

	private Dictionary<uint, int> MKIICOFMMEH;

	private Dictionary<uint, int> KJMABNBIFPC;

	private uint KHPJGNDKLHO;

	private int GDJGHFEHMOM;

	private int DOMAIODJMKE;

	private uint OCMLMJBEODI;

	private uint INABKECJIFD;

	private uint GINLLPEFFOH;

	private uint CGMGIFJHALA;

	private uint CFBGDEEDHEB;

	private uint AHPAGKMOFPO;

	private uint GHADHBKLJMG;

	private uint ICEACPBIEMP;

	private uint JPGBBMCHOII;

	private uint GDEOMGDCIMK;

	private bool CHEBMBLLMAO;

	private BHGGAEEHJCO AMLJBGAHLKF;

	private UIForceTutorialGameScene.HudType EOEELCFHLDO;

	private float OKJJPJKJPIP;

	private bool EHJNMPKHDNL;

	private bool AILOEMPOMBO;

	private byte JOLKAHBIHKN;

	private int CALOJKNLPMH;

	private float FFOEBDAIFFI;

	private float LEBFDIPCCAO;

	private float OPDHDONPMME;

	private float AGNBGDGBBDL;

	protected IEnumerator CCPJNGEADDG;

	protected IEnumerator OAOGGCDIGEM;

	private Vector3 OBNIAJPMIMD;

	private Vector3 BKKPLHBLJHG;

	private PlayerForceTutorialLocal PDBGEOANOEP;

	private Dictionary<uint, float> KEDJAHINPDB;

	private bool HLNCGFHKIBK;

	private int NFIFJDHMJFC;

	private int JHAFLLGOEBA;

	private bool OBEGJJLLLJB;

	private bool EIGIJJDOGCH;

	private bool COPALNNLDLK;

	private bool GKLCIAMLIHC;

	private uint NPNPDKAJAGC;

	private bool ABLKLPOGLCC;

	private float KOCMEMJJPPJ;

	private Dictionary<int, LineRenderer> MGBCBMOLLMJ;

	private uint IFKJNNPLJML;

	private Vector3 GKDAKLJFEDB;

	private float FLPGOFKKADC;

	private bool HMOANFAGGFD;

	private bool COAEIFPFIFL;

	private bool DNNPNIOGMHC;

	private uint AIDHMDBMDHE;

	private PlayerForceTutorialBot OFLBGAOMHIL;

	private PlayerForceTutorialBot IGCKOOCHKKJ;

	private bool MODHBAKGAII;

	private Dictionary<BHGGAEEHJCO, UIHudEnermyPointController> OPALPKOOFDK;

	private int LFFLDIGMNAP;

	private const float ANPEBECPECO = 1f;

	private const float FLLJDCPPDIH = 2f;

	private uint KLEBIJMGICL;

	private uint DOMDMGLENGH;

	private Vector3 KNBANMDIHLC;

	private bool HJOIKKJEPPP;

	private bool BCKFKACMIJF;

	private bool LANMCONONIM;

	private bool MAAMKLHKCNC;

	private uint EDELNFGHOEL;

	private bool NHKALAPCCNE;

	private bool IKILDFDKPCP;

	private CAMEMONAMDD DEPLFDFHOEG;

	private AAGACCEALJB ELOELFBDICF;

	private byte FBDDIBPCJNJ;

	public const byte FDMKOHBOLMB = 1;

	private const byte IGLNGAMFINF = 1;

	private EAccount.NewbieChoice EHAPBHEBFON;

	private uint GPOCGJMDOFI;

	private uint EGGLCCMAIJL;

	private float MAILHMFOEAJ;

	private float PICFOHJPDLJ;

	public const int JABPCDMCLMF = 2;

	public const int IEHKEKKJJNF = 4;

	public const int IKGGLMEKHDL = 2;

	public const int HOCMPGCJIAJ = 1;

	public const int DDDLELFKIKM = 3;

	public const int AOFIIEAKEHI = 3;

	public const int BLDGBECMHOI = 4;

	public const int JIFMHANAFKC = 3;

	private int _003CMDKJELNFDGJ_003Ek__BackingField;

	private int _003CDBEEPBPIBMI_003Ek__BackingField;

	private int _003CHBNKCMJBMMM_003Ek__BackingField;

	private int _003CDIKHMLBJNCE_003Ek__BackingField;

	private float _003CHGEMJMLMHFH_003Ek__BackingField;

	private float _003CCADHPJAKPKH_003Ek__BackingField;

	private float _003CJFIMINJHBFF_003Ek__BackingField;

	public byte ICDKIODPPPJ
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint NLHDMBJFDNA => 0u;

	public byte DBBGMICAJJN => 0;

	public byte PNGDCFAFHLG
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EHAGIHHNPLK
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int KLLOAAIKHLF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int IGOGLJAANMO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int JGKGNFIPOFH
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int BHGGLLNHDBE
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float GOLMGBHAHJM
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float BNDNLBIGLFF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float PLAGCMHJBEN
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IHMLCIJAGMH()
	{
		return false;
	}

	protected override void OnUpdate()
	{
	}

	public override int GetGameType()
	{
		return 0;
	}

	public override bool CanShowGodEffect()
	{
		return false;
	}

	public override Type GetUISceneType()
	{
		return null;
	}

	public override void OnLoadingMaskClosed()
	{
	}

	public override Player CreatePlayer(Transform MLBAMPFOCGP, ulong HGNIOBLGCII, ulong GMKFNKFFPBH, BHGGAEEHJCO OBMFMAKFDDL, bool CHDFFDMBMEL = false, object LHLIKBIDIIJ = null)
	{
		return null;
	}

	protected override void GCLGIKFHIFH()
	{
	}

	protected override void OnSceneLoaded()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void GHNMGMCJFEH()
	{
	}

	private void FJLAPGIGEBK()
	{
	}

	private void ILMPGOHHAPA()
	{
	}

	private void GCFCPOPAPFA()
	{
	}

	private uint LFBJGMFNDPN(Dictionary<uint, int> ICANOFNHAJE)
	{
		return 0u;
	}

	private bool HDDKELHJLJN(Dictionary<uint, int> ICANOFNHAJE)
	{
		return false;
	}

	private bool GJFCPEOAPGN(Dictionary<uint, int> ICANOFNHAJE)
	{
		return false;
	}

	private bool KMKJDMDAIPB(uint GEHJJDLAGJJ)
	{
		return false;
	}

	private int HEIGBJLEECM(uint GEHJJDLAGJJ)
	{
		return 0;
	}

	private void ONNEBCECBLI()
	{
	}

	private void BKHFMGNDNKL()
	{
	}

	private void PIEEKGMPMGE(BHGGAEEHJCO ILIHFPPKKKC, BHGGAEEHJCO CLCIBLOKMAJ, uint MLAIAOIAGPN, uint GEHJJDLAGJJ = 0u)
	{
	}

	private bool BHLNKIEIFJL(BAIANIHCHDO OPBEMIOINMJ)
	{
		return false;
	}

	private void EMFABEIBGLI()
	{
	}

	private void FAMILHMOHAM()
	{
	}

	private void KMOEFDFDABI()
	{
	}

	private void DAHCNMEAJLB()
	{
	}

	private void EGHCCKCHJDI()
	{
	}

	private void GFIGAEFALBD(float FGADPLJBKJO)
	{
	}

	public ForceTutorialSkillCameraManager FADNIPNHGNL(BJFAEJPOLOA CCNBNLAPJFM)
	{
		return null;
	}

	public bool LOGKMHFCJMA()
	{
		return false;
	}

	public bool EBIJAEMIJIK()
	{
		return false;
	}

	public int GCDJHLJLGEI()
	{
		return 0;
	}

	public uint GFBKIFDOBCO()
	{
		return 0u;
	}

	public int GMBCNMCPAKJ()
	{
		return 0;
	}

	public bool IHOJDJCMJHI()
	{
		return false;
	}

	public void IKNGHPBFNHE(uint MDPGBPLMAFO)
	{
	}

	public void LLPIGEANLPK(BAIANIHCHDO NIBBKONKPHP, float LLOCLEPNCGA = 0f)
	{
	}

	private void KEDJLGBALOF(BHGGAEEHJCO OBMFMAKFDDL, PlayerForceTutorialBot AJADHADJBGF)
	{
	}

	private void LADFCCHOMPL(BAIANIHCHDO NIBBKONKPHP, bool CDKLFJAHKFH = false, bool BLAKBFOKGNO = true)
	{
	}

	private string KGCHKBDIDFL(BAIANIHCHDO NIBBKONKPHP)
	{
		return null;
	}

	private uint MECFGCMONOD(BAIANIHCHDO NIBBKONKPHP)
	{
		return 0u;
	}

	private COEDKLIGPPD OFBNGHHJJFO(BAIANIHCHDO NIBBKONKPHP)
	{
		return null;
	}

	private void MHEMIAMNABO()
	{
	}

	private IEnumerator ANOKMPJLJCF()
	{
		return null;
	}

	private void OKNHKFACHLO()
	{
	}

	private void PMBPDFNPDKH()
	{
	}

	public Vector3 PHDJPLNDHHH()
	{
		return default(Vector3);
	}

	public BAIANIHCHDO MLHPJJPHCCP(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return BAIANIHCHDO.NONE;
	}

	private bool MLCMDOFBKIN(BAIANIHCHDO OPBEMIOINMJ)
	{
		return false;
	}

	public void AKLHEEBPIPA(BAIANIHCHDO OPBEMIOINMJ)
	{
	}

	public void KAIJPBBJKOP(BAIANIHCHDO NIBBKONKPHP, bool IDCHCEECMBE = false)
	{
	}

	public void KAIJPBBJKOP(BAIANIHCHDO LGGPCAPDEJK, BAIANIHCHDO LMDMPIMOPEG)
	{
	}

	public void NDGHJGNFEBJ(BAIANIHCHDO LGGPCAPDEJK)
	{
	}

	public void PMCMNBDGGFP(BAIANIHCHDO NIBBKONKPHP)
	{
	}

	public void IFJMCJLPLNF(BAIANIHCHDO NIBBKONKPHP, Player DCAPIHJMMBL)
	{
	}

	public void JKIEBLHAOAJ(BAIANIHCHDO NIBBKONKPHP)
	{
	}

	public void GAPOBFNLCJJ(BAIANIHCHDO NIBBKONKPHP)
	{
	}

	public void NFBIMAHFNCM(Player PGEGMKJKOKI, Action HGFNLBNAACG)
	{
	}

	public void AJHEEFGLACI(Player PGEGMKJKOKI)
	{
	}

	public void DBOIIDHIBEE(Player PGEGMKJKOKI, bool CDKLFJAHKFH = true)
	{
	}

	public void CHNIOACCOGA(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	private void BNLIKKEGAON(Player DFNGEBLDGFF, Player BIGMFDMMCNB, int FCAOOKIBKJK, int HPPACPHIPCP)
	{
	}

	public void FFCIJNHOJIB(PlayerForceTutorialLocal DCAPIHJMMBL)
	{
	}

	private void DEIBDKOMFHI(int OPBEMIOINMJ, uint INIOANKCPDA)
	{
	}

	private void GNKBAANPEOG(PlayerForceTutorialBot PGEGMKJKOKI, int OPBEMIOINMJ)
	{
	}

	private void HOFDKCNGIIJ(PlayerForceTutorialBot PGEGMKJKOKI, uint INIOANKCPDA)
	{
	}

	private void IHMGNMHAJIB()
	{
	}

	private void OIDNJJHJJGN(uint DKLIDODJIEA, int FCAOOKIBKJK)
	{
	}

	private void LBDHCNEOGAI()
	{
	}

	private void BKNBDDJAJLH()
	{
	}

	private void KBHEPNMBNNE()
	{
	}

	private void OPABENKJPEM(PlayerForceTutorialBot LGLCGOLBLKJ, PlayerForceTutorialBot OEGCHACJCMP)
	{
	}

	private void CCEEDJEFJGN()
	{
	}

	private void FEDAMNJJNAN(PlayerForceTutorialBot OKLLCLJGHNO, PlayerForceTutorialBot IBFDCAFAIKI)
	{
	}

	private void PONMLKIAICI(PlayerForceTutorialBot OKLLCLJGHNO, PlayerForceTutorialBot IBFDCAFAIKI)
	{
	}

	private void MLLNNFFAHBJ(PlayerForceTutorialBot OKLLCLJGHNO, PlayerForceTutorialBot IBFDCAFAIKI)
	{
	}

	private void CKMPFOGKFME(PlayerForceTutorialBot OKLLCLJGHNO)
	{
	}

	private void GFNHJDCBAPM()
	{
	}

	private void OHBHCGPCAAM(PlayerForceTutorialBot AJADHADJBGF)
	{
	}

	private void MEJMNNLFAJK(PlayerForceTutorialBot AJADHADJBGF)
	{
	}

	private void HPHODKEJBAA(PlayerForceTutorialBot AJADHADJBGF, FDAEPHMIEPC KEDHIAANLGO, BAIANIHCHDO PGDBBJHAOJB, BAIANIHCHDO LHLDLEJGPAA)
	{
	}

	private void BAPOBMBNABJ(PlayerForceTutorialBot MPHGAPBMKNH, FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public void LPCFNHOJHKI(BAIANIHCHDO OPBEMIOINMJ, Vector3? MNBPEEDKIAD = null, BAIANIHCHDO HNAHDIOANDO = BAIANIHCHDO.NONE)
	{
	}

	private void BHIOMMBPMLD(Player.DDFCIJDHODF EMFKCBCOMLI)
	{
	}

	public void AEECIEJJGHB(BAIANIHCHDO OPBEMIOINMJ, float LLOCLEPNCGA = 0f)
	{
	}

	public void MONJJNINDDG(BAIANIHCHDO OPBEMIOINMJ)
	{
	}

	private void GFJNIBPDDGH(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void IBGPBFIIKMG(object[] JCONDDPFBKK)
	{
	}

	public void FIIGFDPCBIG(Vector3 IGDHIDGLOKG, uint EOJKGKIKHAA, PCFOGCOLIGC KIIHAHCNNDG = PCFOGCOLIGC.EContainerType_Normal)
	{
	}

	public void PGHFGEGNPLC(Vector3 IGDHIDGLOKG, uint HIDANNMJCDP, int PNLDKNOFPNG, uint EOJKGKIKHAA)
	{
	}

	public LevelTutorialTrigger EJCLJBFNKMO(GBAFONFOGDL NIBBKONKPHP)
	{
		return null;
	}

	public LevelTutorialRoutePoint EAJMPKEHLFH(BAIANIHCHDO OPBEMIOINMJ, uint NIBBKONKPHP)
	{
		return null;
	}

	private Dictionary<uint, int> EGGLJPCPKHG(string PIEELDNNLPA)
	{
		return null;
	}

	public void FNINFCJIAMJ(GBAFONFOGDL PEAANCMIPKK, out Vector3 HDFILHFDBKB, out Vector3 IPKKCHLDJMA)
	{
		HDFILHFDBKB = default(Vector3);
		IPKKCHLDJMA = default(Vector3);
	}

	private void NLFDGJAJBOH()
	{
	}

	private void NAJBFLLHEEM(object[] JCONDDPFBKK)
	{
	}

	private void COIPFKJNNEJ(object[] JCONDDPFBKK)
	{
	}

	private void DKEJGPLHDNL(object[] JCONDDPFBKK)
	{
	}

	private void OJOGONBFKBA(object[] JCONDDPFBKK)
	{
	}

	private void FDFFONFGFON(GEvent JCONDDPFBKK)
	{
	}

	private void LHEJNGHOFJL(object[] JCONDDPFBKK)
	{
	}

	private void CMONIDDOLMP(object[] JCONDDPFBKK)
	{
	}

	private void JDANBFLHLMH()
	{
	}

	private void NPHOGHBIPAF(object[] JCONDDPFBKK)
	{
	}

	private void LKFCMFKJLKI(object[] JCONDDPFBKK)
	{
	}

	private void EMMFKNAIIPG(object[] JCONDDPFBKK)
	{
	}

	public void AEDACODILKF()
	{
	}

	private void JJHKIFBIJCO(object[] JCONDDPFBKK)
	{
	}

	private void HABADMOBMBH(object[] JCONDDPFBKK)
	{
	}

	private void IKIMJLLBDKC(object[] JCONDDPFBKK)
	{
	}

	private void JGEMHOGHFPC(object[] JCONDDPFBKK)
	{
	}

	private void HGNINOMOGPE()
	{
	}

	public void PDKOOJDCJHP()
	{
	}

	public void FLOMEMFEOBM()
	{
	}

	public void EEMMKGHHNLM(uint NIBBKONKPHP)
	{
	}

	public void IBEDNIHDOCB()
	{
	}

	public void BGGLEOLIJKO()
	{
	}

	private void JJNBMALIOGB()
	{
	}

	public void HCODHFHKHKO()
	{
	}

	public void MHMMIGPLBGO()
	{
	}

	private void ECKCMGEKKBF()
	{
	}

	private void OIEFBOJEMGG(uint CCNBNLAPJFM)
	{
	}

	private void FBODFAPDLOP(bool NOELJPEEBOM, float FGADPLJBKJO)
	{
	}

	private bool OGACFDGBOON(PlayerForceTutorialBot OFMGKPBGFEE, Player FFHGOACBDMH, BAIANIHCHDO OPBEMIOINMJ = BAIANIHCHDO.NONE)
	{
		return false;
	}

	private void ONBPFKPNDPI(Vector3 OCLFLNINDAP, Vector3 BMEBLGLGMNK, Color KKFCPNKNLDD, string FPDIEEGKBPB, bool HGMEIACOCFB, BAIANIHCHDO OPBEMIOINMJ = BAIANIHCHDO.NONE)
	{
	}

	private void BPNGBPODIFH(BAIANIHCHDO OPBEMIOINMJ, Vector3 OCLFLNINDAP, Vector3 BMEBLGLGMNK, Color KKFCPNKNLDD, bool HGMEIACOCFB)
	{
	}

	public void DIBAAIHAEGM()
	{
	}

	public void KGIAPPKIECP(float CNKMEPFCJOM)
	{
	}

	private void CKOPJKKCBEA()
	{
	}

	private void AEPHLHLAFBP()
	{
	}

	private IEnumerator JOAFFGFFGFB()
	{
		return null;
	}

	private void GIOAFCIDMMB()
	{
	}

	private void DGHFBDNDEBA()
	{
	}

	private void BEALBCMMOKA(uint PPPGENPKBIN)
	{
	}

	private void IAOIIPCHNLB()
	{
	}

	private void EPBMKDPNJFP(CDEDNOPGLJD CCNBNLAPJFM)
	{
	}

	private void PMMGDJGOOJL(HPNMJPLJDCB CCNBNLAPJFM)
	{
	}

	private void MNBDMCHHCEM(HDLDINCNJOP CCNBNLAPJFM)
	{
	}

	private void DOKDEOGBILG()
	{
	}

	private void LMABJHFIABI()
	{
	}

	public void ICOFKBPOGDN(BHGGAEEHJCO KPCKNLHLEGK)
	{
	}

	private void AOPIALCFCCM()
	{
	}

	private void DFILJKHFHIC()
	{
	}

	private void AGMKEPLDDBD()
	{
	}

	private void JAMCNBBCJAJ()
	{
	}

	public void MAOKELNHENJ()
	{
	}

	public void HIEFFMKCCBF(bool MDEDDNJKLGM, bool CNKGAEDFLLN)
	{
	}

	public void FGEAKCNKFME()
	{
	}

	public void PJGIMEBDAHE()
	{
	}

	private void MCBAOBEBBCG()
	{
	}

	private void GPLLECOPOBL()
	{
	}

	private void GAAMBJKPCGB()
	{
	}

	private void CCJHBHBPGIK()
	{
	}

	private void GOEDKMAFDGE()
	{
	}

	private void NHDNHCOIMJL(MADFAIIJNKM CCNBNLAPJFM)
	{
	}

	private void LBOFMPBAIKB()
	{
	}

	public void DDHLJPALLAH(out Vector3 HDFILHFDBKB, out Vector3 BAPEDKECNLH)
	{
		HDFILHFDBKB = default(Vector3);
		BAPEDKECNLH = default(Vector3);
	}

	private void GHIHENBHPOJ()
	{
	}

	public void COIJFJOCKIB()
	{
	}

	private float KIMEGEAICDB(float AOOCNKPILEO)
	{
		return 0f;
	}

	private float CFDDAJABGGL(float AOOCNKPILEO)
	{
		return 0f;
	}

	private void HAJPMDIDLGJ(IHBNOBOEJAP CCNBNLAPJFM)
	{
	}

	private void PPLBIHIEGFP(MADFAIIJNKM CCNBNLAPJFM)
	{
	}

	private void LEMKLGCAPPK(CDEDNOPGLJD CCNBNLAPJFM)
	{
	}

	private void OOLCDDCJGJM(HPNMJPLJDCB CCNBNLAPJFM)
	{
	}

	private void MEAKFGHNNIH(HDLDINCNJOP CCNBNLAPJFM)
	{
	}

	public bool JNOFLMCKBGP(GBAFONFOGDL NIBBKONKPHP)
	{
		return false;
	}

	public void ADIIPKIAAOD(BAIANIHCHDO OPBEMIOINMJ, uint NIBBKONKPHP)
	{
	}

	public Vector3 DPEHPJCDOLH(Vector3 HDFILHFDBKB)
	{
		return default(Vector3);
	}

	private void MBNEPNOLMEB()
	{
	}

	private void PKJGBCMIKDB()
	{
	}

	private void IPBOMOHCNEM()
	{
	}

	private void IAGNPHPHGOL()
	{
	}

	public void HEJEJADFIAL()
	{
	}

	private LevelForceMoveZone AONNOJKKCGB()
	{
		return null;
	}

	public void CNDAEOLLKLN()
	{
	}

	public bool GMDNLNIHLAO()
	{
		return false;
	}

	public bool PHIBGPOFCCI()
	{
		return false;
	}

	public void AIPELINDHKL(GMECHKEDOJP JEPBEDKEKDN, Vector3 ECMGONDIIFP, BHGGAEEHJCO CDNFCLMBFMB)
	{
	}

	public float MLGMIEDABJC()
	{
		return 0f;
	}

	public float MJBMFJNGCME()
	{
		return 0f;
	}

	public float ECHLBEHFGOO()
	{
		return 0f;
	}

	public int BNMFNIFBEDO()
	{
		return 0;
	}

	public int JADKMIPFIAO()
	{
		return 0;
	}

	public bool KJNMKAJAEDD()
	{
		return false;
	}

	public bool JJDCEKHBPAE()
	{
		return false;
	}

	public float ANKCHAGDODC(int IJDPLMDJCLC)
	{
		return 0f;
	}

	public float CFBHDJKCLIO(int IJDPLMDJCLC)
	{
		return 0f;
	}

	public float ADIAMECOIHD()
	{
		return 0f;
	}

	public int GPCGIOLMOAD()
	{
		return 0;
	}

	public float MNAAOLECPDL()
	{
		return 0f;
	}

	public void NFBKJNNDGPM()
	{
	}

	public int ILIMMDIMNFO()
	{
		return 0;
	}

	public EAccount.NewbieChoice EHOJDAJGIOM()
	{
		return EAccount.NewbieChoice.NewbieChoice_NONE;
	}

	public BHGGAEEHJCO CFGCKLEOJKC()
	{
		return default(BHGGAEEHJCO);
	}

	public bool OKNDAAOJBPP()
	{
		return false;
	}

	private void HNMLECJCHDM()
	{
	}

	private void AOCHIMOFCBH(PlayerForceTutorialBot AJADHADJBGF, Player FFHGOACBDMH)
	{
	}

	private void ACDLPBDOPOK()
	{
	}

	private void JHCBCGIJGAH()
	{
	}

	private void ONLHHCJLFMK()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	public new int _003C_003EiFixBaseProxy_GetGameType()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_CanShowGodEffect()
	{
		return false;
	}

	public Type _003C_003EiFixBaseProxy_GetUISceneType()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnLoadingMaskClosed()
	{
	}

	public Player _003C_003EiFixBaseProxy_CreatePlayer(Transform P0, ulong P1, ulong P2, BHGGAEEHJCO P3, bool P4, object P5)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_GCLGIKFHIFH()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_GHNMGMCJFEH()
	{
	}
}
