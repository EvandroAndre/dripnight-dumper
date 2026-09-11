using System.Collections.Generic;
using UnityEngine;

public class SoulBondStraightLine : MonoBehaviour, ILinkTwoPointEffect
{
	public Transform CachedTransform;

	private LineRenderer m_LineRenderer;

	private List<Material> m_LinerendererMat;

	private int m_ColorProperty;

	private bool m_NeedSetLinerendererPosCount;

	private Vector3 m_StartPos;

	private Vector3 m_EndPos;

	private float? m_BaseWidthMultiplier;

	private float m_LastWidthMultiplier;

	private float? m_LastAphaScale;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetPointPos(Vector3 start, Vector3 end)
	{
	}

	private void DrawLine()
	{
	}

	public void ScaleLineWidth(float scale)
	{
	}

	public void ScaleLineAlpha(float t)
	{
	}
}
