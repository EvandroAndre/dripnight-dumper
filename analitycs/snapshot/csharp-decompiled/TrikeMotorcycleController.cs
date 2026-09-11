using System;
using System.Collections.Generic;
using UnityEngine;

public class TrikeMotorcycleController : RMCRealisticMotorcycleController
{
	public MotorcycleWheelController SideWheelCollider;

	protected float RotationValue3;

	protected Transform SideWheelColliderTrans;

	public float SideWheelLeanThreshold;

	private float m_ChassisBaseHeight;

	private float m_RearWheersDistance;

	public float LeanPosAdjustFactor;

	public float antiRollRearHorizontal;

	public bool RotateSteeringHandlerAlongGlobalY;

	private const float EngineRpmMul = (float)Math.PI * 3f / 50f;

	public override bool IsGrounded => false;

	public override List<WheelColliderInterface> WheelColliders => null;

	public override int GetWheelType(GameObject go)
	{
		return 0;
	}

	protected override void Start()
	{
	}

	public override void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	public override void FlyCarAgainstGravity()
	{
	}

	protected override void InputHandle()
	{
	}

	protected override void Engine()
	{
	}

	protected override void ApplyMotorTorque()
	{
	}

	private void ApplyMotorTorque(WheelCollider wheel, float torque)
	{
	}

	public override void Braking()
	{
	}

	protected override void WheelAlign()
	{
	}

	private void WheelAlign(WheelCollider wheelCol, Transform wheelColTrans, Transform wheelTrans, ref float rot)
	{
	}

	protected override void RotateHandlebarFenders()
	{
	}

	protected override void Lean()
	{
	}

	private void AntiRollBars()
	{
	}

	public override void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}
}
