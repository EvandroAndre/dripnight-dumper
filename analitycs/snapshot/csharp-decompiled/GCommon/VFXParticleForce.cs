using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class VFXParticleForce : MonoBehaviour
{
	public enum FlowmapAxisType
	{
		Up,
		Right,
		Fowrard
	}

	public enum ForceShapeType
	{
		Cube,
		Sphere
	}

	public List<ParticleSystem> Particles;

	public bool IsEnabled;

	public bool Boundary;

	public float CenterWeight;

	public float EdgeWeight;

	public ForceShapeType ForceShape;

	public Vector3 Velocity;

	public Vector3 Twirl;

	public Vector3 Shockwave;

	public float FlowStrength;

	public FlowmapAxisType FlowmapAxis;

	public Texture2D Flowmap;

	public int FlowmapSize;

	public Vector2[] FlowmapData;

	public string FlowmapName;

	private int m_FlowmapDataSize;

	private Collider m_ColliderTrigger;

	[NonSerialized]
	public int MaxParticleCount;

	public static int[] s_MaxParticleCountList;

	private static Texture2D GetReadableTexture(Texture2D texture)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public Vector3 GetDirection(Vector3 pos)
	{
		return default(Vector3);
	}

	private Vector3 CalculateFlowDirection(Vector3 posTemp)
	{
		return default(Vector3);
	}

	private Vector3 GetDirection(Vector3 pos, out bool inside)
	{
		inside = default(bool);
		return default(Vector3);
	}
}
