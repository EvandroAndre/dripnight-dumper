using System;
using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

public class TreeSystem : MonoBehaviour
{
	[Serializable]
	public class DistributionData : BaseCustomSerializedObject
	{
		public int m_meshID;

		public Vector3 m_position;

		public Vector2 m_boundMin;

		public Vector2 m_boundMax;

		public short m_scaleID;

		public short m_hueAmount;

		public byte m_textID;

		public DistributionData()
		{
		}

		public DistributionData(int meshID, Vector3 pos, Bounds bounds)
		{
		}

		protected override void OnJsonRead(JsonData json_data)
		{
		}

		protected override void OnJsonWrite(ref JsonWriter writer)
		{
		}

		protected override void OnBinaryRead(ref BinaryReader reader)
		{
		}

		protected override void OnBinaryWrite(ref BinaryWriter writer)
		{
		}

		public void _003C_003EiFixBaseProxy_OnBinaryRead(ref BinaryReader P0)
		{
		}

		public void _003C_003EiFixBaseProxy_OnBinaryWrite(ref BinaryWriter P0)
		{
		}
	}

	public class SimulationData
	{
		public byte m_lastLodID;

		public byte m_newLodID;

		public byte m_fadeCount;

		public int m_visCount;

		public Vector3[] m_auxVecArray;
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

	public class VegetationData
	{
		public GameObject m_go;

		public List<Mesh> m_meshList;

		public List<Material> m_materialList;

		public List<MaterialPropertyBlock> m_materialPropBlockList;

		public VegColorComponent m_vegColorComp;

		public Vector4[] m_vegColorArray;

		public int m_vegColorBias;

		public List<Material> m_depthMaterialList;

		public VegetationData(GameObject go, List<Material> materialList, List<Mesh> meshList, List<MaterialPropertyBlock> matPropBlockList, VegColorComponent vegColorComp, int bias)
		{
		}

		private void CalculateVegColorArray()
		{
		}
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

	public class TreeInstanceData
	{
		public int m_id;

		public int m_lod;

		public int m_meshID;

		public Vector3 m_position;

		public int m_InstanceCount;

		public Matrix4x4[] m_posMatrixList;
	}

	public class GraphicsQualityVeg
	{
		public float[,] m_lodDist;

		public float[,] m_viewDist;

		public int[] m_viewGridSize;

		public byte[,,] m_graphicsQuality;
	}

	public class VegetationTypeData
	{
		public int m_billboardNum;

		public VegetationTypeData(int billboardNum)
		{
		}
	}

	public class VegetationGridData
	{
		public List<int> m_treeIDs;

		public Vector2 m_min;

		public Vector2 m_max;
	}

	public class TreeGroupLowInfo
	{
		public List<Vector3> m_vertsList;

		public List<Vector2> m_uvsList;

		public float m_billboardWidth;

		public float m_billboardHeight;

		public bool have_variate;
	}

	public class BushGroupInfo
	{
		public List<int> m_bushGroupList;

		public int m_newLod;

		public int m_lastLod;

		public float m_fade;
	}

	private class GridInfo
	{
		public int GridWithIndex;

		public int GridHeightIndex;

		public int CamGridDistance;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GridInfo> _003C_003E9__194_0;

		public static Comparison<GridInfo> _003C_003E9__195_0;

		internal int _003CFindPotentialTree_003Eb__194_0(GridInfo x, GridInfo y)
		{
			return 0;
		}

		internal int _003CFindPotentialShadowTree_003Eb__195_0(GridInfo x, GridInfo y)
		{
			return 0;
		}
	}

	private static Matrix4x4[] m_instancingMatrix;

	public static bool m_debugSwitchTree;

	public static bool m_debugSwitchVeg;

	public List<GameObject> m_vegetationTypeList;

	public List<DistributionData> m_distributionDataList;

	public List<GameObject> m_BillboardList;

	public List<string> m_vegetationTypeResIDList;

	public List<string> m_vegetationBillboardResIDList;

	public List<string> m_vegetationPSBillboardResIDLIst;

	public GameObject m_cactusBillboard;

	public GameObject m_palmBillboard;

	public GameObject m_whiteBirchBillboard;

