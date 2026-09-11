using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

public class UGCMergeMeshGenerator
{
	public class RenderInfo
	{
		public string TexturesKey;

		public string ShaderKey;
	}

	public class MergeObjectData
	{
		public RenderInfo[] renderList;

		public Vector3 position;

		public int meshPolyCount;

		public string entityID;

		public int scoreInSelfGrid;

		public int mergedLayerIndex;

		public int mergedGridIndex;

		public HICLJGDBALL.KOGFOBDCAGB mergeUnitInfo;
	}

	public class MergedObjectResult
	{
		public List<MergeObjectData> mergedObjList;

		public SceneEditObjectBase parent;

		public Vector3 localPosition;

		public List<HICLJGDBALL.HFNGFDGEJKJ> generateObjectList;
	}

	private class MergeBatch
	{
		public string TexturesKey;

		public string ShaderKey;

		public List<MergeObjectData> objList;

		public int objCountOnPreBatch;

		public void AddObject(MergeObjectData obj)
		{
		}
	}

	private class MergeResult
	{
		public List<MergeBatch> batchList;

		public MergeBatch GetMergeBatch(string texturesKey, string shaderKey)
		{
			return null;
		}
	}

	private class GridInfo
	{
		public List<MergeObjectData> gridObjectList;

		public MergeResult result;

		public List<MergeObjectData> cantMergeObjectList;

		public GridLayerInfo ownerLayer;

		public int gridIndex;

		public int parentLayerGridIndex;

		public Vector3 position;

		public void Create(GridLayerInfo layer, int index)
		{
		}

		public GridInfo GetParentGrid()
		{
			return null;
		}

		public void GetNearGridList(List<GridInfo> nearGridList)
		{
		}
	}

	private class GridLayerInfo
	{
		public GridInfo[] m_gridList;

		public int m_layerIndex;

		public float m_gridSize;

		public float m_gridStartX;

		public float m_gridStartZ;

		public int m_gridCountX;

		public int m_gridCountZ;

		public GridLayerInfo parentLayer;

		public bool Pos2GridIndex(Vector3 pos, out int outGridIndex)
		{
			outGridIndex = default(int);
			return false;
		}

		public bool GridIndex2Center(int gridIndex, out Vector3 outCenterPos)
		{
			outCenterPos = default(Vector3);
			return false;
		}

		public bool GridIndex2GridXZ(int gridIndex, out int gridX, out int gridZ)
		{
			gridX = default(int);
			gridZ = default(int);
			return false;
		}

		public GridInfo GetOrCreateGridInfo(int gridIndex)
		{
			return null;
		}
	}

	private GridLayerInfo m_layer0;

	private GridLayerInfo m_layer1;

	private GridLayerInfo m_layer2;

	private int m_cantMergeScore;

	public void Generate(List<MergeObjectData> objList, List<MergedObjectResult> resultList)
	{
	}

	private void getLayerResult(GridLayerInfo layer, List<MergedObjectResult> resultList)
	{
	}

	private void processGridLayer(GridInfo[] gridList)
	{
	}

	private void splitObjectsByGrid(List<MergeObjectData> objList)
	{
	}

	private void mergeGrid(GridInfo grid)
	{
	}

	private void mergeObjectList(List<MergeObjectData> objList, MergeResult result)
	{
	}

	private int calcMergeScoreGrid(MergeObjectData obj, GridInfo grid)
	{
		return 0;
	}
}
