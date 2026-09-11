using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMCRealisticMotorcycleController : MonoBehaviour, VehicleControllerInterface
{
	private sealed class _003CChangingGear_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RMCRealisticMotorcycleController _003C_003E4__this;

		public int gear;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChangingGear_003Ed__152(int _003C_003E1__state)
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

	protected bool engineRunning;

	public bool TryResetCar;

	private float resetTime;

	protected Rigidbody rigid;

	public MotorcycleWheelController FrontWheelCollider;

	public MotorcycleWheelController RearWheelCollider;

	public Transform Fender;

	public Transform SteeringHandlebar;

	public Transform FenderContainer;

	public Transform SteeringHandlebarContainer;

	public Transform COM;

	public Transform SkinContainer;

	protected bool m_ReachSpeedAndTurnMax;

	protected List<WheelColliderInterface> m_WheelColliders;

	protected Transform FrontWheelColliderTrans;

	protected Transform RearWheelColliderTrans;

	public bool changingGear;

	public float gearShiftRate;

	public float[] gearSpeed;

	public int currentGear;

	public int totalGears;

	public Transform chassis;

	public float chassisVerticalLean;

	public float chassisHorizontalLean;

	protected float horizontalLean;

	protected float verticalLean;

	public float MaxVerticalLean;

	public float MaxHorizontalLean;

	public float ChassisLenLerpFactor;

	public AnimationCurve[] engineTorqueCurve;

	public float EngineTorque;

	public float MaxEngineRPM;

	public float MinEngineRPM;

	public float m_SteerAngle;

	public int SpeedSteerAudio;

	public string SpeedSteerAudioResID;

	public float ClimbAdditionMinTorque;

	public float ClimbAdditionMaxTorque;

	public float ClimbForwardYMinDegree;

	public float ClimbForwardYMaxDegree;

	public float ClimbUpAddEngineScale;

	public float ReverseClimbUpAddEngineScale;

	public float StopDownHillAddBrakeScale;

	public float StopGoDownAddBrakeScale;

	public float CurAddTorqueShow;

	public float FlyAgainstGravityAcceleration;

	public float FlyAgainstGravityFrontRatio;

	public float FlyAgainstGravityRearRatio;

	public bool IsAWD;

	public float FastStopSpeed;

	public float FastStopBrake;

	private bool m_isBoosting;

	private float m_maxSpeedBackup;

	private float m_engineTorqueBackup;

	private float m_highSpeedSteerAngleBackup;

	private float m_EPSILON;

	protected float Speed;

	public float highSpeedSteerAngle;

	public float highSpeedSteerAngleAtSpeed;

	public float maxSpeed;

	public float Brake;

	protected float EngineRPM;

	protected float motorInput;

	protected float defsteerAngle;

	protected float RotationValue1;

	protected float RotationValue2;

	public float EngineRPMShow;

	private bool mModelVisible;

	public bool UpdateWheelTransforms;

	public float IdleBrakeInput;

	public bool brakingNow;

	protected float steerInput;

	public bool crashed;

	protected bool reversing;

	protected float mSpeedScale;

	protected float mDriverSpeedScale;

	public LayerMask ColliderMask;

	public float ReverseMaxSpeed;

	public float ReverseTorqueScale;

	protected TssSdtFloat mHighSpeedSteerAngleRate;

	protected TssSdtFloat mEngineTorqueRate;

	protected TssSdtFloat mBrakeTorqueRate;

	private bool m_IsInWater;

	protected float m_GearFactor;

	public bool Enable3PSimulate;

	protected float m_LockSpeed;

	public float CurrentSteerAngle;

	public Vector3 SteerAxis;

	public Transform VehicleCOM => null;

	public bool ReachSpeedAndTurnMax => false;

	public virtual List<WheelColliderInterface> WheelColliders => null;

	private int _totalGears => 0;

	public float SteerAngle => 0f;

	public float Velocity => 0f;

	public float CurEngineRPM => 0f;

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

	public int Direction => 0;

	public virtual bool IsGrounded => false;

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

	public VehicleControllerInfo ControllerInfo => null;

	protected virtual Transform VehicleTransform => null;

	public void SetControllerInfo(VehicleControllerInfo i)
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void InitInNeed()
	{
	}

	public AudioSource CreateAudioSource(string audioName, float minDistance, float volume, AudioClip audioClip, bool loop, bool playNow, bool destroyAfterFinished)
	{
		return null;
	}

	public void SoundsInitialize()
	{
	}

	public virtual void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	public virtual void FlyCarAgainstGravity()
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

	public void SetDriverSpeedScale(float scale)
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

	public float GetCurrentMaxSpeed()
	{
		return 0f;
	}

	public float GetCurrentMaxHighYSpeed()
	{
		return 0f;
	}

	public void VehicleLasyUpdate(float gameTime, float deltaTime)
	{
	}

	private void ResetCar(float deltaTime)
	{
	}

	protected virtual void InputHandle()
	{
	}

	public void UpdateVehicleSpeed(float rpm, float velocity)
	{
	}

	public void UpdateVehicleSteerAngle(float steerAngle)
	{
	}

	public virtual void VehicleUpdateInput(bool gas, bool brake, Vector3 steer)
	{
	}

	public virtual void VehicleUpdateInput(float gas, float brake, Vector3 steer)
	{
	}

	protected virtual void Engine()
	{
	}

	protected virtual void ApplyMotorTorque()
	{
	}

	public virtual void Braking()
	{
	}

	protected virtual void WheelAlign()
	{
	}

	protected virtual void RotateHandlebarFenders()
	{
	}

	public void ShiftGears()
	{
	}

	private IEnumerator ChangingGear(int gear)
	{
		return null;
	}

	protected virtual void Lean()
	{
	}

	public void SkidAudio()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public virtual void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}

	public virtual void KillEngine()
	{
	}

	public virtual void StartEngine()
	{
	}

	public virtual int GetWheelType(GameObject go)
	{
		return 0;
	}

	private int GetGearBySpeed(float velocity)
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

	public virtual void BindVehicleSkin(VehicleSkinInfoBase skin_info)
	{
	}

	public void SetJumpHeightRate(float rate)
	{
	}

	public void ForceStop()
	{
	}

	protected float GetClimbAddEngineOrBrakeTorque()
	{
		return 0f;
	}

	protected float GetCarForwardYAngle()
	{
		return 0f;
	}
}
