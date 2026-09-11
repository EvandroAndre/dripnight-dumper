using UnityEngine;

public class CameraPanZoom : MonoBehaviour
{
	private float panX;

	private float panY;

	private Camera _cam;

	private Matrix4x4 _savedProjection;

	private bool _appliedThisFrame;

	public float PanX => 0f;

	public float PanY => 0f;

	private void OnEnable()
	{
	}

	public void SetPan(float x, float y, bool reset = false)
	{
	}

	private void OnDisable()
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}

	private void Restore()
	{
	}

	private static Matrix4x4 BuildProjectionMatrix(Camera cam)
	{
		return default(Matrix4x4);
	}

	private static void ApplyPanXY(ref Matrix4x4 p, float x, float y, bool orthographic)
	{
	}
}
