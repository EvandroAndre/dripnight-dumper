using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class LineRendererHelper : MonoBehaviour
{
	private List<Transform> _dummyPositions;

	public bool useTileAnimation;

	public float animCtl;

	public float mainTexTiling;

	public Texture MainTex;

	public LineRenderer lineRenderer;

	public bool UIFX_random;

	private Color lineColor;

	public bool useDistanceFade;

	public float farDistance;

	public float nearDistance;

	private float lineDistance;

	public Material mMat;

	public Transform scaleRoot;

	private int MainTex_ID;

	private int MainTex_ST_ID;

	private bool m_IsPlayAnimation;

	public List<Transform> DummyPositions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void GetMaterial()
	{
	}

	private void GetScaleRoot()
	{
	}

	public void InitShaderID()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateLineDots()
	{
	}

	public void UpdateLineMats()
	{
	}

	public void UpdateLineColor()
	{
	}

	private float CalculateLineRendererLength()
	{
		return 0f;
	}

	private void LateUpdate()
	{
	}
}
