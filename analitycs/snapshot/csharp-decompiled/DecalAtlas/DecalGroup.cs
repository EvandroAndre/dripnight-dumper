using System.Collections.Generic;
using UnityEngine;

namespace DecalAtlas;

public class DecalGroup : MonoBehaviour
{
	protected DecalManager DecalManager;

	public Texture2D MainTexAtlas;

	public List<Vector4> RectList;

	public int Granularities;

	public GranularityGrids PersistGridData;

	protected Vector2[] PersistDecalPositions;

	protected MeshRenderer _MeshRenderer;

	protected MeshFilter _MeshFilter;

	protected Mesh m_mesh;

	public Material m_mat;

	protected int m_layerMask;

	protected MaterialPropertyBlock m_matBlock;

	public float m_visiblePercent;

	protected bool m_partVisible;

	protected virtual void Start()
	{
	}

	protected virtual void UpdateDecalMesh(int swapDataIndex)
	{
	}

	public virtual void DrawDecalMesh()
	{
	}

	public void UpdateDecals()
	{
	}

	private bool _UpdateGridCellVisibilityCheckEach(int swapDataIndex, ref GranularityDatum granularityDatum, ref GridForGranularity granularityGrid)
	{
		return false;
	}

	private bool _UpdateGridCellVisibility(int swapDataIndex, ref GranularityDatum granularityDatum, ref GridForGranularity granularityGrid)
	{
		return false;
	}
}