	public GameObject m_shrub1Billboard;

	public GameObject m_shrub2Billboard;

	public GameObject m_shrub3Billboard;

	public GameObject m_shrub4Billboard;

	public GameObject m_cactusPSBillboard;

	public GameObject m_palmPSBillboard;

	public GameObject m_whiteBirchPSBillboard;

	public GameObject m_shrub1PSBillboard;

	public GameObject m_shrub2PSBillboard;

	public GameObject m_shrub3PSBillboard;

	public GameObject m_shrub4PSBillboard;

	private List<SimulationData> m_simulationDataList;

	private List<VegetationData> m_vegetationDataList;

	public List<Vector3> m_ScaleTypeList;

	public List<Vector3> m_RotationTypeList;

	public List<int> m_TreeTypeRandMaskList;

	private List<List<int>> m_TreeTypeRandList;

	private int m_maxScaleIDType;

	private Transform m_attachTreeMeshParent;

	private List<int> m_potentVisTreeList;

	private List<int> m_potentVisShadowTreeList;

	private List<TreeGroupData> m_visibleTreeGroupList;

	private List<TreeGroupData> m_visibleShadowTreeGroupList;

	private List<TreeInstanceData> m_visibleTreeInstanceList;

	private List<TreeInstanceData> m_visibleShadowTreeInstanceList;

	private GraphicsQualityVeg m_graphicsQualityVeg;

	private int m_qualityVegID;

	private int m_graphQualityVegID;

	public float m_mapWidth;

	public float m_mapHeight;

	public float m_mapStartPosX;

	public float m_mapStartPosZ;

	private const float m_distToCamera = 2f;

	private List<Color> m_globalTreeColorList;

	private const int m_treeBillboardNum = 3;

	private const int m_treeBillboardVertsNum = 12;

	private int m_newTreeBillboardNum;

	private int m_newTreeBillboardVertsNum;

	public const int m_treeGroupIndNum = 8;

	private int m_curTreeGroupNum;

	private int m_curShadowTreeGroupNum;

	private const int m_treeInstanceIndNum = 20;

	private int m_curTreeInstancingNum;

	private int m_curShadowTreeInstancingNum;

	private int m_curBillboardTreeInstancingNum;

	private int m_curPSBillboardTreeInstancingNum;

	private const int m_treeGroupMax = 7000;

	private int m_treeGroupLowPSTotal;

	private int m_treeGroupLowTotal;

	public const float m_treeGroupFarClipPos = -100000f;

	private static float[] m_treeGroupRandomScale;

	private Dictionary<int, TreeGroupLowInfo> m_treeGroupLowInfoDict;

	private Dictionary<int, TreeGroupLowInfo> m_PStreeGroupLowInfoDict;

	private int[] m_treeGroupLowIndices;

	private int[] m_treeGroupLowPSIndices;

	private List<Vector3> m_treeGroupLowVertsTmp;

	private List<Vector3> m_treeGroupLowPSVertsTmp;

	private List<Vector2> m_treeGroupLowUVsTmp;

	private List<Vector2> m_treeGroupLowPSUVsTmp;

	private Mesh m_treeGroupLowMesh;

	private Mesh m_treeGroupLowPSMesh;

	private Mesh m_treeInstanceLowMesh;

	private Vector3 m_treeGroupLowPos;

	private Material m_treeFarMat;

	private Material m_treeFarDepthMat;

	private int m_treeLayerMask;

	private int m_treeFarLayerMask;

	private List<int> m_visTreeGroupLOD0List;

	private List<int> m_visTreeGroupLOD1List;

	private List<int> m_visTreeGroupFarList;

	private List<int> m_visTreeGroupShadowList;

	private List<BushGroupInfo> m_visBushGroupLOD0List;

	private List<BushGroupInfo> m_visBushGroupLOD1List;

	private Dictionary<int, List<int>> m_treeGroupLOD0Dict;

	private Dictionary<int, List<int>> m_treeGroupLOD1Dict;

	private Dictionary<int, List<int>> m_treeGroupShadowDict;

	private const float m_treeGridSize = 60f;

	private int m_mapTreeGridWidth;

	private Dictionary<int, VegetationGridData> m_disGridTreeIDDict;

