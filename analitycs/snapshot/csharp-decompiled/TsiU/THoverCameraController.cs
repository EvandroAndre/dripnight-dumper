using UnityEngine;

namespace TsiU;

public class THoverCameraController : MonoBehaviour
{
	private enum MouseButton
	{
		Left,
		Right,
		Middle,
		None
	}

	private readonly string MouseHorizontalAxisName;

	private readonly string MouseVerticalAxisName;

	private readonly string MouseScrollAxisName;

	public Transform TargetObject;

	public float CurrentPanAngle;

	public float CurrentTiltAngle;

	public float CurrentDistance;

	public float MinPanAngle;

	public float MaxPanAngle;

	public float MinTiltAngle;

	public float MaxTiltAngle;

	public float PanMovementSensitivity;

	public float TiltMovementSensitivity;

	public float DistanceMovementSensitivity;

	public float UpOffset;

	private Vector3 _lookAtPosition;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
