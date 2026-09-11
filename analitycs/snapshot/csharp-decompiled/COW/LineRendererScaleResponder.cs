using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class LineRendererScaleResponder : MonoBehaviour
{
	private class LineRendererData
	{
		public LineRenderer lineRenderer;

		public float originalWidthMultiplier;

		public LineRendererData(LineRenderer lr)
		{
		}
	}

	private List<LineRenderer> m_LineRenderers;

	private float m_ScaleMultiplier;

	private readonly List<LineRendererData> m_LineRendererDataList;

	private Vector3 m_OriginalScale;

	private Vector3 m_LastScale;

	private const float SCALE_CHANGE_THRESHOLD_SQR = 9.999999E-09f;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void InitializeLineRenderers()
	{
	}

	private void Update()
	{
	}

	private void ApplyScale(Vector3 scale)
	{
	}

	public void ResetToOriginalWidth()
	{
	}

	public void ForceUpdate()
	{
	}
}
