using UnityEngine;

namespace GCommon;

public class EffectMovement : MonoBehaviour
{
	private Vector3 m_StartPoint;

	private Vector3 m_ControlPoint;

	private Vector3 m_EndPoint;

	private float m_StartTime;

	private float m_DurationTime;

	private bool m_NeedAutoDestroy;

	private bool m_EndOfMove;

	private bool m_TowardX;

	private EasingType m_EasingType;

	private ReusableObject m_OwnedResuable;

	public float DurationTime;

	private void Start()
	{
	}

	public void Init(Vector3 start_point, Vector3 end_point, Vector3 control_point, float time, bool need_auto_recycle, bool towardX = false, EasingType easingType = EasingType.Linear)
	{
	}

	private float ApplyEasing(float t)
	{
		return 0f;
	}

	private Vector3 GetPosByBezierCurve(float rate)
	{
		return default(Vector3);
	}

	private void Update()
	{
	}
}
