using GCommon;
using UnityEngine;

public class BezierFollowingObject : ReusableObject
{
	public float DefaultFollowTime;

	private Transform m_Target;

	private Vector3 m_StartPoint;

	private Vector3 m_TurnPoint;

	private float m_FollowTime;

	private float m_StartTime;

	public static void StartFollowing(Transform owner, Transform target, Vector3 startPoint, Vector3 turnPoint, bool isUseDefaultTime = true, float followTime = 0.5f)
	{
	}

	public void StartFollow(Transform target, Vector3 startPoint, Vector3 turnPoint, float followTime)
	{
	}

	private void Update()
	{
	}

	private Vector3 GetCurPoint(float t)
	{
		return default(Vector3);
	}
}
