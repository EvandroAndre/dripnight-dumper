using UnityEngine;

namespace COW.GamePlay;

public class ParachutejumpCarController : MonoBehaviour, VehicleControllerInterface
{
	public enum NJFMLKBOHFB
	{
		None,
		OnBoard,
		SkyDiving,
		Parachuting
	}

	public delegate void FENOCKJJBAJ(NJFMLKBOHFB GBFCLDILKOG);

	public delegate void PFALBFNHBOA(NJFMLKBOHFB GBFCLDILKOG, float OKJIFBCMDAD, float HOGHEFNINAE);

	public Transform VehicleMeshBody;

	protected Rigidbody FMIGAHAFFLL;

	public NJFMLKBOHFB CurKinematicState;

	public FENOCKJJBAJ onParachuteStateChange;

	public PFALBFNHBOA onParachuteStateTick;

	private bool _003CKHNMJGKDMIO_003Ek__BackingField;

	private float _003CBCNEGAJCJDI_003Ek__BackingField;

	private float _003CIJFJOJBBKNF_003Ek__BackingField;

	private float _003CMPMONBGPEHG_003Ek__BackingField;

	private float _003CBIBELMILFPL_003Ek__BackingField;

	private float _003CLJCILIPFLHO_003Ek__BackingField;

	private int _003CAJMAHAEADMA_003Ek__BackingField;

	private bool _003CLCNEAHAPNAK_003Ek__BackingField;

	private float _003CCOMABBCMDLI_003Ek__BackingField;

	private bool NPNDCGCJKIK;

	private Transform _003CJPMCDPNFDEG_003Ek__BackingField;

	private VehicleControllerInfo _003CHCKBHPAFIPO_003Ek__BackingField;

	private bool NALHKOMPFMF;

	private Vector3 IHLMACFBDFJ;

	private float ECLPHAHNDPI;

	private float GPPDAEGIINM;

	private float LFJMPKGJNII;

	private Vector3 BMNLHFJNCLK;

	public bool NANDHBHCEHO => false;

	public bool NJNPAJDNMEI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float JEKAJGBHPGL
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float AAPGPMPKMBD
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float EOONEBKLFFG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DEBMKOBDPHC
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float HNDHIFGGPDK
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int AIGPMFLKHLC
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool NJHEMAJLAMM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float CNDLPFDAFEF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool FGMDKNNKGNJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform CCEJKFHBMAB
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VehicleControllerInfo DIGLGAPOMOP
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float CaculateVehicleRevs()
	{
		return 0f;
	}

	public void SetJumpHeightRate(float JAMCOPNBGFD)
	{
	}

	public void BindVehicleSkin(VehicleSkinInfoBase HDIFMBJLEJC)
	{
	}

	public void SetControllerInfo(VehicleControllerInfo GNLIAKMGDDG)
	{
	}

	public void SetVehicleEnable(bool AOOAGBBHDFA, bool KKKHNJPPGNC = false)
	{
	}

	public void SetMaxSpeedScale(float GLPLIHEECAP)
	{
	}

	public void SetHightSpeedSteerAngleRate(float JAMCOPNBGFD)
	{
	}

	public void SetEngineTorqueRate(float JAMCOPNBGFD)
	{
	}

	public void SetBrakeTorqueRate(float JAMCOPNBGFD)
	{
	}

	public void SetDriverSpeedScale(float GLPLIHEECAP)
	{
	}

	public float GetCurrentMaxSpeed()
	{
		return 0f;
	}

	public float GetCurrentMaxHighYSpeed()
	{
		return 0f;
	}

	public float GetEngineTorqueRate()
	{
		return 0f;
	}

	public float GetBrakeTorqueRate()
	{
		return 0f;
	}

	public float GetDriverSpeedScale()
	{
		return 0f;
	}

	public void UpdateVehicleSpeed(float IFGACJFFEGC, float KMFMICABCFL)
	{
	}

	public void UpdateVehicleSteerAngle(float FGLFEJPBFOD)
	{
	}

	public void VehicleLasyUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void KillEngine()
	{
	}

	public int GetWheelType(GameObject CLACOPMJHDI)
	{
		return 0;
	}

	public void StartBoost(float OMOJGCCJFLO, float LLNANNNALIE, float AOOCNKPILEO, bool MPMKADBEBCJ = false)
	{
	}

	public void StopBoost()
	{
	}

	protected void Awake()
	{
	}

	public void StartEngine()
	{
	}

	public void VehicleUpdateInput(bool NCPIMBDABPG, bool FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	public void VehicleUpdateInput(float NCPIMBDABPG, float FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	public void ChangeToKinematicState(NJFMLKBOHFB AOEDHPLKMNI)
	{
	}

	public void VehicleLazyFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void FixedUpdateOnBoard(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void FixdUpdateSkiDiving(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void FixdUpdateParachuting(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void NBNDEDMCHOE(float HOGHEFNINAE, float DJMLCMBGONM, float NEGFHOCMPJM, float FECODMKJCOB, float KOJJCFHPGJC)
	{
	}

	private void LECGHCPLHNJ(float HOGHEFNINAE, float ANLMIMBKHEC)
	{
	}

	public void LockMaxSpeed(float IMKNJGHAHPI)
	{
	}

	public void UnLockMaxSpeed()
	{
	}

	public void ForceStop()
	{
	}
}
