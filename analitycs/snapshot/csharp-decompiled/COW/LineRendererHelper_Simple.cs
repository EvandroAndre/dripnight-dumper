using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class LineRendererHelper_Simple : MonoBehaviour
{
	public List<Transform> dummyPositions;

	public int interDummyCount;

	public List<float> tensions;

	private int dummyCountLimit;

	private bool isLowQuality;

	private bool isLobby;

	private Vector3[] positionsArray;

	private LineRenderer LineRenderer;

	public bool FoldTesion;

	public LineRenderer lineRenderer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateLineDots()
	{
	}

	private void UpdateLineRendererLobby()
	{
	}

	private void UpdateLineRendererInGame()
	{
	}

	private Vector3 CatmullRomTension(Vector3 P0, Vector3 P1, Vector3 P2, Vector3 P3, float t, float tension)
	{
		return default(Vector3);
	}
}
