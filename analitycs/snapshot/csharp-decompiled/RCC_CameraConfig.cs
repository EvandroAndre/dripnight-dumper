using UnityEngine;

public class RCC_CameraConfig : MonoBehaviour
{
	public bool automatic;

	private Bounds combinedBounds;

	public float distance;

	public float height;

	private void Awake()
	{
	}

	public void SetCameraSettings()
	{
	}

	public static float MaxBoundsExtent(Transform obj)
	{
		return 0f;
	}
}
