using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class UGCLevelMiniSentry : BaseAutoGenIDLevelObject
{
	private const float CMNLOIJGJJK = 100f;

	public Transform Root;

	public Transform RotY;

	public Transform Center;

	public Transform FirePoint;

	public GameObject TeammateEffects;

	public GameObject EnemyEffects;

	public float AngleSpeed;

	public float AngleUp;

	public float AngleDown;

	public Vector3 FirePosLocalPosition;

	public float FireAngle;

	public Animator FireAnimator;

	public Vector3 ExplodeEffectScale;

	public GameObject AttackRangeEffect;

	private TransformRotater KELIMAKCCCH;

	private BHGGAEEHJCO OPJGHJIJGBP;

	private Vector3 HJEMAGHOMGC;

	private bool OANIFIMOFOE;

	private ParticleSystem DACBLANHFFL;

	protected bool JOFGBIHLHJO;

	private UGCAimAssistEntityRepItem _003CJCKDIEANHDJ_003Ek__BackingField;

	private uint HBAGPPLGODG;

	private uint AFEGPBBBIPG;

	private KOJIHOIBJCA BCPCJIGHAPG;

	private GameObject BJNHFBIBPBN;

	public UGCAimAssistEntityRepItem BAGHFDACIOF
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private Vector3 MEJACCEEDFF => default(Vector3);

	private Vector3 EPCMOGEBEKM => default(Vector3);

	public uint OPEIODGNJLA
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public void Init(HOGBJEELAMK KJGEGBPHIPJ, string GDDEBLAFLLG)
	{
	}

	private void PKHCICMIGAP()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public override bool CreateDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public bool IsSameTeam(BHGGAEEHJCO NDGDFMDIGLC)
	{
		return false;
	}

	public uint MaxHP()
	{
		return 0u;
	}

	private void LILALFMPAKJ()
	{
	}

	private void GIGMKAAMOCK(object[] DJAPBCKDFKA)
	{
	}

	public void OnTargetChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnRoatationChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnStatusChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void DFFGCJKHABN(float FADOEDJHAGD, float LJJDHJOELML)
	{
	}

	private void HGJCBDOFMCL()
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

	private void LFAFMJJAAPB(NetworkAIPawn FMHELKKNAIM, bool HDGIHCBAOEN)
	{
	}

	private Vector3 CINHIILBIDL(NetworkAIPawn FMHELKKNAIM, bool HDGIHCBAOEN)
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

	private void KBBLLFDOFLC()
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

	private void IPCAAFDLNPD()
	{
	}

	private void IAEMMPKOFBJ(ResourceID KDBNFJAILNE, ResourceID LBGOPHDLJKH)
	{
	}

	private void NAMCMPDHOAM()
	{
	}

	public void UpdateAttackRange(bool EOGOGFLCEHL, float DFKJIKFKKDH)
	{
	}

	public override void OnSyncUGCEntityProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	private void AJPAPFOHIBH()
	{
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
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
