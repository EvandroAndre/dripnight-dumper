using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class TreeSystemAppendingData
{
	private static int _TreeDataId;

	public int m_treeDataId;

	public string Name;

	public List<TreeSystem.DistributionData> m_treeDistributionDataList;

	public List<TreeSystem.DistributionData> m_shrubDistributionDataList;

	public List<TreeSystem.DistributionData> m_distributionDataList;

	public List<int> m_potentVisTreeList;

	public List<int> m_foundPotentialGridList;

	public Dictionary<int, TreeSystem.VegetationGridData> m_disGridTreeIDDict;

	public List<int> m_potentVisShadowTreeList;

	public List<int> m_visTreeGroupLOD0List;

	public List<int> m_visTreeGroupLOD1List;

	public List<int> m_visTreeGroupShadowList;

	public List<int> m_visTreeGroupFarList;

	public Dictionary<int, List<int>> m_treeGroupLOD0Dict;

	public Dictionary<int, List<int>> m_treeGroupLOD1Dict;

	public Dictionary<int, List<int>> m_treeGroupShadowDict;

	public List<TreeSystem.SimulationData> m_simulationDataList;

	public List<TreeSystem.BushGroupInfo> m_visBushGroupLOD0List;

	public List<TreeSystem.BushGroupInfo> m_visBushGroupLOD1List;

	public List<TreeSystem.TreeGroupData> m_visibleTreeGroupList;

	public List<TreeSystem.TreeGroupData> m_visibleShadowTreeGroupList;

	public List<TreeSystem.BushGroupInfo> m_freeGroupInoList;

	public List<TreeSystem.BushGroupInfo> m_usedGroupInoList;

	public const int m_treeGroupMax = 7000;

	public int m_treeGroupLowTotal;

	public List<short> m_newTreeList;

	public short[] m_allTreeArray;

	public short[,] m_visTreePosID;

	public List<Vector3> m_treeGroupLowVertsTmp;

	public List<Vector3> m_treeGroupLowPSVertsTmp;

	public List<Vector2> m_treeGroupLowUVsTmp;

	public List<Vector2> m_treeGroupLowPSUVsTmp;

	public Mesh m_treeGroupLowMesh;

	public Mesh m_treeGroupLowPSMesh;

	public int[] m_treeGroupLowIndices;

	public int[] m_treeGroupLowPSIndices;

	public int m_curTreeGroupNum;

	public int m_curShadowTreeGroupNum;

	public int m_curTreeInstancingNum;

	public int m_curShadowTreeInstancingNum;

	public int m_curBillboardTreeInstancingNum;

	public int m_curPSBillboardTreeInstancingNum;

	public List<TreeSystem.TreeInstanceData> m_visibleTreeInstanceList;

	public List<TreeSystem.TreeInstanceData> m_visibleShadowTreeInstanceList;

	public int m_tmpVisCount;

	public int m_tmpVisTreeID;

	public int m_treeTypeBias;

	public bool m_isRecalculateBound;

	public bool m_HasShrub;

	public bool m_HasTree;

	public TreeSystemAppendingData(string name)
	{
	}

	public void ReleaseData()
	{
	}

	public void CleanTree()
	{
	}

	public void CleanShrub()
	{
	}

	public void AddTree(TreeSystem.DistributionData tree)
	{
	}

	public void AddShrub(TreeSystem.DistributionData shrub)
	{
	}

	public void RefreshData()
	{
	}
}
