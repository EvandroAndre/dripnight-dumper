using System.Collections.Generic;
using UnityEngine;

public class SceneEditObjectSetScale : MonoBehaviour
{
	private Renderer[] m_renderers;

	private Vector3 m_lastScale;

	private int _ScaleID;

	private MaterialPropertyBlock mpb;

	private static readonly HashSet<string> validShaderNames;

	private int ScaleID => 0;

	private void Start()
	{
	}

	public void SetScale()
	{
	}
}
