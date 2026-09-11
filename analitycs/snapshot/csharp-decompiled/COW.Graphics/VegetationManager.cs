using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class VegetationManager : MonoBehaviour
{
	public enum VegetationType
	{
		Veg_Grass,
		Veg_Tree,
		Veg_Total
	}

	[Serializable]
	public class DistributionData
	{
		public int m_meshID;

		public VegetationType m_type;

		public Vector3 m_position;

		public Vector3 m_direction;

		public Quaternion m_rotation;

		public Vector2 m_boundMin;

		public Vector2 m_boundMax;

		public short m_colorID;

		public short m_scaleID;

		public bool m_needhide;

		public DistributionData(int meshID, VegetationType type, Vector3 pos, Vector3 direction, Quaternion roation, Bounds bounds)
		{
		}
	}

	[Serializable]
	public class DicReplaceSceneData
	{
		public string m_label;

		public List<DistributionData> m_distributionDataOriginal;

		public List<DistributionData> m_distributionDataReplaced;

		public int m_originalTreeCount;

		public int m_replacedTreeCount;

		public bool m_isEnable;

		public DicReplaceSceneData(string label, List<DistributionData> originalData, List<DistributionData> replacedData)
		{
		}
	}

	public class SimulationData
	{
		public float m_startAngle;

		public byte m_lodID;

		public byte m_lastLodID;

		public byte m_newLodID;

		public byte m_fadeCount;

		public int m_visCount;

		public float m_grassFadeRatio;

		public Vector3[] m_auxVecArray;

		public SimulationData(GameObject go, float startAngle, int id)
		{
		}
	}

	[Serializable]
	public class SimulationSetting
	{
		public float m_windDiff;

		public float m_windSpeed;

		public float m_windAmplitude;

		public Vector3 m_windDir;

		public float m_farClipDist;

		public float m_fadeDist;

		public List<int> m_texCountList;

		public float m_lod0Dist;

		public float m_lod1Dist;

		public float m_lod2Dist;

		public float m_shadowBias;

		public float m_shadowPower;

		public float m_shadowClampMin;

		public float m_shadowClampMax;
	}

	private class VegetationData
	{
		public GameObject m_go;

		public List<Mesh> m_meshList;

		public List<Material> m_materialList;

		public List<MaterialPropertyBlock> m_materialPropBlockList;

		public VegColorComponent m_vegColorComp;

		public Vector4[] m_vegColorArray;

		public int m_vegColorBias;

		public VegetationData(GameObject go, List<Material> materialList, List<Mesh> meshList, List<MaterialPropertyBlock> matPropBlockList, VegColorComponent vegColorComp, int bias)
		{
		}

		private void CalculateVegColorArray()
		{
		}
	}

	public class GrassGroupData
	{
		public int m_id;

		public int m_groupID;

		public int m_meshID;

		public Vector3 m_position;

		public Vector4[] m_transformVecArray;
	}

	public class TreeGroupData
	{
		public int m_id;

		public int m_lod;

		public int m_meshID;

		public Vector3 m_position;

		public Matrix4x4 m_posMatrix0;

		public Matrix4x4 m_posMatrix1;
	}

	public class GraphicsQualityVeg
	{
		public float[,,] m_lodDist;

		public float[,] m_viewDist;

		public int[,] m_viewGridSize;

		public byte[,,,] m_graphicsQuality;
	}

	public class VegetationTypeData
	{
		public VegetationType m_type;

		public int m_billboardNum;

		public VegetationTypeData(VegetationType type, int billboardNum)
		{
		}
	}

	public class VegetationGridData
	{
		public List<int> m_ids;

		public Vector2 m_min;

		public Vector2 m_max;
	}

	public static bool m_debugSwitchGrass;

	public static bool m_debugSwitchTree;

	public static bool m_debugSwitchVeg;

	public static bool EnableHide;

	public static bool EnablePreZPass;

	public bool EnableGrass;

	private static bool s_forceDisabled;

	public List<GameObject> m_vegetationTypeList;

	public List<DistributionData> m_distributionDataList;

	public SimulationSetting m_simulationSetting;

	public List<DicReplaceSceneData> m_ReplaceDataList;

	private int m_posInsertReplaceData;

	private List<SimulationData> m_simulationDataList;

	private List<VegetationData> m_vegetationDataList;

	private Transform m_attachGrassMeshParent;

	private Transform m_attachTreeMeshParent;

	private List<int> m_potentVisGrassList;

	private List<int> m_potentVisTreeList;

	private List<int> m_potentVisShadowTreeList;

	private List<int> m_visibleGrassInstList;

	private Dictionary<int, List<int>> m_visibleGrassLowInstDict;

	private Dictionary<int, List<GrassGroupData>> m_visibleGrassGroupDict;

	private List<TreeGroupData> m_visibleTreeGroupList;

	private List<TreeGroupData> m_visibleShadowTreeGroupList;

	private float m_vegetationHeight;

	private GraphicsQualityVeg m_graphicsQualityVeg;

	private int m_qualityVegID;

	private int m_graphQualityVegID;

	private int m_grassGroupID;

	private float m_mapWidth;

	private float m_mapHeight;

	private float m_mapStartPosX;

	private float m_mapStartPosZ;

	private const float m_distToCamera = 2f;

	private Dictionary<string, VegetationTypeData> m_vegTypeDict;

	private Vector4 m_replaceShadowMapBias;

	private List<Color> m_globalGrassColorList;

	private List<Color> m_globalTreeColorList;

	private const int m_treeGroupIndNum = 8;

	private int m_curTreeGroupNum;

	private int m_curShadowTreeGroupNum;

	private const int m_treeGroupMax = 2000;

	private int m_treeGroupLowPSTotal;

	private const int m_treeGroupLowTotal = 400;

	private const float m_treeGroupFarClipPos = -100000f;

	private Dictionary<int, List<Vector3>> m_treeGroupLowVertsDict;

	private Dictionary<int, List<Vector2>> m_treeGroupLowUVsDict;

	private int[] m_treeGroupLowIndices;

	private int[] m_treeGroupLowPSIndices;

	private List<Vector3> m_treeGroupLowVertsTmp;

	private List<Vector3> m_treeGroupLowPSVertsTmp;

	private List<Vector2> m_treeGroupLowUVsTmp;

	private List<Vector2> m_treeGroupLowPSUVsTmp;

	private List<Color> m_treeGroupLowColorsTmp;

	private List<Color> m_treeGroupLowPSColorsTmp;

	private Dictionary<int, int> m_treeGroupLowBillboradNumDict;

	private int m_hidVegBias;

	private bool m_hasHideVeg;

	private Mesh m_treeGroupLowMesh;

	private Mesh m_treeGroupLowPSMesh;

	private float m_PsMeshDelayClearCount;

	private Vector3 m_treeGroupLowPos;

	private Material m_treeFarMat;

	private Texture m_treeMainTex;

	private int m_treeLayerMask;

	public Vector4 m_treeScaleVec;

	public Vector4 m_treeScaleVecSec;

	private float[] m_treeScaleArray;

	private List<int> m_visTreeGroupLOD0List;

	private List<int> m_visTreeGroupLOD1List;

	private List<int> m_visTreeGroupFarList;

	private List<int> m_visTreeGroupShadowList;

	private HashSet<int> m_chekedVisTreeIDList;

	private Dictionary<int, List<int>> m_treeGroupLOD0Dict;

	private Dictionary<int, List<int>> m_treeGroupLOD1Dict;

	private Dictionary<int, List<int>> m_treeGroupShadowDict;

	private const int m_grassGroupTypeNum = 4;

	private const int m_grassGroupIndNum = 10;

	private int[] m_curGrassGroupNum;

	public GameObject m_pineTreeBillboard;

	public GameObject m_greenTreeBillboard;

	public GameObject m_cocoTreeBillboard;

	public GameObject m_grassGroupGOType0;

	public GameObject m_grassGroupGOType1;

	public GameObject m_grassGroupGOType2;

	public GameObject m_grassGroupGOType3;

	private Mesh[,] m_grassGroupMesh;

	private Material[,] m_grassGroupMaterial;

	private MaterialPropertyBlock[,] m_grassGroupMatPropBlock;

	private Dictionary<int, int> m_grassGroupTypeDict;

	private const float m_grassGridSize = 30f;

	private const float m_treeGridSize = 60f;

	private int m_mapGrassGridWidth;

	private int m_mapTreeGridWidth;

	private Dictionary<int, List<int>> m_disGridGrassIDDict;

	private Dictionary<int, VegetationGridData> m_disGridTreeIDDict;

	private Camera m_camera;

	private byte m_fadeSpeedCount;

	private int m_treeScaleBias;

	private bool m_isSpeedGameMode;

	private short[] m_allTreeArray;

	private List<short> m_newTreeList;

	private short[,] m_visTreePosID;

	private Material m_shadowMat;

	private Material m_shadowRTMat;

	private SceneGraphics m_sceneGraphcisInst;

	private Vector2 m_lightDir;

	private Vector2 m_penLightDir;

	private List<int> m_foundPotentialGridList;

	private bool m_isRecalculateBound;

	private float _003CCamRotDelta_003Ek__BackingField;

	private float _003CCamPosDelta_003Ek__BackingField;

	private Quaternion m_LastCamRotation;

	private Vector3 m_LastCamPosition;

	private bool m_isInit;

	public GameObject m_vegRootGO;

	public static string originRootName;

	public static string replaceRootName;

	private bool m_treeGroupLowMeshDirty;

	private static readonly int s_MatPropIDBias;

	private static readonly int s_MatPropIDWindVec;

	private static readonly int s_MatPropIDVegColor;

	private static readonly int s_MatPropIDPosMatrix0;

	private static readonly int s_MatPropIDPosMatrix1;

	private static readonly int s_MatPropIDScaleVec;

	private static readonly int s_MatPropIDTransformVec;

	private static readonly int s_MatPropIDPosBias;

	private int m_firstTreeID;

	private bool bFindPotention;

	private List<int> m_gridVisibleList;

	private List<int> m_tmpVisibleList;

	public bool m_StandAloneBackCamPos;

	private Vector2[] points;

	private bool bBuildGrass;

	private bool bBuildTree;

	private bool bDrawGrass;

	private bool bDrawTree;

	private int m_tmpVisCount;

	private int lowMeshBias;

	private int buffPosIDOld;

	private int buffPosIDNew;

	private short maxBuffPos;

	private int m_tmpVisTreeID;

	public static bool ForceDisabled => false;

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

	public static void SetForceDisabled(bool disabled)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void InitData()
	{
	}

	private void OnLoadingOver(object[] data)
	{
	}

	public void InitShadowMat()
	{
	}

	public void Init(bool reduceMemForJobs = false)
	{
	}

	private void InitReplacedData()
	{
	}

	public void CheckTreeGrid(int mesh_id)
	{
	}

	private int CaculateDimID(float x, float z)
	{
		return 0;
	}

	private void LateUpdate()
	{
	}

	private void RefreshCameTransDelta()
	{
	}

	public void SimuateVegetation()
	{
	}

	public void UpdateSimulationSetting()
	{
	}

	public void InitVegetationMeshes()
	{
	}

	private void DisableOriginalTreeAndGrassRepalceLayer(Transform layer)
	{
	}

	private void DisableOriginalTreeAndGrass()
	{
	}

	private void DisableVegetationInstances()
	{
	}

	private void InitVegetationTypes()
	{
	}

	private void InitFarTreeMeshes()
	{
	}

	private void InitFarGrassMeshes()
	{
	}

	private void SimuateMovement()
	{
	}

	private void SimulatePopup(int id, ref Vector2 camPosition, float startFadeDist, float startFadeDistSqr, float farClipDistSqr)
	{
	}

	private void DrawVegetation()
	{
	}

	private void RefreshSimulateData()
	{
	}

	private void FindPotentVisibleVegetation()
	{
	}

	private void FindPotentialGrass(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private Vector2 CalcBorderIntersection(Vector2 pos, Vector2 forward)
	{
		return default(Vector2);
	}

	private static Vector2 CalcBorderIntersection(Vector2 pos, Vector2 forward, float m_mapStartPosX, float m_mapStartPosZ, float m_mapWidth, float m_mapHeight)
	{
		return default(Vector2);
	}

	private void FindPotentialTree(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void FindPotentialShadowTree(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private bool IsGOVisible(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, ref Vector2 minVec, ref Vector2 maxVec)
	{
		return false;
	}

	private void BuildVisibleVegetation(bool buildAll = true)
	{
	}

	private void BuildVisibleGrass(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private void BuildVisibleTreeLod(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private void BuildVisibleTree(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, bool buildAll = true)
	{
	}

	private void BuildShadowTree()
	{
	}

	private void FindVisibleTreeBufferPos(ref int lowMeshBias, ref short maxBuffPos, ref int buffPosIDOld, ref int buffPosIDNew)
	{
	}

	private void EnableRuntimeVegShader(bool isEnable)
	{
	}

	private void FadeTreeLOD(ref SimulationData simData, int id, byte newLOD, byte lastLOD, byte changingLOD)
	{
	}

	private int GetFadeCoeff(ref SimulationData simData, int lod0, int lod1, int lod2)
	{
		return 0;
	}

	private void UpdateFadeCoeff(ref SimulationData simData)
	{
	}

	public void RefreshHideVegForPS()
	{
	}
}
