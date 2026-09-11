using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelMiniSentry : LevelObjectSpawnedAttackable
{
	private enum OJEHGFMMIBM
	{
		None,
		Teammate,
		Enemy
	}

	private sealed class JJCPOGEFJHK
	{
		public LevelMiniSentry KOKNHFGCGLN;

		public string DGDDJLEOPBL;

		public Vector3 OCLFLNINDAP;

		public Vector3 MNBPEEDKIAD;

		internal void BNFLIHGDBFK(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
		{
		}
	}

	private sealed class DFPKKENCNKI
	{
		public LevelMiniSentry KOKNHFGCGLN;

		public string DGDDJLEOPBL;

		public ResourceID OCCLMDNGINA;

		internal void JMOFBAGFHCA(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
		{
		}
	}

	private sealed class BJKJCIDKBCH
	{
		public LevelMiniSentry KOKNHFGCGLN;

		public Vector3 HDFILHFDBKB;

		public float HKMEOMLEHJP;
	}

	private sealed class BDLKNDKOMME
	{
		public string DGDDJLEOPBL;

		public ResourceID OCCLMDNGINA;

		public BJKJCIDKBCH EDIPCAMGBNP;

		internal void LNGLONANLIA(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
		{
		}
	}

	private sealed class LGPFHNIJNMA
	{
		public string DGDDJLEOPBL;

		public ResourceID OCCLMDNGINA;

		public BJKJCIDKBCH HIDGOLEIPLE;

		internal void ADGJBLIFNKA(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
		{
		}
	}

	private const float CMNLOIJGJJK = 100f;

	public Transform Root;

	public Transform RotY;

	public Transform RotX;

	public Transform Center;

	public Transform FirePoint;

	public Transform VFXRoot;

	private TransformRotater KELIMAKCCCH;

	private GEFOFFLCOLD GFBHKKMBJLJ;

	private BHGGAEEHJCO OPJGHJIJGBP;

	protected ResourceID IEODCPPNAIC;

	private Vector3 HJEMAGHOMGC;

	private bool OANIFIMOFOE;

	private ParticleSystem DACBLANHFFL;

	protected bool JOFGBIHLHJO;

	private FEKBCHODFLE GELFGDBLHDE;

	private readonly EntityVisualEffectManager EINPMFNJINA;

	private uint OFOOLJGOBOO;

	private uint MIFMDLPGPOC;

	private uint CMDLOCGBFEE;

	private uint DEJHGDDKOHD;

	private OJEHGFMMIBM NBLPLACFBEF;

	private OJEHGFMMIBM DMGPANCFAMI;

	private float DHCLMLPBNJD;

	private float JEIAKNOKKDP;

	private GameObject HGNHEOPGNEN;

	private ResourceID HKFCLJNONPA;

	private ResourceID MOBIHAPJJHM;

	private ResourceID IPOMOFDNNMM;

	private GameObject AGGLIHAKAIE;

	private GameObject FADCNONNNAA;

	private Vector3 MEJACCEEDFF => default(Vector3);

	private Vector3 EPCMOGEBEKM => default(Vector3);

	public override int DCMNDCMNAAH => 0;

	private bool JDFKKCPBAEL => false;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	protected override void LMNGOJOJFNM(CSVBaseData FKOEIMHOHAI)
	{
	}

	private void PMBHPHEKLBF()
	{
	}

	private void IGDPFBIFHJI(GEFOFFLCOLD JCONDDPFBKK)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	protected override void FLFHMOGHICH(bool GMLCCOIKJGD)
	{
	}

	private void LILALFMPAKJ(GEFOFFLCOLD JCONDDPFBKK)
	{
	}

	public override void OnDead(CMCLPFPANDP OINKNIGKDMO)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void OnRecycle()
	{
	}

	private void CFKDOLGFBEL()
	{
	}

	protected void NIKLDFOLOJD()
	{
	}

	protected void OECHPGECOKF()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private void GIGMKAAMOCK(object[] DJAPBCKDFKA)
	{
	}

	protected void PJCMEMHNDND(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void APDOIHEDMAB(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void LEMDBLJJJPH(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void DFFGCJKHABN(float FADOEDJHAGD, float LJJDHJOELML)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void LADPODDMGFI(Player PGEGMKJKOKI, bool HDGIHCBAOEN)
	{
	}

	private Vector3 EIAEKGAFINL(Player PGEGMKJKOKI, bool HDGIHCBAOEN)
	{
		return default(Vector3);
	}

	private void LADPODDMGFI(NetworkAIPawn PGEGMKJKOKI, bool HDGIHCBAOEN)
	{
	}

	private Vector3 KCNPLDJLELB(NetworkAIPawn PGEGMKJKOKI, bool HDGIHCBAOEN)
	{
		return default(Vector3);
	}

	private float GCGGGGKOEOO(float MHAAFMCMHAC, float PAFBAHJAAGC)
	{
		return 0f;
	}

	private void LMBNLNMIGOA(Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD)
	{
	}

	private void EIEOEFGILMJ(GameObject CLACOPMJHDI, Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD)
	{
	}

	private void KBBLLFDOFLC()
	{
	}

	private void EAPIPNMGPCN(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	private void DNENKHFBFNL(GameObject CLACOPMJHDI)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void GPFMCMHMHKO(float HOGHEFNINAE)
	{
	}

	private void OOAFHEPCLFH(float FADOEDJHAGD, float LJJDHJOELML)
	{
	}

	private void GIPOHAJMIJN(Vector3 HDFILHFDBKB)
	{
	}

	private void PHJMKBNLHIM()
	{
	}

	private void IIGMJHNALHA()
	{
	}

	private void NCDOCLGNOPF()
	{
	}

	private void NAMCMPDHOAM()
	{
	}

	private void HIDKLCEEGGE()
	{
	}

	public override void OnSyncUGCEntityProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	protected void PAMFCIBOEII()
	{
	}

	public void ShowDeActiveEffect(bool EOGOGFLCEHL)
	{
	}

	public void ShowGatherEffect(bool EPOBGLJNAOD, bool GEOKDGKLGJH, bool AMDDODHJNGL, float HKMEOMLEHJP)
	{
	}

	private void ICFHLANOCCH(GameObject CLACOPMJHDI, Vector3 HDFILHFDBKB, float HKMEOMLEHJP)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_LMNGOJOJFNM(CSVBaseData P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_FLFHMOGHICH(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDead(CMCLPFPANDP P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
