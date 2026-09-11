using UnityEngine;

namespace COW.GamePlay;

internal class UGCFirstPersonCamera : FollowCamera, COW.GamePlay.CALHLIPMGMD<UGCCameraConfigRepItem>
{
	private Transform IBKKJOMIPGI;

	private Transform LCKHBCEAEOK;

	public string swingBindBoneName;

	public string forwardBindBoneName;

	public float ballRadius;

	public Vector3 firstFollowPosOffset;

	public Vector3 CreepFollowPosOffset;

	public Vector3 deadPosOffset;

	public float minDeflectionAngle;

	public float maxDeflectionAngle;

	public int filterRecordMax;

	public float filterRecordLerp;

	public int filterRecordIndex;

	public Vector3[] filterRecord;

	private Vector3 GDELMDBMHCO;

	public float lerpStep;

	public float walkingLerp;

	public int startAndStopLerpFrame;

	private int NBENAJFENOA;

	private bool DBBAOGLAHKN;

	public float distance;

	public float rayCastdIstance;

	public int distanceFrame;

	private int GIEOLHDKDBP;

	public bool useTestRotate;

	public Vector3 testRotate;

	public Vector3 testCrouchRotate;

	private readonly CKIFHNOIGJM KNBPCFLHANH;

	public override Vector3 FNAMPFFAMBD => default(Vector3);

	public override Quaternion DEIEGHLADGP => default(Quaternion);

	public override float GetFovNormal()
	{
		return 0f;
	}

	protected override void AAJBLNPFLOB()
	{
	}

	private Vector3 BCBNONJHKLN()
	{
		return default(Vector3);
	}

	private Vector3 LBLGOKDFKPE(Vector3 CLHCDPPLLDJ)
	{
		return default(Vector3);
	}

	private Vector3 KNJEIJMOBHH()
	{
		return default(Vector3);
	}

	public override float GetCapSuleOffsetZ()
	{
		return 0f;
	}

	protected Quaternion JOFAFJAELGL()
	{
		return default(Quaternion);
	}

	protected override void ODOLOHHIKGN()
	{
	}

	public override void OnCameraChanged()
	{
	}

	public override void RefreshState(UGCCameraConfigRepItem ICDHKINICGE)
	{
	}

	public new void InitManually(KMBEHIGOKNF LAIDKEINKFG, float FFADCBDFANJ, float HMCHAKDHAKE, float GOKHJBJHCLK, float CGGPBJKCDEG, Vector3 DFNHOKCIIJK, NHMBEJGPEMP CJPNFPLEDPA, CIDCDEOCLBA OAGMEDEPKML, FDACAOPGNJK FPJMDJMMDBL)
	{
	}

	public new void UninitManually()
	{
	}

	public float _003C_003EiFixBaseProxy_GetFovNormal()
	{
		return 0f;
	}

	public new Vector3 _003C_003EiFixBaseProxy_get_TransTargetPos()
	{
		return default(Vector3);
	}

	public new Quaternion _003C_003EiFixBaseProxy_get_TransTargetRot()
	{
		return default(Quaternion);
	}

	public new void _003C_003EiFixBaseProxy_AAJBLNPFLOB()
	{
	}

	public float _003C_003EiFixBaseProxy_GetCapSuleOffsetZ()
	{
		return 0f;
	}

	public new void _003C_003EiFixBaseProxy_ODOLOHHIKGN()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshState(UGCCameraConfigRepItem P0)
	{
	}
}
