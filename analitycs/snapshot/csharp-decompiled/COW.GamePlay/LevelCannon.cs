using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelCannon : BaseLevelObject
{
	private class BPFFGIOAGPE : ShadowStateBase
	{
		public Quaternion DOGHPBHDLCJ;

		public Quaternion GBHPAJHAAMF;
	}

	public enum EHGMJBFMMGJ
	{
		SYNC,
		SYNCLIST,
		GET_IN,
		GET_OUT,
		FIRE
	}

	private BHGGAEEHJCO BMIGBNMBAJH;

	public uint CannonID;

	public Transform PivotTransform;

	public Transform InCannonPosition;

	public Transform OutCannonPosition;

	public Vector3 originalForward;

	public Transform HorizontalRotRoot;

	public Transform VerticalRotRoot;

	public Transform CannonRoot;

	private Collider NBABLFEJEOG;

	private GameObject BCNMDJLHFBB;

	private GameObject HMLGFBDNCLC;

	private GameObject KIKGMALHLNN;

	private GameObject MDAPDHALKII;

	private bool NGEKIKKEPAK;

	private float FCONEHLDPOO;

	private float HMCHNLLMNHK;

	private bool ALOMFBGFEGP;

	private uint NBEMHANDLBC;

	private MDFIOMKMCEK GFBHKKMBJLJ;

	public Quaternion OriginLocalRotation;

	public uint BindVehicleId;

	public string SpecialModelName;

	public Quaternion CachedAimRotation;

	private GMPGMPFNMFP GLDGGAEAFKC;

	public float MinViewAngle;

	public float MaxViewAngle;

	public float ViewDistance;

	public AnimationCurve AnimCurve;

	public float AngleReal;

	public float DistReal;

	public float ViewAngle;

	protected uint IAPBBEEDLCG;

	private BPFFGIOAGPE LAPJPJICGJD;

	private Vector3 FIDHDOCBDFJ;

	private Quaternion HAHAMBBCDGB;

	public float RotHorizontalRangeMinAngle;

	public float RotHorizontalRangeMaxAngle;

	public float OriginalForwardAngle;

	public Transform CachedEnemy;

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

	public BHGGAEEHJCO PIDInCannon()
	{
		return default(BHGGAEEHJCO);
	}

	public void UpdateCannonAllPartsRotation()
	{
	}

	protected override void OnStart()
	{
	}

	private void JKJJCEKCFKO()
	{
	}

	public uint GetAmmoID()
	{
		return 0u;
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

	private bool FALIDDEGDFB(Player KDJNEHDAAFL)
	{
		return false;
	}

	public void GetInOrOut(BHGGAEEHJCO MJBAGNLEIIL, bool NMMNOEDALPA)
	{
	}

	public void OnPlayerDeadInCannon()
	{
	}

	private void FGBAGJIMMIK(Player KDJNEHDAAFL, bool NMMNOEDALPA)
	{
	}

	private void IABKODJCEFJ()
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void OnCannonFire()
	{
	}

	private void MLBDFDIELLC()
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

	protected override void JHEFLJNCBPJ()
	{
	}

	protected override void OnModelShowed()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	protected override void FLFHMOGHICH(bool GMLCCOIKJGD)
	{
	}

	private void KNBIJNKGKBC()
	{
	}

	private void KKEAKCBBECB()
	{
	}

	private void GGMMPKGPCAI(uint GGAOIPIHOBP, bool LKFAPKCNACC, Object PCGMOOHAIDE)
	{
	}

	private void IEDNBHIJJNN(uint GGAOIPIHOBP, bool LKFAPKCNACC, Object PCGMOOHAIDE)
	{
	}

	private void IOPCNKDGGAP(GameObject HACIJIFIDKM)
	{
	}

	private void PAMADFLNLAI(ResourceID OCCLMDNGINA, GameObject HACIJIFIDKM)
	{
	}

	private void FIOFNPKABOP(GMECHKEDOJP JCONDDPFBKK, Vector3 LJADOJKNALD)
	{
	}

	private void IMGBIIDGCLE(GMECHKEDOJP JEPBEDKEKDN, Vector3 LJADOJKNALD)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public int GetCurrentHeat()
	{
		return 0;
	}

	public bool GetFireState()
	{
		return false;
	}

	public MDFIOMKMCEK GetData()
	{
		return null;
	}

	public int GetShotCount()
	{
		return 0;
	}

	public int GetTotalShotCount()
	{
		return 0;
	}

	public void SetVehicleData(uint GHIOJIHDBAL, uint EILJPLGANJG, uint DNMJOHLDACM)
	{
	}

	public Transform GetEnemyVehicle(Camera NJMENHHJHCJ)
	{
		return null;
	}

	private bool MOIDBNBNGIB(Transform HACIJIFIDKM, Camera NJMENHHJHCJ)
	{
		return false;
	}

	private void IPDEKFPAPOL(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	private bool CLKJLAGKIAK(CSVBaseData FADOEDJHAGD)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
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

	public void _003C_003EiFixBaseProxy_JHEFLJNCBPJ()
	{
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_FLFHMOGHICH(bool P0)
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
