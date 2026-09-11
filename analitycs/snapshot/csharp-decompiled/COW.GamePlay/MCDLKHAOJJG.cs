using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using COW.Gameplay.UGC;
using GCommon;
using UMA.Simple;
using UnityEngine;
using message;
using proto;

namespace COW.GamePlay;

internal abstract class MCDLKHAOJJG : MatchGame, ISessionHanlder
{
	private struct CDEGIHKODFO(string GBNEKDOECMK, int JLIGIGBCKCA, FontStyle AHCLACIKMOB)
	{
		public string GOCNECPPDIC = null;

		public int DFDAPIDCHMF = 0;

		public FontStyle KJALKHEHBNG = FontStyle.Normal;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<InGameShaderWarmupConfig, uint> _003C_003E9__113_0;

		public static Action<int> _003C_003E9__210_0;

		internal uint JHHNHMBBOIJ(InGameShaderWarmupConfig GPFPIAMCEMI)
		{
			return 0u;
		}

		internal void HOIMNFJOKAN(int OFFDDDDNPCG)
		{
		}
	}

	private sealed class NCKBGPCABNG
	{
		public UIModelActivity BFAHHHNJBIF;

		public List<LGCLHIKCNJA> EMANEBGLLJG;

		internal void PHFCPDHPPMI(ClientActivityDesc DNNNJDJIBMP)
		{
		}
	}

	private sealed class LCNEGGACCGG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public MCDLKHAOJJG KOKNHFGCGLN;

		private IEnumerator LKACOAHEDDC;

		private bool DEOGDCLIIMH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public LCNEGGACCGG(int CBPPJACCGOH)
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

	private sealed class DIPGLJOAOEJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public MCDLKHAOJJG KOKNHFGCGLN;

		private float BDELDDDOKGM;

		private PNCPKGJGBPP GAOBPBLBGOG;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public DIPGLJOAOEJ(int CBPPJACCGOH)
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

	private sealed class PEBHCDCGEBP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public MCDLKHAOJJG KOKNHFGCGLN;

		private List<int> KBCDPIGGKML;

		private int AHFPLPDAKJN;

		private SlotOverlayCacheManager KMNDKCMNCID;

		private List<int>.Enumerator KOHCEAJKEIN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public PEBHCDCGEBP(int CBPPJACCGOH)
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

		private void FCCDBLLBMAO()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static ulong _003CLOIHGHFBOBG_003Ek__BackingField;

	private static readonly Dictionary<uint, string> GEOINLODIFC;

	protected long BAIIJPLNBIC;

	private static byte[] _003CPJKFDOEHMLF_003Ek__BackingField;

	private static HMACSHA256 _003CHPGBIGGFOFK_003Ek__BackingField;

	private float _003CJAPNEMKGLBA_003Ek__BackingField;

	protected static readonly Vector3 MINOPMHIHEP;

	protected static readonly Vector3 PELABCOEPGP;

	protected GameObject HJBPNHPBKLK;

	protected ITransformNode LNAFFHKPBJI;

	protected Transform AJALKPDGMJP;

	protected float JLGCOJCLKMN;

	public uint EIAKLGFNLJE;

	public ulong ALFOKPOIICI;

	protected ulong FHHIAHOIMNE;

	public uint NHPFOMNHMGM;

	public uint LJACEMHGJMH;

	public float GMFGCJKLDNC;

	private uint DONAPMIAIMB;

	private long ICGFAFHCIJG;

	private int BKMGBJGGCBL;

	protected FCNKGLHEPHJ KAFOEINGPNE;

	private DHBFKHBHIAA LPEJBMMCLDB;

	protected DEOCFJLEDKD EFBJCLOGGHB;

	protected DGGAKDCKJPP IMFCAFAHBEG;

	protected NOAPGJAIOBB MMEOIAFCCNK;

	protected AGLOOADCOLF NPIMKHEDNHD;

	private IOGBFCCOHIL _003COEDCNCCPBCD_003Ek__BackingField;

	protected float CIBCCOLLLFB;

	protected BHGGAEEHJCO FCAFGGLNJNI;

	protected List<BHGGAEEHJCO> OIFCOCOBPHP;

	protected List<BHGGAEEHJCO> JFPIAAKEIID;

	protected float PDMJFMPFJFK;

	protected float CEEEPGAMEND;

	protected float NIGICDHOAIA;

	protected int DLBGEEFMMOE;

	private Dictionary<BHGGAEEHJCO, byte> MMKPMBGGJOP;

	public const byte LBGFNOEOAPD = byte.MaxValue;

