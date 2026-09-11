using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class GrassSystemAppendingData
{
	private static int _GrassDataId;

	public int m_grassDataId;

	public string Name;

	public GrassCell[] m_grassCell;

	public List<GrassInst> m_grassInstList;

	public Mesh m_grassSimMesh;

	public Mesh m_grassSimBillboardMesh;

	public List<Vector3> m_grassSimMeshVertList;

	public List<Color32> m_grassSimMeshColorList;

	public List<Vector3> m_grassSimBillboardVertList;

	public List<Vector3> m_grassSimBillboardNormalList;

	public List<Color32> m_grassSimBillboardColorList;

	public List<GrassSubCell> m_grassVisibleSubCellList;

	public Dictionary<GrassSubCell, GrassSystem.GrassInstSimInfo> m_fadeInstFadeDict;

	public Dictionary<GrassSubCell, GrassSystem.GrassInstSimInfo> m_visibleGrassSimMeshDict;

	public Dictionary<GrassSubCell, GrassSystem.GrassInstSimInfo> m_visibleGrassSimBillboardDict;

	public List<GrassSystem.GrassBufferInfo> m_freeGrassBillboardBufferList;

	public List<GrassSystem.GrassBufferInfo> m_freeGrassMeshBufferList;

	public bool m_NeedMergeFreeBufferList;

	public bool m_NeedMergeFreeBillboardBufferList;

	public int m_currentUpdateCount;

	public GrassSystemAppendingData(string name)
	{
	}

	public void InitGrassCell(int cellW, int cellH)
	{
	}

	public void InitMeshVertLists(Mesh simMesh, Mesh simBillboard)
	{
	}

	public void ReleaseData()
	{
	}
}
