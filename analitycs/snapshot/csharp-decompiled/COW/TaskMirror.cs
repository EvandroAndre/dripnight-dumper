using Lean.Touch;
using UnityEngine;

namespace COW;

public class TaskMirror : BaseTask
{
	public Camera camera;

	public UITexture texture;

	public float radius;

	public float successRate;

	private Color32[] m_TarColor;

	private bool[] m_BMask;

	private bool m_IsDirty;

	private float m_Radius2;

	private int m_Count;

	private bool m_IsComplete;

	private Texture2D m_mask;

	private Color32[] m_CacheMaskColor;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FingerSet(LeanFinger finger)
	{
	}

	private void FingerDown(LeanFinger finger)
	{
	}

	private void MaskDrawLine(Vector2 pos1, Vector2 pos2, float radius)
	{
	}

	private void MaskDrawCircle(Vector2 localPos, float radius)
	{
	}

	private void LateUpdate()
	{
	}

	private void CheckComplete()
	{
	}
}
