using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class GrassSystem : MonoBehaviour
{
	public struct GrassInstSimInfo(int newLOD, int lastLOD, float fade = 0f, int startBillboardPos = -1, int startMeshPos = -1, int billboardLen = 0, int meshLen = 0)
	{
		public float m_fadeCoeff = 0f;

		public int m_newLOD = 0;

		public int m_lastLOD = 0;

		public int m_bufferBillboardStartPos = 0;

		public int m_bufferMeshStartPos = 0;

		public int m_bufferBillboardLen = 0;

		public int m_bufferMeshLen = 0;

		public bool m_needRefresh = false;
	}

	public struct GrassBufferInfo(int startPos, int len)
	{
		public int m_startPos = 0;

		public int m_len = 0;
	}

	private class GrassBufferInfoCompare : IComparer<GrassBufferInfo>
	{
		public int Compare(GrassBufferInfo x, GrassBufferInfo y)
		{
			return 0;
		}
	}

	public string m_mapName;

	public GameObject m_grassPrefab0;

	public GameObject m_grassPrefab1;

	public GameObject m_grassPrefab2;

	public List<GameObject> m_grassPrefabList;

	public List<string> m_grassPrefabResNameList;

	public GameObject m_grassBillboardPrefab;

	public string m_grassPrefab0_ResName;

	public string m_grassPrefab1_ResName;

	public string m_grassPrefab2_ResName;

	private List<GrassInst> m_grassInstList;

	public float m_grassMaskStartX;

	public float m_grassMaskStartZ;

	public float m_grassMaskStartY;

	public float m_grassMaskSizeX;

	public float m_grassMaskSizeZ;

	public float m_grassMaskSizeY;

	public const float m_grassMaskCellSize = 60f;

	public const float m_grassMaskSubCellSize = 20f;

	public const float m_grassViewDist = 100f;

	public bool m_UseHoudiniData;

	public bool m_EnableUVOffset;

	public bool m_UseHoudiniPrefabRemapUV;

	public int m_grassCellNumW;

	public int m_grassCellNumH;

	public const int m_grassSubCellNumW = 3;

	public const int m_grassSubCellNumH = 3;

	private int MAX_INST_NUM;

	private int MAX_BILLBOARD_INST_NUM;

	private int[] PREFAB_VERT_NUM;

	private Vector2[] m_PrefabSizes;

	private int[] PREFAB_INDEX_NUM;

	private static int PREFAB_BILLBOARD_VERT_NUM;

	private static int PREFAB_BILLBOARD_INDEX_NUM;

	private static float FAR_POS_Y;

	private static int[] INST_QUALITY_STEP;

	private static float[,] LOD_DIST_QUALITY;

	private float m_fadeSpeed;

	private float m_billboardDistSqr;

	private float m_meshDistSqr;

	private float m_fadeDistSqr;

	private int m_typeSpriteIDBias;

	private int m_grassLayerMask;

	private Dictionary<int, List<Vector3>> m_grassPrefabVertDict;

	private Dictionary<int, List<Vector3>> m_grassPrefabNormalDict;

	private Dictionary<int, List<Vector2>> m_grassPrefabUVDict;

	private Dictionary<int, List<Color32>> m_grassPrefabColorDict;

	private Dictionary<int, List<int>> m_grassPrefabIndicesDict;

	private List<Vector3> m_grassBillboardPrefabVertList;

	private List<Vector2> m_grassBillboardPrefabUVList;

	private List<int> m_grassBillboardPrefabIndicesList;

	private Material m_grassSimMat;

	private Material m_grassSimBillboardMat;

	private List<Vector3> m_grassSimMeshVertList;

	private List<Color32> m_grassSimMeshColorList;

	private List<Vector3> m_grassSimBillboardVertList;

	private List<Vector3> m_grassSimBillboardNormalList;

	private List<Color32> m_grassSimBillboardColorList;

	private bool m_meshBufferDirty;

	private bool m_billboardBufferDirty;

	private Mesh m_grassSimMesh;

	private Mesh m_grassSimBillboardMesh;

	private Camera m_camera;

	private HashSet<Texture> m_grassMatTextures;

	private GrassCell[] m_grassCell;

	private Dictionary<GrassSubCell, GrassInstSimInfo> m_fadeInstFadeDict;

	private Dictionary<GrassSubCell, GrassInstSimInfo> m_visibleGrassSimMeshDict;

	private Dictionary<GrassSubCell, GrassInstSimInfo> m_visibleGrassSimBillboardDict;

	private List<GrassSubCell> m_grassVisibleSubCellList;

	private List<GrassSubCell> m_tmpFadeList;

	private List<GrassSubCell> m_tmpRemoveMeshList;

	private List<GrassSubCell> m_tmpRemoveBillboardList;

	private List<GrassSubCell> m_tmpRemoveFadeList;

	private List<GrassBufferInfo> m_freeGrassBillboardBufferList;

	private List<GrassBufferInfo> m_freeGrassMeshBufferList;

	private GrassBufferInfoCompare m_freeGrassBufferCompare;

	private bool m_NeedMergeFreeBufferList;

	private bool m_NeedMergeFreeBillboardBufferList;

	private bool m_MergeFreeBufferListFuncOpen;

	private bool m_enableGrassCamHFOV;

	private int m_currentUpdateCount;

	private bool m_isDataReady;

	public float[] m_spriteScale;

	public TreeSystem m_treeSystem;

	private SceneGraphics m_sceneGraphcisInst;

	private uint _003CFrameCount_003Ek__BackingField;

	private bool _003CUseFrameSplit_003Ek__BackingField;

	private float _003CCamRotDelta_003Ek__BackingField;

	private float _003CCamPosDelta_003Ek__BackingField;

	private int m_DelayUseFrameSplitCount;

	private Quaternion m_LastCamRotation;

	private Vector3 m_LastCamPosition;

	private bool m_IsNeoParadise;

	private bool m_IsNeoParadiseMax;

	private bool m_IsWorkShop;

	private bool m_IsSonoran;

	private bool m_IsShangrila;

	private bool m_EnablePreZPass;

	private bool m_EnableMeshColor;

	private bool m_EnableNormal;

	private bool m_EnableSplitUpdate;

	private float m_GrassHeightScale;

	private Dictionary<GrassSubCell, GrassInstSimInfo> m_tmpSimDict;

	private List<Color32> m_tmpColorList;

	private Vector2[] points;

	public bool m_UseFEData;

	private Dictionary<string, GrassSystemAppendingData> m_FEGrassData;

	public List<GrassInst> GrassInstances
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public List<GrassSubCell> GrassVisibleSubCells
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public uint FrameCount
	{
		get
		{
			return _003CFrameCount_003Ek__BackingField;
		}
		private set
		{
			_003CFrameCount_003Ek__BackingField = value;
		}
	}

	public bool UseFrameSplit
	{
		get
		{
			return _003CUseFrameSplit_003Ek__BackingField;
		}
		private set
		{
			_003CUseFrameSplit_003Ek__BackingField = value;
		}
	}

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

	private bool IsPony()
	{
		return false;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateRemapUV()
	{
	}

	private void RefreshGrassHeightScale()
	{
	}

	private void LateUpdate()
	{
	}

	private void RefreshCameTransDelta()
	{
	}

	public void OnCameraTypeChanged(int old_type, int new_type)
	{
	}

	private void ClearFadeInst(object[] data)
	{
	}

	public void OnSceneLoaded()
	{
	}

	public string CombinePrefabResName(string original)
	{
		return null;
	}

	public static void GetPrefabByResName(string res_name, ref GameObject prefab_original)
	{
	}

	public void InitGrassPrefabVert()
	{
	}

	public void InitGrassPrefab()
	{
	}

	private void InitGrassInstAndCell()
	{
	}

	private void IncreaseABTextureRefIfNeed(Texture cut_tex, ref int ref_count)
	{
	}

	private void ReadDataFromHoudini(TextAsset inst_data, TextAsset cell_data)
	{
	}

	public void OnCameraChanged(Camera target_cam)
	{
	}

	private void UpdateVisibleCell()
	{
	}

	private void UpdateGrassInst()
	{
	}

	public void ChangeGrassShowByRect(bool is_show, Rect[] rects)
	{
	}

	private void DrawGrassInst()
	{
	}

	private void UpdateBushData()
	{
	}

	private void PrepareGrassInstDrawData()
	{
	}

	public void OnScreenShotRendering()
	{
	}

	private void SimpleDrawGrassInst()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private Vector3 AddFadeCoeffToYPos(Vector3 pos, float coeff, int spriteID)
	{
		return default(Vector3);
	}

	public void FetchGrassPrefabVerts()
	{
	}

	public void FetchGrassPrefabVertsForHoudini()
	{
	}

	private float GetScale(int spriteID)
	{
		return 0f;
	}

	public int GetTypeID(int spriteID)
	{
		return 0;
	}

	private int GetConvertedSpriteID(int spriteID)
	{
		return 0;
	}

	private int GetBillBoardSpriteID(int spriteID)
	{
		return 0;
	}

	private void InitGrassCell()
	{
	}

	private bool IsGOVisible(ref Vector2 camPosition, ref Vector2 camForward, float camCosHalfFov, ref Vector2 minVec, ref Vector2 maxVec)
	{
		return false;
	}

	private void RotateVector(Vector3 v, Quaternion q, ref Vector3 newV, float scale, int sprite_id)
	{
	}

	private void ConvertVectorToColor(Vector3 v, ref Color32 color)
	{
	}

	private void RecycleBillboardBuffer(GrassInstSimInfo simInfo)
	{
	}

	private void RecycleMeshBuffer(GrassInstSimInfo simInfo)
	{
	}

	private void MergeFreeBufferList(ref List<GrassBufferInfo> buffer_list)
	{
	}

	private void GetBillboardBufferPos(ref int bufferStartPos, int len)
	{
	}

	private void GetMeshBufferPos(ref int bufferStartPos, int len)
	{
	}

	private int LoadFEGrassData_i(string sceneid, byte[] data)
	{
		return 0;
	}

	public int LoadFEGrassData(string sceneid, byte[] data)
	{
		return 0;
	}

	public void ReleaseFEGrassData(string sceneid)
	{
	}

	private void AddFEInst(GrassInst inst, GrassSystemAppendingData data)
	{
	}

	private void AddFEGrassToCell(int id, GrassInst inst, ref int cellID, ref int subCellID, GrassSystemAppendingData data)
	{
	}

	private void initFEDataSubCell(GrassSystemAppendingData data)
	{
	}

	public void AddFEBushToCell(int id, TreeSystem.DistributionData inst, ref int cellID, ref int subCellID, GrassSystemAppendingData data)
	{
	}

	private void ClearFadeInst_FE()
	{
	}

	private void LateUpdate_FE()
	{
	}

	private void UpdateVisibleCellFE(GrassSystemAppendingData data)
	{
	}

	private void UpdateGrassInstFE(GrassSystemAppendingData data)
	{
	}

	private void PrepareGrassInstDrawDataFE(GrassSystemAppendingData data)
	{
	}

	private void SimpleDrawGrassInstFE(GrassSystemAppendingData data)
	{
	}

	private void DrawGrassInstFE(GrassSystemAppendingData data)
	{
	}

	public void UpdateBushDataFE(GrassSystemAppendingData data)
	{
	}

	public GrassSystemAppendingData GetGrassAppendingDataByName(string name)
	{
		return null;
	}

	private void GetBillboardBufferPosFE(ref int bufferStartPos, int len, GrassSystemAppendingData data)
	{
	}

	private void GetMeshBufferPosFE(ref int bufferStartPos, int len, GrassSystemAppendingData data)
	{
	}

	private void RecycleBillboardBufferFE(GrassInstSimInfo simInfo, GrassSystemAppendingData data)
	{
	}

	private void RecycleMeshBufferFE(GrassInstSimInfo simInfo, GrassSystemAppendingData data)
	{
	}
}
