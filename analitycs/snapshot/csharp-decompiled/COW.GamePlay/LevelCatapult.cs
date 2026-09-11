using GCommon;
using GCommon.Audio;
using UnityEngine;

namespace COW.GamePlay;

public class LevelCatapult : BaseLevelObject
{
	private class DMKIIDHPLAL : ShadowStateBase
	{
		public Quaternion DOGHPBHDLCJ;

		public Quaternion GBHPAJHAAMF;
	}

	public enum HJIENKLKGPG
	{
		SYNC,
		SYNCLIST,
		GET_IN,
		GET_OUT,
		LAUNCH,
		DESTORY,
		ADD
	}

	private BHGGAEEHJCO BMIGBNMBAJH;

	public Transform InCatapultPosition;

	public Transform OutCatapultPosition;

	public Vector3 originalForward;

	public Transform BoardRoot;

	public Transform HorizontalRotRoot;

	public Transform VerticalRotRoot;

	public Transform ChargingEffectAnchor;

	private Collider NBABLFEJEOG;

	private uint LPKELAJBNAM;

	private uint AFKJGPCDCJD;

	private AudioPlaybackParams_Unity CCENIKPBPHG;

	private GameObject HMLGFBDNCLC;

	private GameObject EMPKPKHLLNC;

	private GameObject KIKGMALHLNN;

	private GameObject MDAPDHALKII;

	private VisualInstanceHolder NNGIELADGOO;

	private bool LALKFHFEJPM;

	private ResourceID DBLGNFIILFA;

	private uint NBEMHANDLBC;

	private bool AEJBBALNABP;

	public bool m_ShowGizmos;

	public GameObject m_DestroyEffect;

	public GameObject[] m_TimesEffects;

	private FEKBCHODFLE GELFGDBLHDE;

	private uint JFGPHBGECML;

	private UGCHandCatapultRepItem AOAJFHPKHCD;

	protected uint IAPBBEEDLCG;

	private DMKIIDHPLAL LAPJPJICGJD;

	private Vector3 FIDHDOCBDFJ;

	private Quaternion HAHAMBBCDGB;

	public float RotHorizontalRangeMinAngle;

	public float RotHorizontalRangeMaxAngle;

	public float OriginalForwardAngle;

	private bool _003COJFCJLKMCME_003Ek__BackingField;

	public bool JIKOPAIIHAN => false;

	public Vector3 AKDFABCDFCJ
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion BLGMCODFIGH
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public int KNFANAGFAHN => 0;

	public bool KAPDMOHOGNK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UGCHandCatapultRepItem GetUGCHandCatapultRepItem()
	{
		return null;
	}

	public BHGGAEEHJCO PIDInCatapult()
	{
		return default(BHGGAEEHJCO);
	}

	private void CFCGOPDDJAF()
	{
	}

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	public void Init(uint HIDANNMJCDP, uint KFMNLPAHBJA)
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	private void MGBLKDLEBDF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected override void OnOnDestroy()
	{
	}

	public void CalculateHorizontalRotationRange()
	{
	}

	public void PushSyncState(Quaternion LEOLFBEGFAO, uint OJFBGFOOKEK)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	private bool DHCKGAHDACD(Player KDJNEHDAAFL)
	{
		return false;
	}

	private void FGBAGJIMMIK(Player KDJNEHDAAFL, bool NMMNOEDALPA)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void ELLIALENOCE()
	{
	}

	public void PrepareLaunch()
	{
	}

	private void AFHNAPJGPBG()
	{
	}

	private void EAPIPNMGPCN(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	public void RealLaunch()
	{
	}

	private void MLBDFDIELLC()
	{
	}

	private void CCHMOKLEBLC()
	{
	}

	private void OEBFHHJELMD()
	{
	}

	private void EHNIPNBNOOA()
	{
	}

	private void LLFOBOJPDBJ()
	{
	}

	private void CJEHEOMACCH()
	{
	}

	private void HJLOLJEEDDL()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void KNBIJNKGKBC()
	{
	}

	private void LNDHCEHOMJL(uint GGAOIPIHOBP, bool LKFAPKCNACC, Object PCGMOOHAIDE)
	{
	}

	private void HLMGPMKJLNN(GameObject KGJNMPHDKAB)
	{
	}

	private void ILKHHBGEBJM(PropCatapult BKKHHEJKDFF)
	{
	}

	private void MOKFPPBDBON(uint GGAOIPIHOBP, bool LKFAPKCNACC, Object PCGMOOHAIDE)
	{
	}

	private void ABBJEHEOHNH(uint GGAOIPIHOBP, bool LKFAPKCNACC, Object PCGMOOHAIDE)
	{
	}

	private void KKEAKCBBECB()
	{
	}

	private void IOPCNKDGGAP(GameObject HACIJIFIDKM)
	{
	}

	private void PAMADFLNLAI(ResourceID OCCLMDNGINA, GameObject HACIJIFIDKM)
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
