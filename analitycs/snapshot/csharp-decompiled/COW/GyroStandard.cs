using UnityEngine;

namespace COW;

public class GyroStandard : MonoBehaviour
{
	private float width;

	private float height;

	public float Width
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float ScaledWidth => 0f;

	public float ScaledHeight => 0f;

	public Vector3 TopLeft => default(Vector3);

	public Vector3 TopRight => default(Vector3);

	public Vector3 BottomRight => default(Vector3);

	public Vector3 BottomLeft => default(Vector3);

	private void OnDrawGizmos()
	{
	}

	public void ResetStandard()
	{
	}
}
