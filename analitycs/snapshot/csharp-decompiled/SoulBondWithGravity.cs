using System.Collections.Generic;
using UnityEngine;

public class SoulBondWithGravity : MonoBehaviour, ILinkTwoPointEffect
{
	private Transform m_Start;

	private Transform m_Middle;

	private Transform m_End;

	private int m_Interpolation;

	public Transform CachedTransform;

	private Vector3[] m_BezierResultCache;

	private LineRenderer m_LineRenderer;

	private List<Material> m_LinerendererMat;

	private int m_ColorProperty;

	private float m_MiddleTransDroopRatio;

	private bool m_NeedSetLinerendererPosCount;

	private float m_MiddleTransMaxDroopHeight;

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

	public void SetMaxDroop(float length)
	{
	}

	private void DrawBezier()
	{
	}

	public Vector3 Lerp(float t, bool returnWorldPos = true)
	{
		return default(Vector3);
	}

	public void ScaleLineWidth(float scale)
	{
	}

	public void ScaleLineAlpha(float t)
	{
	}
}
