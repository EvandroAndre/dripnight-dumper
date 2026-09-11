using System.Collections.Generic;
using UnityEngine;

public class CustomTrail : MonoBehaviour
{
	public Transform customSpace;

	public float trailTime;

	public float pointSpacing;

	private List<Vector3> localPoints;

	private List<float> timeStamps;

	private LineRenderer line;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private float GetTime()
	{
		return 0f;
	}

	private void AddPoint(Vector3? localPos = null, float? time = null)
	{
	}
}
