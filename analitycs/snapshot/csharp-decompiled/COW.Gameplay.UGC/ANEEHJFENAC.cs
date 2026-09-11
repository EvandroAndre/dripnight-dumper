using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;

namespace COW.Gameplay.UGC;

public class ANEEHJFENAC : SingletonModule<ANEEHJFENAC>
{
	public enum KJIECPOHDOF
	{
		GameData,
		CustomResource,
		BinaryResource
	}

	public class ADHBJLKGMND
	{
		public ResVersionInfo.FileInfo OCANFFEJGJJ;

		public string OLOOJDPHIFA;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ResVersionInfo.FileInfo, bool> _003C_003E9__51_2;

		public static Func<ResVersionInfo.FileInfo, bool> _003C_003E9__51_3;

		public static Func<ResVersionInfo.FileInfo, bool> _003C_003E9__51_0;

		public static Func<ResVersionInfo.FileInfo, bool> _003C_003E9__51_1;

		public static Func<ResVersionInfo.FileInfo, bool> _003C_003E9__55_0;

		public static Func<ResVersionInfo.FileInfo, string> _003C_003E9__55_1;

		internal bool DDNJGDFHGHD(ResVersionInfo.FileInfo HCHNDEEBELG)
		{
			return false;
		}

		internal bool KJOPIJLPCLM(ResVersionInfo.FileInfo HCHNDEEBELG)
		{
			return false;
		}

		internal bool BDPMOBPEMHC(ResVersionInfo.FileInfo HCHNDEEBELG)
		{
			return false;
		}

		internal bool AKAAJAKAFHC(ResVersionInfo.FileInfo HCHNDEEBELG)
		{
			return false;
		}

		internal bool PMPGLPGNOCF(ResVersionInfo.FileInfo NBLHNPAHGNA)
		{
			return false;
		}

		internal string ENCKGNNDABL(ResVersionInfo.FileInfo NBLHNPAHGNA)
		{
			return null;
		}
	}

	private sealed class HCDAOOCFBOH
	{
		public string EPNFIEHNCMA;

		public UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG;

		public bool JEPLKMPMMCF;

		public UGCDownloadResourceInfo KCMDMEFEMHH;

		public ANEEHJFENAC KOKNHFGCGLN;

		internal void LDFICDLEDLA(byte[] JCONDDPFBKK)
		{
		}
	}

	private sealed class IIAMFMOAAHJ
	{
		public Action<byte[]> CEHELPAIELA;

		public List<UGCResourceForGameData.PackageOrABFileInfo> HLMPAJNEOEJ;

		internal void KMDHGLMJEFE(int OFFDDDDNPCG)
		{
		}
	}

	private sealed class ODEJNMFFICN
	{
		public Action<string, byte[]> CEHELPAIELA;

		public string MFLHABMMAJB;

		internal void PEAODJBKPHP(byte[] JEFHCDDMPLK)
		{
		}
	}

	private sealed class EOGCKCIMGMI
	{
		public Dictionary<string, byte[]> EMANEBGLLJG;

		public HashSet<string> KKLAMMNKDII;

		public Action<Dictionary<string, byte[]>> CEHELPAIELA;

		public Action<string, byte[]> DPEDCHIGDDB;

		internal void INIHKNBLNAD(string HDIMHAAOHGA, byte[] JEFHCDDMPLK)
		{
		}
	}

	private sealed class DILICMMAEIH
	{
		public List<UGCResourceForGameData.PackageOrABFileInfo> LKNONBGGMPG;

		public Action<bool> CEHELPAIELA;

		internal void FFFNICMCOJD(int OFFDDDDNPCG)
		{
		}
	}

	private sealed class IBPMFNACJLH
	{
		public UGCDownloadResourceInfo KCMDMEFEMHH;

		public string MFLHABMMAJB;

		public ANEEHJFENAC KOKNHFGCGLN;

		public Action<byte[]> CEHELPAIELA;

		public bool IHFEABLNLFC;

		public Action AICGECPFGGH;

		public Action FPOMKOPIJJL;

