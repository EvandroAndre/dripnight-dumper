using UnityEngine;

namespace Cinemachine;

public class CinemachineTransposer : CinemachineComponentBase
{
	public enum BindingMode
	{
		LockToTargetOnAssign,
		LockToTargetWithWorldUp,
		LockToTargetNoRoll,
		LockToTarget,
		WorldSpace,
		SimpleFollowWithWorldUp
	}

	public enum AngularDampingMode
	{
		Euler,
		Quaternion
	}

	public BindingMode m_BindingMode;

	public Vector3 m_FollowOffset;

	public float m_XDamping;

	public float m_YDamping;

	public float m_ZDamping;

	public AngularDampingMode m_AngularDampingMode;

	public float m_PitchDamping;

	public float m_YawDamping;

	public float m_RollDamping;

	public float m_AngularDamping;

	private bool _003CHideOffsetInInspector_003Ek__BackingField;

	private Vector3 m_PreviousTargetPosition;

	private Quaternion m_PreviousReferenceOrientation;

	private Quaternion m_targetOrientationOnAssign;

	private Transform m_previousTarget;

	public bool HideOffsetInInspector
	{
		get
		{
			return _003CHideOffsetInInspector_003Ek__BackingField;
		}
		set
		{
			_003CHideOffsetInInspector_003Ek__BackingField = value;
		}
	}

	public Vector3 EffectiveOffset => default(Vector3);

	public override bool IsValid => false;

	public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

	protected Vector3 Damping => default(Vector3);

	protected Vector3 AngularDamping => default(Vector3);

	protected virtual void OnValidate()
	{
	}

	public override void MutateCameraState(ref CameraState curState, float deltaTime)
	{
	}

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
	{
	}

	protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime)
	{
	}

	protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient)
	{
		outTargetPosition = default(Vector3);
		outTargetOrient = default(Quaternion);
	}

	public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp)
	{
		return default(Vector3);
	}

	public Quaternion GetReferenceOrientation(Vector3 worldUp)
	{
		return default(Quaternion);
	}

	private static Quaternion Uppify(Quaternion q, Vector3 up)
	{
		return default(Quaternion);
	}
}
