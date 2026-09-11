using System;
using UnityEngine;

namespace UMA;

[Serializable]
public class UMABlendFrame
{
	public float frameWeight;

	public Vector3[] deltaVertices;

	public Vector3[] deltaNormals;

	public Vector3[] deltaTangents;

	public UMABlendFrame(int vertexCount)
	{
	}
}
