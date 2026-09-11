using UnityEngine;

namespace GCommon;

public class Circle2D : IShape2D
{
	private Vector3 m_Position;

	private float m_Radius;

	public Circle2D(Vector3 pos, float radius)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetSize()
	{
		return default(Vector3);
	}

	public Vector3 GetCenter()
	{
		return default(Vector3);
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public float GetRadius()
	{
		return 0f;
	}

	public void SetRadius(float radius)
	{
	}

	public bool IsPointInside(Vector3 v, float margin = 0f)
	{
		return false;
	}

	public Vector3 GetRandomPoint(float margin = 0f)
	{
		return default(Vector3);
	}

	public Vector3 ClampPoint(Vector3 v, float margin = 0f)
	{
		return default(Vector3);
	}
}
