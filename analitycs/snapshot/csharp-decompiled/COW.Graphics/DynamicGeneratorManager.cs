using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class DynamicGeneratorManager
{
	[Serializable]
	public class DistributionData
	{
		public int m_meshID;

		public DynamicGenerator.GeneratorType m_type;

		public Vector3 m_position;

		public Vector3 m_scale;

		public Quaternion m_rotation;

		public Vector2 m_boundMin;

		public Vector2 m_boundMax;

		public int m_dirRndID;

		public DistributionData(int meshID, int dirRndID, DynamicGenerator.GeneratorType type, Vector3 pos, Vector3 scale, Quaternion roation, Bounds bounds)
		{
		}
	}

	public class SimulationData
	{
		public SimulationCachedData m_cachedData;

		public GameObject m_go;

		public int m_lodID;

		public int m_lastLodID;

		public int m_newLodID;

		public int m_fadeCount;

		public bool m_isVisible;

		public Vector3 m_direction;

		public Vector3 m_position;
	}

	public class SimulationCachedData
	{
		public Vector4 m_boundPoint;

		public Matrix4x4 m_transform;

		public Vector3 m_worldPos;

		public Vector3[] m_treeBillboardVerts;
	}

	[Serializable]
	public class DynamicPrefabInfo
	{
		public GameObject m_prefab;

		public GameObject m_collider;

		public DynamicGenerator.GeneratorType m_type;

		public int m_individualNum;

		public bool m_receiveShadow;
	}

	public class DynamicPrefabMesh
	{
		public bool SelfVisible;

		public DynamicMeshVisibleHelper MeshVisibleHelper;

		public List<DynamicPrefabSubMesh> m_subMeshList;
	}

	public class DynamicPrefabSubMesh
	{
		public GameObject m_go;

		public List<Mesh> m_meshList;

		public List<Renderer> m_rendererList;

		public List<Material> m_materialList;

		public List<MaterialPropertyBlock> m_materialPropBlockList;

		public List<List<Material>> m_subMeshShareMatList;

		public Vector3 m_position;

		public DynamicPrefabSubMesh(GameObject go, List<Renderer> rendererList, List<Mesh> meshList, List<MaterialPropertyBlock> matPropBlockList, List<Material> matList, Vector3 pos)
		{
		}
	}

	public class DynamicInstanceGroupMesh
	{
		public int m_id;

		public int m_meshID;

		public int m_lodID;

		public int m_instNum;

		public float[] m_fadeFactor;

		public Vector3 m_position;

		public Vector4[] m_transformVecArray;

		public Matrix4x4 m_rotateMatrix;

		public Matrix4x4 m_translateMatrix;

		public Matrix4x4 m_transRotateMatrix;
	}

	public class GridInfo
	{
		public List<int> m_ids;

		public Vector2 m_min;

		public Vector2 m_max;
	}

	public class DynamicInstanceSet
	{
		public int m_type;

		public List<DistributionData> m_distributionDataList;

		public List<SimulationData> m_simulationDataList;

		public Dictionary<int, GridInfo> m_disGridIDDict;

		public List<int> m_visInstanceList;

		public Dictionary<int, List<int>> m_visInstanceGroupDict;

		public Dictionary<int, List<DynamicInstanceGroupMesh>> m_visInstanceGroupMeshDict;

		public Dictionary<int, List<GameObject>> m_visColliderDict;

		public bool m_hasDynColliders;

		public DynamicInstanceSet(int type)
		{
		}
	}

	public class GraphicsQualityConfig
	{
		public float[,,] m_lodDist;

		public float[,] m_viewDist;

		public float[] m_gridSize;

		public int[,] m_viewGridCount;

		public int[,,,] m_graphicsQuality;
	}

	private List<DynamicGeneratorGroup> m_dynamicGenGroupList;

	private List<DynamicPrefabInfo> m_dynamicPrefabList;

	private List<DynamicPrefabInfo> m_dynamicGroupPrefabList;

	private DynamicInstanceSet[] m_dynamicInstSet;

	private List<DynamicPrefabMesh> m_dynamicPrefabMeshList;

	private List<DynamicPrefabMesh> m_dynamicGroupPrefabMeshList;

	private Camera m_camera;

	private GraphicsQualityConfig m_graphQualityConf;

	private int m_systemQualityID;

	private int m_graphQualityID;

	private int m_groupQualityID;

	private Vector2 m_camForward;

	private Vector2 m_realCamPosition;

	private Vector2 m_camPosition;

	private float m_camCosHalfFov;

	private bool m_camLookingDown;

	private const int m_dynInstanceGroupNum = 10;

	private const float m_distToCamera = 2f;

	private int m_usedGroupMeshPoolNum;

	private List<DynamicInstanceGroupMesh> m_instGroupMeshPoolList;

	private int[,] m_mapGridCount;

	private Matrix4x4 m_shaderRotateMatrix;

	private int m_layerMask;

	private List<List<int>> m_cachedGroupList;

	private List<List<DynamicInstanceGroupMesh>> m_cachedGroupMeshList;

	private int m_cachedGroupNum;

	private int m_cachedGroupMeshNum;

	private Material m_shadowMat;

	private Material m_shadowRTMat;

	private int m_translateMatrix;

	private int m_rotateMatrix;

	private int m_transRotateMatrix;

	private int m_fadeFactor;

	private int m_transformVec;

	private int m_posMatrix0ID;

	private int m_posMatrix1ID;

	private float _003CCamRotDelta_003Ek__BackingField;

	private float _003CCamPosDelta_003Ek__BackingField;

	private Quaternion m_LastCamRotation;

	private Vector3 m_LastCamPosition;

	public bool buildDynamics;

	private bool m_EnablePreZPass;

	private int[] m_lastCamGridIDs;

	private int[,] m_visGrids;

	private List<int> m_visGridList;

	private List<int> m_invisGridList;

	private List<int> m_potentVisibleList;

	private List<int> m_gridVisibleList;

	private Vector2[] points;

	public Matrix4x4 m_posMatrix0;

	public Matrix4x4 m_posMatrix1;

	public float CamRotDelta
	{
		get
		{
			return _003CCamRotDelta_003Ek__BackingField;
		}
		private set
		{
			_003CCamRotDelta_003Ek__BackingField = value;
		}
	}

	public float CamPosDelta
	{
		get
		{
			return _003CCamPosDelta_003Ek__BackingField;
		}
		private set
		{
			_003CCamPosDelta_003Ek__BackingField = value;
		}
	}

	public void Init(Camera camera, List<DynamicGeneratorGroup> dynamicGenGroupList)
	{
	}

	private void InitShaderPropertyVals()
	{
	}

	private void InitDynGenGroupList(List<DynamicGeneratorGroup> dynamicGenGroupList)
	{
	}

	private void InitDynamicGroup(List<DynamicGeneratorGroup> dynamicGroupList)
	{
	}

	public void AddDynamicGroupList(List<DynamicGeneratorGroup> dynamicGroupList)
	{
	}

	private void InitCSVData()
	{
	}

	private void InitQualityID()
	{
	}

	private void InitPrefabMesh(List<DynamicPrefabInfo> prefabList, List<DynamicPrefabMesh> prefabMeshList)
	{
	}

	private void InitDistributionData(DynamicInstanceSet[] dstSet, Dictionary<int, DynamicInstanceSet> srcSet)
	{
	}

	private void RefreshCameTransDelta()
	{
	}

	public void Tick()
	{
	}

	public bool NeedBuildDynamics()
	{
		return false;
	}

	private void BuildVisibleColliders()
	{
	}

	private void UpdateCamPos()
	{
	}

	private void BuildVisSets()
	{
	}

	private void BuildVisibleSet(int type, ref DynamicInstanceSet dynInstSet)
	{
	}

	private bool IsGOVisible(ref Vector2 minVec, ref Vector2 maxVec)
	{
		return false;
	}

	private void BuildVisibleInstances(DynamicInstanceSet dynInstSet, ref List<int> potentVisibleList, bool bTurnOffViewFrustumCull = false)
	{
	}

	private void BuildVisInstanceMovement()
	{
	}

	private void BuildVisInstanceMeshes()
	{
	}

	private void BuildVisInstanceMesh(DynamicInstanceSet dynInstSet)
	{
	}

	private void FillGroupMesh(DynamicInstanceGroupMesh groupMesh, int instGroupCount, int indNum)
	{
	}

	private void BuildVisInstanceGenericMesh(int instGroupCount, DynamicInstanceGroupMesh groupMesh, ref Matrix4x4 transform, ref Vector3 scale, int id)
	{
	}

	private void BuildVisInstanceTreeMesh(int instGroupCount, DynamicInstanceGroupMesh groupMesh, DistributionData distData)
	{
	}

	private void DrawVisInstances()
	{
	}

	private void DrawVisInstance(DynamicInstanceSet dynInstSet)
	{
	}

	private void DrawGeneric(DistributionData distData, SimulationData simData)
	{
	}

	private void DrawGeneric(DistributionData distData, Vector3 pos, int lod)
	{
	}

	private void DrawGenericGroup(DynamicInstanceGroupMesh groupMesh, DynamicGenerator.GeneratorType type, bool isReceiveShadow)
	{
	}

	private void DrawGrass(DistributionData distData, SimulationData simData)
	{
	}

	private void DrawGrassGroup(DynamicInstanceGroupMesh groupMesh)
	{
	}

	private void DrawTreeGroup(DynamicInstanceGroupMesh groupMesh)
	{
	}
}
