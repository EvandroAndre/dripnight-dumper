using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCC_CarControllerV3 : MonoBehaviour, VehicleControllerInterface
{
	public enum WheelType
	{
		FWD,
		RWD,
		AWD,
		BIASED
	}

	public enum IndicatorsOn
	{
		Off,
		Right,
		Left,
		All
	}

	private sealed class _003CChangingGear_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RCC_CarControllerV3 _003C_003E4__this;

		public int gear;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChangingGear_003Ed__223(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	protected Rigidbody rigid;

	internal bool sleepingRigid;

	public bool AIController;

	public RCC_WheelCollider FrontLeftWheelCollider;

	public Action ChangeGearDele;

	public RCC_WheelCollider FrontRightWheelCollider;

	public RCC_WheelCollider RearLeftWheelCollider;

	public RCC_WheelCollider RearRightWheelCollider;

	internal RCC_WheelCollider[] allWheelColliders;

	public Transform[] ExtraRearWheelsTransform;

	public RCC_WheelCollider[] ExtraRearWheelsCollider;

	public bool applyEngineTorqueToExtraRearWheelColliders;

	public Transform SteeringWheel;

	public WheelType WheelTypeChoise;

	public float biasedWheelTorque;

	public Transform COM;

	public Transform SkinContainer;

	public Transform SteeringWheelContainer;

	private List<RCC_WheelCollider> m_WheelColliders;

	public bool canControl;

	public bool engineRunning;

	public bool semiAutomaticGear;

	private bool canGoReverseNow;

	public AnimationCurve[] engineTorqueCurve;

	public float[] gearSpeed;

	public float engineTorque;

	public float brakeTorque;

	public float maxEngineRPM;

	public float minEngineRPM;

	public float engineInertia;

	public bool useRevLimiter;

	public bool useExhaustFlame;

	public float steerAngle;

	public int SpeedSteerAudio;

	public string SpeedSteerAudioResID;

	public float highspeedsteerAngle;

	public float highspeedsteerAngleAtspeed;

	public float antiRollFrontHorizontal;

	public float antiRollRearHorizontal;

	public float antiRollVertical;

	public float downForce;

	private float speed;

	public Transform RootTrans;

	public float defMaxSpeed;

	public float maxspeed;

	private float mSpeedScale;

	protected float mDriverSpeedScale;

	private float m_MaxSpeedChangePrecent;

	private float resetTime;

	private float orgSteerAngle;

	private float fuelInput;

	public int currentGear;

	public int totalGears;

	public float gearShiftingDelay;

	public bool changingGear;

	private int direction;

	private bool m_ReachSpeedAndTurnMax;

	public bool autoGenerateGearCurves;

	public bool autoGenerateTargetSpeedsForChangingGear;

	private bool mModelVisible;

	private float gasInput;

	private float brakeInput;

	private float steerInput;

	public float clutchInput;

	public float handbrakeInput;

	public float boostInput;

	public bool cutGas;

	public float idleInput;

	private bool m_IsInWater;

	internal float engineRPM;

	internal float rawEngineRPM;

	public float EngineRPMShow;

	public IndicatorsOn indicatorsOn;

	public float indicatorTimer;

	private float oldRotation;

	public Transform velocityDirection;

	public Transform steeringDirection;

	public float velocityAngle;

	private float angle;

	private float angularVelo;

	public bool ABS;

	public bool TCS;

	public bool ESP;

	public bool steeringHelper;

	public bool tractionHelper;

	public float ABSThreshold;

	public float TCSThreshold;

	public float TCSStrength;

	public float ESPThreshold;

	public float ESPStrength;

	public float steerHelperLinearVelStrength;

	public float steerHelperAngularVelStrength;

	public float tractionHelperStrength;

	public bool ABSAct;

	public bool TCSAct;

	public bool ESPAct;

	public bool overSteering;

	public bool underSteering;

	internal float driftAngle;

	internal bool driftingNow;

	private bool applyCounterSteering;

	public float frontCamber;

	public float rearCamber;

	public float frontSlip;

	public float rearSlip;

	public float turboBoost;

	public float NoS;

	public bool useNOS;

	public bool useTurbo;

	private RCC_Camera carCamera;

	private float m_GearFactor;

	public float IdleBrakeInput;

	public float ClimbAdditionMinTorque;

	public float ClimbAdditionMaxTorque;

	public float ClimbForwardYMinDegree;

	public float ClimbForwardYMaxDegree;

	public float ClimbUpAddEngineScale;

	public float ReverseClimbUpAddEngineScale;

	public float StopDownHillAddBrakeScale;

	public float StopGoDownAddBrakeScale;

	public float CurAddTorqueShow;

	public float ReverseMaxSpeed;

	public float ReverseTorqueScale;

	public float FlyAgainstGravityAcceleration;

	public float FlyAgainstGravityFrontRatio;

	public float FlyAgainstGravityRearRatio;

	public float FlyAnainstGravityRollRatio;

	private bool m_isBoosting;

	private float m_maxSpeedBackup;

	private float m_engineTorqueBackup;

	private float m_highSpeedSteerAngleBackup;

	private TssSdtFloat mHighSpeedSteerAngleRate;

	private TssSdtFloat mEngineTorqueRate;

	private TssSdtFloat mBrakeTorqueRate;

	private float originDefMaxSpeed;

	private AnimationCurve[] originEngineTorqueCurve;

	private float[] originGearSpeed;

	public Vector3 mobileDirction;

	protected float m_LockSpeed;

	private RCC_Settings RCCSettings => null;

	public Transform VehicleCOM => null;

	public List<RCC_WheelCollider> WheelColliders => null;

	public bool autoReverse => false;

	public bool automaticGear => false;

	public float SteerAngle => 0f;

	public float Velocity => 0f;

	public int Direction => 0;

	public bool ReachSpeedAndTurnMax => false;

	public virtual bool IsGrounded => false;

	public bool ModelVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float GasInput => 0f;

	public float BrakeInput => 0f;

	public float SteerInput => 0f;

	internal float _gasInput
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal float _brakeInput
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal float _boostInput
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsInWater
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float CurEngineRPM => 0f;

	public VehicleControllerInfo ControllerInfo => null;

	public float GetCurrentMaxSpeed()
	{
		return 0f;
	}

	public float GetCurrentMaxHighYSpeed()
	{
		return 0f;
	}

	public float GetCurrentReverseMaxSpeed()
	{
		return 0f;
	}

	public void SetControllerInfo(VehicleControllerInfo i)
	{
	}

	public void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}

	protected void Awake()
	{
	}

	public virtual void KillEngine()
	{
	}

	public virtual void StartEngine()
	{
	}

	public virtual void VehicleUpdateInput(bool gas, bool brake, Vector3 steer)
	{
	}

	public virtual void VehicleUpdateInput(float gas, float brake, Vector3 steer)
	{
	}

	public void VehicleLasyUpdate(float gameTime, float deltaTime)
	{
	}

	private void Inputs()
	{
	}

	public virtual void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	public void SetMaxSpeedScale(float scale)
	{
	}

	public void SetHightSpeedSteerAngleRate(float rate)
	{
	}

	public void SetEngineTorqueRate(float rate)
	{
	}

	public void SetBrakeTorqueRate(float rate)
	{
	}

	public float GetEngineTorqueRate()
	{
		return 0f;
	}

	public float GetBrakeTorqueRate()
	{
		return 0f;
	}

	public void SetDriverSpeedScale(float scale)
	{
	}

	public float GetDriverSpeedScale()
	{
		return 0f;
	}

	public void LockMaxSpeed(float speed)
	{
	}

	public void UnLockMaxSpeed()
	{
	}

	private void Engine(float fixedDeltaTime)
	{
	}

	private void ApplyMotorTorque(RCC_WheelCollider wc, float torque)
	{
	}

	private void ESPCheck(float velocity, float steering)
	{
	}

	private void ApplyBrakeTorque(RCC_WheelCollider wc, float brake)
	{
	}

	private void ApplySteering(RCC_WheelCollider wc)
	{
	}

	private void Braking()
	{
	}

	private float GetClimbAddEngineOrBrakeTorque()
	{
		return 0f;
	}

	private float GetCarForwardYAngle()
	{
		return 0f;
	}

	private float GetCarForwardZAngle()
	{
		return 0f;
	}

	private void AntiRollBars()
	{
	}

	private void SteerHelper()
	{
	}

	private void TractionHelper()
	{
	}

	private void Clutch(float deltaTime)
	{
	}

	private void GearBox()
	{
	}

	internal IEnumerator ChangingGear(int gear)
	{
		return null;
	}

	private void RevLimiter()
	{
	}

	private void Turbo()
	{
	}

	private void DriftVariables()
	{
	}

	private void ResetCar(float deltaTime)
	{
	}

	private bool OverTorque()
	{
		return false;
	}

	public void TorqueCurve()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateVehicleSpeed(float rpm, float velocity)
	{
	}

	public void UpdateVehicleSteerAngle(float steerAngle)
	{
	}

	public int GetWheelType(GameObject go)
	{
		return 0;
	}

	public float CaculateVehicleRevs()
	{
		return 0f;
	}

	public void StartBoost(float torque, float maxSpeed, float angle, bool ingoreVelocityChange = false)
	{
	}

	public void StopBoost()
	{
	}

	public void BindVehicleSkin(VehicleSkinInfoBase skin_info)
	{
	}

	public void SetJumpHeightRate(float rate)
	{
	}

	public void ForceStop()
	{
	}
}
