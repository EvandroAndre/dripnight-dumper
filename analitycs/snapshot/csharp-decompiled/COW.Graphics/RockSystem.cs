using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class RockSystem : MonoBehaviour
{
	[Serializable]
	public class DistributionData
	{
		public int m_meshID;

		public int m_smallRockTypeID;

		public Vector2 m_boundMin;

		public Vector2 m_boundMax;

		public Matrix4x4 m_transform;

		public Vector3 m_scale;

		public DistributionData(int meshID, int smallRockTypeID, Matrix4x4 transform, Bounds bounds, Quaternion rotation, Vector3 scale)
		{
		}
	}

	public class SimulationData
	{
		public byte m_lodID;

		public byte m_lastLodID;

		public byte m_newLodID;

		public byte m_fadeCount;

		public int m_visCount;

		public SimulationData(GameObject go, int id)
		{
		}
	}

	private class RockData
	{
		public GameObject m_go;

		public List<Mesh> m_meshList;

		public List<Material> m_materialList;

		public List<MaterialPropertyBlock> m_materialPropBlockList;

		public RockData(GameObject go, List<Material> materialList, List<Mesh> meshList, List<MaterialPropertyBlock> matPropBlockList)
		{
		}
	}

	public class RockGroupData
	{
		public int m_id;

		public int m_lod;

		public int m_meshID;

		public Vector3 m_position;

		public Matrix4x4 m_rotateMatrix;

		public Matrix4x4 m_translateMatrix;

		public Matrix4x4 m_transRotateMatrix;
	}

	public class GraphicsQualityRock
	{
		public float[,] m_lodDist;

		public float[] m_viewDist;

		public int[] m_viewGridSize;

		public byte[,,] m_graphicsQuality;
	}

	public class RockTypeData
	{
		public int m_billboardNum;

		public RockTypeData(int billboardNum)
		{
		}
	}

	public class RockGridData
	{
		public List<int> m_ids;

		public Vector2 m_min;

		public Vector2 m_max;
	}

	public static bool m_debugSwitchRock;

	public List<GameObject> m_rockTypeList;

	public List<DistributionData> m_distributionDataList;

	private List<SimulationData> m_simulationDataList;

	private List<RockData> m_rockDataList;

	private Transform m_attachRockMeshParent;

	private List<int> m_potentVisRockList;

	private List<int> m_potentVisShadowRockList;

	private List<RockGroupData> m_visibleRockGroupList;

	private List<RockGroupData> m_visibleShadowRockGroupList;

	private GraphicsQualityRock m_graphicsQualityRock;

	private int m_qualityRockID;

	private int m_graphQualityRockID;

	private float m_mapWidth;

	private float m_mapStartPosX;

	private float m_mapStartPosZ;

	private const float m_distToCamera = 2f;

	private const int m_rockGroupIndNum = 6;

	private int m_curRockGroupNum;

	private int m_curShadowRockGroupNum;

	private const float m_rockGroupFarClipPos = -100000f;

	private int m_rockLayerMask;

	private List<int> m_visRockGroupLOD0List;

	private List<int> m_visRockGroupLOD1List;

	private List<int> m_visLastRockGroupLOD1List;

	private List<int> m_visRockGroupShadowList;

	private Dictionary<int, List<int>> m_rockGroupLOD0Dict;

	private Dictionary<int, List<int>> m_rockGroupLOD1Dict;

	private Dictionary<int, List<int>> m_rockGroupShadowDict;

	private const float m_rockGridSize = 60f;

	private int m_mapRockGridWidth;

	private Dictionary<int, RockGridData> m_disGridRock0IDDict;

	private Dictionary<int, RockGridData> m_disGridRock1IDDict;

	private Dictionary<int, RockGridData> m_disGridRock2IDDict;

	private Camera m_camera;

	private byte m_fadeSpeedCount;

	private Material m_shadowMat;

	private Material m_shadowRTMat;

	private SceneGraphics m_sceneGraphcisInst;

	private Vector2 m_lightDir;

	private Vector2 m_penLightDir;

	private List<int> m_foundPotentialGridList;

	public GameObject m_bigRockPreivewGO;

	public GameObject m_medRockPreivewGO;

	private bool m_isPreviewDone;

	public GameObject m_bigRocks;

	public GameObject m_medRocks;

	private Renderer[] m_bigRocksRenderer;

	private Renderer[] m_medRocksRenderer;

	private Vector2[] points;

	private int m_tmpVisCount;

	private void Start()
	{
	}

	public void Init()
	{
	}

	private void LateUpdate()
	{
	}

	public void SimuateRock()
	{
	}

	private void RockFade()
	{
	}

	public void InitRockMeshes()
	{
	}

	private void DisableRockInstances()
	{
	}

	private void InitRockTypes()
	{
	}

	private void DrawRock()
	{
	}

	private void FindPotentVisibleRock()
	{
	}

	private void FindPotentialRock(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, int rockType, Dictionary<int, RockGridData> disGridRockIDDict, int bias)
	{
	}

	private bool IsGOVisible(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, ref Vector2 minVec, ref Vector2 maxVec)
	{
		return false;
	}

	private void BuildVisibleRock()
	{
	}

	private void BuildVisibleRock(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private void BuildShadowRock()
	{
	}

	private void EnableRuntimeRockShader(bool isEnable)
	{
	}

	private void FadeRockLOD(ref SimulationData simData, int id, byte newLOD, byte lastLOD, byte changingLOD)
	{
	}

	private int GetFadeCoeff(ref SimulationData simData, int lod0, int lod1)
	{
		return 0;
	}

	private void UpdateFadeCoeff(ref SimulationData simData)
	{
	}

	private void SetFadeInfo(ref SimulationData simData, byte newLod, byte lastLod, byte count)
	{
	}
}
