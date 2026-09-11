using UnityEngine;

public interface VehicleControllerInterface
{
	bool ModelVisible { get; set; }

	bool ReachSpeedAndTurnMax { get; }

	float SteerAngle { get; }

	float Velocity { get; }

	float GasInput { get; }

	float BrakeInput { get; }

	float SteerInput { get; }

	int Direction { get; }

	bool IsGrounded { get; }

	float CurEngineRPM { get; }

	bool IsInWater { get; set; }

	Transform VehicleCOM { get; }

	VehicleControllerInfo ControllerInfo { get; }

	float CaculateVehicleRevs();

	void BindVehicleSkin(VehicleSkinInfoBase skin_info);

	void SetControllerInfo(VehicleControllerInfo i);

	void SetVehicleEnable(bool isEnable, bool switchController = false);

	void SetMaxSpeedScale(float scale);

	float GetCurrentMaxSpeed();

	float GetCurrentMaxHighYSpeed();

	void SetDriverSpeedScale(float scale);

	float GetDriverSpeedScale();

	void LockMaxSpeed(float speed);

	void UnLockMaxSpeed();

	void UpdateVehicleSpeed(float rpm, float velocity);

	void UpdateVehicleSteerAngle(float steerAngle);

	void VehicleLazyFixedUpdate(float gameTime, float deltaTime);

	void VehicleLasyUpdate(float gameTime, float deltaTime);

	void VehicleUpdateInput(bool gas, bool brake, Vector3 steer);

	void VehicleUpdateInput(float gas, float brake, Vector3 steer);

	void KillEngine();

	void StartEngine();

	int GetWheelType(GameObject go);

	void StartBoost(float torque, float maxSpeed, float angle, bool ingoreVelocityChange = false);

	void StopBoost();

	void SetJumpHeightRate(float rate);

	void SetHightSpeedSteerAngleRate(float rate);

	void SetEngineTorqueRate(float rate);

	void SetBrakeTorqueRate(float rate);

	float GetEngineTorqueRate();

	float GetBrakeTorqueRate();

	void ForceStop();
}
