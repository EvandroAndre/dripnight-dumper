using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class ArcGenerator : MonoBehaviour
{
	public enum FDCKHAJOMHN
	{
		PathType_Line,
		PathType_LeftRadian,
		PathType_RightRadian,
		PathType_UpRadian,
		PathType_DownRadian
	}

	public class OODNHPHGKBA
	{
		public int ABHFDDCCINN;

		public int LLKCBIFDLEC;

		public FDCKHAJOMHN BEMEECCFLCM;

		public float KMMLHGBPKME;

		public float DHICBGKAJPG;
	}

	public int MePrefabID;

	private string EKOFMOJCBKN;

	public Transform ModelRoot;

	public Transform pointA;

	public Transform pointB;

	public FDCKHAJOMHN PathType;

	public float AngleDegrees;

	public float LineStandardLength;

	public float LineLengthScale;

	private Transform HKGGGKFOBPN;

	private bool BFHDODFCHFO;

	private Vector3 BOHEBDDBMGH;

	private Vector3 FEPLHMDDBGA;

	private float FFPLAJMAGOP;

	public int m_GroupID;

	public int m_Number;

	public BoxCollider LinePathBoxCollderTrigger;

	private const float EGGCKEFMPGH = 4f;

	private Material OLCMODJPICL;

	private LineRenderer IPJGCHAFPKP;

	private Color KJEFKMCPNFO;

	private Color DPBGGEENHAJ;

	private bool HOGDMILLCGK;

	private bool CHJDBGBADBJ;

	public FDCKHAJOMHN FNMFIOMAAPP => FDCKHAJOMHN.PathType_Line;

	public Transform MPOOOIBOAOF => null;

	public Vector3 DGGCKBGKIEM => default(Vector3);

	public Vector3 GLBGLJPNIAJ => default(Vector3);

	public float DLLEBHAOBOD => 0f;

	public int JEOLAJOGNMG
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EHHKGEIPEPN
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void DebugToggleShowLineRender()
	{
	}

	public void ChangeArchColor(bool NGNJFIIBHHJ)
	{
	}

	public void MultGameInitGroupAndModelName(OODNHPHGKBA DNLOAIJHEGL)
	{
	}

	public void PostCreateRegisterAndCalcArcInfo()
	{
	}

	public void InitLineBoxColliderSizeAndCenter()
	{
	}

	private void IEFGDMOONLM()
	{
	}

	private void FMNLODIHFFE()
	{
	}

	private void LLOADEFMONN()
	{
	}

	private void MMMJBOCLEKJ(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void OEKOBEDBNMI(GameObject KGJNMPHDKAB)
	{
	}

	private bool ELMMMEDNFAL()
	{
		return false;
	}

	private void IAJBEHHHEKJ()
	{
	}

	private void KALMOIIIKBP()
	{
	}

	private void LENNNJGDLKE()
	{
	}

	public bool IsCanTriggerArcRun(Vector3 KKGOELFBELN, float CFEAAKGKJPE, ref Vector3 IOGJGBCJLOF)
	{
		return false;
	}

	public POECFMGBOLN CalcArcRunDirType(Vector3 DGPAAJKLJJJ, Vector3 AAMHGCIOFOK)
	{
		return POECFMGBOLN.ArcRunDirType_Clockwise;
	}

	public Vector3 GetPointTangentForward(Vector3 KKGOELFBELN, POECFMGBOLN OLJMPCJCCHN)
	{
		return default(Vector3);
	}

	public Vector3 GetXZFowardOnArc(Vector3 CABDCBCFAJM, POECFMGBOLN OLJMPCJCCHN)
	{
		return default(Vector3);
	}

	public void CalcOnceMoveTargetPoint(float LFKCCCACLOH, Vector3 MNNOKGKFAHJ, POECFMGBOLN OLJMPCJCCHN, EKOFDDAKHEB EBAOFOLHJLL)
	{
	}

	private Vector3 MMOFBOIFLDG(Vector3 KKGOELFBELN)
	{
		return default(Vector3);
	}

	private Vector3 DJLOJALMCKC(Vector3 KKGOELFBELN)
	{
		return default(Vector3);
	}

	private Vector3 BDDBHKKPHPK(Vector3 KKGOELFBELN)
	{
		return default(Vector3);
	}
}