	private bool NJFDFCKHFGG;

	private static CSVAsyncDataMap<uint, InGameShaderWarmupConfig> OBBCHIDCNJI;

	public UGCRunnerManager BGEGMEIPMBC;

	protected bool CAFBNDPCCBK;

	private OHGNMPAEJDB PDDIIJIMMLG;

	private Stack<IEnumerator> ILGOCGEBPFC;

	private FTimer AHPPPIDDLEH;

	private IEnumerator MMBCGALIKIB;

	private KDOJKBLGBAF HFAEGHILGHG;

	private HOOLEJGDAPP NMIEMAEHPJK;

	private uint EIONNIDPHLF;

	private FTimer KPFCHFKDDAG;

	private static List<int>.Enumerator ONEEDDPAJJH;

	private static CDEGIHKODFO[] HAHFEKKNBGG;

	private ONFBHNEPBCM KCPHNLINCKA;

	private float KEKHKNJFDPO;

	public static ulong KNPKOILKMNN
	{
		get
		{
			return 0uL;
		}
		private set
		{
		}
	}

	public static byte[] EBNAKMPIPCG
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static HMACSHA256 FJPPCNKOIEL
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public float LFHALBCMJNM
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public FCNKGLHEPHJ JOMEHMFNDPJ => null;

	public DHBFKHBHIAA ENNIMJHINII => null;

	public DEOCFJLEDKD OEGDAMHLDNP => null;

	public DGGAKDCKJPP DGGAKDCKJPP => null;

	public NOAPGJAIOBB NOAPGJAIOBB => null;

	public AGLOOADCOLF AGLOOADCOLF => null;

	public IOGBFCCOHIL IOGBFCCOHIL
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public UGCRunnerManager EGIPCHPLBLH => null;

	public bool HJCAKAJOIBO => false;

	public override void OnMatchStart()
	{
	}

	public byte HMGMKMPDKAM(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return 0;
	}

	public void BDFMNOIHFIL(BHGGAEEHJCO OBMFMAKFDDL, byte IKMGPLIHPFE)
	{
	}

	public override bool IsOnlineGame()
	{
		return false;
	}

	protected virtual bool HICAHNILDDI()
	{
		return false;
	}

	protected virtual void FKNOEAKPBIF()
	{
	}

	protected virtual bool CJIMFNLGNPG()
	{
		return false;
	}

	protected virtual void PHCIBIKNFLI(AODHDBMJFKH OINKNIGKDMO)
	{
	}

	public override LoadingProcess[] GetLoadingProcesses()
	{
		return null;
	}

	public override bool IsOptWaitGameInitAfterLoadScene()
	{
		return false;
	}

	public IPLMKGDIEOC KPELGDBOFDK()
	{
		return null;
	}

	public MatchGameClient AODOLHMDPHB()
	{
		return null;
	}

	public bool JFOFPGIKDPK(UIModelUGCResourceSelect.ETableType JPJBLAMLPHI, string GGMIDNEJGNO)
	{
		return false;
	}

	public override void OnLoadingFailed(int LBLKJJLINJB)
	{
	}

	public override void OnLoadingSceneFailed()
	{
	}

	private void CGNIGCHJBLO()
	{
	}

	protected override void OnAwake()
	{
	}

	protected override void OnSceneLoaded()
	{
	}

	protected void KJJKILHPCBC()
	{
	}

	protected void KHJCBJCABCL(ResourceID GGMIDNEJGNO, ref string[] NBOIFGLEMAG)
	{
	}

	public override bool NeedPreloadBeforeLoadScene()
	{
		return false;
	}

	protected override void OnPreloadLoaded()
	{
	}

	private void NAANLPNBLBL()
	{
	}

	protected override void AfterPreloadLoaded()
	{
	}

	protected virtual void KMGEHIECKOF()
	{
	}

	protected void NBDKGNCFEFM()
	{
	}

	public void KOCLECBFAPD(BHGGAEEHJCO KJLFMPOFELA, AvatarManager.JEGKOJDIKEL DKIIMBMLFHG, bool BCHDKJGBGNF)
	{
	}

	protected void LCLALAKHFJD()
	{
	}

	public override uint GetPreloadCountPerFrame()
	{
		return 0u;
	}

	public void OnPingSent(int FMLOEEAODJK)
	{
	}

	public int BPKNJBDPOEA()
	{
		return 0;
	}

	public void OnPingReceiveTimeout()
	{
	}

	public void OnReconnect()
	{
	}

	public void OnConnected(bool EMANEBGLLJG)
	{
	}

	public void OnDisconnected(DisconnectedReason OINKNIGKDMO)
	{
	}

