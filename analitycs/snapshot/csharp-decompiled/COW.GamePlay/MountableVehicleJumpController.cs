namespace COW.GamePlay;

public class MountableVehicleJumpController : VehicleJumpController
{
	public float SlopeAngleThreshold;

	public float verticalVelocityMultiplier;

	public float fixedXRotationSpeed;

	public float maxXRotationSpeed;

	public float ReverseMaxSpeed;

	public float ReverseTorqueScale;

	protected TssSdtFloat FMEFBKGCBKF;

	protected TssSdtFloat DBNLEIMDDEB;

	public override float GetEngineTorqueRate()
	{
		return 0f;
	}

	public override void SetEngineTorqueRate(float JAMCOPNBGFD)
	{
	}

	public override void SetBrakeTorqueRate(float JAMCOPNBGFD)
	{
	}

	public override float GetBrakeTorqueRate()
	{
		return 0f;
	}

	protected override void OBDOJJKOLKD()
	{
	}

	protected override void OHLAGAAKGBF(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void VehicleLazyFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public float _003C_003EiFixBaseProxy_GetEngineTorqueRate()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_SetEngineTorqueRate(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetBrakeTorqueRate(float P0)
	{
	}

	public float _003C_003EiFixBaseProxy_GetBrakeTorqueRate()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OBDOJJKOLKD()
	{
	}

	public void _003C_003EiFixBaseProxy_OHLAGAAKGBF(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_VehicleLazyFixedUpdate(float P0, float P1)
	{
	}
}