		internal void KLCJFCAAAJF()
		{
		}

		internal void MGJAECEPHME()
		{
		}

		internal void DFKCCFHJELE()
		{
		}
	}

	private sealed class MKOLAIAOAMG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public UnityWebRequest MNLILCFELGJ;

		public float MABNDAPDODG;

		public Action CEHELPAIELA;

		private int GJJEKMDPDOF;

		private float BKFMOEPJCAA;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MKOLAIAOAMG(int CBPPJACCGOH)
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

	private sealed class EGCKDPLFNNN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public float OJFFOLLPMGL;

		public Action CEHELPAIELA;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public EGCKDPLFNNN(int CBPPJACCGOH)
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

	private sealed class HOFMIDEFDGH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public UGCDownloadResourceInfo KCMDMEFEMHH;

		public ANEEHJFENAC KOKNHFGCGLN;

		public Action<byte[]> CEHELPAIELA;

		private IBPMFNACJLH JGAPPCDEFGK;

		private float HFLPLHAMFOO;

		private int MJGPBDJKJNA;

		private Uri HEBHJCEFOPN;

		private Coroutine GAFEDIDCFJH;

		private UnityWebRequest MOMHJNAHDBF;

		private Coroutine PHILOPAMIKF;

		private Coroutine JJNAAGKJFFP;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public HOFMIDEFDGH(int CBPPJACCGOH)
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

	public bool AMADPDGNJCD;

	public MonoBehaviour ACJKGKAOBGO;

	public bool IELENBMFOBG;

	private List<UGCDownloadInfo> INJJNGCCAMB;

	private Queue<UGCDownloadInfo> EDGJLHPINOP;

	private readonly Dictionary<string, ADHBJLKGMND> DMGEGMPBBIF;

	private static HashSet<string> DEKLOJKJBEG;

	private HashSet<string> DLBFPEBBKOM;

	public Dictionary<uint, TagDownloadInfo> ENPDCOPLHAO;

	private bool JPDNNDJHDMP;

	private List<KeyValuePair<uint, uint>> MLEHEFCDBGL;

	public List<KeyValuePair<uint, uint>> KOKNIEDMCBB => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void LMNGOJOJFNM(MonoBehaviour PDHOHGAGEEM)
	{
	}

	public bool ACNBPOLAGJN(UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG)
	{
		return false;
	}

	public bool FPPOMJJMHAN(UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG, out byte[] JCONDDPFBKK)
	{
		JCONDDPFBKK = null;
		return false;
	}

	public string IJKJJKOBFIC(UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG, KJIECPOHDOF BABFNPHMOCF)
	{
		return null;
	}

	public string KANPPCEMGOD(UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG)
	{
		return null;
	}

	public string PHEOIPNJONC(UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG)
	{
		return null;
	}

	public string GIMPKENFHAG(UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG)
	{
		return null;
	}

	public bool FPAFIHJNKLC(string CADLKLNLFLH, bool KALOAHAGLDP = true)
	{
		return false;
	}

	public string ANJIDDGMFCO(string MFLHABMMAJB)
	{
		return null;
	}

	private string LGFAIHLIJJA(string MFLHABMMAJB)
	{
		return null;
	}

	public bool GPOLFICODNG(UGCResourceShopMetaData LLAJBLDIFMI, out UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG)
	{
		HCHNDEEBELG = null;
		return false;
	}

	public void MGEDICABKPC(List<UGCResourceForGameData.PackageOrABFileInfo> HLMPAJNEOEJ, Action<int> CEHELPAIELA)
	{
	}

	public void JHLHFPIMIPM(string MFLHABMMAJB, Action<byte[]> CEHELPAIELA)
	{
	}

	private void GELFNEKOIFK(string MFLHABMMAJB, Action<string, byte[]> CEHELPAIELA)
	{
	}

	public void DNKMDPPFIBN(HashSet<string> KKLAMMNKDII, Action<Dictionary<string, byte[]>> CEHELPAIELA)
	{
	}

