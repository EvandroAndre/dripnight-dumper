using System;
using System.Collections.Generic;
using UnityEngine;

public class RCC_WheelCollider : MonoBehaviour, WheelColliderInterface
{
	public RCC_CarControllerV3 carController;

	public bool fixWheelOverlap;

	private Rigidbody rigid;

	private WheelCollider _wheelCollider;

	private List<RCC_WheelCollider> allWheelColliders;

	public Transform wheelModel;

	[NonSerialized]
	public Vector3 WheelModelOffset;

	private Transform WheelModelRotation;

	private float wheelRotation;

	private float camber;

	internal float steerAngle;

	internal bool isGrounded;

	public bool isGroundedShow;

	internal float totalSlip;

	internal float rpm;

	internal float wheelRPMToSpeed;

	private float wheelSlipAmountSideways;

	private float wheelSlipAmountForward;

	private float orgSidewaysStiffness;

	private float orgForwardStiffness;

	public WheelFrictionCurve forwardFrictionCurve;

	public WheelFrictionCurve sidewaysFrictionCurve;

	internal float tractionHelpedSidewaysStiffness;

	private float minForwardStiffness;

	private float maxForwardStiffness;

	private float minSidewaysStiffness;

	private float maxSidewaysStiffness;

	public float ForwardSlip;

	public float SidewaySlip;

	public LayerMask ColliderMask;

	internal bool disableModelTransUpdate;

	private float m_ScaleY;

	public bool VehicleHighSpeedFrictionController;

	public float XFrictionSpeedStartMul;

	public float XFrictionSpeedMaxMul;

	public float XFrictionValueMinMul;

	private float mOrgRadius;

	public int raysNumber;

	public float rayStartAngle;

	public float raysMaxAngle;

	public float wheelWidth;

	public float wheelColliderMaxScale;

	private bool m_HasFixedUpdate;

	public bool doWheelAlign;

	public WheelCollider wheelCollider
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsGrounded => false;

	public float motorTorque
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float brakeTorque
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public WheelHit UpdateGrounded()
	{
		return default(WheelHit);
	}

	public void UpdateWheelCollider()
	{
	}

	private void FixWheelOverlap()
	{
	}

	private WheelFrictionCurve SetFrictionCurves(WheelFrictionCurve curve, float extremumSlip, float extremumValue, float asymptoteSlip, float asymptoteValue)
	{
		return default(WheelFrictionCurve);
	}

	public void WheelAlign()
	{
	}

	public void WheelCamber()
	{
	}

	private void Frictions(bool contacted, float forwardSlip)
	{
	}

	private void Drift(float forwardSlip)
	{
	}

	private bool isSkidding()
	{
		return false;
	}

	public void EnableWheelCollider(bool e)
	{
	}

	public void AttachWheelModel(Transform model)
	{
	}

	public void ClearTorque()
	{
	}
}
