using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class VehicleJumpController : MonoBehaviour, VehicleControllerInterface
{
	public Rigidbody m_Rigid;

	public RCC_WheelCollider[] m_Wheels;

	public CarJumpParam m_Param;

	public float m_BoostDirYOffSet;

	public MotorcycleWheelController[] m_MotorcycleWheels;

	protected Vector3 EAKBCBHBIDO;

	protected bool JLOJHLOFFKC;

	protected float JAJJIOGDDKB;

	protected int LPGKAHPHGIG;

	private const int POCKDGBJODO = 3;

	private TssSdtFloat JABJAIFFFCE;

	protected float IBFGEOJLKLH;

	private float _003CBIBELMILFPL_003Ek__BackingField;

	private int _003CAJMAHAEADMA_003Ek__BackingField;

	private float _003CMPMONBGPEHG_003Ek__BackingField;

	private bool _003CKHNMJGKDMIO_003Ek__BackingField;

	private float _003CBCNEGAJCJDI_003Ek__BackingField;

	private float _003CLJCILIPFLHO_003Ek__BackingField;

	protected float KFBDKCAEEMF;

	private float _003CCOMABBCMDLI_003Ek__BackingField;

	private bool NPNDCGCJKIK;

	private List<WheelColliderInterface> BMCKBOFHFIF;

	public bool NANDHBHCEHO => false;

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

	public VehicleControllerInfo DIGLGAPOMOP => null;

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

	public Transform CCEJKFHBMAB => null;

	public float AAPGPMPKMBD => 0f;

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

	public List<WheelColliderInterface> EDPKEIGPCOH => null;

	public bool NJHEMAJLAMM => false;

	public float CaculateVehicleRevs()
	{
		return 0f;
	}

	public int GetWheelType(GameObject CLACOPMJHDI)
	{
		return 0;
	}

	public void SetJumpHeightRate(float JAMCOPNBGFD)
	{
	}

	public void StartBoost(float OMOJGCCJFLO, float LLNANNNALIE, float AOOCNKPILEO, bool MPMKADBEBCJ = false)
	{
	}

	public void StopBoost()
	{
	}

	public void SetControllerInfo(VehicleControllerInfo GNLIAKMGDDG)
	{
	}

	public void SetDriverSpeedScale(float GLPLIHEECAP)
	{
	}

	public float GetDriverSpeedScale()
	{
		return 0f;
	}

	public void SetMaxSpeedScale(float GLPLIHEECAP)
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

	public void SetHightSpeedSteerAngleRate(float JAMCOPNBGFD)
	{
	}

	public virtual void SetEngineTorqueRate(float JAMCOPNBGFD)
	{
	}

	public virtual void SetBrakeTorqueRate(float JAMCOPNBGFD)
	{
	}

	public virtual float GetEngineTorqueRate()
	{
		return 0f;
	}

	public virtual float GetBrakeTorqueRate()
	{
		return 0f;
	}

	public void SetVehicleEnable(bool AOOAGBBHDFA, bool KKKHNJPPGNC = false)
	{
	}

	public void Active()
	{
	}

	public void StartEngine()
	{
	}

	public void KillEngine()
	{
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

	protected virtual void OHLAGAAKGBF(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void VehicleLazyFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void VehicleUpdateInput(bool NCPIMBDABPG, bool FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	public virtual void VehicleUpdateInput(float NCPIMBDABPG, float FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	protected virtual void OBDOJJKOLKD()
	{
	}

	public void BindVehicleSkin(VehicleSkinInfoBase HDIFMBJLEJC)
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
