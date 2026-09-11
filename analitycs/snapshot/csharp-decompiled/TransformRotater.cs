using UnityEngine;

internal class TransformRotater
{
	public Transform Root;

	public Transform RotX;

	public Transform RotY;

	public Transform RotZ;

	public Transform Center;

	public TransformRotaterAngleCalculator AngleCalculator;

	private Vector3 m_CurrentRotAngles;

	private Vector3 m_CurrentLocalDir;

	private Matrix4x4 m_ToLocal;

	public void Init(bool reset)
	{
	}

	private bool NeedUpdate(Transform tr, float current, float val)
	{
		return false;
	}

	public bool RotateToEular(float x, float y, float z)
	{
		return false;
	}

	public bool RotateToDir(Vector3 targetPoint, float maxAngles = 360f)
	{
		return false;
	}
}