	public bool MJIBAGDFJGF(DisconnectedReason OINKNIGKDMO)
	{
		return false;
	}

	protected virtual void EFHLGFLEDHE(uint IKAFCLILEOM)
	{
	}

	public override void AfterJoinMatchFinish()
	{
	}

	protected virtual void EMEPIJPPKPH()
	{
	}

	private static void EPAAOCAPBAE()
	{
	}

	private bool KJCFILONPPO(InGameShaderWarmupConfig DKLKGHGFNCC)
	{
		return false;
	}

	private void OHFFMHBGNLO()
	{
	}

	public IEnumerator CNKAGLMKFHP()
	{
		return null;
	}

	private void JKLCMJLPFGH(object[] JCONDDPFBKK)
	{
	}

	private void JIKHKOGDOLG()
	{
	}

	private IEnumerator JGCOPALKMOO()
	{
		return null;
	}

	private void HAPKEPICOPB()
	{
	}

	protected void HNFACMEEOMJ()
	{
	}

	private void OOHFHHAFHGC(object[] JCONDDPFBKK)
	{
	}

	private void FALKOIHMJPE(object[] JCONDDPFBKK)
	{
	}

	private void GJDLEFHECAM(object[] JCONDDPFBKK)
	{
	}

	private void ADNKOJIANGL(object[] JCONDDPFBKK)
	{
	}

	private void HJJBMCAACFD(object[] JCONDDPFBKK)
	{
	}

	private void EFFCHDOLKDD(object[] JCONDDPFBKK)
	{
	}

	private void BOEFPGJCJJD(object[] JCONDDPFBKK)
	{
	}

	private void NDKKJADNNCH(object[] JCONDDPFBKK)
	{
	}

	private void NFBIMAHFNCM(object[] JCONDDPFBKK)
	{
	}

	private void FFCIJNHOJIB(object[] JCONDDPFBKK)
	{
	}

	private void KLKGKJJDPNO()
	{
	}

	private void BDNPMOOLFJL(object[] JCONDDPFBKK)
	{
	}

	private void FGLJOAIEAJK(object[] JCONDDPFBKK)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnFixedUpdate()
	{
	}

	public void BJEDIMFNBGD(bool HCLGHJNEFIC)
	{
	}

	public void FEDINFJBOKE(bool HCLGHJNEFIC)
	{
	}

	public void IAHOLGMNPGD(bool HCLGHJNEFIC)
	{
	}

	public void KLKGKJJDPNO(bool HCLGHJNEFIC)
	{
	}

	public void MDDKMNGJIDF(uint MFODICJHGJI)
	{
	}

	protected override void OnNetworkFixedUpdate()
	{
	}

	protected virtual bool BBHMICFJAPO()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnInitWithInGameReload()
	{
	}

	protected override void OnUnInitWithInGameReload()
	{
	}

	public override int GetGameType()
	{
		return 0;
	}

	public AGLOOADCOLF EJFCBPHLPPF()
	{
		return null;
	}

	public void FMFICIAFJDE(KPNNEAJJBGO AOFCDPKJKJO)
	{
	}

	public void MMLFLPPINNO(KAAKGAONPBH APHHNHEDHKD)
	{
	}

	public void MMLFLPPINNO(uint JLDGHJBBEJF)
	{
	}

	public void FAMPBDCOJKP()
	{
	}

	public float IMPPCMEABDG()
	{
		return 0f;
	}

	public float OEMMNOPHEKC()
	{
		return 0f;
	}

	public uint IAIKNCMJHLF()
	{
		return 0u;
	}

	protected ResourceID[] BCKLFGOLGBP()
	{
		return null;
	}

	public override ResourceID[] GetAudioPreloadResourceID()
	{
		return null;
	}

	private void DDCOBNCNHKG(List<int> AOFCDPKJKJO, ref List<int> PCGMOOHAIDE)
	{
	}

	public override List<int> GetPreloadUmaResource()
	{
		return null;
	}

	public override IEnumerator PreloadUmas()
	{
		return null;
	}

	protected virtual NKAJNENFKJF GFPMIPDNBBJ()
	{
		return null;
	}

	protected List<LGCLHIKCNJA> GLPNDOOOICE()
	{
		return null;
	}

	protected virtual bool AHMMEIKKBHE(DisconnectedReason OINKNIGKDMO)
	{
		return false;
	}

	private void CEFKGKBHCJK()
	{
	}

	protected void PHMGKHKICPA()
	{
	}

	protected void JAOIHKAJKLM()
	{
	}

