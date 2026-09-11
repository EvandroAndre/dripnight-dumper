using System.Collections.Generic;
using COW.PotentiallyVisible;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelContainerBase : BaseLevelObject, IPVSItemActive
{
	public abstract class JCNAILDDJDJ
	{
		public EJMCDCLJNJI NDMAKMHCKLG;
	}

	public class OLODJCCPDBM : JCNAILDDJDJ
	{
		public uint JDHNCLHNJIP;

		public uint HIDANNMJCDP;

		public uint PNLDKNOFPNG;

		public OCFPPJPODIM HECDKBIPPPE;

		public int PEEJOLJNFEG;

		public byte KIIHAHCNNDG;

		public ushort NGPHHLFGIAN;

		public bool EDCGCIMENGJ;

		public uint OICHAGAMPKF;

		public uint NNNGCLBDOAA;

		public uint LFHNNJHMBPF;

		public string INPCPDAFMCN;

		public byte AEMNDEAEPIN;

		public bool DJIHBMJHLAM;

		public JCNAILDDJDJ BLJEIAHKEPL(EJMCDCLJNJI GDHOJCDAGHJ, uint DBHJCLICABH, uint OOHPGKKKJJP, uint GFNGPPGMMKN, OCFPPJPODIM GJDLFMIFHMG = null, int JLDCAPAFNOG = 0, byte OPGIHCOLJBI = byte.MaxValue, ushort HCEMMEOKMCA = 0, bool CKHFHHKDCCL = false, uint BCGKCLDPOMG = 0u, uint MEDEOPGLEMO = 0u, uint MGEHDJFMMJA = 0u, string INPCPDAFMCN = "", byte JEKAAAOBKLL = 0, bool NLFFCJFCBKF = false)
		{
			return null;
		}
	}

	public class OOCECOLGKNM : JCNAILDDJDJ
	{
		public uint JDHNCLHNJIP;

		public uint HIDANNMJCDP;

		public uint PNLDKNOFPNG;

		public BHGGAEEHJCO LJONMJMIGGB;

		public JCNAILDDJDJ BLJEIAHKEPL(EJMCDCLJNJI GDHOJCDAGHJ, uint DBHJCLICABH, uint OOHPGKKKJJP, uint GFNGPPGMMKN, uint JLDCAPAFNOG = 0u)
		{
			return null;
		}
	}

	public class GPKPIPABAIP : JCNAILDDJDJ
	{
		public object KNBKKNMLGJE;

		public JCNAILDDJDJ BLJEIAHKEPL(EJMCDCLJNJI GDHOJCDAGHJ, object DBHJCLICABH)
		{
			return null;
		}
	}

	public class KBDDBDDPPOJ : JCNAILDDJDJ
	{
		public object KNBKKNMLGJE;

		public JCNAILDDJDJ BLJEIAHKEPL(EJMCDCLJNJI GDHOJCDAGHJ, object DBHJCLICABH)
		{
			return null;
		}
	}

	public class OPFDGGPPNNH : JCNAILDDJDJ
	{
		public BHGGAEEHJCO LJONMJMIGGB;

		public JCNAILDDJDJ BLJEIAHKEPL(EJMCDCLJNJI GDHOJCDAGHJ, uint DBHJCLICABH = 0u)
		{
			return null;
		}
	}

	public class FNEAJNOJPML : JCNAILDDJDJ
	{
		public object KNFKOKLIGGB;

		public JCNAILDDJDJ BLJEIAHKEPL(EJMCDCLJNJI GDHOJCDAGHJ, object DBHJCLICABH)
		{
			return null;
		}
	}

	public class JELFNNLHDEO : JCNAILDDJDJ
	{
		public BHGGAEEHJCO OBMFMAKFDDL;

		public JCNAILDDJDJ BLJEIAHKEPL(EJMCDCLJNJI GDHOJCDAGHJ, BHGGAEEHJCO DBHJCLICABH)
		{
			return null;
		}
	}

	public static OLODJCCPDBM levelContainerActionAdd;

	public static OOCECOLGKNM levelContainerActionDel;

	public static GPKPIPABAIP levelContainerActionUpdate;

	public static KBDDBDDPPOJ levelContainerActionAddContainer;

	public static OPFDGGPPNNH levelContainerActionDelContainer;

	public static FNEAJNOJPML levelContainerActionUpdateLaser;

	public static JELFNNLHDEO levelContainerActionPickContainer;

	public float concentricRadiusMin;

	public float concentricRadiusMax;

	protected List<ICLMFONIIKB> IGFCNCOPFPM;

	protected List<ICLMFONIIKB> OIAJLOCMLON;

	protected ObjectPool<ICLMFONIIKB> JNKHOEIMAFL;

	protected List<ICLMFONIIKB> EOBJOPJLPED;

	protected bool JLIMLONINLK;

	public ICLMFONIIKB DeletedPickup;

	protected bool HIFJICEDIKK;

	protected bool IMIDFBOODAH;

	protected List<MeshRenderer> LMKKJDJNCEA;

	protected bool ANHEAALMPKK;

	protected BoxCollider NOKDJBBFOID;

	public byte m_ContainerType;

	private bool PEHHAFMNFHF;

	public bool NeedAttachModel;

	protected bool OPFGDJAEGAJ;

	protected bool PJFOLLAGJPI;

	private ICLMFONIIKB.JMLBHNGOIJF ICNOFBOINNP;

	private static List<MeshRenderer> NHHGCHDCJLA;

	public static Vector3 DEFAULT_SIZE;

	protected BoxCollider MAPIIIIOMDD => null;

	public byte ABAMKHGKMDM
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool EDCGCIMENGJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected virtual ResourceID BCDLOAKKJKP()
	{
		return default(ResourceID);
	}

	public int GetCount()
	{
		return 0;
	}

	public string GetFirstPickUpName()
	{
		return null;
	}

	public List<ICLMFONIIKB> GetPickUpList()
	{
		return null;
	}

	public List<ICLMFONIIKB> GetPickUpCombineList()
	{
		return null;
	}

	public ICLMFONIIKB ContainsPickupByItemDataID(uint ECJCMBJODNP, out Vector3 IEGPGLIEKDF)
	{
		IEGPGLIEKDF = default(Vector3);
		return null;
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	protected void KLKDNLFCPOC(BHGGAEEHJCO LJONMJMIGGB)
	{
	}

	protected void ICCDGNNHBKN(uint HIDANNMJCDP, uint JDHNCLHNJIP, BHGGAEEHJCO LJONMJMIGGB)
	{
	}

	protected virtual void CJJPLFGICLP(bool EDKHIBPEAMH = true)
	{
	}

	protected virtual void GDPHELHKFFE()
	{
	}

	protected void GGNPEBBEAAL()
	{
	}

	protected override void OnStart()
	{
	}

	public void Init(OPICPDCLKAG CCNBNLAPJFM, uint LIKPJDHGPFG)
	{
	}

	protected override void PreRegister()
	{
	}

	protected void BJFJNDGJILH()
	{
	}

	protected void EMMGJCLHPBG()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	protected Vector3 CBKAGDDDLJM(Vector3 BAFIFNKBHLC)
	{
		return default(Vector3);
	}

	protected virtual void KOPPJJAOGIE(ICLMFONIIKB NDFJAIGOHFD, uint OBMFMAKFDDL = uint.MaxValue, bool DHBBIKHNLJC = false, bool IKLPCICHAKE = false)
	{
	}

	protected virtual void NGGPOOMFENJ(ICLMFONIIKB NDFJAIGOHFD, uint JDHNCLHNJIP)
	{
	}

	protected void HJBKIEKNNAL(GameObject HACIJIFIDKM)
	{
	}

	public static void DelAnimInWater(GameObject HACIJIFIDKM)
	{
	}

	public void InitAttachModel(ref ICLMFONIIKB NDFJAIGOHFD, bool LKOELOMHIAK = false)
	{
	}

	protected void JMPOPBKFNII(GameObject PKAIAHODENA, ICLMFONIIKB NDFJAIGOHFD, bool LKOELOMHIAK)
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	protected virtual void GBDDGCMFHPP()
	{
	}

	public void AddRenderers(GameObject NAGHAPBBLKF)
	{
	}

	public void RemoveRenderers(GameObject NAGHAPBBLKF)
	{
	}

	public void SetRenderersActive(bool CJGJFCPPCEJ)
	{
	}

	public void SetSize(Vector3 DFDAPIDCHMF, float FOGHGKFGEKN, float MGENIPLBANA)
	{
	}

	public void SetTriggerEnable(bool HCLGHJNEFIC)
	{
	}

	public static string GetNameTag(byte KIIHAHCNNDG)
	{
		return null;
	}

	public static string GetContainerName(byte KIIHAHCNNDG, ushort FKPOAJIBBLL)
	{
		return null;
	}

	public static OPICPDCLKAG GetLevelObjectType(byte KIIHAHCNNDG)
	{
		return OPICPDCLKAG.Invalid;
	}

	public static ICLMFONIIKB MapMsgid2PickUp(uint LKHIALHNOLD, uint OIDEMOGGDDI, uint PNLDKNOFPNG, byte CCNBNLAPJFM, uint BJOKOEBNEKN = 0u, ushort NGPHHLFGIAN = 0, uint EJLFGJBOCPL = 0u, uint LFHNNJHMBPF = 0u, uint KALHAMBHMMJ = 0u, string INPCPDAFMCN = "", byte AEMNDEAEPIN = 0, bool DJIHBMJHLAM = false)
	{
		return null;
	}

	internal static bool OGPFBPEMPEM(List<IFKANCAEBDB> BBKNDBJFIKJ, uint HMEEAGECFIO, BHGGAEEHJCO HFONPOGCAJH)
	{
		return false;
	}

	internal static bool OGPFBPEMPEM(BHGGAEEHJCO GMNNHBALBEH, uint HMEEAGECFIO, BHGGAEEHJCO HFONPOGCAJH)
	{
		return false;
	}

	internal static bool ABJLDOILMPP(List<IFKANCAEBDB> BBKNDBJFIKJ, uint HMEEAGECFIO, BHGGAEEHJCO HFONPOGCAJH)
	{
		return false;
	}

	internal static bool ABJLDOILMPP(BHGGAEEHJCO GMNNHBALBEH, BHGGAEEHJCO HFONPOGCAJH)
	{
		return false;
	}

	public bool IsLootContainer()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_PreRegister()
	{
	}
}
