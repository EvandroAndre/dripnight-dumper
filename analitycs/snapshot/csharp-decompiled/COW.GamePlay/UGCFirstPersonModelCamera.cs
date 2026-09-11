using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class UGCFirstPersonModelCamera : FollowCamera, COW.GamePlay.CALHLIPMGMD<UGCCameraConfigRepItem>
{
	private Transform IBKKJOMIPGI;

	private Transform LCKHBCEAEOK;

	public float minDeflectionAngle;

	public float maxDeflectionAngle;

	public float ballRadius;

	public int filterRecordMax;

	public float filterRecordLerp;

	public int filterRecordIndex;

	public Vector3[] filterRecord;

	public Vector3 firstFollowPosOffset;

	public Vector3 CreepFollowPosOffset;

	public Vector3 deadPosOffset;

	public string swingBindBoneName;

	public string forwardBindBoneName;

	public float Stabilization;

	public bool useTestRotate;

	public Vector3 testRotate;

	public Vector3 testCrouchRotate;

	public Vector3 testCrawlRotate;

	public float runForwardMaxMagnitude;

	public float runForwardSpeed;

	public float runForwardRevertSpeed;

	private float EBBAKDPHOOM;

	private float KPLCKBJABFH;

	private bool HCBOCFLIIFH;

	private float FKDPPIDNMLK;

	private float OENLFCBDMBO;

	private bool AKEBJBPKBIJ;

	private VisualInstanceHolder LNAJJAECBFB;

	private Camera PIEPMPLHHMF;

	private readonly CKIFHNOIGJM KNBPCFLHANH;

	private Vector3 HKEOMKFHGID;

	public override Vector3 FNAMPFFAMBD => default(Vector3);

	public override Quaternion DEIEGHLADGP => default(Quaternion);

	public Vector3 LerpRotate(Vector3 PFJFADHEJLJ)
	{
		return default(Vector3);
	}

	public override float GetFovNormal()
	{
		return 0f;
	}

	protected override void AAJBLNPFLOB()
	{
	}

	private Vector3 KNJEIJMOBHH()
	{
		return default(Vector3);
	}

	protected Quaternion JOFAFJAELGL()
	{
		return default(Quaternion);
	}

	private Vector3 BCBNONJHKLN()
	{
		return default(Vector3);
	}

	public void PlayFireEffect()
	{
	}

	public override float GetCapSuleOffsetZ()
	{
		return 0f;
	}

	protected override void ODOLOHHIKGN()
	{
	}

	public override void OnCameraUnLoaded()
	{
	}

	public override void OnCameraChanged()
	{
	}

	private void BDCNBBGGHDA(GameObject KGJNMPHDKAB)
	{
	}

	public override void RefreshState(UGCCameraConfigRepItem ICDHKINICGE)
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

	public void _003C_003EiFixBaseProxy_OnCameraUnLoaded()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshState(UGCCameraConfigRepItem P0)
	{
	}
}