	protected void EKLDHBHPAJC()
	{
	}

	public void ANPCBHKCKFP()
	{
	}

	public void MEGEKNJBMCM()
	{
	}

	public override void PauseGame(bool FKJMCGEFJMD)
	{
	}

	public override bool IsGamePaused()
	{
		return false;
	}

	public override bool CanActiveSkillTakeEffect(BHGGAEEHJCO OBMFMAKFDDL, HBLKLJHFJDK NAEHPILKNPP, out string GAIHINNHFMJ)
	{
		GAIHINNHFMJ = null;
		return false;
	}

	public virtual bool NAJLMDOMMNE()
	{
		return false;
	}

	public virtual bool PJIPIPEGPPA()
	{
		return false;
	}

	public bool PHHIIBGAAAM(ulong HGNIOBLGCII)
	{
		return false;
	}

	public override Player CreatePlayer(Transform MLBAMPFOCGP, ulong HGNIOBLGCII, ulong GMKFNKFFPBH, BHGGAEEHJCO OBMFMAKFDDL, bool CHDFFDMBMEL = false, object LHLIKBIDIIJ = null)
	{
		return null;
	}

	protected ushort DOOKGLIILCN()
	{
		return 0;
	}

	private void LFOAJCBHOLG()
	{
	}

	protected virtual void NNDKLEJFLIJ()
	{
	}

	public override void OnLoadingMaskClosed()
	{
	}

	protected virtual IHFFDJIDIAA IDLLAEJOPMH()
	{
		return null;
	}

	protected void ICLBMBKBELA()
	{
	}

	protected void BIODIPGJDIN()
	{
	}

	protected void PAHPPHDMKIJ()
	{
	}

	protected float ABNBHIKPIIC(BHGGAEEHJCO JFPADHMCADP)
	{
		return 0f;
	}

	public virtual void CCBGCOHIPGL()
	{
	}

	public void GBNNMDHNLLC()
	{
	}

	protected virtual void HEPEKHFOODE(uint PPPGENPKBIN)
	{
	}

	public override ONFBHNEPBCM CurrentLvlAbilityModule()
	{
		return null;
	}

	protected virtual void APAHGAJGEMJ()
	{
	}

	public override float ReconnectTime()
	{
		return 0f;
	}

	protected bool ADLHCKHNHDB()
	{
		return false;
	}

	public virtual void HPBGKIHMHOL()
	{
	}

	public virtual void GOMPFMINPGG()
	{
	}

	public virtual void OJFIACOGDAP()
	{
	}

	public virtual bool NAOGJDKDCBI()
	{
		return false;
	}

	public void MJOIECGELCE()
	{
	}

	private void KEPKNHCLDAF(string DNOALKJKIHL, uint JNACDFINCPH, uint JMPGKJJEMEP)
	{
	}

	private void CKLKJBEDGDC(uint MJIFGJPGLAM, bool GKKELMDDGBJ, UnityEngine.Object FJEPEDPFODO)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanActiveSkillTakeEffect(BHGGAEEHJCO P0, HBLKLJHFJDK P1, out string P2)
	{
		P2 = null;
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnPreloadLoaded()
	{
	}

	public void _003C_003EiFixBaseProxy_OnMatchStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUnInitWithInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnLoadingMaskClosed()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsOnlineGame()
	{
		return false;
	}

	public LoadingProcess[] _003C_003EiFixBaseProxy_GetLoadingProcesses()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsOptWaitGameInitAfterLoadScene()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnLoadingFailed(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnLoadingSceneFailed()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedPreloadBeforeLoadScene()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_AfterPreloadLoaded()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetPreloadCountPerFrame()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_AfterJoinMatchFinish()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNetworkFixedUpdate()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInitWithInGameReload()
	{
	}

	public int _003C_003EiFixBaseProxy_GetGameType()
	{
		return 0;
	}

	public ResourceID[] _003C_003EiFixBaseProxy_GetAudioPreloadResourceID()
	{
		return null;
	}

	public List<int> _003C_003EiFixBaseProxy_GetPreloadUmaResource()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_PreloadUmas()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_PauseGame(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsGamePaused()
	{
		return false;
	}

	public Player _003C_003EiFixBaseProxy_CreatePlayer(Transform P0, ulong P1, ulong P2, BHGGAEEHJCO P3, bool P4, object P5)
	{
		return null;
	}

	public ONFBHNEPBCM _003C_003EiFixBaseProxy_CurrentLvlAbilityModule()
	{
		return null;
	}

	public float _003C_003EiFixBaseProxy_ReconnectTime()
	{
		return 0f;
	}
}
