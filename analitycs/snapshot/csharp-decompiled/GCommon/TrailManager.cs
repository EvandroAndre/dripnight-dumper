using System;
using System.Collections.Generic;
using GCommon.Trails;
using UnityEngine;

namespace GCommon;

[Serializable]
public class TrailManager : MonoBehaviour
{
	public TrailRenderer_Base[] Trails;

	private Dictionary<Material, List<PCTrail>> m_MatToTrailList;

	private Dictionary<Material, CombineInstance[]> m_CombineInstances;

	private Dictionary<Material, int> m_TrailCountDic;

	private Mesh[] combinedMesh;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public void AddTrail(Material mat, PCTrail trail)
	{
	}

	private void ClearMesh()
	{
	}

	private void DrawMesh(Mesh trailMesh, Material trailMaterial)
	{
	}
}