	public void BOOBCGPGGFN(List<UGCResourceForGameData.PackageOrABFileInfo> LKNONBGGMPG, Action<bool> CEHELPAIELA)
	{
	}

	private static void BHOAJDKOJAE(UGCDownloadResourceInfo KCMDMEFEMHH, byte[] JCONDDPFBKK, string EPNFIEHNCMA)
	{
	}

	private void NHJKKPJAEBG()
	{
	}

	private static bool LPINLEABKBH(UGCDownloadInfo MFPDMENPABN)
	{
		return false;
	}

	private IEnumerator NHOLPLIEFNG(UGCDownloadResourceInfo KCMDMEFEMHH, Action<byte[]> CEHELPAIELA)
	{
		return null;
	}

	private void LMKCAAHJNKE(Action<byte[]> CEHELPAIELA, byte[] DJAPBCKDFKA)
	{
	}

	private IEnumerator IHMNJDIOCIE(float OJFFOLLPMGL, Action CEHELPAIELA)
	{
		return null;
	}

	private IEnumerator FEGHAOGCFHD(UnityWebRequest MNLILCFELGJ, float MABNDAPDODG, Action CEHELPAIELA)
	{
		return null;
	}

	private List<UGCDownloadResourceInfo> LOHNACEGANH(UGCDownloadResourceInfo KCMDMEFEMHH)
	{
		return null;
	}

	private UGCDownloadResourceInfo KNFBKDADHHJ(UGCDownloadResourceInfo KCMDMEFEMHH)
	{
		return null;
	}

	public void EMGJKBMHPAA()
	{
	}

	public bool KFEOBIGEEIO(UGCSimpleDownloadTask OLACABEFLPO, SceneEditSlotInfo MMAHAIMIGND)
	{
		return false;
	}

	public void CBFPMNEOJGP(UGCSimpleDownloadTask OLACABEFLPO, SceneEditSlotInfo MMAHAIMIGND, bool KAJIIEFFGOK = false, bool FNONPENGEJB = true, bool JMCKPJNGOFG = true)
	{
	}

	public void KNILDMFLGME(UGCSimpleDownloadTask OLACABEFLPO, UGCResInfo LEJGCOCLNOK, bool IMDJFECNGBK = false, bool KAJIIEFFGOK = false, bool FNONPENGEJB = true, bool JMCKPJNGOFG = true)
	{
	}

	public void PNGPNOHGDLN(UGCSimpleDownloadTask OLACABEFLPO, List<UGCResInfo> HEMEMHNEDLE, bool KAJIIEFFGOK = false, bool FNONPENGEJB = true, bool JMCKPJNGOFG = true)
	{
	}

	public void NMPJFENMFIO(UGCSimpleDownloadTask OLACABEFLPO)
	{
	}

	public void ECJKFIPBAHK(UGCSimpleDownloadTask OLACABEFLPO)
	{
	}

	public void PPNENLMDEEH(UGCSimpleDownloadTask OLACABEFLPO, UGCResInfo LEJGCOCLNOK, List<uint> FHBBPGDINFA, List<List<UGCResourceForGameData.PackageOrABFileInfo>> CJOMBJLBPGE, bool KAJIIEFFGOK = false)
	{
	}

	public void OBGJEPNHLKP(UGCSimpleDownloadTask OLACABEFLPO, SceneEditSlotInfo MMAHAIMIGND)
	{
	}

	public void DGOLMHGFFGB(UGCSimpleDownloadTask OLACABEFLPO, WorkshopCreateNewConfigData BEAEMEOAFEB)
	{
	}

	public void JHAKOALMFGL(UGCSimpleDownloadTask OLACABEFLPO, WorkshopCreateNewConfigData LLDCCMJGHIA, WorkshopCreateNewConfigData NLOPIHOEFOK)
	{
	}

	public void AMDELAKKLKD(UGCSimpleDownloadTask OLACABEFLPO, UGCTutorialLevelConfig PJBBKBOMICO, bool KAJIIEFFGOK = false)
	{
	}

