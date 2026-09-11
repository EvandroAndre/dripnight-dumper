using UnityEngine;

namespace COW.GamePlay;

public class HorseObstacleAvoidance : MonoBehaviour
{
	public float WallHitPositionOffset;

	public float WallHitPositionOffsetHigh;

	public float WallSlideTangentScale;

	public float WallHitHighSpeedThreshold;

	public float WallSlideCooldown;

	public float WallSlideNormalOutwardScale;

	public float WallSlideNormalOutwardMin;

	public float WallSlideNormalOutwardScaleLow;

	public float WallSlideNormalOutwardMinLow;

	public float WallHitPositionOffsetSpeedScale;

	public float CollisionSlideYawLerp;

	private float LIMFLCPLMIG;

	public float PerpendicularTangentThreshold;

	public float MinSlideSpeedWhenPerpendicular;

	public float TriggerPreSlideBlend;

	public float TriggerSlideYawLerp;

	public float CornerStickDotThreshold;

	public float WallDirectionChangeCooldown;

	public float MinDotToSwitchDuringCooldown;

	public float WallStaySteerDuration;

	public float WallStayYawLerp;

	private Rigidbody ELGFFDMMMKB;

	private float PHKJBLGFFCE;

	private float ACHFAHIAAFP;

	private Vector3 PFONDMEEAJN;

	private float EOAJHBJCPOD;

	private const float PBNAJDJAGHO = 0.0001f;

	private const int BCACIJMIMLK = 8;

	private const float HAPGPCNPOII = -0.1f;

	private static readonly Vector3 HNFMEPODHGP;

	private const float PLECBBEKFKM = 0.55f;

	private const float GMHEPKFGLDA = 0.75f;

	private ContactPoint[] NGEDCHCHNKO;

	private int NFCFHCJGIEI;

	private int GOAKPLFNHKD;

	private bool OALDCGHBJNO;

	private bool FLKJNKADNIP;

	private Vector3 FPGFAHEKIAE;

	private Vector3 BHMPCHBBLJC;

	private const float DJMMOBMBGIO = 0.0025f;

	private const float ODJLEIPDPGF = 0.999f;

	private const int GEFFKINHKMG = 4;

	private int AEIMGDDGLFA;

	private int HJFNBCLAMHM;

	private readonly Vector3[] KFGGCKBHBAE;

	private readonly bool[] EMDFODIIGDI;

	private const float NIIPHOFMHDP = 0.9995f;

	private bool IFFMIPGAOAB => false;

	private bool CNCHLNCEPIP => false;

	private Vector3 JBAABGCFDPB()
	{
		return default(Vector3);
	}

	private void ODKNEFFHJCB(Vector3 AAAOADBFHJG)
	{
	}

	public void ApplyWallStayYawLerp(Rigidbody DGGPEJGHEIP, bool NOHBHOKNKIB)
	{
	}

	public void OnCollisionHitStaticObject(Collision MKPLDLFKAIK, Rigidbody IOBHEBBOILM)
	{
	}

	private void NENBMKFKMEI(Collision MKPLDLFKAIK, Rigidbody IOBHEBBOILM)
	{
	}

	private bool NLDBGIOCODB(Collision MKPLDLFKAIK, Rigidbody DGGPEJGHEIP, out Vector3 LNFAEDLGHHO, out Vector3 KNCIFOJPGGP, out float KOFBCENOPOP)
	{
		LNFAEDLGHHO = default(Vector3);
		KNCIFOJPGGP = default(Vector3);
		KOFBCENOPOP = default(float);
		return false;
	}

	private int MNBNCNCBDKC(Collision MKPLDLFKAIK)
	{
		return 0;
	}

	private void FBJLDJNIFEL(Vector3 LNFAEDLGHHO, Transform FAALEOOPLOE)
	{
	}

	private Vector3 IHLCIDNPCEO(Vector3 LNFAEDLGHHO, Vector3 JNPOBHKLBIO, Transform FAALEOOPLOE, bool APPJBGHOIED, float KOFBCENOPOP)
	{
		return default(Vector3);
	}

	private void OCKGENMONOP(Rigidbody MHHPLOFLGKP, Vector3 OAMHENLAFHP, Vector3 JNPOBHKLBIO, float PGNLGBGJKKM, float CACOCFHJCHG)
	{
	}

	private bool PJDIBLCNDIB(Rigidbody MHHPLOFLGKP, Vector3 OAMHENLAFHP)
	{
		return false;
	}

	private bool DEKBJAABEDP(Vector3 CMLHEABHDGM, out bool EMANEBGLLJG)
	{
		EMANEBGLLJG = default(bool);
		return false;
	}

	private void BNFFHMGFJDM(Vector3 CMLHEABHDGM, bool EMANEBGLLJG)
	{
	}

	private bool CIFNKKCCGCG(Rigidbody MHHPLOFLGKP, Quaternion GGMNCBLHMAE, Vector3 BAJCOCKEAAK)
	{
		return false;
	}

	private bool OPLFGCABEOJ(Rigidbody MHHPLOFLGKP)
	{
		return false;
	}

	private bool CDBONINPMHD(Collision MKPLDLFKAIK, Rigidbody MHHPLOFLGKP, Vector3 OAMHENLAFHP)
	{
		return false;
	}

	private Vector3 NFAPILNGKIM(Collision MKPLDLFKAIK, Rigidbody MHHPLOFLGKP, Vector3 JNPOBHKLBIO, Vector3 GGEKCLCINCK)
	{
		return default(Vector3);
	}

	private Vector3 DPHAKGBFEDB(ContactPoint BHAHBHMNMGB)
	{
		return default(Vector3);
	}

	private Vector3 DNPALIBCLLJ(Vector3 JNPOBHKLBIO, Vector3 GLBPGGBJFFI)
	{
		return default(Vector3);
	}

	private void AAKGMMELFCE()
	{
	}

	private void KCAHCKKJKHP()
	{
	}

	private int DBIMFLPELJM()
	{
		return 0;
	}

	public void SetEnterLevelTrigger(Collider GLJGHEAPBOF, bool PDEMMOBBACC)
	{
	}

	public void SetStayLevelTrigger(Collider GLJGHEAPBOF)
	{
	}

	private void NCKODKEICHD(Collider GLJGHEAPBOF)
	{
	}

	private void EAAMMGFADBJ(Collider GLJGHEAPBOF, float PGNLGBGJKKM)
	{
	}
}
