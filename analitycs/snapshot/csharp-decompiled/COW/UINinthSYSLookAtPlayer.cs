using UnityEngine;

namespace COW;

public class UINinthSYSLookAtPlayer : MonoBehaviour
{
	public float YRotationOffset;

	public bool IsLookAtPlayerAlways;

	public float LookAtPlayerRadius;

	public bool EnableLerp;

	public float LerpSpeed;

	private Vector3 m_DefaultAngle;

	private Vector3 m_TargetAngle;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private void ApplyTargetAngle()
	{
	}

	private void LookAtPlayer()
	{
	}

	private Vector3 GetTargetPosition()
	{
		return default(Vector3);
	}
}
