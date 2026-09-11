using UnityEngine;

namespace GCommon;

public class CustomBounds : MonoBehaviour
{
	private const float MinBoundsSize = 0.001f;

	private bool m_UseCustomBounds;

	private Vector3 m_Center;

	private Vector3 m_Size;

	public bool UseCustomBounds
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 LocalCenter => default(Vector3);

	public Vector3 LocalSize => default(Vector3);

	public Bounds GetLocalBounds()
	{
		return default(Bounds);
	}

	public Bounds GetWorldBounds()
	{
		return default(Bounds);
	}

	public void SetLocalBounds(Vector3 center, Vector3 size)
	{
	}

	public void FitFromChildRenderers()
	{
	}

	private void OnValidate()
	{
	}

	private static Vector3 NormalizeSize(Vector3 size)
	{
		return default(Vector3);
	}

	private static Bounds TransformBounds(Bounds localBounds, Matrix4x4 matrix)
	{
		return default(Bounds);
	}
}
