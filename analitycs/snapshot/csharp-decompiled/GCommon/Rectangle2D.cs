using UnityEngine;

namespace GCommon;

public class Rectangle2D : IShape2D
{
	private Vector3 m_Position;

	private float m_HalfLength;

	private float m_HalfWidth;

	public Rectangle2D(Vector3 pos, float length, float width)
	{
	}

	public Rectangle2D(Vector3 leftBottom, Vector3 rightTop)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void SetPosition(Vector3 v)
	{
	}

	public void UpdateSize(float length, float width)
	{
	}

	public Vector3 GetSize()
	{
		return default(Vector3);
	}

	public Vector3 GetCenter()
	{
		return default(Vector3);
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