	private Camera m_camera;

	private byte m_fadeSpeedCount;

	private byte m_maxfadeSpeedCount;

	private Vector3 m_lastCamPos;

	private const float BASE_START_LERP_SPEED = 6f;

	private const float BASE_MAX_LERP_SPEED = 12f;

	private static float START_LERP_SPEED;

	private static float MAX_LERP_SPEED;

	private int m_treeScaleBias;

	public int m_treeTypeBias;

	public bool m_IsVariableTreeTypeBias;

	private short[] m_allTreeArray;

	private List<short> m_newTreeList;

	private short[,] m_visTreePosID;

	private Material m_shadowMat;

	private Material m_shadowRTMat;

	private SceneGraphics m_sceneGraphcisInst;

	private Vector2 m_lightDir;

	private Vector2 m_penLightDir;

	private bool m_treeGroupLowMeshDirty;

	private List<int> m_foundPotentialGridList;

	private bool m_isRecalculateBound;

	private List<BushGroupInfo> m_freeGroupInoList;

	private List<BushGroupInfo> m_usedGroupInoList;

	public GameObject m_treeRootGO;

	public GrassSystem m_grassSystem;

	private static bool m_EnablePreZPass;

	private static bool m_EnablePreZV2Pass;

	public bool m_UseHoudiniData;

	public float m_FadeInOutRatio;

	public float FadeInSpeed;

	public float FadeOutSpeed;

	private float m_FadeInSpeed;

	private float m_FadeOutSpeed;

	private const int STARDFRAMRATE = 30;

	private int m_frameRatio;

	private int m_SpeedInterval;

	private HashSet<Texture> m_treeMatTextures;

	private static readonly int s_MatPropIDPosMatrix0;

	private static readonly int s_MatPropIDPosMatrix1;

	private static readonly int s_MatPropIDPosBias;

	private bool m_ponyMapChangeTreeMaxNum;

	private bool m_ponyTreeGridSort;

	private float m_ponyMapViewFarRatio;

	private List<GridInfo> m_GirdList;

	private Stack<GridInfo> m_GridInfoPool;

	private int m_firstTreeID;

	private bool m_IsNeoParadise;

	private bool m_IsNeoParadiseMax;

	private bool m_IsWorkShop;

	private bool m_IsSonoran;

	private bool m_IsShangrila;

	private bool m_IsHippo;

	private bool m_IsPony;

	private bool m_UseSecondRotMatrix;

	private bool m_SupportedInstancing;

	private bool m_EnableSplitUpdate;

	private bool bFindPotention;

	private Vector2[] points;

	private bool bBuildTree;

	private bool bDrawTree;

	private int m_tmpVisCount;

	private int m_tmpVisTreeID;

	public bool m_UseFEData;

	private Dictionary<string, TreeSystemAppendingData> m_FETreeData;

	public List<TreeGroupData> VisibleTreeGroups
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public void UGCSetLightDir(Vector3 dir)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private GridInfo GetGridInfoFromPool()
	{
		return null;
	}

	private void ReturnGridInfoToPool(GridInfo gridInfo)
	{
	}

	public void ClearGridList()
	{
	}

	public void Init()
	{
	}

	private void LateUpdate()
	{
	}

	public void SimuateVegetation(bool is_need_now = false)
	{
	}

	public void InitVegetationMeshes()
	{
	}

	private void DisableVegetationInstances()
	{
	}

	private bool IsNeoParadise()
	{
		return false;
	}

	private bool IsNeoParadiseMax()
	{
		return false;
	}

	private bool IsWorkShop()
	{
		return false;
	}

	private bool IsSonoran()
	{
		return false;
	}

	private bool IsShangrila()
	{
		return false;
	}

	private bool IsHippo()
	{
		return false;
	}

	private bool IsPony()
	{
		return false;
	}

	private void InitVegetationTypes(bool forceUpdate = false)
	{
	}

	private void IncreaseABTextureRefIfNeed(Texture cut_tex, ref int ref_count)
	{
	}

	private void InitFarTreeMeshWithInstance()
	{
	}

	private void InitFarTreeMeshes()
	{
	}

