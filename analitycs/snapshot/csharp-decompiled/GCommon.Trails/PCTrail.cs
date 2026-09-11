using System;
using System.Collections.Generic;
using GCommon.Utillities;
using UnityEngine;

namespace GCommon.Trails;

public class PCTrail : IDisposable
{
	public CircularBuffer<PCTrailPoint> Points;

	public Mesh Mesh;

	public List<Vector3> verticies;

	public List<Vector3> normals;

	public List<Vector2> uvs;

	public List<Color> colors;

	public int[] indicies;

	public int activePointCount;

	public bool IsActiveTrail;

	public PCTrail(int numPoints)
	{
	}

	public void Dispose()
	{
	}
}