	private static UGCResInfo KENGGBODHCP(string PEHJODPGACF, uint JNACDFINCPH, uint JMPGKJJEMEP)
	{
		return null;
	}

	private static UGCResInfo OPLFIPKHLFJ(string PEHJODPGACF, uint JNACDFINCPH, uint JMPGKJJEMEP)
	{
		return null;
	}

	private void MDFDMAHGCFH(UGCResInfo LEJGCOCLNOK, Dictionary<string, UGCResInfo> NDENPFPPFJI, HashSet<ResourceID> AJBNDBPPMOC)
	{
	}

	private void BJPNLNGBEEL(UGCSimpleDownloadTask OLACABEFLPO, List<UGCResourceForGameData.PackageOrABFileInfo> LKNONBGGMPG, bool MEBBLGNLMNE = false, bool IMDJFECNGBK = false, bool KAJIIEFFGOK = false)
	{
	}

	public bool HAPOGHPAHJN(UGCSimpleDownloadTask OLACABEFLPO, bool MBFIKEDPLHD = true)
	{
		return false;
	}

	public void AANGEELBLNB(UGCSimpleDownloadTask OLACABEFLPO)
	{
	}

	private void PCEOGBHKHDD(UGCSimpleDownloadTask OLACABEFLPO)
	{
	}

	private void OCPIOCOPPNA(List<ResVersionInfo.FileInfo> OPIFIKODPEC, bool PDPHNFDILAK = false)
	{
	}

	private void OCPIOCOPPNA(List<ResourceID> GKIDJCGHAOA, List<string> IOHMFAIDGMN, bool PDPHNFDILAK = false)
	{
	}

	public float DMAJIBFHOKG(UGCSimpleDownloadTask OLACABEFLPO)
	{
		return 0f;
	}

	public bool GLBBBJOCGPI(UGCSimpleDownloadTask OLACABEFLPO)
	{
		return false;
	}

	public bool IMGLKAMEKHF(UGCSimpleDownloadTask OLACABEFLPO)
	{
		return false;
	}

	public bool BMIINMEDBBD()
	{
		return false;
	}

	public void OMEEALJJPNH(ResDownloadType ALEGEPCAFEJ)
	{
	}

	public void KNJBMONFDHF(ResDownloadType ALEGEPCAFEJ)
	{
	}

	public bool COFDNDOKHEM(UGCResourceForGameData.PackageOrABFileInfo HCHNDEEBELG, out ResVersionInfo.FileInfo BJEMOEFNEBH)
	{
		BJEMOEFNEBH = null;
		return false;
	}

	public bool JGKNLEHJKDJ(string CADLKLNLFLH)
	{
		return false;
	}

	public ResVersionInfo.FileInfo GOIDFMCCEIG(string CADLKLNLFLH)
	{
		return null;
	}

	public ADHBJLKGMND HJGEFOOCNCI(string CADLKLNLFLH)
	{
		return null;
	}

	public string NGIPMLACIDH(string CADLKLNLFLH)
	{
		return null;
	}

	public bool NDGNBEHFKPP(string CADLKLNLFLH)
	{
		return false;
	}

	public void JOFBNJLADHK(TagDownloadInfo LGGNEHFEPLA, bool JKHCMCJNGFM)
	{
	}

	public void GNNACHALEFP(uint AIJPLANDCCO, TagDownloadInfo LGGNEHFEPLA)
	{
	}

	public void LHNBMIFCKIH(List<ResVersionInfo.FileInfo> LKNONBGGMPG)
	{
	}

	public uint AGMALOALIJE(ResVersionInfo.FileInfo HCHNDEEBELG, string PBNMDIIMEGN = null)
	{
		return 0u;
	}

	private uint AGJPHBOOLOG(uint OHDICOEGJNM)
	{
		return 0u;
	}

	private void HIGDAOMCNBC(ResVersionInfo.FileInfo HCHNDEEBELG, uint GFJEGGDAHOJ)
	{
	}

	public void GKAHCEDPALF(bool NIKNPJFPPFJ = false)
	{
	}

	public void HCHEEOBBCIL()
	{
	}
}
