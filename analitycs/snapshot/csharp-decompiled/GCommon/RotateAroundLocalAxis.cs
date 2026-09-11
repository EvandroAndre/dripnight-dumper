using UnityEngine;

namespace GCommon;

public class RotateAroundLocalAxis : MonoBehaviour
{
	public enum ERotateAxis
	{
		X,
		Y,
		Z
	}

	public ERotateAxis Axis;

	public float Speed;

	private Vector3 m_RotationAxis;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