	public Material GetTreeMaterial(TreeGroupData treeGroup)
	{
		return null;
	}

	public MaterialPropertyBlock GetTreeMaterialPropBlock(TreeGroupData treeGroup)
	{
		return null;
	}

	public void OnScreenShotRendering()
	{
	}

	private void DrawVegetation()
	{
	}

	private void DrawVegetationNow()
	{
	}

	private void FixedFadeCountWithSpeed()
	{
	}

	private void FindPotentVisibleVegetation()
	{
	}

	private Vector2 CalcBorderIntersection(Vector2 pos, Vector2 forward)
	{
		return default(Vector2);
	}

	private void FindPotentialTree(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private void FindPotentialShadowTree(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
	{
	}

	private bool IsGOVisible(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, ref Vector2 minVec, ref Vector2 maxVec)
	{
		return false;
	}

	public void OnCameraChanged(Camera target_cam)
	{
	}

	private void BuildVisibleVegetation()
	{
	}

	private void BuildVisibleTree(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov)
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

	private void SimpleUpdateFadeTreeLOD()
	{
	}

	private void FadeTreeLOD(ref SimulationData simData, int id, byte newLOD, byte lastLOD, byte changingLOD)
	{
	}

	private float GetFadeCoeff(ref SimulationData simData, int lod0, int lod1, int lod2)
	{
		return 0f;
	}

	private void UpdateFadeCoeff(ref SimulationData simData)
	{
	}

	public void ClearVisibleBushGroup()
	{
	}

	public void RecycleBushGroupList()
	{
	}

	public void AddBushGroup(int lod, List<int> bushList, int newLod, int lastLod, float fade = 0f)
	{
	}

	public void initFEData(TreeSystemAppendingData data)
	{
	}

	private void initFarFEMesh(TreeSystemAppendingData data)
	{
	}

	private bool LoadFETreeData_i(string sceneid, byte[] data)
	{
		return false;
	}

	public bool LoadFETreeData(string sceneid, byte[] data)
	{
		return false;
	}

	public void ReleaseFEData(string sceneid)
	{
	}

	private bool LoadFEShrubData_i(string sceneid, byte[] data)
	{
		return false;
	}

	public bool LoadFEShrubData(string sceneid, byte[] data)
	{
		return false;
	}

	private void LateUpdateFE()
	{
	}

	private void DrawSpeedPreviewFE()
	{
	}

	public void SimuateVegetationFE()
	{
	}

	private void FindPotentVisibleVegetationFE(TreeSystemAppendingData data)
	{
	}

	private void FindPotentialTreeFE(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, TreeSystemAppendingData data)
	{
	}

	private void FindPotentialShadowTreeFE(Vector2 camFruLeft, Vector2 camFruRight, ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, TreeSystemAppendingData data)
	{
	}

	private void BuildVisibleVegetationFE(TreeSystemAppendingData data)
	{
	}

	private void UpdateFadeCoeffFE(ref SimulationData simData, TreeSystemAppendingData data)
	{
	}

	private void FadeTreeLODFE(ref SimulationData simData, int id, byte newLOD, byte lastLOD, byte changingLOD, TreeSystemAppendingData data)
	{
	}

	private void FindVisibleTreeBufferPosFE(ref int lowMeshBias, ref short maxBuffPos, ref int buffPosIDOld, ref int buffPosIDNew, TreeSystemAppendingData data)
	{
	}

	private void BuildVisibleTreeFE(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, TreeSystemAppendingData data)
	{
	}

	private void BuildShadowTreeFE(TreeSystemAppendingData data)
	{
	}

	private void SimpleUpdateFadeTreeLODFE(TreeSystemAppendingData data)
	{
	}

	private void DrawVegetationFE(TreeSystemAppendingData data)
	{
	}

	public void ClearVisibleBushGroupFE(TreeSystemAppendingData data)
	{
	}

	public void RecycleBushGroupListFE(TreeSystemAppendingData data)
	{
	}

	public void AddBushGroupFE(TreeSystemAppendingData data, int lod, List<int> bushList, int newLod, int lastLod, float fade = 0f)
	{
	}

	public TreeSystemAppendingData GetTreeAppendingDataByName(string name)
	{
		return null;
	}
}
