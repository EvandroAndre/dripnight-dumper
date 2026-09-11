using System;
using UnityEngine;

namespace Cinemachine;

public class CinemachineTrackedDolly : CinemachineComponentBase
{
	public enum CameraUpMode
	{
		Default,
		Path,
		PathNoRoll,
		FollowTarget,
		FollowTargetNoRoll
	}

	[Serializable]
	public struct AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment)
	{
		public bool m_Enabled = false;

		public float m_PositionOffset = 0f;

		public int m_SearchRadius = 0;

		public int m_SearchResolution = 0;
	}

	public CinemachinePathBase m_Path;

	public float m_PathPosition;

	public CinemachinePathBase.PositionUnits m_PositionUnits;

	public Vector3 m_PathOffset;

	public float m_XDamping;

	public float m_YDamping;

	public float m_ZDamping;

	public CameraUpMode m_CameraUp;

	public float m_PitchDamping;

	public float m_YawDamping;

	public float m_RollDamping;

	public AutoDolly m_AutoDolly;

	private float m_PreviousPathPosition;

	private Quaternion m_PreviousOrientation;

	private Vector3 m_PreviousCameraPosition;

	public override bool IsValid => false;

	public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

	private Vector3 AngularDamping => default(Vector3);

	public override void MutateCameraState(ref CameraState curState, float deltaTime)
	{
	}

	private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up)
	{
		return default(Quaternion);
	}
}
