using UnityEngine;

public class MotorcycleWheelController : MonoBehaviour, WheelColliderInterface
{
	public RMCRealisticMotorcycleController m_Controller;

	public WheelCollider m_WheelCollider;

	public Transform m_WheelTransform;

	public bool isGrounded;

	private float rot;

	public bool VehicleHighSpeedFrictionController;

	public float XFrictionSpeedStartMul;

	public float XFrictionSpeedMaxMul;

	public float XFrictionValueMinMul;

	private WheelFrictionCurve sidewaysFrictionCurve;

	private float orgSidewaysStiffness;

	public bool IsGrounded => false;

	private void Awake()
	{
	}

	public void AttachWheelModel(Transform model)
	{
	}

	public void EnableWheelCollider(bool e)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void UpdateWheelCollider()
	{
	}

	public WheelHit UpdateGrounded()
	{
		return default(WheelHit);
	}

	public void ClearTorque()
	{
	}
}
