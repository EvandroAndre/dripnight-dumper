using UnityEngine;

public class FullScreenAdapter : MonoBehaviour
{
	public enum AdaptType
	{
		Stretch,
		Fit
	}

	public Camera cam;

	public AdaptType adaptType;

	public float zDis;

	public Vector2 scale;

	public Vector2 offset;

	public bool isLocked;

	private float m_lastFOV;

	private float m_lastAspect;

	private bool isInit;

	private Vector2 m_orginalScale;

	private float m_orginalFOV;

	private const float m_orginalAspect = 1.7777778f;

	private Mesh m_planeMesh;

	private void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	public void AdaptCamera()
	{
	}
}
